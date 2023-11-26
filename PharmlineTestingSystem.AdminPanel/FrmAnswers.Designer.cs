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
            advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            panel1 = new System.Windows.Forms.Panel();
            BackBtn = new RJControlls.RJButton();
            HeaderPanel = new System.Windows.Forms.Panel();
            AnswersLabel = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            viAnswerBindingSource = new System.Windows.Forms.BindingSource(components);
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            questionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colOption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            optionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colIscorrect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            colDrug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            drugIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAnswerDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).BeginInit();
            panel1.SuspendLayout();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viAnswerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // advancedDataGridView1
            // 
            advancedDataGridView1.AutoGenerateColumns = false;
            advancedDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            advancedDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            advancedDataGridView1.BackgroundColor = System.Drawing.Color.White;
            advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, colQuestion, questionIdDataGridViewTextBoxColumn, employeeIdDataGridViewTextBoxColumn, colEmployeeName, colOption, optionIdDataGridViewTextBoxColumn, colIscorrect, colDrug, drugIdDataGridViewTextBoxColumn, colAnswerDate });
            advancedDataGridView1.DataSource = viAnswerBindingSource;
            advancedDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            advancedDataGridView1.FilterAndSortEnabled = true;
            advancedDataGridView1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView1.Location = new System.Drawing.Point(0, 146);
            advancedDataGridView1.Name = "advancedDataGridView1";
            advancedDataGridView1.ReadOnly = true;
            advancedDataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            advancedDataGridView1.Size = new System.Drawing.Size(715, 304);
            advancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(BackBtn);
            panel1.Controls.Add(HeaderPanel);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(715, 146);
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
            BackBtn.Location = new System.Drawing.Point(579, 83);
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
            HeaderPanel.Size = new System.Drawing.Size(715, 77);
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
            // viAnswerBindingSource
            // 
            viAnswerBindingSource.DataSource = typeof(Shared.ViewModels.viAnswer);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 22;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colQuestion
            // 
            colQuestion.DataPropertyName = "Question";
            colQuestion.HeaderText = "Вопрос";
            colQuestion.MinimumWidth = 22;
            colQuestion.Name = "colQuestion";
            colQuestion.ReadOnly = true;
            colQuestion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // questionIdDataGridViewTextBoxColumn
            // 
            questionIdDataGridViewTextBoxColumn.DataPropertyName = "QuestionId";
            questionIdDataGridViewTextBoxColumn.HeaderText = "QuestionId";
            questionIdDataGridViewTextBoxColumn.MinimumWidth = 22;
            questionIdDataGridViewTextBoxColumn.Name = "questionIdDataGridViewTextBoxColumn";
            questionIdDataGridViewTextBoxColumn.ReadOnly = true;
            questionIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            questionIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            employeeIdDataGridViewTextBoxColumn.MinimumWidth = 22;
            employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            employeeIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            employeeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // colEmployeeName
            // 
            colEmployeeName.DataPropertyName = "EmployeeName";
            colEmployeeName.HeaderText = "Сотрудник";
            colEmployeeName.MinimumWidth = 22;
            colEmployeeName.Name = "colEmployeeName";
            colEmployeeName.ReadOnly = true;
            colEmployeeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colOption
            // 
            colOption.DataPropertyName = "Option";
            colOption.HeaderText = "Вариант";
            colOption.MinimumWidth = 22;
            colOption.Name = "colOption";
            colOption.ReadOnly = true;
            colOption.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // optionIdDataGridViewTextBoxColumn
            // 
            optionIdDataGridViewTextBoxColumn.DataPropertyName = "OptionId";
            optionIdDataGridViewTextBoxColumn.HeaderText = "OptionId";
            optionIdDataGridViewTextBoxColumn.MinimumWidth = 22;
            optionIdDataGridViewTextBoxColumn.Name = "optionIdDataGridViewTextBoxColumn";
            optionIdDataGridViewTextBoxColumn.ReadOnly = true;
            optionIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            optionIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // colIscorrect
            // 
            colIscorrect.DataPropertyName = "IsCorrect";
            colIscorrect.HeaderText = "Правильно";
            colIscorrect.MinimumWidth = 22;
            colIscorrect.Name = "colIscorrect";
            colIscorrect.ReadOnly = true;
            colIscorrect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colDrug
            // 
            colDrug.DataPropertyName = "Drug";
            colDrug.HeaderText = "Препарат";
            colDrug.MinimumWidth = 22;
            colDrug.Name = "colDrug";
            colDrug.ReadOnly = true;
            colDrug.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // drugIdDataGridViewTextBoxColumn
            // 
            drugIdDataGridViewTextBoxColumn.DataPropertyName = "DrugId";
            drugIdDataGridViewTextBoxColumn.HeaderText = "DrugId";
            drugIdDataGridViewTextBoxColumn.MinimumWidth = 22;
            drugIdDataGridViewTextBoxColumn.Name = "drugIdDataGridViewTextBoxColumn";
            drugIdDataGridViewTextBoxColumn.ReadOnly = true;
            drugIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            drugIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // colAnswerDate
            // 
            colAnswerDate.DataPropertyName = "AnswerDate";
            colAnswerDate.HeaderText = "Дата ответа";
            colAnswerDate.MinimumWidth = 22;
            colAnswerDate.Name = "colAnswerDate";
            colAnswerDate.ReadOnly = true;
            colAnswerDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // FrmAnswers
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(715, 450);
            Controls.Add(advancedDataGridView1);
            Controls.Add(panel1);
            Name = "FrmAnswers";
            Text = "FrmAnswers";
            Load += FrmAnswers_Load;
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).EndInit();
            panel1.ResumeLayout(false);
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)viAnswerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.Panel panel1;
        private RJControlls.RJButton BackBtn;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label AnswersLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOption;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIscorrect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrug;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnswerDate;
        private System.Windows.Forms.BindingSource viAnswerBindingSource;
    }
}