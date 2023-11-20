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
    }
}
