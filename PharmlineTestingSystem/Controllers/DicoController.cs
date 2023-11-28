using Microsoft.AspNetCore.Authorization;
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
    [SwaggerTag("Дико")]
    public class DicoController
    {
        private readonly IDicoService service;

        public DicoController(IDicoService service)
        {
            this.service = service;
        }

        [Authorize(Roles = "admin")]
        [HttpPost("add_drug")]
        public ValueTask<AnswerBasic> AddDrugAsync([FromBody] spDrug drug)
        {
            return service.AddDrugAsync(drug);
        }

        [Authorize(Roles = "admin")]
        [HttpPost("edit_drug")]
        public ValueTask<AnswerBasic> EditDrugAsync([FromBody] spDrug drug)
        {
            return service.EditDrugAsync(drug);
        }

        [Authorize(Roles = "employee,admin")]
        [HttpGet("drugs")]
        public ValueTask<Answer<spDrug[]>> GetDrugsAsync(int? status = null)
        {
            return service.GetDrugsAsync(status);
        }

        [Authorize(Roles ="admin,employee")]
        [HttpGet("drug/{name}")]
        public ValueTask<Answer<int>> GetDrugIdByNameAsync(string name)
        {
            return service.GetDrugIdByNameAsync(name);
        }

        [Authorize(Roles = "admin")]
        [HttpGet("statuses")]
        public ValueTask<Answer<spStatus[]>> GetStatusesAsync()
        {
            return service.GetStatusesAsync();
        }

        [Authorize(Roles = "admin")]
        [HttpGet("employees")]
        public ValueTask<Answer<tbEmployee[]>> GetEmployeesAsync()
        {
            return service.GetEmployeesAsync();
        }

        [Authorize(Roles = "admin")]
        [HttpPost("add_employee")]
        public ValueTask<Answer<int>> AddEmployeeAsync([FromBody] tbEmployee employee)
        {
            return service.AddEmployeeAsync(employee);
        }

        [Authorize(Roles = "admin")]
        [HttpPost("edit_employee")]
        public ValueTask<AnswerBasic> EditEmployeeAsync(tbEmployee employee)
        {
            return service.EditEmployeeAsync(employee);
        }
    }
}
