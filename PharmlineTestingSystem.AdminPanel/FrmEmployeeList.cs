using PharmlineTestingSystem.AdminPanel.Services;
using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.ViewModels;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmlineTestingSystem.AdminPanel
{
    public partial class FrmEmployeeList : Form
    {
        public readonly DicoPanelService DicoService = new DicoPanelService();
        private Answer<tbEmployee[]> Employees;

        public FrmEmployeeList()
        {
            InitializeComponent();
        }

        private async void FrmEmployeeList_Load(object sender, EventArgs e)
        {
            await GetEmployeesAsync();
        }

        private async void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            var employee = new tbEmployee();
            var frmEmployee = new FrmEmployee(employee);
            if (frmEmployee.ShowDialog() != DialogResult.OK) return;

            var res = await DicoService.AddEmployeeAsync(employee);
            MessageBox.Show(res.Message);

            await GetEmployeesAsync();
        }

        private async Task GetEmployeesAsync()
        {
            Employees = await DicoService.GetEmployeesAsync();
            this.EmployeeGridView.DataSource = Employees.Data;
            this.EmployeeGridView.Refresh();
        }

        private async void EditEmployeeBtn_Click(object sender, EventArgs e)
        {
            var row = this.EmployeeGridView.SelectedRows[EmployeeGridView.SelectedRows.Count - 1];
            var employee = row.DataBoundItem as tbEmployee;
            employee.Phone = employee.Phone.Replace("+998", "");

            var frmEmployee = new FrmEmployee(employee);
            if (frmEmployee.ShowDialog() != DialogResult.OK) return;

            var res = await DicoService.EditEmployeeAsync(employee);
            MessageBox.Show(res.Message);

            await GetEmployeesAsync();
        }
    }
}
