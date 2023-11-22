using AsbtCore.UtilsV2;
using PharmlineTestingSystem.AdminPanel.Services;
using PharmlineTestingSystem.AdminPanel.Utils;
using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmlineTestingSystem.AdminPanel
{
    public partial class FrmQuestion : Form
    {
        public tbQuestion Question;
        private readonly DicoPanelService DicoService = new DicoPanelService();

        public FrmQuestion(tbQuestion question)
        {
            InitializeComponent();
            Question = question;
            this.tbQuestionBindingSource.DataSource = question;
        }

        private async void FrmQuestion_Load(object sender, EventArgs e)
        {
            this.OptionsGridView.DataSource = Question.Options;
            var drugs = await DicoService.GetDrugsAsync(1);
            var statuses = await DicoService.GetStatusesAsync();
            this.colStatus.DataSource = statuses.Data;
            this.DrugComboBox.DataSource = drugs.Data;
            this.StatusComboBox.DataSource = statuses.Data;
            this.IsOpencheckBox.Text = "Открытый";
            GridRowStyle.SetRowsStyle(this.OptionsGridView.Rows, 4);
        }

        private void BackBtn_Click(object sender, EventArgs e) => this.Close();

        private void SaveOptionsBtn_Click(object sender, EventArgs e)
        {
            Question = this.tbQuestionBindingSource.DataSource as tbQuestion;
            bool isOpen = this.IsOpencheckBox.Checked;
            Question.DrugId = this.DrugComboBox.SelectedValue.ToInt();
            Question.Status = this.StatusComboBox.SelectedValue.ToInt();

            Question.Options = new List<tbOption>();
            for (int i = 0; i < OptionsGridView.Rows.Count - 1; i++)
            {
                DataGridViewRow row = (DataGridViewRow)OptionsGridView.Rows[i];
                var option = new tbOption();
                option.Answer = row.Cells["colAnswer"].Value.ToString();
                option.Status = row.Cells["colStatus"].Value.ToInt();
                option.Variant = row.Cells["colVariant"].Value.ToString();

                var isCorrect = row.Cells["colIsCorrect"].Value;
                option.IsCorrect = isCorrect != null && Convert.ToBoolean(isCorrect);
                Question.Options.Add(option);
            }

            Question.IsOpen = isOpen;

            DialogResult = DialogResult.OK;
        }
    }
}
