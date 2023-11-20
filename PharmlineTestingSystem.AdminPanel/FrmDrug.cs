using AsbtCore.UtilsV2;
using PharmlineTestingSystem.AdminPanel.Services;
using PharmlineTestingSystem.Models;
using System;
using System.Windows.Forms;

namespace PharmlineTestingSystem.AdminPanel
{
    public partial class FrmDrug : Form
    {
        public readonly DicoPanelService DicoService = new DicoPanelService();
        public spDrug Drug;

        public FrmDrug(spDrug drug)
        {
            InitializeComponent();
            Drug = drug;
            this.spDrugBindingSource.DataSource = drug;
            this.StatusComboBox.LostFocus += StatusComboBox_LostFocus;
        }

        private void StatusComboBox_LostFocus(object sender, EventArgs e)
        {
            this.NameTextBox.Focus();
        }

        private void CancelBtn_Click(object sender, EventArgs e) => this.Close();

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Drug = this.spDrugBindingSource.DataSource as spDrug;
            Drug.Status = this.StatusComboBox.SelectedValue.ToInt();
            DialogResult = DialogResult.OK;
        }

        private async void FrmDrug_Load(object sender, EventArgs e)
        {
            var statuses = await DicoService.GetStatusesAsync();
            this.StatusComboBox.DataSource = statuses.Data;
        }
    }
}
