using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.Interfaces;
using PharmlineTestingSystem.Shared.ViewModels;
using System.Threading.Tasks;

namespace PharmlineTestingSystem.Controllers
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService rpUser;
        private ILogger<UsersController> logger;

        public UsersController(ILogger<UsersController> logger, IUserService service)
        {
            this.logger = logger;
            rpUser = service;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<Answer<viUser>> AuthenticateAsync([FromBody] viAuthenticateModel model)
        {
            var remoteIpAddress = Request.HttpContext.Connection.RemoteIpAddress?.ToString();
            if (string.IsNullOrEmpty(model.Login) || string.IsNullOrEmpty(model.Password))
            {
                logger.LogInformation($"Login Empty User:{model.Login} Passw:{model.Password} Ip:{remoteIpAddress}");
                return new Answer<viUser>(false, "Логин ёки парол бўш", null);
            }

            return await rpUser.AuthenticateAsync(model, remoteIpAddress);
        }


        [HttpPost("register")]
        public async Task<Answer<viUser>> UserRegisterAsync([FromBody] viUserRegister model)
        {
            var remoteIpAddress = Request.HttpContext.Connection.RemoteIpAddress;
            if (string.IsNullOrEmpty(model.Login) && string.IsNullOrEmpty(model.Password))
            {
                logger.LogInformation($"Login Empty User:{model.Login} Passw:{model.Password} Ip:{remoteIpAddress}");
                return new Answer<viUser>(false, "Парол ёки логин бўш", null);
            }

            return await rpUser.CreateUserAsync(model);
        }


        [HttpPost("update")]
        public async Task<AnswerBasic> Update([FromBody] viUser model)
        {
            return await rpUser.UpdateAsync(model);
        }

        [HttpPost("change_password")]
        public async Task<AnswerBasic> ChangePasswordAsync([FromBody] SetProperty<int, string> model)
        {
            return await rpUser.ChangePasswordAsync(model);
        }


        [HttpGet("get_users")]
        public Task<Answer<tbUser[]>> GetUsersAsync()
        {
            return rpUser.GetAllUsersAsync();
        }


        [HttpGet("get_user_by_id/{id}")]
        public Task<Answer<tbUser>> GetUserByIdAsync(int id)
        {
            return rpUser.GetByIdAsync(id);
        }

        [HttpPost("set_user_status")]
        public Task<Answer<viUser>> SetUserStatusAsync([FromBody] SetProperty<int, int> model)
        {
            return rpUser.SetUserStatusAsync(model);
        }
    }
}
