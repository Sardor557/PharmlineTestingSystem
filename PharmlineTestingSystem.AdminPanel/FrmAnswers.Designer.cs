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
            answersAdvancedGridView = new Zuby.ADGV.AdvancedDataGridView();
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
            viAnswerBindingSource = new System.Windows.Forms.BindingSource(components);
            panel1 = new System.Windows.Forms.Panel();
            BackBtn = new RJControlls.RJButton();
            HeaderPanel = new System.Windows.Forms.Panel();
            AnswersLabel = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)answersAdvancedGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viAnswerBindingSource).BeginInit();
            panel1.SuspendLayout();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // answersAdvancedGridView
            // 
            answersAdvancedGridView.AutoGenerateColumns = false;
            answersAdvancedGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            answersAdvancedGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            answersAdvancedGridView.BackgroundColor = System.Drawing.Color.White;
            answersAdvancedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            answersAdvancedGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, colQuestion, questionIdDataGridViewTextBoxColumn, employeeIdDataGridViewTextBoxColumn, colEmployeeName, colOptionContext, colVariant, optionIdDataGridViewTextBoxColumn, colIsCorrect, colDrug, drugIdDataGridViewTextBoxColumn, colAnswerDate });
            answersAdvancedGridView.DataSource = viAnswerBindingSource;
            answersAdvancedGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            answersAdvancedGridView.FilterAndSortEnabled = true;
            answersAdvancedGridView.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            answersAdvancedGridView.Location = new System.Drawing.Point(0, 146);
            answersAdvancedGridView.Name = "answersAdvancedGridView";
            answersAdvancedGridView.ReadOnly = true;
            answersAdvancedGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            answersAdvancedGridView.Size = new System.Drawing.Size(862, 426);
            answersAdvancedGridView.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            answersAdvancedGridView.TabIndex = 0;
            answersAdvancedGridView.SortStringChanged += advancedDataGridView1_SortStringChanged;
            answersAdvancedGridView.FilterStringChanged += advancedDataGridView1_FilterStringChanged;
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
            // colOptionContext
            // 
            colOptionContext.DataPropertyName = "OptionContext";
            colOptionContext.HeaderText = "Ответ";
            colOptionContext.MinimumWidth = 22;
            colOptionContext.Name = "colOptionContext";
            colOptionContext.ReadOnly = true;
            colOptionContext.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colVariant
            // 
            colVariant.DataPropertyName = "Variant";
            colVariant.HeaderText = "Вариант";
            colVariant.MinimumWidth = 22;
            colVariant.Name = "colVariant";
            colVariant.ReadOnly = true;
            colVariant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // colIsCorrect
            // 
            colIsCorrect.DataPropertyName = "IsCorrect";
            colIsCorrect.HeaderText = "Правильность";
            colIsCorrect.MinimumWidth = 22;
            colIsCorrect.Name = "colIsCorrect";
            colIsCorrect.ReadOnly = true;
            colIsCorrect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // viAnswerBindingSource
            // 
            viAnswerBindingSource.DataSource = typeof(Shared.ViewModels.viAnswer);
            viAnswerBindingSource.ListChanged += viAnswerBindingSource_ListChanged;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(BackBtn);
            panel1.Controls.Add(HeaderPanel);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(862, 146);
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
            BackBtn.Location = new System.Drawing.Point(726, 83);
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
            HeaderPanel.Size = new System.Drawing.Size(862, 77);
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
            // FrmAnswers
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(862, 572);
            Controls.Add(answersAdvancedGridView);
            Controls.Add(panel1);
            Name = "FrmAnswers";
            Text = "FrmAnswers";
            Load += FrmAnswers_Load;
            ((System.ComponentModel.ISupportInitialize)answersAdvancedGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)viAnswerBindingSource).EndInit();
            panel1.ResumeLayout(false);
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView answersAdvancedGridView;
        private System.Windows.Forms.Panel panel1;
        private RJControlls.RJButton BackBtn;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label AnswersLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOption;
        private System.Windows.Forms.BindingSource viAnswerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOptionContext;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVariant;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsCorrect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrug;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnswerDate;
    }
}