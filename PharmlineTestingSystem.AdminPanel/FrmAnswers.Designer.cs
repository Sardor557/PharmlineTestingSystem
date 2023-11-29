namespace PharmlineTestingSystem.AdminPanel
{
    partial class FrmAnswers
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
            components = new System.ComponentModel.Container();
            viAnswerBindingSource = new System.Windows.Forms.BindingSource(components);
            panel1 = new System.Windows.Forms.Panel();
            BackBtn = new RJControlls.RJButton();
            HeaderPanel = new System.Windows.Forms.Panel();
            AnswersLabel = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            AnswersGridView = new System.Windows.Forms.DataGridView();
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            questionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colOptionContext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colVariant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            optionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colIsCorrect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            colDrug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            drugIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAnswerDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SearchPanel = new System.Windows.Forms.Panel();
            QuestionComboBox = new System.Windows.Forms.ComboBox();
            DrugComboBox = new System.Windows.Forms.ComboBox();
            spDrugBindingSource = new System.Windows.Forms.BindingSource(components);
            EmployeeComboBox = new System.Windows.Forms.ComboBox();
            tbEmployeeBindingSource = new System.Windows.Forms.BindingSource(components);
            ResetBtn = new RJControlls.RJButton();
            SearchBtn = new RJControlls.RJButton();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)viAnswerBindingSource).BeginInit();
            panel1.SuspendLayout();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AnswersGridView).BeginInit();
            SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spDrugBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbEmployeeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // viAnswerBindingSource
            // 
            viAnswerBindingSource.DataSource = typeof(Shared.ViewModels.viAnswer);
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(BackBtn);
            panel1.Controls.Add(HeaderPanel);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1198, 146);
            panel1.TabIndex = 1;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            BackBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            BackBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            BackBtn.BorderRadius = 10;
            BackBtn.BorderSize = 0;
            BackBtn.FlatAppearance.BorderSize = 0;
            BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BackBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            BackBtn.ForeColor = System.Drawing.Color.White;
            BackBtn.Location = new System.Drawing.Point(1062, 83);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new System.Drawing.Size(124, 54);
            BackBtn.TabIndex = 5;
            BackBtn.Text = "⬅️ Назад";
            BackBtn.TextColor = System.Drawing.Color.White;
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = System.Drawing.Color.SlateBlue;
            HeaderPanel.Controls.Add(AnswersLabel);
            HeaderPanel.Controls.Add(pictureBox1);
            HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            HeaderPanel.Location = new System.Drawing.Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new System.Drawing.Size(1198, 77);
            HeaderPanel.TabIndex = 4;
            // 
            // AnswersLabel
            // 
            AnswersLabel.AutoSize = true;
            AnswersLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            AnswersLabel.Location = new System.Drawing.Point(247, 24);
            AnswersLabel.Name = "AnswersLabel";
            AnswersLabel.Size = new System.Drawing.Size(104, 28);
            AnswersLabel.TabIndex = 1;
            AnswersLabel.Text = "Ответы";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo2;
            pictureBox1.Location = new System.Drawing.Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(219, 50);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AnswersGridView
            // 
            AnswersGridView.AutoGenerateColumns = false;
            AnswersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            AnswersGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            AnswersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AnswersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, colQuestion, questionIdDataGridViewTextBoxColumn, employeeIdDataGridViewTextBoxColumn, colEmployeeName, colOptionContext, colVariant, optionIdDataGridViewTextBoxColumn, colIsCorrect, colDrug, drugIdDataGridViewTextBoxColumn, colAnswerDate });
            AnswersGridView.DataSource = viAnswerBindingSource;
            AnswersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            AnswersGridView.Location = new System.Drawing.Point(262, 146);
            AnswersGridView.Name = "AnswersGridView";
            AnswersGridView.Size = new System.Drawing.Size(936, 519);
            AnswersGridView.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // colQuestion
            // 
            colQuestion.DataPropertyName = "Question";
            colQuestion.HeaderText = "Вопрос";
            colQuestion.Name = "colQuestion";
            // 
            // questionIdDataGridViewTextBoxColumn
            // 
            questionIdDataGridViewTextBoxColumn.DataPropertyName = "QuestionId";
            questionIdDataGridViewTextBoxColumn.HeaderText = "QuestionId";
            questionIdDataGridViewTextBoxColumn.Name = "questionIdDataGridViewTextBoxColumn";
            questionIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            employeeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // colEmployeeName
            // 
            colEmployeeName.DataPropertyName = "EmployeeName";
            colEmployeeName.HeaderText = "Сотрудник";
            colEmployeeName.Name = "colEmployeeName";
            // 
            // colOptionContext
            // 
            colOptionContext.DataPropertyName = "OptionContext";
            colOptionContext.HeaderText = "Ответ";
            colOptionContext.Name = "colOptionContext";
            // 
            // colVariant
            // 
            colVariant.DataPropertyName = "Variant";
            colVariant.HeaderText = "Вариант";
            colVariant.Name = "colVariant";
            // 
            // optionIdDataGridViewTextBoxColumn
            // 
            optionIdDataGridViewTextBoxColumn.DataPropertyName = "OptionId";
            optionIdDataGridViewTextBoxColumn.HeaderText = "OptionId";
            optionIdDataGridViewTextBoxColumn.Name = "optionIdDataGridViewTextBoxColumn";
            optionIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // colIsCorrect
            // 
            colIsCorrect.DataPropertyName = "IsCorrect";
            colIsCorrect.HeaderText = "Правильность";
            colIsCorrect.Name = "colIsCorrect";
            // 
            // colDrug
            // 
            colDrug.DataPropertyName = "Drug";
            colDrug.HeaderText = "Препарат";
            colDrug.Name = "colDrug";
            // 
            // drugIdDataGridViewTextBoxColumn
            // 
            drugIdDataGridViewTextBoxColumn.DataPropertyName = "DrugId";
            drugIdDataGridViewTextBoxColumn.HeaderText = "DrugId";
            drugIdDataGridViewTextBoxColumn.Name = "drugIdDataGridViewTextBoxColumn";
            drugIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // colAnswerDate
            // 
            colAnswerDate.DataPropertyName = "AnswerDate";
            colAnswerDate.HeaderText = "Дата ответа";
            colAnswerDate.Name = "colAnswerDate";
            // 
            // SearchPanel
            // 
            SearchPanel.Controls.Add(QuestionComboBox);
            SearchPanel.Controls.Add(DrugComboBox);
            SearchPanel.Controls.Add(EmployeeComboBox);
            SearchPanel.Controls.Add(ResetBtn);
            SearchPanel.Controls.Add(SearchBtn);
            SearchPanel.Controls.Add(label3);
            SearchPanel.Controls.Add(label2);
            SearchPanel.Controls.Add(label1);
            SearchPanel.Dock = System.Windows.Forms.DockStyle.Left;
            SearchPanel.Location = new System.Drawing.Point(0, 146);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new System.Drawing.Size(262, 519);
            SearchPanel.TabIndex = 3;
            // 
            // QuestionComboBox
            // 
            QuestionComboBox.DisplayMember = "Value";
            QuestionComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            QuestionComboBox.FormattingEnabled = true;
            QuestionComboBox.Location = new System.Drawing.Point(60, 235);
            QuestionComboBox.Name = "QuestionComboBox";
            QuestionComboBox.Size = new System.Drawing.Size(140, 29);
            QuestionComboBox.TabIndex = 10;
            QuestionComboBox.ValueMember = "Id";
            // 
            // DrugComboBox
            // 
            DrugComboBox.DataSource = spDrugBindingSource;
            DrugComboBox.DisplayMember = "Name";
            DrugComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            DrugComboBox.FormattingEnabled = true;
            DrugComboBox.Location = new System.Drawing.Point(60, 143);
            DrugComboBox.Name = "DrugComboBox";
            DrugComboBox.Size = new System.Drawing.Size(140, 29);
            DrugComboBox.TabIndex = 9;
            DrugComboBox.ValueMember = "Id";
            DrugComboBox.SelectedIndexChanged += DrugComboBox_SelectedIndexChanged;
            // 
            // spDrugBindingSource
            // 
            spDrugBindingSource.DataSource = typeof(Models.spDrug);
            // 
            // EmployeeComboBox
            // 
            EmployeeComboBox.DataSource = tbEmployeeBindingSource;
            EmployeeComboBox.DisplayMember = "FullName";
            EmployeeComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            EmployeeComboBox.FormattingEnabled = true;
            EmployeeComboBox.Location = new System.Drawing.Point(60, 49);
            EmployeeComboBox.Name = "EmployeeComboBox";
            EmployeeComboBox.Size = new System.Drawing.Size(140, 29);
            EmployeeComboBox.TabIndex = 8;
            EmployeeComboBox.ValueMember = "Id";
            // 
            // tbEmployeeBindingSource
            // 
            tbEmployeeBindingSource.DataSource = typeof(Models.tbEmployee);
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            ResetBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            ResetBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            ResetBtn.BorderRadius = 10;
            ResetBtn.BorderSize = 0;
            ResetBtn.FlatAppearance.BorderSize = 0;
            ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ResetBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            ResetBtn.ForeColor = System.Drawing.Color.White;
            ResetBtn.Location = new System.Drawing.Point(129, 309);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new System.Drawing.Size(93, 41);
            ResetBtn.TabIndex = 7;
            ResetBtn.Text = "Сброс";
            ResetBtn.TextColor = System.Drawing.Color.White;
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            SearchBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            SearchBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            SearchBtn.BorderRadius = 10;
            SearchBtn.BorderSize = 0;
            SearchBtn.FlatAppearance.BorderSize = 0;
            SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SearchBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            SearchBtn.ForeColor = System.Drawing.Color.White;
            SearchBtn.Location = new System.Drawing.Point(30, 309);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new System.Drawing.Size(93, 41);
            SearchBtn.TabIndex = 6;
            SearchBtn.Text = "Поиск";
            SearchBtn.TextColor = System.Drawing.Color.White;
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(108, 217);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "Вопрос";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(102, 125);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Препарат";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(102, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Сотрудник";
            // 
            // FrmAnswers
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1198, 665);
            Controls.Add(AnswersGridView);
            Controls.Add(SearchPanel);
            Controls.Add(panel1);
            Name = "FrmAnswers";
            Text = "FrmAnswers";
            Load += FrmAnswers_Load;
            ((System.ComponentModel.ISupportInitialize)viAnswerBindingSource).EndInit();
            panel1.ResumeLayout(false);
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)AnswersGridView).EndInit();
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spDrugBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbEmployeeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private RJControlls.RJButton BackBtn;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label AnswersLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOption;
        private System.Windows.Forms.BindingSource viAnswerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOptionContext;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVariant;
        private System.Windows.Forms.DataGridView AnswersGridView;
        private System.Windows.Forms.Panel SearchPanel;
        private RJControlls.RJButton ResetBtn;
        private RJControlls.RJButton SearchBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox QuestionComboBox;
        private System.Windows.Forms.ComboBox DrugComboBox;
        private System.Windows.Forms.ComboBox EmployeeComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsCorrect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrug;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnswerDate;
        private System.Windows.Forms.BindingSource tbEmployeeBindingSource;
        private System.Windows.Forms.BindingSource spDrugBindingSource;
    }
}