using PharmlineTestingSystem.Shared.ViewModels;
using System.Threading.Tasks;

namespace PharmlineTestingSystem.Shared.Interfaces
{
    public interface IEmployeeService
    {
        ValueTask<Answer<bool>> IsEmployeeRegistered(long telegramId);
        ValueTask<Answer<viEmployee>> LoginEmployeeAsync(viEmployeeAuthorization authorization);
        ValueTask<AnswerBasic> UpdateEmployeeLanguage(SetProperty<long, string> property);
    }
}
