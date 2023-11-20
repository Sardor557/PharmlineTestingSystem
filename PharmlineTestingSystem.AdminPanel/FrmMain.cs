using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PharmlineTestingSystem.AdminPanel
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            var gradient_rectangle = new Rectangle(0, 0, Width, Height);
            var b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(20, 20, 30), Color.FromArgb(57, 128, 227), 65f);
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void QuestionsBtn_Click(object sender, System.EventArgs e)
        {
            var frmQuestion = new FrmQuestionsList();
            frmQuestion.ShowDialog();
        }

        private void EmployeeBtn_Click(object sender, System.EventArgs e)
        {
            var frmEmployeeList = new FrmEmployeeList();
            frmEmployeeList.ShowDialog();
        }
    }
}
