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
            tbAnswerBindingSource = new System.Windows.Forms.BindingSource(components);
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            questionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            optionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            optionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            createUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            updateUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            updateDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).BeginInit();
            panel1.SuspendLayout();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbAnswerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // advancedDataGridView1
            // 
            advancedDataGridView1.AutoGenerateColumns = false;
            advancedDataGridView1.BackgroundColor = System.Drawing.Color.White;
            advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, questionIdDataGridViewTextBoxColumn, questionDataGridViewTextBoxColumn, employeeIdDataGridViewTextBoxColumn, employeeDataGridViewTextBoxColumn, optionIdDataGridViewTextBoxColumn, optionDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, createUserDataGridViewTextBoxColumn, createDateDataGridViewTextBoxColumn, updateUserDataGridViewTextBoxColumn, updateDateDataGridViewTextBoxColumn });
            advancedDataGridView1.DataSource = tbAnswerBindingSource;
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
            // tbAnswerBindingSource
            // 
            tbAnswerBindingSource.DataSource = typeof(Models.tbAnswer);
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
            // questionIdDataGridViewTextBoxColumn
            // 
            questionIdDataGridViewTextBoxColumn.DataPropertyName = "QuestionId";
            questionIdDataGridViewTextBoxColumn.HeaderText = "QuestionId";
            questionIdDataGridViewTextBoxColumn.MinimumWidth = 22;
            questionIdDataGridViewTextBoxColumn.Name = "questionIdDataGridViewTextBoxColumn";
            questionIdDataGridViewTextBoxColumn.ReadOnly = true;
            questionIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // questionDataGridViewTextBoxColumn
            // 
            questionDataGridViewTextBoxColumn.DataPropertyName = "Question";
            questionDataGridViewTextBoxColumn.HeaderText = "Question";
            questionDataGridViewTextBoxColumn.MinimumWidth = 22;
            questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            questionDataGridViewTextBoxColumn.ReadOnly = true;
            questionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            employeeIdDataGridViewTextBoxColumn.MinimumWidth = 22;
            employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            employeeIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            employeeDataGridViewTextBoxColumn.MinimumWidth = 22;
            employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            employeeDataGridViewTextBoxColumn.ReadOnly = true;
            employeeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // optionIdDataGridViewTextBoxColumn
            // 
            optionIdDataGridViewTextBoxColumn.DataPropertyName = "OptionId";
            optionIdDataGridViewTextBoxColumn.HeaderText = "OptionId";
            optionIdDataGridViewTextBoxColumn.MinimumWidth = 22;
            optionIdDataGridViewTextBoxColumn.Name = "optionIdDataGridViewTextBoxColumn";
            optionIdDataGridViewTextBoxColumn.ReadOnly = true;
            optionIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // optionDataGridViewTextBoxColumn
            // 
            optionDataGridViewTextBoxColumn.DataPropertyName = "Option";
            optionDataGridViewTextBoxColumn.HeaderText = "Option";
            optionDataGridViewTextBoxColumn.MinimumWidth = 22;
            optionDataGridViewTextBoxColumn.Name = "optionDataGridViewTextBoxColumn";
            optionDataGridViewTextBoxColumn.ReadOnly = true;
            optionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 22;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // createUserDataGridViewTextBoxColumn
            // 
            createUserDataGridViewTextBoxColumn.DataPropertyName = "CreateUser";
            createUserDataGridViewTextBoxColumn.HeaderText = "CreateUser";
            createUserDataGridViewTextBoxColumn.MinimumWidth = 22;
            createUserDataGridViewTextBoxColumn.Name = "createUserDataGridViewTextBoxColumn";
            createUserDataGridViewTextBoxColumn.ReadOnly = true;
            createUserDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            createDateDataGridViewTextBoxColumn.MinimumWidth = 22;
            createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            createDateDataGridViewTextBoxColumn.ReadOnly = true;
            createDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // updateUserDataGridViewTextBoxColumn
            // 
            updateUserDataGridViewTextBoxColumn.DataPropertyName = "UpdateUser";
            updateUserDataGridViewTextBoxColumn.HeaderText = "UpdateUser";
            updateUserDataGridViewTextBoxColumn.MinimumWidth = 22;
            updateUserDataGridViewTextBoxColumn.Name = "updateUserDataGridViewTextBoxColumn";
            updateUserDataGridViewTextBoxColumn.ReadOnly = true;
            updateUserDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // updateDateDataGridViewTextBoxColumn
            // 
            updateDateDataGridViewTextBoxColumn.DataPropertyName = "UpdateDate";
            updateDateDataGridViewTextBoxColumn.HeaderText = "UpdateDate";
            updateDateDataGridViewTextBoxColumn.MinimumWidth = 22;
            updateDateDataGridViewTextBoxColumn.Name = "updateDateDataGridViewTextBoxColumn";
            updateDateDataGridViewTextBoxColumn.ReadOnly = true;
            updateDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).EndInit();
            panel1.ResumeLayout(false);
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbAnswerBindingSource).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn questionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tbAnswerBindingSource;
    }
}