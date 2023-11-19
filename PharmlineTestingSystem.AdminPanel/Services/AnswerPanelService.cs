using AsbtCore.UtilsV2;
using Microsoft.Extensions.Configuration;
using PharmlineTestingSystem.AdminPanel.Utils;
using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.Interfaces;
using PharmlineTestingSystem.Shared.ViewModels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmlineTestingSystem.AdminPanel.Services
{
    public sealed class AnswerPanelService : IAnswerService
    {
        private readonly CRestClient client;
        private readonly string ServerUrl;

        public AnswerPanelService()
        {
            var conf = Program.Conf.GetSection("MySettings").Get<MySettings>();
            ServerUrl = conf.ServerUrl;

            this.client = new CRestClient();
        }

        public async ValueTask<Answer<tbAnswer[]>> GetQuestionAnwersAsync(int questionId)
        {
            var res = await client.GetApiAsync<Answer<tbAnswer[]>>(ServerUrl + $"question/{questionId}", Vars.Token);
            if (!res.IsSuccess)
                MessageBox.Show(res.Message);
            return res;
        }
    }
}
