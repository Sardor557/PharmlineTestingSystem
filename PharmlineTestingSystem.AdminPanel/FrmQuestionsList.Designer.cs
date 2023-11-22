namespace PharmlineTestingSystem.AdminPanel
{
    partial class FrmQuestionsList
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
            BackBtn = new RJControlls.RJButton();
            EditQuestionBtn = new RJControlls.RJButton();
            AddQuestionBtn = new RJControlls.RJButton();
            QuestionsGridView = new System.Windows.Forms.DataGridView();
            colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colContext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDrugId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            spDrugBindingSource = new System.Windows.Forms.BindingSource(components);
            colIsOpen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            createUserDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            updateUserDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            updateDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tbQuestionBindingSource = new System.Windows.Forms.BindingSource(components);
            splitter1 = new System.Windows.Forms.Splitter();
            OptionsGridView = new System.Windows.Forms.DataGridView();
            colOptionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colVariant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colIsCorrect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            createUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colOptionCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            updateUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            updateDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tbOptionBindingSource = new System.Windows.Forms.BindingSource(components);
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuestionsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spDrugBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbQuestionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OptionsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbOptionBindingSource).BeginInit();
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
            panel.Controls.Add(BackBtn);
            panel.Controls.Add(EditQuestionBtn);
            panel.Controls.Add(AddQuestionBtn);
            panel.Dock = System.Windows.Forms.DockStyle.Top;
            panel.Location = new System.Drawing.Point(0, 77);
            panel.Name = "panel";
            panel.Size = new System.Drawing.Size(547, 64);
            panel.TabIndex = 1;
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
            BackBtn.Location = new System.Drawing.Point(411, 4);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new System.Drawing.Size(124, 54);
            BackBtn.TabIndex = 4;
            BackBtn.Text = "⬅️ Назад";
            BackBtn.TextColor = System.Drawing.Color.White;
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
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
            EditQuestionBtn.Click += EditQuestionBtn_Click;
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
            AddQuestionBtn.Click += AddQuestionBtn_Click;
            // 
            // QuestionsGridView
            // 
            QuestionsGridView.AutoGenerateColumns = false;
            QuestionsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            QuestionsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            QuestionsGridView.BackgroundColor = System.Drawing.Color.White;
            QuestionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            QuestionsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colId, colContext, colDrugId, colIsOpen, statusDataGridViewTextBoxColumn1, createUserDataGridViewTextBoxColumn1, colCreateDate, updateUserDataGridViewTextBoxColumn1, updateDateDataGridViewTextBoxColumn1 });
            QuestionsGridView.DataSource = tbQuestionBindingSource;
            QuestionsGridView.Dock = System.Windows.Forms.DockStyle.Top;
            QuestionsGridView.Location = new System.Drawing.Point(0, 141);
            QuestionsGridView.MultiSelect = false;
            QuestionsGridView.Name = "QuestionsGridView";
            QuestionsGridView.ReadOnly = true;
            QuestionsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            QuestionsGridView.Size = new System.Drawing.Size(547, 335);
            QuestionsGridView.TabIndex = 2;
            QuestionsGridView.SelectionChanged += QuestionsGridView_SelectionChanged;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colContext
            // 
            colContext.DataPropertyName = "Context";
            colContext.HeaderText = "Контекст";
            colContext.Name = "colContext";
            colContext.ReadOnly = true;
            // 
            // colDrugId
            // 
            colDrugId.AutoComplete = false;
            colDrugId.DataPropertyName = "DrugId";
            colDrugId.DataSource = spDrugBindingSource;
            colDrugId.DisplayMember = "Name";
            colDrugId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            colDrugId.HeaderText = "Препарат";
            colDrugId.Name = "colDrugId";
            colDrugId.ReadOnly = true;
            colDrugId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            colDrugId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            colDrugId.ValueMember = "Id";
            // 
            // spDrugBindingSource
            // 
            spDrugBindingSource.DataSource = typeof(Models.spDrug);
            // 
            // colIsOpen
            // 
            colIsOpen.DataPropertyName = "IsOpen";
            colIsOpen.HeaderText = "Октрытый вопрос";
            colIsOpen.Name = "colIsOpen";
            colIsOpen.ReadOnly = true;
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
            // colCreateDate
            // 
            colCreateDate.DataPropertyName = "CreateDate";
            colCreateDate.HeaderText = "Дата создания";
            colCreateDate.Name = "colCreateDate";
            colCreateDate.ReadOnly = true;
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
            // tbQuestionBindingSource
            // 
            tbQuestionBindingSource.DataSource = typeof(Models.tbQuestion);
            // 
            // splitter1
            // 
            splitter1.BackColor = System.Drawing.Color.Red;
            splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            splitter1.Location = new System.Drawing.Point(0, 476);
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
            OptionsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colOptionId, colAnswer, dataGridViewTextBoxColumn5, questionDataGridViewTextBoxColumn, colVariant, colIsCorrect, statusDataGridViewTextBoxColumn, createUserDataGridViewTextBoxColumn, colOptionCreateDate, updateUserDataGridViewTextBoxColumn, updateDateDataGridViewTextBoxColumn });
            OptionsGridView.DataSource = tbOptionBindingSource;
            OptionsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            OptionsGridView.Location = new System.Drawing.Point(0, 479);
            OptionsGridView.Name = "OptionsGridView";
            OptionsGridView.ReadOnly = true;
            OptionsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            OptionsGridView.Size = new System.Drawing.Size(547, 279);
            OptionsGridView.TabIndex = 4;
            // 
            // colOptionId
            // 
            colOptionId.DataPropertyName = "Id";
            colOptionId.HeaderText = "Id";
            colOptionId.Name = "colOptionId";
            colOptionId.ReadOnly = true;
            // 
            // colAnswer
            // 
            colAnswer.DataPropertyName = "Answer";
            colAnswer.HeaderText = "Ответ";
            colAnswer.Name = "colAnswer";
            colAnswer.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "QuestionId";
            dataGridViewTextBoxColumn5.HeaderText = "QuestionId";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Visible = false;
            // 
            // questionDataGridViewTextBoxColumn
            // 
            questionDataGridViewTextBoxColumn.DataPropertyName = "Question";
            questionDataGridViewTextBoxColumn.HeaderText = "Question";
            questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            questionDataGridViewTextBoxColumn.ReadOnly = true;
            questionDataGridViewTextBoxColumn.Visible = false;
            // 
            // colVariant
            // 
            colVariant.DataPropertyName = "Variant";
            colVariant.HeaderText = "Вариант";
            colVariant.Name = "colVariant";
            colVariant.ReadOnly = true;
            // 
            // colIsCorrect
            // 
            colIsCorrect.DataPropertyName = "IsCorrect";
            colIsCorrect.HeaderText = "Правильный";
            colIsCorrect.Name = "colIsCorrect";
            colIsCorrect.ReadOnly = true;
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
            // colOptionCreateDate
            // 
            colOptionCreateDate.DataPropertyName = "CreateDate";
            colOptionCreateDate.HeaderText = "Дата создания";
            colOptionCreateDate.Name = "colOptionCreateDate";
            colOptionCreateDate.ReadOnly = true;
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
            // tbOptionBindingSource
            // 
            tbOptionBindingSource.DataSource = typeof(Models.tbOption);
            // 
            // FrmQuestionsList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = BackBtn;
            ClientSize = new System.Drawing.Size(547, 758);
            Controls.Add(OptionsGridView);
            Controls.Add(splitter1);
            Controls.Add(QuestionsGridView);
            Controls.Add(panel);
            Controls.Add(HeaderPanel);
            Name = "FrmQuestionsList";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Вопросы";
            Load += FrmQuestionsList_Load;
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)QuestionsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)spDrugBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbQuestionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)OptionsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbOptionBindingSource).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn variantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCorrectDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn drugIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spDrugBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isOpenDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOptionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVariant;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsCorrect;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOptionCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn;
        private RJControlls.RJButton BackBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContext;
        private System.Windows.Forms.DataGridViewComboBoxColumn colDrugId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createUserDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateUserDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn1;
    }
}