using AsbtCore.UtilsV2;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PharmlineCRMSystem.Shared.Services;
using PharmlineTestingSystem.Database;
using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.Interfaces;
using PharmlineTestingSystem.Shared.ViewModels;
using System;
using System.Linq;
using System.Threading.Tasks;

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
            var tran = await db.Database.BeginTransactionAsync();
            try
            {
                int userId = accessor.GetId();
                question.Validate();

                question.CreateDate = DateTime.Now;
                question.CreateUser = userId;

                var options = question.Options;
                question.Options = null;


                await db.tbQuestions.AddAsync(question);
                await db.SaveChangesAsync();

                options = options.Select(x =>
                {
                    x.QuestionId = question.Id; x.CreateDate = DateTime.Now;
                    x.CreateUser = userId; return x;
                }).ToList();

                await db.tbOptions.AddRangeAsync(options);
                await db.SaveChangesAsync();

                await tran.CommitAsync();

                return new Answer<int>(true, "", question.Id);
            }
            catch (Exception ex)
            {
                await tran.RollbackAsync();
                logger.LogError("QuestionService.AddQuestionAsync error:{0}", ex.GetAllMessages());
                return new Answer<int>(false, "Ошибка");
            }
        }

        public async ValueTask<AnswerBasic> EditQuestionAsync(tbQuestion model)
        {
            var tran = await db.Database.BeginTransactionAsync();
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

                return new AnswerBasic(true, "");
            }
            catch (Exception ex)
            {
                await tran.RollbackAsync();
                logger.LogError("QuestionService.EditQuestionAsync error:{0}", ex.GetAllMessages());
                return new AnswerBasic(false, "Ошибка");
            }
        }
    }
}
