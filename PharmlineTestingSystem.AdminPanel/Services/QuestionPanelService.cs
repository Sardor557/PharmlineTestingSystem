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
    public sealed class QuestionPanelService : IQuestionService
    {
        private readonly CRestClient client;
        private readonly string ServerUrl;

        public QuestionPanelService()
        {
            var conf = Program.Conf.GetSection("MySettings").Get<MySettings>();
            ServerUrl = conf.ServerUrl;

            this.client = new CRestClient();
        }

        public async ValueTask<Answer<int>> AddQuestionAsync(tbQuestion question)
        {
            return await client.PostApiAsync<tbQuestion, Answer<int>>(ServerUrl + "Question/add", question, Vars.Token);
        }

        public async ValueTask<AnswerBasic> EditQuestionAsync(tbQuestion model)
        {
            return await client.PostApiAsync<tbQuestion, AnswerBasic>(ServerUrl + "Question/edit", model, Vars.Token);
        }

        public ValueTask<Answer<viQuestion>> GetCurrentQuestionAsync(int questionId)
        {
            throw new System.NotImplementedException();
        }

        public ValueTask<Answer<viQuestion>> GetQuestionByDrugIdAsync(int drugId, int overId)
        {
            throw new System.NotImplementedException();
        }

        public async ValueTask<Answer<tbOption[]>> GetQuestionOptionsAsync(int questionId)
        {
            var res = await client.GetApiAsync<Answer<tbOption[]>>(ServerUrl + $"Question/options/{questionId}", Vars.Token);
            if (!res.IsSuccess)
                MessageBox.Show(res.Message);
            return res;
        }

        public async ValueTask<Answer<SetProperty<int, string>[]>> GetQuestionPropertyByDrugIdAsync(int drugId)
        {
            var res = await client.GetApiAsync<Answer<SetProperty<int, string>[]>>(ServerUrl + $"Question/property/{drugId}", Vars.Token);
            if (!res.IsSuccess)
                MessageBox.Show(res.Message);
            return res;
        }

        public async ValueTask<Answer<tbQuestion[]>> GetQuestionsAsync()
        {
            var res = await client.GetApiAsync<Answer<tbQuestion[]>>(ServerUrl + $"Question", Vars.Token);
            if (!res.IsSuccess)
                MessageBox.Show(res.Message);
            return res;
        }
    }
}
