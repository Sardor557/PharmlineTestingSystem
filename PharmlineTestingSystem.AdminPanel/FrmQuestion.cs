using PharmlineTestingSystem.Utils;
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
            this.OptionsGridView.DataError += OptionsGridView_DataError;
        }

        private void OptionsGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
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

            this.DrugComboBox.DataSource = drugs.Data;
            this.DrugComboBox.SelectedValue = Question.DrugId;
            this.IsOpencheckBox.Text = null;

            this.tbOptionBindingSource.DataSource = Question.Options;

            this.spStatusBindingSource.DataSource = statuses.Data;
            this.spStatusGridBindingSource.DataSource = statuses.Data;

            if (Question.Status != 0)
            {
                this.StatusComboBox.SelectedValue = Question.Status;
                this.StatusComboBox.Text = statuses.Data.Where(x => x.Id == Question.Status).Select(x => x.Name).FirstOrDefault();
            }

            this.OptionsGridView.Rows.SetRowsStyle(5);
        }

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

                tbOption option = GetOption(row);
                if (option == null) continue;

                Question.Options.Add(option);
            }

            Question.IsOpen = isOpen;
            DialogResult = DialogResult.OK;
        }

        private tbOption GetOption(DataGridViewRow row)
        {
            var answer = row.Cells["colAnswer"].Value;
            var status = row.Cells["colStatus"].Value;
            var variant = row.Cells["colVariant"].Value;

            var arr = new object[3] { answer, status, variant };

            if (arr.Any(x => x is null)) return null;

            var option = new tbOption();

            var optionId = row.Cells["colOptionId"].Value;
            option.Id = optionId != null ? optionId.ToInt() : 0;

            option.Answer = answer.ToString();
            option.Status = status.ToInt();
            option.Variant = variant.ToString();
            option.QuestionId = Question.Id;

            var isCorrect = row.Cells["colIsCorrect"].Value;
            option.IsCorrect = isCorrect != null && Convert.ToBoolean(isCorrect);
            return option;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
