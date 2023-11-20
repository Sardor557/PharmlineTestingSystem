using PharmlineTestingSystem.AdminPanel.Services;
using PharmlineTestingSystem.AdminPanel.Utils;
using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.ViewModels;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmlineTestingSystem.AdminPanel
{
    public partial class FrmDrugList : Form
    {
        public readonly DicoPanelService DicoService = new DicoPanelService();
        private Answer<spDrug[]> Drugs;

        public FrmDrugList()
        {
            InitializeComponent();
            this.DrugsGridView.CellFormatting += DrugGridView_CellFormatting;
            this.FormClosed += FrmDrugList_FormClosed;

        }

        private void FrmDrugList_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private async void FrmDrugList_Load(object sender, EventArgs e)
        {
            await GetDrugsAsync();
            GridRowStyle.SetRowsStyle(this.DrugsGridView.Rows, 2);
        }

        private void DrugGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GridRowStyle.SetRowsStyle(this.DrugsGridView.Rows, 2);
        }

        private async Task GetDrugsAsync()
        {
            Drugs = await DicoService.GetDrugsAsync();
            this.DrugsGridView.DataSource = Drugs.Data;
            this.DrugsGridView.Refresh();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private async void AddDrugBtn_Click(object sender, EventArgs e)
        {
            var drug = new spDrug();
            var frmDrug = new FrmDrug(drug);
            if (frmDrug.ShowDialog() != DialogResult.OK) return;

            var res = await DicoService.AddDrugAsync(drug);
            MessageBox.Show(res.Message);
            frmDrug.Dispose();

            await GetDrugsAsync();
        }

        private async void EditDrugBtn_Click(object sender, EventArgs e)
        {
            var row = this.DrugsGridView.SelectedRows[DrugsGridView.SelectedRows.Count - 1];
            var drug = row.DataBoundItem as spDrug;

            var frmEmployee = new FrmDrug(drug);
            if (frmEmployee.ShowDialog() != DialogResult.OK) return;

            frmEmployee.Dispose();
            var res = await DicoService.EditDrugAsync(drug);
            MessageBox.Show(res.Message);

            await GetDrugsAsync();
        }
    }
}
