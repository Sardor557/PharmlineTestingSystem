using PharmlineTestingSystem.Shared.ViewModels;
using System.Threading.Tasks;

namespace PharmlineTestingSystem.Shared.Interfaces
{
    public interface IEmployeeService
    {
        ValueTask<Answer<string>> LoginEmployeeAsync(viEmployeeAuthorization authorization);
    }
}
