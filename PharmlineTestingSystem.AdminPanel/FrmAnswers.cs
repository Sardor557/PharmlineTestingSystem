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
    }
}
