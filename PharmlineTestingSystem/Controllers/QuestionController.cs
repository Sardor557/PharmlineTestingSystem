﻿using Microsoft.AspNetCore.Authorization;
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
    [SwaggerTag("Вопросы")]
    public class QuestionController
    {
        private readonly IQuestionService service;

        public QuestionController(IQuestionService service)
        {
            this.service = service;
        }

        [Authorize(Roles = "admin")]
        [HttpPost("add")]
        public ValueTask<Answer<int>> AddQuestionAsync([FromBody] tbQuestion question)
        {
            return service.AddQuestionAsync(question);
        }

        [Authorize(Roles = "admin")]
        [HttpPost("edit")]
        public ValueTask<AnswerBasic> EditQuestionAsync([FromBody] tbQuestion model)
        {
            return service.EditQuestionAsync(model);
        }

        [Authorize(Roles = "admin")]
        [HttpGet("options/{questionId}")]
        public ValueTask<Answer<tbOption[]>> GetQuestionOptionsAsync(int questionId)
        {
            return service.GetQuestionOptionsAsync(questionId);
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public ValueTask<Answer<tbQuestion[]>> GetQuestionsAsync()
        {
            return service.GetQuestionsAsync();
        }

        [Authorize(Roles = "admin,employee")]
        [HttpGet("by_drug/{drugId}/{overId}")]
        public ValueTask<Answer<viQuestion>> GetQuestionByDrugIdAsync(int drugId, int overId)
        {
            return service.GetQuestionByDrugIdAsync(drugId, overId);
        }

        [Authorize(Roles = "admin,employee")]
        [HttpGet("current/{questionId}")]
        public ValueTask<Answer<viQuestion>> GetCurrentQuestionAsync(int questionId)
        {
            return service.GetCurrentQuestionAsync(questionId);
        }

        [Authorize(Roles = "admin")]
        [HttpGet("property/{drugId}")]
        public ValueTask<Answer<SetProperty<int, string>[]>> GetQuestionPropertyByDrugIdAsync(int drugId)
        {
            return service.GetQuestionPropertyByDrugIdAsync(drugId);
        }
    }
}
