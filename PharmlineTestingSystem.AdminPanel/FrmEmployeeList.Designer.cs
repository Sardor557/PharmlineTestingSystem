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
            BackBtn = new RJControlls.RJButton();
            EditEmployeeBtn = new RJControlls.RJButton();
            AddEmployeeBtn = new RJControlls.RJButton();
            tbEmployeeBindingSource = new System.Windows.Forms.BindingSource(components);
            EmployeeGridView = new System.Windows.Forms.DataGridView();
            colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTelegramId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCreateUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            updateUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            updateDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel.SuspendLayout();
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
            panel.Controls.Add(BackBtn);
            panel.Controls.Add(EditEmployeeBtn);
            panel.Controls.Add(AddEmployeeBtn);
            panel.Dock = System.Windows.Forms.DockStyle.Top;
            panel.Location = new System.Drawing.Point(0, 77);
            panel.Name = "panel";
            panel.Size = new System.Drawing.Size(547, 66);
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
            BackBtn.Location = new System.Drawing.Point(411, 6);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new System.Drawing.Size(124, 54);
            BackBtn.TabIndex = 3;
            BackBtn.Text = "⬅️ Назад";
            BackBtn.TextColor = System.Drawing.Color.White;
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
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
            EditEmployeeBtn.Location = new System.Drawing.Point(159, 6);
            EditEmployeeBtn.Name = "EditEmployeeBtn";
            EditEmployeeBtn.Size = new System.Drawing.Size(150, 54);
            EditEmployeeBtn.TabIndex = 2;
            EditEmployeeBtn.Text = "Изменить сотрудника";
            EditEmployeeBtn.TextColor = System.Drawing.Color.White;
            EditEmployeeBtn.UseVisualStyleBackColor = false;
            EditEmployeeBtn.Click += EditEmployeeBtn_Click;
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
            EmployeeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colId, colFullName, colPhone, colTelegramId, colPassword, colStatus, colCreateUser, colCreateDate, updateUserDataGridViewTextBoxColumn, updateDateDataGridViewTextBoxColumn });
            EmployeeGridView.DataSource = tbEmployeeBindingSource;
            EmployeeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            EmployeeGridView.Location = new System.Drawing.Point(0, 143);
            EmployeeGridView.MultiSelect = false;
            EmployeeGridView.Name = "EmployeeGridView";
            EmployeeGridView.ReadOnly = true;
            EmployeeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            EmployeeGridView.Size = new System.Drawing.Size(547, 569);
            EmployeeGridView.TabIndex = 2;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colFullName
            // 
            colFullName.DataPropertyName = "FullName";
            colFullName.HeaderText = "Ф.И.О";
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "Номер";
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colTelegramId
            // 
            colTelegramId.DataPropertyName = "TelegramId";
            colTelegramId.HeaderText = "TelegramId";
            colTelegramId.Name = "colTelegramId";
            colTelegramId.ReadOnly = true;
            colTelegramId.Visible = false;
            // 
            // colPassword
            // 
            colPassword.DataPropertyName = "Password";
            colPassword.HeaderText = "Password";
            colPassword.Name = "colPassword";
            colPassword.ReadOnly = true;
            colPassword.Visible = false;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Visible = false;
            // 
            // colCreateUser
            // 
            colCreateUser.DataPropertyName = "CreateUser";
            colCreateUser.HeaderText = "CreateUser";
            colCreateUser.Name = "colCreateUser";
            colCreateUser.ReadOnly = true;
            colCreateUser.Visible = false;
            // 
            // colCreateDate
            // 
            colCreateDate.DataPropertyName = "CreateDate";
            colCreateDate.HeaderText = "Дата создания";
            colCreateDate.Name = "colCreateDate";
            colCreateDate.ReadOnly = true;
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
            CancelButton = BackBtn;
            ClientSize = new System.Drawing.Size(547, 712);
            Controls.Add(EmployeeGridView);
            Controls.Add(panel);
            Controls.Add(HeaderPanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEmployeeList";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Сотрудники";
            Load += FrmEmployeeList_Load;
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn variantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCorrectDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn drugIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isOpenDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource tbEmployeeBindingSource;
        private System.Windows.Forms.DataGridView EmployeeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelegramId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn;
        private RJControlls.RJButton BackBtn;
    }
}