using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.ViewModels;
using System.Threading.Tasks;

namespace PharmlineTestingSystem.Shared.Interfaces
{
    public interface IAnswerService
    {
        ValueTask<AnswerBasic> AddAnswerAsync(viAnswer model);
        ValueTask<Answer<viAnswer[]>> GetAnswersAsync();
        ValueTask<Answer<tbAnswer[]>> GetQuestionAnwersAsync(int questionId);
        ValueTask<Answer<viAnswer[]>> SearchAnswerAsync(SearchAnswer search);
    }
}
