using System.Drawing;
using System.Windows.Forms;

namespace PharmlineTestingSystem.AdminPanel
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginLabel = new Label();
            LoginTextBox = new TextBox();
            PasswordLabel = new Label();
            PasswordTextBox = new TextBox();
            LoginBtn = new Button();
            CancelBtn = new Button();
            SuspendLayout();
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Segoe UI", 13F);
            LoginLabel.Location = new Point(46, 36);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(62, 25);
            LoginLabel.TabIndex = 0;
            LoginLabel.Text = "Логин";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(114, 39);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(160, 23);
            LoginTextBox.TabIndex = 1;
            LoginTextBox.Text = "admin";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 13F);
            PasswordLabel.Location = new Point(34, 75);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(74, 25);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Пароль";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(114, 78);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(160, 23);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.Text = "s8064025";
            // 
            // LoginBtn
            // 
            LoginBtn.Font = new Font("Segoe UI", 12F);
            LoginBtn.Location = new Point(89, 129);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(75, 36);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Вход";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Font = new Font("Segoe UI", 12F);
            CancelBtn.ForeColor = Color.Red;
            CancelBtn.Location = new Point(170, 129);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 36);
            CancelBtn.TabIndex = 5;
            CancelBtn.Text = "Отмена";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // FrmLogin
            // 
            AcceptButton = LoginBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CancelBtn;
            ClientSize = new Size(321, 177);
            Controls.Add(CancelBtn);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginTextBox);
            Controls.Add(LoginLabel);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginLabel;
        private TextBox LoginTextBox;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private Button LoginBtn;
        private Button CancelBtn;
    }
}
