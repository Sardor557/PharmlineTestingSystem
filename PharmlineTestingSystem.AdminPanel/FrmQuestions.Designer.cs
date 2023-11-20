namespace PharmlineTestingSystem.AdminPanel
{
    partial class FrmQuestions
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
            HeaderPanel = new System.Windows.Forms.Panel();
            QuestionsLabel = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel = new System.Windows.Forms.Panel();
            EditQuestionBtn = new RJControlls.RJButton();
            AddQuestionBtn = new RJControlls.RJButton();
            QuestionsGridView = new System.Windows.Forms.DataGridView();
            tbQuestionBindingSource = new System.Windows.Forms.BindingSource(components);
            splitter1 = new System.Windows.Forms.Splitter();
            OptionsGridView = new System.Windows.Forms.DataGridView();
            tbOptionBindingSource = new System.Windows.Forms.BindingSource(components);
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            answerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            questionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            variantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            isCorrectDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            createUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            updateUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            updateDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            spDrugBindingSource = new System.Windows.Forms.BindingSource(components);
            idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            contextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            drugIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            drugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            isOpenDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            createUserDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            createDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            updateUserDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            updateDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuestionsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbQuestionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OptionsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbOptionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spDrugBindingSource).BeginInit();
            SuspendLayout();
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = System.Drawing.Color.SlateBlue;
            HeaderPanel.Controls.Add(QuestionsLabel);
            HeaderPanel.Controls.Add(pictureBox1);
            HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            HeaderPanel.Location = new System.Drawing.Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new System.Drawing.Size(547, 77);
            HeaderPanel.TabIndex = 0;
            // 
            // QuestionsLabel
            // 
            QuestionsLabel.AutoSize = true;
            QuestionsLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            QuestionsLabel.Location = new System.Drawing.Point(247, 24);
            QuestionsLabel.Name = "QuestionsLabel";
            QuestionsLabel.Size = new System.Drawing.Size(119, 28);
            QuestionsLabel.TabIndex = 1;
            QuestionsLabel.Text = "Вопросы";
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
            // panel
            // 
            panel.BackColor = System.Drawing.Color.White;
            panel.Controls.Add(EditQuestionBtn);
            panel.Controls.Add(AddQuestionBtn);
            panel.Dock = System.Windows.Forms.DockStyle.Top;
            panel.Location = new System.Drawing.Point(0, 77);
            panel.Name = "panel";
            panel.Size = new System.Drawing.Size(547, 64);
            panel.TabIndex = 1;
            // 
            // EditQuestionBtn
            // 
            EditQuestionBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            EditQuestionBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            EditQuestionBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            EditQuestionBtn.BorderRadius = 10;
            EditQuestionBtn.BorderSize = 0;
            EditQuestionBtn.FlatAppearance.BorderSize = 0;
            EditQuestionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            EditQuestionBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            EditQuestionBtn.ForeColor = System.Drawing.Color.White;
            EditQuestionBtn.Location = new System.Drawing.Point(174, 4);
            EditQuestionBtn.Name = "EditQuestionBtn";
            EditQuestionBtn.Size = new System.Drawing.Size(150, 54);
            EditQuestionBtn.TabIndex = 2;
            EditQuestionBtn.Text = "Изменить вопрос";
            EditQuestionBtn.TextColor = System.Drawing.Color.White;
            EditQuestionBtn.UseVisualStyleBackColor = false;
            // 
            // AddQuestionBtn
            // 
            AddQuestionBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            AddQuestionBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            AddQuestionBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            AddQuestionBtn.BorderRadius = 10;
            AddQuestionBtn.BorderSize = 0;
            AddQuestionBtn.FlatAppearance.BorderSize = 0;
            AddQuestionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddQuestionBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            AddQuestionBtn.ForeColor = System.Drawing.Color.White;
            AddQuestionBtn.Location = new System.Drawing.Point(3, 4);
            AddQuestionBtn.Name = "AddQuestionBtn";
            AddQuestionBtn.Size = new System.Drawing.Size(150, 54);
            AddQuestionBtn.TabIndex = 1;
            AddQuestionBtn.Text = "Добавить вопрос";
            AddQuestionBtn.TextColor = System.Drawing.Color.White;
            AddQuestionBtn.UseVisualStyleBackColor = false;
            // 
            // QuestionsGridView
            // 
            QuestionsGridView.AutoGenerateColumns = false;
            QuestionsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            QuestionsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            QuestionsGridView.BackgroundColor = System.Drawing.Color.White;
            QuestionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            QuestionsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn1, contextDataGridViewTextBoxColumn, drugIdDataGridViewTextBoxColumn, drugDataGridViewTextBoxColumn, isOpenDataGridViewCheckBoxColumn, statusDataGridViewTextBoxColumn1, createUserDataGridViewTextBoxColumn1, createDateDataGridViewTextBoxColumn1, updateUserDataGridViewTextBoxColumn1, updateDateDataGridViewTextBoxColumn1 });
            QuestionsGridView.DataSource = tbQuestionBindingSource;
            QuestionsGridView.Dock = System.Windows.Forms.DockStyle.Top;
            QuestionsGridView.Location = new System.Drawing.Point(0, 141);
            QuestionsGridView.Name = "QuestionsGridView";
            QuestionsGridView.ReadOnly = true;
            QuestionsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            QuestionsGridView.Size = new System.Drawing.Size(547, 298);
            QuestionsGridView.TabIndex = 2;
            // 
            // tbQuestionBindingSource
            // 
            tbQuestionBindingSource.DataSource = typeof(Models.tbQuestion);
            // 
            // splitter1
            // 
            splitter1.BackColor = System.Drawing.Color.Red;
            splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            splitter1.Location = new System.Drawing.Point(0, 439);
            splitter1.Name = "splitter1";
            splitter1.Size = new System.Drawing.Size(547, 3);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // OptionsGridView
            // 
            OptionsGridView.AutoGenerateColumns = false;
            OptionsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            OptionsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            OptionsGridView.BackgroundColor = System.Drawing.Color.White;
            OptionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OptionsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, answerDataGridViewTextBoxColumn, questionIdDataGridViewTextBoxColumn, questionDataGridViewTextBoxColumn, variantDataGridViewTextBoxColumn, isCorrectDataGridViewCheckBoxColumn, statusDataGridViewTextBoxColumn, createUserDataGridViewTextBoxColumn, createDateDataGridViewTextBoxColumn, updateUserDataGridViewTextBoxColumn, updateDateDataGridViewTextBoxColumn });
            OptionsGridView.DataSource = tbOptionBindingSource;
            OptionsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            OptionsGridView.Location = new System.Drawing.Point(0, 442);
            OptionsGridView.Name = "OptionsGridView";
            OptionsGridView.ReadOnly = true;
            OptionsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            OptionsGridView.Size = new System.Drawing.Size(547, 302);
            OptionsGridView.TabIndex = 4;
            // 
            // tbOptionBindingSource
            // 
            tbOptionBindingSource.DataSource = typeof(Models.tbOption);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // answerDataGridViewTextBoxColumn
            // 
            answerDataGridViewTextBoxColumn.DataPropertyName = "colAnswer";
            answerDataGridViewTextBoxColumn.HeaderText = "Контекст ответа";
            answerDataGridViewTextBoxColumn.Name = "answerDataGridViewTextBoxColumn";
            answerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // questionIdDataGridViewTextBoxColumn
            // 
            questionIdDataGridViewTextBoxColumn.DataPropertyName = "colQuestionId";
            questionIdDataGridViewTextBoxColumn.HeaderText = "Вопрос";
            questionIdDataGridViewTextBoxColumn.Name = "questionIdDataGridViewTextBoxColumn";
            questionIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // questionDataGridViewTextBoxColumn
            // 
            questionDataGridViewTextBoxColumn.DataPropertyName = "Question";
            questionDataGridViewTextBoxColumn.HeaderText = "Question";
            questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            questionDataGridViewTextBoxColumn.ReadOnly = true;
            questionDataGridViewTextBoxColumn.Visible = false;
            // 
            // variantDataGridViewTextBoxColumn
            // 
            variantDataGridViewTextBoxColumn.DataPropertyName = "colVariant";
            variantDataGridViewTextBoxColumn.HeaderText = "Вариант";
            variantDataGridViewTextBoxColumn.Name = "variantDataGridViewTextBoxColumn";
            variantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isCorrectDataGridViewCheckBoxColumn
            // 
            isCorrectDataGridViewCheckBoxColumn.DataPropertyName = "colIsCorrect";
            isCorrectDataGridViewCheckBoxColumn.HeaderText = "Правильный";
            isCorrectDataGridViewCheckBoxColumn.Name = "isCorrectDataGridViewCheckBoxColumn";
            isCorrectDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // createUserDataGridViewTextBoxColumn
            // 
            createUserDataGridViewTextBoxColumn.DataPropertyName = "CreateUser";
            createUserDataGridViewTextBoxColumn.HeaderText = "CreateUser";
            createUserDataGridViewTextBoxColumn.Name = "createUserDataGridViewTextBoxColumn";
            createUserDataGridViewTextBoxColumn.ReadOnly = true;
            createUserDataGridViewTextBoxColumn.Visible = false;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            createDateDataGridViewTextBoxColumn.DataPropertyName = "colCreateDate";
            createDateDataGridViewTextBoxColumn.HeaderText = "Дата создания";
            createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            createDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updateUserDataGridViewTextBoxColumn
            // 
            updateUserDataGridViewTextBoxColumn.DataPropertyName = "UpdateUser";
            updateUserDataGridViewTextBoxColumn.HeaderText = "UpdateUser";
            updateUserDataGridViewTextBoxColumn.Name = "updateUserDataGridViewTextBoxColumn";
            updateUserDataGridViewTextBoxColumn.ReadOnly = true;
            updateUserDataGridViewTextBoxColumn.Visible = false;
            // 
            // updateDateDataGridViewTextBoxColumn
            // 
            updateDateDataGridViewTextBoxColumn.DataPropertyName = "UpdateDate";
            updateDateDataGridViewTextBoxColumn.HeaderText = "UpdateDate";
            updateDateDataGridViewTextBoxColumn.Name = "updateDateDataGridViewTextBoxColumn";
            updateDateDataGridViewTextBoxColumn.ReadOnly = true;
            updateDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // spDrugBindingSource
            // 
            spDrugBindingSource.DataSource = typeof(Models.spDrug);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // contextDataGridViewTextBoxColumn
            // 
            contextDataGridViewTextBoxColumn.DataPropertyName = "colContext";
            contextDataGridViewTextBoxColumn.HeaderText = "Контекст";
            contextDataGridViewTextBoxColumn.Name = "contextDataGridViewTextBoxColumn";
            contextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drugIdDataGridViewTextBoxColumn
            // 
            drugIdDataGridViewTextBoxColumn.DataPropertyName = "colDrugId";
            drugIdDataGridViewTextBoxColumn.DataSource = spDrugBindingSource;
            drugIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            drugIdDataGridViewTextBoxColumn.HeaderText = "Препарат";
            drugIdDataGridViewTextBoxColumn.Name = "drugIdDataGridViewTextBoxColumn";
            drugIdDataGridViewTextBoxColumn.ReadOnly = true;
            drugIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            drugIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            drugIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // drugDataGridViewTextBoxColumn
            // 
            drugDataGridViewTextBoxColumn.DataPropertyName = "Drug";
            drugDataGridViewTextBoxColumn.HeaderText = "Drug";
            drugDataGridViewTextBoxColumn.Name = "drugDataGridViewTextBoxColumn";
            drugDataGridViewTextBoxColumn.ReadOnly = true;
            drugDataGridViewTextBoxColumn.Visible = false;
            // 
            // isOpenDataGridViewCheckBoxColumn
            // 
            isOpenDataGridViewCheckBoxColumn.DataPropertyName = "colIsOpen";
            isOpenDataGridViewCheckBoxColumn.HeaderText = "Открыты вопрос";
            isOpenDataGridViewCheckBoxColumn.Name = "isOpenDataGridViewCheckBoxColumn";
            isOpenDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            statusDataGridViewTextBoxColumn1.ReadOnly = true;
            statusDataGridViewTextBoxColumn1.Visible = false;
            // 
            // createUserDataGridViewTextBoxColumn1
            // 
            createUserDataGridViewTextBoxColumn1.DataPropertyName = "CreateUser";
            createUserDataGridViewTextBoxColumn1.HeaderText = "CreateUser";
            createUserDataGridViewTextBoxColumn1.Name = "createUserDataGridViewTextBoxColumn1";
            createUserDataGridViewTextBoxColumn1.ReadOnly = true;
            createUserDataGridViewTextBoxColumn1.Visible = false;
            // 
            // createDateDataGridViewTextBoxColumn1
            // 
            createDateDataGridViewTextBoxColumn1.DataPropertyName = "colCreateDate";
            createDateDataGridViewTextBoxColumn1.HeaderText = "Дата создания";
            createDateDataGridViewTextBoxColumn1.Name = "createDateDataGridViewTextBoxColumn1";
            createDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // updateUserDataGridViewTextBoxColumn1
            // 
            updateUserDataGridViewTextBoxColumn1.DataPropertyName = "UpdateUser";
            updateUserDataGridViewTextBoxColumn1.HeaderText = "UpdateUser";
            updateUserDataGridViewTextBoxColumn1.Name = "updateUserDataGridViewTextBoxColumn1";
            updateUserDataGridViewTextBoxColumn1.ReadOnly = true;
            updateUserDataGridViewTextBoxColumn1.Visible = false;
            // 
            // updateDateDataGridViewTextBoxColumn1
            // 
            updateDateDataGridViewTextBoxColumn1.DataPropertyName = "UpdateDate";
            updateDateDataGridViewTextBoxColumn1.HeaderText = "UpdateDate";
            updateDateDataGridViewTextBoxColumn1.Name = "updateDateDataGridViewTextBoxColumn1";
            updateDateDataGridViewTextBoxColumn1.ReadOnly = true;
            updateDateDataGridViewTextBoxColumn1.Visible = false;
            // 
            // FrmQuestions
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(547, 744);
            Controls.Add(OptionsGridView);
            Controls.Add(splitter1);
            Controls.Add(QuestionsGridView);
            Controls.Add(panel);
            Controls.Add(HeaderPanel);
            Name = "FrmQuestions";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Вопросы";
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)QuestionsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbQuestionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)OptionsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbOptionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)spDrugBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJControlls.RJButton AddQuestionBtn;
        private System.Windows.Forms.Label QuestionsLabel;
        private RJControlls.RJButton EditQuestionBtn;
        private System.Windows.Forms.DataGridView QuestionsGridView;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView OptionsGridView;
        private System.Windows.Forms.BindingSource tbOptionBindingSource;
        private System.Windows.Forms.BindingSource tbQuestionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn variantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCorrectDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn drugIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spDrugBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isOpenDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createUserDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateUserDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn1;
    }
}