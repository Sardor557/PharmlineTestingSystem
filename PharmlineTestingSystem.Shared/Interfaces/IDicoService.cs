using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.ViewModels;
using System.Threading.Tasks;

namespace PharmlineTestingSystem.Shared.Interfaces
{
    public interface IDicoService
    {
        ValueTask<AnswerBasic> AddDrugAsync(spDrug drug);
        ValueTask<Answer<int>> AddEmployeeAsync(tbEmployee employee);
        ValueTask<AnswerBasic> EditDrugAsync(spDrug drug);
        ValueTask<AnswerBasic> EditEmployeeAsync(tbEmployee employee);
        ValueTask<Answer<int>> GetDrugIdByNameAsync(string name);
        ValueTask<Answer<spDrug[]>> GetDrugsAsync(int? status = null);
        ValueTask<Answer<tbEmployee[]>> GetEmployeesAsync();
        ValueTask<Answer<spStatus[]>> GetStatusesAsync();
    }
}
