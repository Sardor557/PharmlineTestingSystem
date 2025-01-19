namespace PharmlineTestingSystem.AdminPanel
{
    partial class FrmQuestion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            DrugLabel = new System.Windows.Forms.Label();
            DrugComboBox = new System.Windows.Forms.ComboBox();
            spDrugBindingSource = new System.Windows.Forms.BindingSource(components);
            tbQuestionBindingSource = new System.Windows.Forms.BindingSource(components);
            ContextTextBox = new System.Windows.Forms.RichTextBox();
            ContextLabel = new System.Windows.Forms.Label();
            IsOpencheckBox = new System.Windows.Forms.CheckBox();
            OptionsGridView = new System.Windows.Forms.DataGridView();
            colOptionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colQuestionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colVariant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colIsCorrect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            colStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            spStatusBindingSource = new System.Windows.Forms.BindingSource(components);
            createUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            updateUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            updateDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tbOptionBindingSource = new System.Windows.Forms.BindingSource(components);
            SaveOptionsBtn = new System.Windows.Forms.Button();
            StatusLabel = new System.Windows.Forms.Label();
            StatusComboBox = new System.Windows.Forms.ComboBox();
            BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)spDrugBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbQuestionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OptionsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spStatusBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbOptionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // DrugLabel
            // 
            DrugLabel.AutoSize = true;
            DrugLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            DrugLabel.Location = new System.Drawing.Point(16, 40);
            DrugLabel.Name = "DrugLabel";
            DrugLabel.Size = new System.Drawing.Size(79, 21);
            DrugLabel.TabIndex = 0;
            DrugLabel.Text = "Препарат";
            // 
            // DrugComboBox
            // 
            DrugComboBox.CausesValidation = false;
            DrugComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", spDrugBindingSource, "Id", true));
            DrugComboBox.DataSource = spDrugBindingSource;
            DrugComboBox.DisplayMember = "Name";
            DrugComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            DrugComboBox.FormattingEnabled = true;
            DrugComboBox.Location = new System.Drawing.Point(101, 37);
            DrugComboBox.Name = "DrugComboBox";
            DrugComboBox.Size = new System.Drawing.Size(147, 29);
            DrugComboBox.TabIndex = 1;
            DrugComboBox.ValueMember = "ID";
            // 
            // spDrugBindingSource
            // 
            spDrugBindingSource.DataSource = typeof(Models.spDrug);
            // 
            // tbQuestionBindingSource
            // 
            tbQuestionBindingSource.DataSource = typeof(Models.tbQuestion);
            // 
            // ContextTextBox
            // 
            ContextTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", tbQuestionBindingSource, "Context", true));
            ContextTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            ContextTextBox.Location = new System.Drawing.Point(28, 123);
            ContextTextBox.Name = "ContextTextBox";
            ContextTextBox.Size = new System.Drawing.Size(603, 118);
            ContextTextBox.TabIndex = 2;
            ContextTextBox.Text = "";
            // 
            // ContextLabel
            // 
            ContextLabel.AutoSize = true;
            ContextLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            ContextLabel.Location = new System.Drawing.Point(280, 99);
            ContextLabel.Name = "ContextLabel";
            ContextLabel.Size = new System.Drawing.Size(74, 21);
            ContextLabel.TabIndex = 3;
            ContextLabel.Text = "Контекст";
            // 
            // IsOpencheckBox
            // 
            IsOpencheckBox.AutoSize = true;
            IsOpencheckBox.CausesValidation = false;
            IsOpencheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", tbQuestionBindingSource, "IsOpen", true));
            IsOpencheckBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            IsOpencheckBox.Location = new System.Drawing.Point(280, 41);
            IsOpencheckBox.Name = "IsOpencheckBox";
            IsOpencheckBox.Size = new System.Drawing.Size(103, 25);
            IsOpencheckBox.TabIndex = 4;
            IsOpencheckBox.Text = "Октрытый";
            IsOpencheckBox.UseVisualStyleBackColor = true;
            // 
            // OptionsGridView
            // 
            OptionsGridView.AutoGenerateColumns = false;
            OptionsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            OptionsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            OptionsGridView.BackgroundColor = System.Drawing.Color.White;
            OptionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OptionsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colOptionId, colAnswer, colQuestionId, colVariant, colIsCorrect, colStatus, createUserDataGridViewTextBoxColumn, createDateDataGridViewTextBoxColumn, updateUserDataGridViewTextBoxColumn, updateDateDataGridViewTextBoxColumn });
            OptionsGridView.DataSource = tbOptionBindingSource;
            OptionsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            OptionsGridView.Location = new System.Drawing.Point(0, 282);
            OptionsGridView.MultiSelect = false;
            OptionsGridView.Name = "OptionsGridView";
            OptionsGridView.Size = new System.Drawing.Size(659, 385);
            OptionsGridView.TabIndex = 5;
            // 
            // colOptionId
            // 
            colOptionId.DataPropertyName = "Id";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            colOptionId.DefaultCellStyle = dataGridViewCellStyle1;
            colOptionId.HeaderText = "Id";
            colOptionId.Name = "colOptionId";
            colOptionId.ReadOnly = true;
            // 
            // colAnswer
            // 
            colAnswer.DataPropertyName = "Answer";
            colAnswer.HeaderText = "Ответ";
            colAnswer.Name = "colAnswer";
            // 
            // colQuestionId
            // 
            colQuestionId.DataPropertyName = "QuestionId";
            colQuestionId.HeaderText = "QuestionId";
            colQuestionId.Name = "colQuestionId";
            colQuestionId.Visible = false;
            // 
            // colVariant
            // 
            colVariant.DataPropertyName = "Variant";
            colVariant.HeaderText = "Вариант";
            colVariant.Name = "colVariant";
            // 
            // colIsCorrect
            // 
            colIsCorrect.DataPropertyName = "IsCorrect";
            colIsCorrect.FalseValue = "false";
            colIsCorrect.HeaderText = "Правильность";
            colIsCorrect.Name = "colIsCorrect";
            colIsCorrect.TrueValue = "true";
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.DataSource = spStatusBindingSource;
            colStatus.DisplayMember = "Name";
            colStatus.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            colStatus.HeaderText = "Статус";
            colStatus.Name = "colStatus";
            colStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            colStatus.ValueMember = "Id";
            // 
            // spStatusBindingSource
            // 
            spStatusBindingSource.DataSource = typeof(Models.spStatus);
            // 
            // createUserDataGridViewTextBoxColumn
            // 
            createUserDataGridViewTextBoxColumn.DataPropertyName = "CreateUser";
            createUserDataGridViewTextBoxColumn.HeaderText = "CreateUser";
            createUserDataGridViewTextBoxColumn.Name = "createUserDataGridViewTextBoxColumn";
            createUserDataGridViewTextBoxColumn.Visible = false;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            createDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            createDateDataGridViewTextBoxColumn.HeaderText = "Дата создания";
            createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            createDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updateUserDataGridViewTextBoxColumn
            // 
            updateUserDataGridViewTextBoxColumn.DataPropertyName = "UpdateUser";
            updateUserDataGridViewTextBoxColumn.HeaderText = "UpdateUser";
            updateUserDataGridViewTextBoxColumn.Name = "updateUserDataGridViewTextBoxColumn";
            updateUserDataGridViewTextBoxColumn.Visible = false;
            // 
            // updateDateDataGridViewTextBoxColumn
            // 
            updateDateDataGridViewTextBoxColumn.DataPropertyName = "UpdateDate";
            updateDateDataGridViewTextBoxColumn.HeaderText = "UpdateDate";
            updateDateDataGridViewTextBoxColumn.Name = "updateDateDataGridViewTextBoxColumn";
            updateDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // tbOptionBindingSource
            // 
            tbOptionBindingSource.DataSource = typeof(Models.tbOption);
            // 
            // SaveOptionsBtn
            // 
            SaveOptionsBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            SaveOptionsBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            SaveOptionsBtn.Location = new System.Drawing.Point(25, 247);
            SaveOptionsBtn.Name = "SaveOptionsBtn";
            SaveOptionsBtn.Size = new System.Drawing.Size(96, 29);
            SaveOptionsBtn.TabIndex = 7;
            SaveOptionsBtn.Text = "Сохранить";
            SaveOptionsBtn.UseVisualStyleBackColor = true;
            SaveOptionsBtn.Click += SaveOptionsBtn_Click;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            StatusLabel.Location = new System.Drawing.Point(421, 39);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new System.Drawing.Size(57, 21);
            StatusLabel.TabIndex = 8;
            StatusLabel.Text = "Статус";
            // 
            // StatusComboBox
            // 
            StatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", spStatusBindingSource, "Id", true));
            StatusComboBox.DataSource = spStatusBindingSource;
            StatusComboBox.DisplayMember = "Name";
            StatusComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new System.Drawing.Point(484, 41);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new System.Drawing.Size(147, 29);
            StatusComboBox.TabIndex = 9;
            StatusComboBox.ValueMember = "Id";
            // 
            // BackBtn
            // 
            BackBtn.BackColor = System.Drawing.SystemColors.Control;
            BackBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            BackBtn.ForeColor = System.Drawing.Color.Firebrick;
            BackBtn.Location = new System.Drawing.Point(127, 247);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new System.Drawing.Size(96, 29);
            BackBtn.TabIndex = 10;
            BackBtn.Text = "Отмена";
            BackBtn.UseVisualStyleBackColor = false;
            // 
            // FrmQuestion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(659, 667);
            Controls.Add(BackBtn);
            Controls.Add(StatusComboBox);
            Controls.Add(StatusLabel);
            Controls.Add(SaveOptionsBtn);
            Controls.Add(OptionsGridView);
            Controls.Add(IsOpencheckBox);
            Controls.Add(ContextLabel);
            Controls.Add(ContextTextBox);
            Controls.Add(DrugComboBox);
            Controls.Add(DrugLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmQuestion";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Вопрос";
            Load += FrmQuestion_Load;
            ((System.ComponentModel.ISupportInitialize)spDrugBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbQuestionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)OptionsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)spStatusBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbOptionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label DrugLabel;
        private System.Windows.Forms.ComboBox DrugComboBox;
        private System.Windows.Forms.RichTextBox ContextTextBox;
        private System.Windows.Forms.Label ContextLabel;
        private System.Windows.Forms.CheckBox IsOpencheckBox;
        private System.Windows.Forms.DataGridView OptionsGridView;
        private System.Windows.Forms.Button SaveOptionsBtn;
        private System.Windows.Forms.BindingSource tbOptionBindingSource;
        private System.Windows.Forms.BindingSource tbQuestionBindingSource;
        private System.Windows.Forms.BindingSource spStatusBindingSource;        
        private System.Windows.Forms.BindingSource spDrugBindingSource;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOptionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuestionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVariant;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsCorrect;
        private System.Windows.Forms.DataGridViewComboBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn createUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn;
    }
}