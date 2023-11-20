namespace PharmlineTestingSystem.AdminPanel
{
    partial class FrmEmployeeList
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
            EmployeesLabel = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel = new System.Windows.Forms.Panel();
            EditEmployeeBtn = new RJControlls.RJButton();
            AddEmployeeBtn = new RJControlls.RJButton();
            spDrugBindingSource = new System.Windows.Forms.BindingSource(components);
            tbQuestionBindingSource = new System.Windows.Forms.BindingSource(components);
            tbOptionBindingSource = new System.Windows.Forms.BindingSource(components);
            tbEmployeeBindingSource = new System.Windows.Forms.BindingSource(components);
            EmployeeGridView = new System.Windows.Forms.DataGridView();
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            telegramIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            createUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            updateUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            updateDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spDrugBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbQuestionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbOptionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbEmployeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeGridView).BeginInit();
            SuspendLayout();
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = System.Drawing.Color.SlateBlue;
            HeaderPanel.Controls.Add(EmployeesLabel);
            HeaderPanel.Controls.Add(pictureBox1);
            HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            HeaderPanel.Location = new System.Drawing.Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new System.Drawing.Size(547, 77);
            HeaderPanel.TabIndex = 0;
            // 
            // EmployeesLabel
            // 
            EmployeesLabel.AutoSize = true;
            EmployeesLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            EmployeesLabel.Location = new System.Drawing.Point(247, 24);
            EmployeesLabel.Name = "EmployeesLabel";
            EmployeesLabel.Size = new System.Drawing.Size(160, 28);
            EmployeesLabel.TabIndex = 1;
            EmployeesLabel.Text = "Сотрудники";
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
            panel.Controls.Add(EditEmployeeBtn);
            panel.Controls.Add(AddEmployeeBtn);
            panel.Dock = System.Windows.Forms.DockStyle.Top;
            panel.Location = new System.Drawing.Point(0, 77);
            panel.Name = "panel";
            panel.Size = new System.Drawing.Size(547, 66);
            panel.TabIndex = 1;
            // 
            // EditEmployeeBtn
            // 
            EditEmployeeBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            EditEmployeeBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            EditEmployeeBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            EditEmployeeBtn.BorderRadius = 10;
            EditEmployeeBtn.BorderSize = 0;
            EditEmployeeBtn.FlatAppearance.BorderSize = 0;
            EditEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            EditEmployeeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            EditEmployeeBtn.ForeColor = System.Drawing.Color.White;
            EditEmployeeBtn.Location = new System.Drawing.Point(174, 6);
            EditEmployeeBtn.Name = "EditEmployeeBtn";
            EditEmployeeBtn.Size = new System.Drawing.Size(150, 54);
            EditEmployeeBtn.TabIndex = 2;
            EditEmployeeBtn.Text = "Изменить сотрудника";
            EditEmployeeBtn.TextColor = System.Drawing.Color.White;
            EditEmployeeBtn.UseVisualStyleBackColor = false;
            // 
            // AddEmployeeBtn
            // 
            AddEmployeeBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            AddEmployeeBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            AddEmployeeBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            AddEmployeeBtn.BorderRadius = 10;
            AddEmployeeBtn.BorderSize = 0;
            AddEmployeeBtn.FlatAppearance.BorderSize = 0;
            AddEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddEmployeeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            AddEmployeeBtn.ForeColor = System.Drawing.Color.White;
            AddEmployeeBtn.Location = new System.Drawing.Point(3, 6);
            AddEmployeeBtn.Name = "AddEmployeeBtn";
            AddEmployeeBtn.Size = new System.Drawing.Size(150, 54);
            AddEmployeeBtn.TabIndex = 1;
            AddEmployeeBtn.Text = "Добавить сотрудника";
            AddEmployeeBtn.TextColor = System.Drawing.Color.White;
            AddEmployeeBtn.UseVisualStyleBackColor = false;
            AddEmployeeBtn.Click += AddEmployeeBtn_Click;
            // 
            // spDrugBindingSource
            // 
            spDrugBindingSource.DataSource = typeof(Models.spDrug);
            // 
            // tbQuestionBindingSource
            // 
            tbQuestionBindingSource.DataSource = typeof(Models.tbQuestion);
            // 
            // tbOptionBindingSource
            // 
            tbOptionBindingSource.DataSource = typeof(Models.tbOption);
            // 
            // tbEmployeeBindingSource
            // 
            tbEmployeeBindingSource.DataSource = typeof(Models.tbEmployee);
            // 
            // EmployeeGridView
            // 
            EmployeeGridView.AutoGenerateColumns = false;
            EmployeeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            EmployeeGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            EmployeeGridView.BackgroundColor = System.Drawing.Color.White;
            EmployeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, telegramIdDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, createUserDataGridViewTextBoxColumn, createDateDataGridViewTextBoxColumn, updateUserDataGridViewTextBoxColumn, updateDateDataGridViewTextBoxColumn });
            EmployeeGridView.DataSource = tbEmployeeBindingSource;
            EmployeeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            EmployeeGridView.Location = new System.Drawing.Point(0, 143);
            EmployeeGridView.Name = "EmployeeGridView";
            EmployeeGridView.ReadOnly = true;
            EmployeeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            EmployeeGridView.Size = new System.Drawing.Size(547, 395);
            EmployeeGridView.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "colFullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "Ф.И.О";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "colPhone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telegramIdDataGridViewTextBoxColumn
            // 
            telegramIdDataGridViewTextBoxColumn.DataPropertyName = "TelegramId";
            telegramIdDataGridViewTextBoxColumn.HeaderText = "TelegramId";
            telegramIdDataGridViewTextBoxColumn.Name = "telegramIdDataGridViewTextBoxColumn";
            telegramIdDataGridViewTextBoxColumn.ReadOnly = true;
            telegramIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            passwordDataGridViewTextBoxColumn.Visible = false;
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
            createDateDataGridViewTextBoxColumn.HeaderText = "Дата Создания";
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
            // FrmEmployeeList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(547, 538);
            Controls.Add(EmployeeGridView);
            Controls.Add(panel);
            Controls.Add(HeaderPanel);
            Name = "FrmEmployeeList";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Вопросы";
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spDrugBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbQuestionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbOptionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbEmployeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJControlls.RJButton AddEmployeeBtn;
        private System.Windows.Forms.Label EmployeesLabel;
        private RJControlls.RJButton EditEmployeeBtn;
        private System.Windows.Forms.BindingSource tbOptionBindingSource;
        private System.Windows.Forms.BindingSource tbQuestionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn variantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCorrectDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn drugIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spDrugBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isOpenDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource tbEmployeeBindingSource;
        private System.Windows.Forms.DataGridView EmployeeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telegramIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn;
    }
}