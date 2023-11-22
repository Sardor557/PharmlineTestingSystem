namespace PharmlineTestingSystem.AdminPanel
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            QuestionsBtn = new RJControlls.RJButton();
            AnswersBtn = new RJControlls.RJButton();
            DrugsBtn = new RJControlls.RJButton();
            EmployeeBtn = new RJControlls.RJButton();
            SuspendLayout();
            // 
            // QuestionsBtn
            // 
            QuestionsBtn.BackColor = System.Drawing.Color.Indigo;
            QuestionsBtn.BackgroundColor = System.Drawing.Color.Indigo;
            QuestionsBtn.BorderColor = System.Drawing.Color.Indigo;
            QuestionsBtn.BorderRadius = 20;
            QuestionsBtn.BorderSize = 0;
            QuestionsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            QuestionsBtn.FlatAppearance.BorderSize = 0;
            QuestionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            QuestionsBtn.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            QuestionsBtn.ForeColor = System.Drawing.Color.White;
            QuestionsBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            QuestionsBtn.Location = new System.Drawing.Point(31, 36);
            QuestionsBtn.Name = "QuestionsBtn";
            QuestionsBtn.Size = new System.Drawing.Size(205, 119);
            QuestionsBtn.TabIndex = 0;
            QuestionsBtn.Text = "Вопросы";
            QuestionsBtn.TextColor = System.Drawing.Color.White;
            QuestionsBtn.UseVisualStyleBackColor = false;
            QuestionsBtn.Click += QuestionsBtn_Click;
            // 
            // AnswersBtn
            // 
            AnswersBtn.BackColor = System.Drawing.Color.Indigo;
            AnswersBtn.BackgroundColor = System.Drawing.Color.Indigo;
            AnswersBtn.BorderColor = System.Drawing.Color.Indigo;
            AnswersBtn.BorderRadius = 20;
            AnswersBtn.BorderSize = 0;
            AnswersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            AnswersBtn.FlatAppearance.BorderSize = 0;
            AnswersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AnswersBtn.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            AnswersBtn.ForeColor = System.Drawing.Color.White;
            AnswersBtn.Location = new System.Drawing.Point(264, 36);
            AnswersBtn.Name = "AnswersBtn";
            AnswersBtn.Size = new System.Drawing.Size(205, 119);
            AnswersBtn.TabIndex = 1;
            AnswersBtn.Text = "Ответы";
            AnswersBtn.TextColor = System.Drawing.Color.White;
            AnswersBtn.UseVisualStyleBackColor = false;
            // 
            // DrugsBtn
            // 
            DrugsBtn.BackColor = System.Drawing.Color.Indigo;
            DrugsBtn.BackgroundColor = System.Drawing.Color.Indigo;
            DrugsBtn.BorderColor = System.Drawing.Color.Indigo;
            DrugsBtn.BorderRadius = 20;
            DrugsBtn.BorderSize = 0;
            DrugsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            DrugsBtn.FlatAppearance.BorderSize = 0;
            DrugsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DrugsBtn.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            DrugsBtn.ForeColor = System.Drawing.Color.White;
            DrugsBtn.Location = new System.Drawing.Point(31, 210);
            DrugsBtn.Name = "DrugsBtn";
            DrugsBtn.Size = new System.Drawing.Size(205, 119);
            DrugsBtn.TabIndex = 2;
            DrugsBtn.Text = "Препараты";
            DrugsBtn.TextColor = System.Drawing.Color.White;
            DrugsBtn.UseVisualStyleBackColor = false;
            DrugsBtn.Click += DrugsBtn_Click;
            // 
            // EmployeeBtn
            // 
            EmployeeBtn.BackColor = System.Drawing.Color.Indigo;
            EmployeeBtn.BackgroundColor = System.Drawing.Color.Indigo;
            EmployeeBtn.BorderColor = System.Drawing.Color.Indigo;
            EmployeeBtn.BorderRadius = 20;
            EmployeeBtn.BorderSize = 0;
            EmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            EmployeeBtn.FlatAppearance.BorderSize = 0;
            EmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            EmployeeBtn.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            EmployeeBtn.ForeColor = System.Drawing.Color.White;
            EmployeeBtn.Location = new System.Drawing.Point(264, 210);
            EmployeeBtn.Name = "EmployeeBtn";
            EmployeeBtn.Size = new System.Drawing.Size(205, 119);
            EmployeeBtn.TabIndex = 3;
            EmployeeBtn.Text = "Сотрудники";
            EmployeeBtn.TextColor = System.Drawing.Color.White;
            EmployeeBtn.UseVisualStyleBackColor = false;
            EmployeeBtn.Click += EmployeeBtn_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Indigo;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(508, 374);
            Controls.Add(EmployeeBtn);
            Controls.Add(DrugsBtn);
            Controls.Add(AnswersBtn);
            Controls.Add(QuestionsBtn);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Главное";
            Paint += FrmMain_Paint;
            ResumeLayout(false);
        }

        #endregion

        private RJControlls.RJButton QuestionsBtn;
        private RJControlls.RJButton AnswersBtn;
        private RJControlls.RJButton DrugsBtn;
        private RJControlls.RJButton EmployeeBtn;
    }
}