using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.Interfaces;
using PharmlineTestingSystem.Shared.ViewModels;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace PharmlineTestingSystem.Controllers
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("[controller]")]
    [SwaggerTag("Дико")]
    public class DicoController
    {
        private readonly IDicoService service;

        public DicoController(IDicoService service)
        {
            this.service = service;
        }

        [HttpPost("add_drug")]
        public ValueTask<AnswerBasic> AddDrugAsync([FromBody] spDrug drug)
        {
            return service.AddDrugAsync(drug);
        }

        [HttpPost("edit_drug")]
        public ValueTask<AnswerBasic> EditDrugAsync([FromBody] spDrug drug)
        {
            return service.EditDrugAsync(drug);
        }

        [HttpGet("drugs")]
        public ValueTask<Answer<spDrug[]>> GetDrugsAsync(int? status = null)
        {
            return service.GetDrugsAsync(status);
        }

        [HttpGet("statuses")]
        public ValueTask<Answer<spStatus[]>> GetStatusesAsync()
        {
            return service.GetStatusesAsync();
        }
    }
}
