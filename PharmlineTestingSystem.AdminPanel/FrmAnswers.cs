using PharmlineTestingSystem.AdminPanel.Services;
using System;
using System.Windows.Forms;

namespace PharmlineTestingSystem.AdminPanel
{
    public partial class FrmAnswers : Form
    {
        private readonly AnswerPanelService AnswerService = new AnswerPanelService();

        public FrmAnswers()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private async void FrmAnswers_Load(object sender, EventArgs e)
        {
            var answers = await AnswerService.GetAnswersAsync();
            this.viAnswerBindingSource.DataSource = answers.Data;
        }

        private void advancedDataGridView1_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            this.viAnswerBindingSource.Sort = this.answersAdvancedGridView.SortString;
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            this.viAnswerBindingSource.Filter = this.answersAdvancedGridView.FilterString;
        }

        private void viAnswerBindingSource_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {

        }
    }
}
