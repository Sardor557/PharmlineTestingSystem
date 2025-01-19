using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PharmlineTestingSystem.Database;
using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.Interfaces;
using PharmlineTestingSystem.Shared.ViewModels;
using System;
using System.Linq;
using System.Threading.Tasks;
using PharmlineTestingSystem.Utils;

namespace PharmlineTestingSystem.Repository.Services
{
    public sealed class QuestionService : IQuestionService
    {
        private readonly MyDbContext db;
        private readonly ILogger<QuestionService> logger;
        private readonly IHttpContextAccessorExtensions accessor;

        public QuestionService(MyDbContext db, ILogger<QuestionService> logger, IHttpContextAccessorExtensions accessor)
        {
            this.db = db;
            this.logger = logger;
            this.accessor = accessor;
        }

        public async ValueTask<Answer<tbQuestion[]>> GetQuestionsAsync()
        {
            try
            {
                var q = await db.tbQuestions.AsNoTracking().ToArrayAsync();
                return new Answer<tbQuestion[]>(true, "", q);
            }
            catch (Exception ex)
            {
                logger.LogError("QuestionService.GetQuestionsAsync error:{0}", ex.GetAllMessages());
                return new Answer<tbQuestion[]>(false, "Ошибка");
            }
        }

        public async ValueTask<Answer<tbOption[]>> GetQuestionOptionsAsync(int questionId)
        {
            try
            {
                var q = await db.tbOptions
                    .AsNoTracking()
                    .Where(x => x.QuestionId == questionId)
                    .ToArrayAsync();

                return new Answer<tbOption[]>(true, "", q);
            }
            catch (Exception ex)
            {
                logger.LogError("QuestionService.GetQuestionOptionsAsync error:{0}", ex.GetAllMessages());
                return new Answer<tbOption[]>(false, "Ошибка");
            }
        }

        public async ValueTask<Answer<int>> AddQuestionAsync(tbQuestion question)
        {
            using var tran = await db.Database.BeginTransactionAsync();
            try
            {
                int userId = accessor.GetId();
                question.Validate();

                question.CreateDate = DateTime.Now;
                question.CreateUser = userId;

                question.Options = question.Options.Select(x =>
                {
                    x.QuestionId = question.Id; x.CreateDate = DateTime.Now;
                    x.CreateUser = userId; return x;
                }).ToList();

                await db.tbQuestions.AddAsync(question);
                await db.SaveChangesAsync();

                await tran.CommitAsync();

                return new Answer<int>(true, "OK", question.Id);
            }
            catch (ArgumentException ae)
            {
                await tran.RollbackAsync();
                logger.LogError("QuestionService.AddQuestionAsync error:{0}", ae.GetAllMessages());
                return new Answer<int>(false, ae.Message);
            }
            catch (Exception ex)
            {
                await tran.RollbackAsync();
                logger.LogError("QuestionService.AddQuestionAsync error: {0} stack: {1}", ex.GetAllMessages(), ex.GetStackTrace(5));
                return new Answer<int>(false, "Ошибка");
            }
        }

        public async ValueTask<AnswerBasic> EditQuestionAsync(tbQuestion model)
        {
            using var tran = await db.Database.BeginTransactionAsync();
            try
            {
                model.Validate();
                int userId = accessor.GetId();

                var q = await db.tbQuestions.Include(x => x.Options).FirstOrDefaultAsync(x => model.Id == x.Id);
                if (q is null)
                {
                    await tran.RollbackAsync();
                    return new AnswerBasic(false, $"Вопрос таким id - {model.Id} не найден");
                }

                q.UpdateDate = DateTime.Now;
                q.UpdateUser = userId;
                q.Status = model.Status;
                q.Context = model.Context;
                q.DrugId = model.DrugId;

                foreach (var option in model.Options)
                {
                    var existOption = await db.tbOptions.FirstOrDefaultAsync(x => x.QuestionId == model.Id && x.Id == option.Id);
                    if (option.Id == 0)
                    {
                        existOption = new tbOption();
                        existOption.Status = option.Status;
                        existOption.CreateDate = DateTime.Now;
                        existOption.CreateUser = userId;
                        existOption.Answer = option.Answer;
                        existOption.QuestionId = model.Id;
                        existOption.Variant = option.Variant;

                        await db.tbOptions.AddAsync(existOption);
                        continue;
                    }

                    existOption.UpdateDate = DateTime.Now;
                    existOption.UpdateUser = userId;
                    existOption.Status = option.Status;
                    existOption.Answer = option.Answer;
                    existOption.QuestionId = option.QuestionId;
                    existOption.Variant = option.Variant;
                }

                await db.SaveChangesAsync();
                await tran.CommitAsync();

                return new AnswerBasic(true, "OK");
            }
            catch (ArgumentException ae)
            {
                await tran.RollbackAsync();
                logger.LogError("QuestionService.AddQuestionAsync error: {0}", ae.GetAllMessages());
                return new AnswerBasic(false, ae.Message);
            }
            catch (Exception ex)
            {
                await tran.RollbackAsync();
                logger.LogError("QuestionService.EditQuestionAsync error: {0} stack: {1}", ex.GetAllMessages(), ex.GetStackTrace(5));
                return new AnswerBasic(false, "Ошибка");
            }
        }

        public async ValueTask<Answer<viQuestion>> GetQuestionByDrugIdAsync(int drugId, int overId)
        {
            try
            {
                var question = await db.tbQuestions
                    .AsNoTracking()
                    .Include(x => x.Options)
                    .Where(x => x.DrugId == drugId && x.Id > overId)
                    .OrderBy(x => x.Id)
                    .Select(x => new viQuestion
                    {
                        Id = x.Id,
                        Context = x.Context + $"\n\n{string.Join("\n", x.Options.Select(o => $"{o.Variant}. {o.Answer}"))}",
                        IsOpen = x.IsOpen,
                        Options = x.Options.Select(y => new viOption
                        {
                            Id = y.Id,
                            QuestionId = x.Id,
                            Variant = y.Variant,
                        }).ToList(),
                    })
                    .FirstOrDefaultAsync();

                if (question is null)
                    return new Answer<viQuestion>(false, "Вопросы к данному препарату закончились");

                return new Answer<viQuestion>(true, "OK", question);
            }
            catch (Exception ex)
            {
                logger.LogError("QuestionService.GetQuestionByDrugIdAsync error:{0}", ex.GetAllMessages());
                return new Answer<viQuestion>(false, "Ошибка");
            }
        }

        public async ValueTask<Answer<viQuestion>> GetCurrentQuestionAsync(int questionId)
        {
            try
            {
                var question = await db.tbQuestions
                    .AsNoTracking()
                    .Include(x => x.Options)
                    .Where(x => x.Id == questionId)
                    .OrderBy(x => x.Id)
                    .Select(x => new viQuestion
                    {
                        Id = x.Id,
                        Context = x.Context + $"\n\n{string.Join("\n", x.Options.Select(o => $"{o.Variant}. {o.Answer}"))}",
                        IsOpen = x.IsOpen,
                        Options = x.Options.Select(y => new viOption
                        {
                            Id = y.Id,
                            QuestionId = x.Id,
                            Variant = y.Variant,
                        }).ToList(),
                    })
                    .FirstOrDefaultAsync();

                return new Answer<viQuestion>(true, "", question);
            }
            catch (Exception ex)
            {
                logger.LogError("QuestionService.GetCurrentQuestionAsync error:{0}", ex.GetAllMessages());
                return new Answer<viQuestion>(false, "Ошибка");
            }
        }

        public async ValueTask<Answer<SetProperty<int, string>[]>> GetQuestionPropertyByDrugIdAsync(int drugId)
        {
            try
            {
                var question = await db.tbQuestions
                    .AsNoTracking()
                    .Where(x => x.DrugId == drugId)
                    .Select(x => new SetProperty<int, string>
                    {
                        Id = x.Id,
                        Value = x.Context
                    })
                    .ToArrayAsync();

                return new Answer<SetProperty<int, string>[]>(true, "", question);
            }
            catch (Exception ex)
            {
                logger.LogError("QuestionService.GetQuestionPropertyByDrugIdAsync error:{0}", ex.GetAllMessages());
                return new Answer<SetProperty<int, string>[]>(false, "Ошибка");
            }
        }
    }
}
