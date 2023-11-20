using AsbtCore.UtilsV2;
using PharmlineTestingSystem.AdminPanel.Services;
using PharmlineTestingSystem.Models;
using System;
using System.Windows.Forms;

namespace PharmlineTestingSystem.AdminPanel
{
    public partial class FrmEmployee : Form
    {
        public tbEmployee Employee;

        public FrmEmployee(tbEmployee employee)
        {
            InitializeComponent();
            Employee = employee;
            this.tbEmployeeBindingSource.DataSource = employee;
        }

        private async void FrmEmployee_Load(object sender, EventArgs e)
        {
            var dico = new DicoPanelService();
            var statuses = await dico.GetStatusesAsync();

            this.StatusComboBox.DataSource = statuses.Data;
            this.StatusComboBox.TextChanged += StatusComboBox_TextChanged; ;
        }

        private void StatusComboBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e) => this.Close();

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Employee = this.tbEmployeeBindingSource.DataSource as tbEmployee;
            DialogResult = DialogResult.OK;
        }
    }
}
