using AsbtCore.UtilsV2;
using Microsoft.Extensions.Configuration;
using PharmlineTestingSystem.AdminPanel.Utils;
using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.Interfaces;
using PharmlineTestingSystem.Shared.ViewModels;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmlineTestingSystem.AdminPanel.Services
{
    public sealed class DicoPanelService : IDicoService
    {
        private readonly CRestClient client;
        private readonly string ServerUrl;

        public DicoPanelService()
        {
            var conf = Program.Conf.GetSection("MySettings").Get<MySettings>();
            ServerUrl = conf.ServerUrl;

            this.client = new CRestClient();
        }

        public async ValueTask<AnswerBasic> AddDrugAsync(spDrug drug)
        {
            return await client.PostApiAsync<spDrug, AnswerBasic>(ServerUrl + "Dico/add_drug", drug, Vars.Token);
        }

        public async ValueTask<Answer<int>> AddEmployeeAsync(tbEmployee employee)
        {
            return await client.PostApiAsync<tbEmployee, Answer<int>>(ServerUrl + "Dico/add_employee", employee, Vars.Token);
        }

        public async ValueTask<AnswerBasic> EditDrugAsync(spDrug drug)
        {
            return await client.PostApiAsync<spDrug, AnswerBasic>(ServerUrl + "Dico/edit_drug", drug, Vars.Token);
        }

        public async ValueTask<AnswerBasic> EditEmployeeAsync(tbEmployee employee)
        {
            return await client.PostApiAsync<tbEmployee, AnswerBasic>(ServerUrl + "Dico/edit_employee", employee, Vars.Token);
        }

        public ValueTask<Answer<int>> GetDrugIdByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<Answer<spDrug[]>> GetDrugsAsync(int? status = null)
        {
            var res = await client.GetApiAsync<Answer<spDrug[]>>(ServerUrl + $"Dico/drugs", Vars.Token);
            if (!res.IsSuccess)
                MessageBox.Show(res.Message);
            return res;
        }

        public async ValueTask<Answer<tbEmployee[]>> GetEmployeesAsync()
        {
            var res = await client.GetApiAsync<Answer<tbEmployee[]>>(ServerUrl + $"Dico/employees", Vars.Token);
            if (!res.IsSuccess)
                MessageBox.Show(res.Message);
            return res;
        }

        public async ValueTask<Answer<spStatus[]>> GetStatusesAsync()
        {
            var res = await client.GetApiAsync<Answer<spStatus[]>>(ServerUrl + $"Dico/statuses", Vars.Token);
            if (!res.IsSuccess)
                MessageBox.Show(res.Message);
            return res;
        }
    }
}
