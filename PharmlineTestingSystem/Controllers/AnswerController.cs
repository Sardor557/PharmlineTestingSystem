using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.Interfaces;
using PharmlineTestingSystem.Shared.ViewModels;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace PharmlineTestingSystem.Controllers
{    
    [ApiVersion("1.0")]
    [Route("[controller]")]
    [SwaggerTag("Ответы")]
    public class AnswerController
    {
        public readonly IAnswerService service;

        public AnswerController(IAnswerService service) => this.service = service;

        [Authorize(Roles = "admin")]
        [HttpGet("question/{questionId}")]
        public ValueTask<Answer<tbAnswer[]>> GetQuestionAnwersAsync(int questionId) => service.GetQuestionAnwersAsync(questionId);

        [Authorize(Roles = "admin")]
        [HttpGet]
        public ValueTask<Answer<viAnswer[]>> GetAnswersAsync() => service.GetAnswersAsync();
    }
}
