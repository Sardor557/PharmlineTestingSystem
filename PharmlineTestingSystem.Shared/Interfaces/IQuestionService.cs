using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.ViewModels;
using System.Threading.Tasks;

namespace PharmlineTestingSystem.Shared.Interfaces
{
    public interface IQuestionService
    {
        ValueTask<Answer<int>> AddQuestionAsync(tbQuestion question);
        ValueTask<AnswerBasic> EditQuestionAsync(tbQuestion model);
        ValueTask<Answer<viQuestion>> GetCurrentQuestionAsync(int questionId);
        ValueTask<Answer<viQuestion>> GetQuestionByDrugIdAsync(int drugId, int overId);
        ValueTask<Answer<tbOption[]>> GetQuestionOptionsAsync(int questionId);
        ValueTask<Answer<SetProperty<int, string>[]>> GetQuestionPropertyByDrugIdAsync(int drugId);
        ValueTask<Answer<tbQuestion[]>> GetQuestionsAsync();
    }
}
