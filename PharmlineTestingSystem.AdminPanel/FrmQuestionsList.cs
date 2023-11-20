using AsbtCore.UtilsV2;
using PharmlineTestingSystem.AdminPanel.Services;
using PharmlineTestingSystem.AdminPanel.Utils;
using PharmlineTestingSystem.Models;
using PharmlineTestingSystem.Shared.ViewModels;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            GridRowStyle.SetRowsStyle(this.QuestionsGridView.Rows, 4);
        }

        private async void FrmQuestionsList_Load(object sender, EventArgs e)
        {
            await GetQuestionsAsync();
            GridRowStyle.SetRowsStyle(this.QuestionsGridView.Rows, 4);
            var drugs = await DicoService.GetDrugsAsync();
            this.colDrugId.DataSource = drugs.Data;
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

            var row = gv.Rows[0];
            if (row is null) return;

            int questionId = row.Cells["IdColumn"].Value.ToInt();
            var options = await QuestionService.GetQuestionOptionsAsync(questionId);

            this.OptionsGridView.DataSource = options.Data;

        }
    }
}
