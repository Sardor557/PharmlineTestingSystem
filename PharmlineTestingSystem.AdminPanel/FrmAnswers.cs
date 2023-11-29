using AsbtCore.UtilsV2;
using PharmlineTestingSystem.AdminPanel.Services;
using PharmlineTestingSystem.Shared.ViewModels;
using System;
using System.Windows.Forms;

namespace PharmlineTestingSystem.AdminPanel
{
    public partial class FrmAnswers : Form
    {
        private readonly AnswerPanelService AnswerService = new AnswerPanelService();
        private readonly QuestionPanelService QuestionService = new QuestionPanelService();
        private readonly DicoPanelService DicoService = new DicoPanelService();

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
            var drugs = await DicoService.GetDrugsAsync();
            var employees = await DicoService.GetEmployeesAsync();
            var answers = await AnswerService.GetAnswersAsync();

            this.viAnswerBindingSource.DataSource = answers.Data;
            this.DrugComboBox.DataSource = drugs.Data;
            this.EmployeeComboBox.DataSource = employees.Data;
        }

        private async void DrugComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var questions = await QuestionService.GetQuestionPropertyByDrugIdAsync(this.DrugComboBox.SelectedValue.ToInt());
            this.QuestionComboBox.DataSource = questions.Data;
            this.QuestionComboBox.SelectedItem = null;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            this.DrugComboBox.SelectedItem = null;
            this.EmployeeComboBox.SelectedItem = null;
            this.QuestionComboBox.SelectedItem = null;
        }

        private async void SearchBtn_Click(object sender, EventArgs e)
        {
            var model = new SearchAnswer();
            model.DrugId = this.DrugComboBox.SelectedValue?.ToInt();
            model.EmployeeId = this.EmployeeComboBox.SelectedValue?.ToInt();
            model.QuestionId = this.QuestionComboBox.SelectedValue?.ToInt();

            var search = await AnswerService.SearchAnswerAsync(model);
            this.viAnswerBindingSource.DataSource = search.Data;
        }
    }
}
