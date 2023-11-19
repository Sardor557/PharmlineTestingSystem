using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.Interfaces;
using PharmlineTestingSystem.Shared.ViewModels;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace PharmlineTestingSystem.Controllers
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("[controller]")]
    [SwaggerTag("Вопросы")]
    public class QuestionController
    {
        private readonly IQuestionService service;

        public QuestionController(IQuestionService service)
        {
            this.service = service;
        }

        [HttpPost("add")]
        public ValueTask<Answer<int>> AddQuestionAsync([FromBody] tbQuestion question)
        {
            return service.AddQuestionAsync(question);
        }

        [HttpPost("edit")]
        public ValueTask<AnswerBasic> EditQuestionAsync([FromBody] tbQuestion model)
        {
            return service.EditQuestionAsync(model);
        }

        [HttpGet("options/{questionId}")]
        public ValueTask<Answer<tbOption[]>> GetQuestionOptionsAsync(int questionId)
        {
            return service.GetQuestionOptionsAsync(questionId);
        }

        [HttpGet]
        public ValueTask<Answer<tbQuestion[]>> GetQuestionsAsync()
        {
            return service.GetQuestionsAsync();
        }
    }
}
