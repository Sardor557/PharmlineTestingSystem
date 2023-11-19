using PharmlineTestingSystem.AdminPanel.Services;
using PharmlineTestingSystem.AdminPanel.Utils;
using PharmlineTestingSystem.Shared.ViewModels;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmlineTestingSystem.AdminPanel
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            await Authorize();
        }

        private async Task Authorize()
        {

            var client = new UserPanelService();

            var res = await client.AuthenticateAsync(new viAuthenticateModel { Login = LoginTextBox.Text, Password = PasswordTextBox.Text });

            if (res is null)
            {
                MessageBox.Show("Заполните поля");
                return;
            }

            if (res.IsSuccess)
            {
                Vars.UserId = res.Data.Id;
                Vars.Token = res.Data.Token;

                DialogResult = DialogResult.OK;
                return;
            }
            else
                MessageBox.Show(res.Message);
        }

        public static DialogResult Execute()
        {
            FrmLogin frm = new FrmLogin();
            frm.LoginTextBox.Focus();
            DialogResult res = frm.ShowDialog();
            frm.Dispose();

            return res;
        }
    }
}
