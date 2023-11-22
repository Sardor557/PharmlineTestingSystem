using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PharmlineTestingSystem.Database;
using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.Interfaces;
using PharmlineTestingSystem.Shared.ViewModels;
using System.Threading.Tasks;
using System;
using System.Linq;
using AsbtCore.UtilsV2;

namespace PharmlineTestingSystem.Repository.Services
{
    public sealed class AnswerService : IAnswerService
    {
        private readonly MyDbContext db;
        private readonly ILogger<AnswerService> logger;        

        public AnswerService(MyDbContext db, ILogger<AnswerService> logger)
        {
            this.db = db;
            this.logger = logger;
        }

        public async ValueTask<Answer<tbAnswer[]>> GetQuestionAnwersAsync(int questionId)
        {
            try
            {
                var q = await db.tbAnswers
                    .AsNoTracking()
                    .Where(x => x.QuestionId == questionId)
                    .ToArrayAsync();

                return new Answer<tbAnswer[]>(true, "", q);
            }
            catch (Exception ex)
            {
                logger.LogError("QuestionService.GetQuestionAnwersAsync error:{0}", ex.GetAllMessages());
                return new Answer<tbAnswer[]>(false, "Ошибка");
            }
        }

        public async ValueTask<Answer<viAnswer[]>> GetAnswersAsync()
        {
            try
            {
                var answer = await db.tbAnswers
                    .AsNoTracking()
                    .Include(x => x.Employee)
                    .Include(x => x.Question).ThenInclude(x => x.Drug)
                    .Include(x => x.Option)
                    .Select(x => new viAnswer
                    {
                        Id = x.Id,
                        AnswerDate = x.CreateDate,
                        DrugId = x.Question.DrugId,
                        Drug = x.Question.Drug.Name,
                        EmployeeId = x.EmployeeId,
                        EmployeeName = x.Employee.FullName,
                        OptionId = x.OptionId,
                        Option = x.Option.Answer,
                        IsCorrect = x.Option.IsCorrect,
                        QuestionId = x.QuestionId,
                        Question = x.Question.Context
                    })
                    .OrderBy(x => x.AnswerDate)
                    .ToArrayAsync();

                return new Answer<viAnswer[]>(true, "", answer);
            }
            catch (Exception ex)
            {
                logger.LogError("QuestionService.GetQuestionAnwersAsync error:{0}", ex.GetAllMessages());
                return new Answer<viAnswer[]>(false, "Ошибка");

            }
        }
    }
}
