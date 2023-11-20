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
    public partial class FrmQuestionsList : Form
    {
        private readonly DicoPanelService DicoService = new DicoPanelService();
        private readonly QuestionPanelService QuestionService = new QuestionPanelService();
        private Answer<tbQuestion[]> Questions;

        public FrmQuestionsList()
        {
            InitializeComponent();
            this.QuestionsGridView.CellFormatting += QuestionsGridView_CellFormatting; ;
        }

        private void QuestionsGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GridRowStyle.SetRowsStyle(this.QuestionsGridView.Rows, 4);
        }

        private async void FrmQuestionsList_Load(object sender, EventArgs e)
        {
            await GetQuestionsAsync();
            GridRowStyle.SetRowsStyle(this.QuestionsGridView.Rows, 4);
        }

        private async Task GetQuestionsAsync()
        {
            Questions = await QuestionService.GetQuestionsAsync();
            this.QuestionsGridView.DataSource = Questions.Data;
            this.QuestionsGridView.Refresh();
        }
    }
}
