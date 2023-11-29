using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PharmlineTestingSystem.Shared.Interfaces;
using PharmlineTestingSystem.Shared.ViewModels;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace PharmlineTestingSystem.Controllers
{
    [Authorize(Roles = "admin,employee")]
    [ApiVersion("1.0")]
    [Route("[controller]")]
    [SwaggerTag("Ответы")]

    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService service;

        public EmployeeController(IEmployeeService service)
        {
            this.service = service;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public ValueTask<Answer<viEmployee>> LoginEmployeeAsync(viEmployeeAuthorization authorization) => service.LoginEmployeeAsync(authorization);
                        
        [HttpGet("{telegramId}")]
        public ValueTask<Answer<bool>> IsEmployeeRegistered(long telegramId) => service.IsEmployeeRegistered(telegramId);

        [HttpPost("update_language")]
        public ValueTask<AnswerBasic> UpdateEmployeeLanguage(SetProperty<long, string> property) => service.UpdateEmployeeLanguage(property);
    }
}
