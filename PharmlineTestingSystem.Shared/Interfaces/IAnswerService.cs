﻿using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.ViewModels;
using System.Threading.Tasks;

namespace PharmlineTestingSystem.Shared.Interfaces
{
    public interface IAnswerService
    {
        ValueTask<Answer<tbAnswer[]>> GetQuestionAnwersAsync(int questionId);
    }
}