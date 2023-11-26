using AsbtCore.UtilsV2;
using PharmlineTestingSystem.AdminPanel.Services;
using PharmlineTestingSystem.AdminPanel.Utils;
using PharmlineTestingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            this.OptionsGridView.CellEnter += OptionsGridView_CellEnter;
        }

        private void OptionsGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            bool validClick = (e.RowIndex != -1 && e.ColumnIndex != -1);
            var datagridview = sender as DataGridView;

            if (datagridview.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && validClick)
            {
                datagridview.BeginEdit(true);
                ((ComboBox)datagridview.EditingControl).DroppedDown = true;
            }
        }

        private async void FrmQuestion_Load(object sender, EventArgs e)
        {
            var drugs = await DicoService.GetDrugsAsync(1);
            var statuses = await DicoService.GetStatusesAsync();
            this.colStatus.DataSource = statuses.Data;
            this.DrugComboBox.DataSource = drugs.Data;
            this.StatusComboBox.DataSource = statuses.Data;
            this.IsOpencheckBox.Text = "Открытый";
            this.OptionsGridView.DataSource = Question.Options;
            GridRowStyle.SetRowsStyle(this.OptionsGridView.Rows, 5);
        }

        private void BackBtn_Click(object sender, EventArgs e) => this.Close();

        private void SaveOptionsBtn_Click(object sender, EventArgs e)
        {
            Question = this.tbQuestionBindingSource.DataSource as tbQuestion;
            bool isOpen = this.IsOpencheckBox.Checked;
            Question.DrugId = this.DrugComboBox.SelectedValue.ToInt();
            Question.Status = this.StatusComboBox.SelectedValue.ToInt();

            Question.Options = new List<tbOption>();
            foreach (DataGridViewRow row in OptionsGridView.Rows)
            {
                if (row.IsNewRow) continue;

                var answer = row.Cells["colAnswer"].Value;
                var status = row.Cells["colStatus"].Value;
                var variant = row.Cells["colVariant"].Value;

                var arr = new object[3] { answer, status, variant };

                if (arr.Any(x => x is null)) continue;

                var option = new tbOption();

                var optionId = row.Cells["colOptionId"].Value;
                option.Id = optionId != null ? optionId.ToInt() : 0;

                option.Answer = answer.ToString();
                option.Status = status.ToInt();
                option.Variant = variant.ToString();
                option.QuestionId = row.Cells["colQuestionId"].Value.ToInt();

                var isCorrect = row.Cells["colIsCorrect"].Value;
                option.IsCorrect = isCorrect != null && Convert.ToBoolean(isCorrect);
                Question.Options.Add(option);
            }

            Question.IsOpen = isOpen;
            DialogResult = DialogResult.OK;
        }
    }
}
