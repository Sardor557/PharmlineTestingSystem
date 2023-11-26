using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.ViewModels;
using System.Threading.Tasks;

namespace PharmlineTestingSystem.Shared.Interfaces
{
    public interface IQuestionService
    {
        ValueTask<Answer<int>> AddQuestionAsync(tbQuestion question);
        ValueTask<AnswerBasic> EditQuestionAsync(tbQuestion model);
        ValueTask<Answer<viQuestion>> GetQuestionByDrugIdAsync(int drugId);
        ValueTask<Answer<tbOption[]>> GetQuestionOptionsAsync(int questionId);
        ValueTask<Answer<tbQuestion[]>> GetQuestionsAsync();
    }
}
