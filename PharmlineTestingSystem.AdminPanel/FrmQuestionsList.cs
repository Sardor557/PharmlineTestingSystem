using PharmlineTestingSystem.Utils;
using PharmlineTestingSystem.AdminPanel.Services;
using PharmlineTestingSystem.AdminPanel.Utils;
using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace PharmlineTestingSystem.AdminPanel
{
    public partial class FrmQuestionsList : Form
    {
        private readonly DicoPanelService DicoService = new DicoPanelService();
        private readonly QuestionPanelService QuestionService = new QuestionPanelService();
        private Answer<tbQuestion[]> Questions;

        public FrmQuestionsList()
        {
            InitializeComponent();
            this.QuestionsGridView.CellFormatting += QuestionsGridView_CellFormatting;
            this.FormClosed += FrmQuestionsList_FormClosed;
        }

        private void FrmQuestionsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void QuestionsGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            this.QuestionsGridView.Rows.SetRowsStyle(4);
        }

        private async void FrmQuestionsList_Load(object sender, EventArgs e)
        {
            this.QuestionsGridView.Rows.SetRowsStyle(4);
            var drugs = await DicoService.GetDrugsAsync();
            this.colDrugId.DataSource = drugs.Data;
            await GetQuestionsAsync();

        }

        private async Task GetQuestionsAsync()
        {
            Questions = await QuestionService.GetQuestionsAsync();
            this.QuestionsGridView.DataSource = Questions.Data;
            this.QuestionsGridView.Refresh();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private async void QuestionsGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (sender is not DataGridView gv) return;

            if (gv.SelectedRows.Count < 1) return;
            
            var row = gv.SelectedRows[0];
            if (row is null) return;

            int questionId = row.Cells["colId"].Value.ToInt();

            var options = await QuestionService.GetQuestionOptionsAsync(questionId);
            this.OptionsGridView.DataSource = options.Data;
            this.OptionsGridView.Refresh();
        }

        private async void AddQuestionBtn_Click(object sender, EventArgs e)
        {
            var question = new tbQuestion();
            var frmQuestion = new FrmQuestion(question);

            if (frmQuestion.ShowDialog() != DialogResult.OK) return;

            frmQuestion.Dispose();

            var res = await QuestionService.AddQuestionAsync(question);
            MessageBox.Show(res.Message);
            await GetQuestionsAsync();
        }

        private async void EditQuestionBtn_Click(object sender, EventArgs e)
        {
            var questionCells = this.QuestionsGridView.SelectedRows[0].Cells;
            var question = new tbQuestion();

            question.Id = questionCells["colId"].Value.ToInt();
            question.Context = questionCells["colContext"].Value.ToString();
            question.DrugId = questionCells["colDrugId"].Value.ToInt();
            question.Options = new List<tbOption>();

            var isOpen = questionCells["colIsOpen"].Value;
            question.IsOpen = isOpen != null && Convert.ToBoolean(isOpen);

            question.Status = questionCells["colStatus"].Value.ToInt();

            var optionRows = this.OptionsGridView.Rows;

            foreach (DataGridViewRow row in optionRows)
            {
                var cells = row.Cells;

                var option = new tbOption();
                option.Id = cells["colOptionId"].Value.ToInt();
                option.Answer = cells["colAnswer"].Value.ToString();
                option.QuestionId = question.Id;
                option.CreateDate = cells["colOptionCreateDate"].Value.ToDateTime();

                var isCorrect = cells["colIsCorrect"].Value;
                option.IsCorrect = isCorrect != null && Convert.ToBoolean(isCorrect);

                option.Status = cells["colOptionStatus"].Value.ToInt();
                option.Variant = cells["colVariant"].Value.ToString();

                question.Options.Add(option);
            }

            var frmQuestion = new FrmQuestion(question);
            if (frmQuestion.ShowDialog() != DialogResult.OK) return;

            frmQuestion.Dispose();
            var res = await QuestionService.EditQuestionAsync(question);
            MessageBox.Show(res.Message);
            await GetQuestionsAsync();
        }
    }
}
