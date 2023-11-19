using AsbtCore.UtilsV2;
using Microsoft.Extensions.Configuration;
using PharmlineTestingSystem.AdminPanel.Utils;
using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.Interfaces;
using PharmlineTestingSystem.Shared.ViewModels;
using System;
using System.Threading.Tasks;

namespace PharmlineTestingSystem.AdminPanel.Services
{
    public sealed class UserPanelService : IUserService
    {
        private readonly CRestClient client;
        private readonly string ServerUrl;

        public UserPanelService()
        {
            var conf = Program.Conf.GetSection("MySettings").Get<MySettings>();
            ServerUrl = conf.ServerUrl;

            this.client = new CRestClient();
            client.SetTimeout(15);
        }

        public async Task<Answer<viUser>> AuthenticateAsync(viAuthenticateModel model, string ip = "")
        {
            if (string.IsNullOrEmpty(model.Login) || string.IsNullOrEmpty(model.Password))
                return null;

            var r = await client.PostApiStringResultAsync(ServerUrl + "Users/login", model);
            if (r.IsSuccess)
                return r.DataStr.FromJson<Answer<viUser>>();
            else
                return new Answer<viUser>(false, "Что-то пошло не так", null);
        }

        public Task<AnswerBasic> ChangePasswordAsync(SetProperty<int, string> p)
        {
            throw new NotImplementedException();
        }

        public Task<Answer<viUser>> CreateUserAsync(viUserRegister value)
        {
            throw new NotImplementedException();
        }

        public Task<Answer<tbUser[]>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Answer<tbUser>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Answer<viUser>> SetUserStatusAsync(SetProperty<int, int> model)
        {
            throw new NotImplementedException();
        }

        public Task<AnswerBasic> UpdateAsync(viUser user)
        {
            throw new NotImplementedException();
        }
    }
}
