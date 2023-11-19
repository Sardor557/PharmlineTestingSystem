using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.ViewModels;
using System.Threading.Tasks;

namespace PharmlineTestingSystem.Shared.Interfaces
{
    public interface IDicoService
    {
        ValueTask<AnswerBasic> AddDrugAsync(spDrug drug);
        ValueTask<AnswerBasic> EditDrugAsync(spDrug drug);
        ValueTask<Answer<spDrug[]>> GetDrugsAsync(int? status = null);
        ValueTask<Answer<spStatus[]>> GetStatusesAsync();
    }
}
