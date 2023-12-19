namespace PharmlineTestingSystem.AdminPanel
{
    partial class FrmDrugList
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
            BackBtn = new RJControlls.RJButton();
            EditDrugBtn = new RJControlls.RJButton();
            AddDrugBtn = new RJControlls.RJButton();
            panel = new System.Windows.Forms.Panel();
            DrugsLabel = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            HeaderPanel = new System.Windows.Forms.Panel();
            DrugsGridView = new System.Windows.Forms.DataGridView();
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            createUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            updateUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            updateDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            spDrugBindingSource = new System.Windows.Forms.BindingSource(components);
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DrugsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spDrugBindingSource).BeginInit();
            SuspendLayout();
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
            // EditDrugBtn
            // 
            EditDrugBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            EditDrugBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            EditDrugBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            EditDrugBtn.BorderRadius = 10;
            EditDrugBtn.BorderSize = 0;
            EditDrugBtn.FlatAppearance.BorderSize = 0;
            EditDrugBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            EditDrugBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            EditDrugBtn.ForeColor = System.Drawing.Color.White;
            EditDrugBtn.Location = new System.Drawing.Point(159, 6);
            EditDrugBtn.Name = "EditDrugBtn";
            EditDrugBtn.Size = new System.Drawing.Size(150, 54);
            EditDrugBtn.TabIndex = 2;
            EditDrugBtn.Text = "Изменить препарат";
            EditDrugBtn.TextColor = System.Drawing.Color.White;
            EditDrugBtn.UseVisualStyleBackColor = false;
            EditDrugBtn.Click += EditDrugBtn_Click;
            // 
            // AddDrugBtn
            // 
            AddDrugBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            AddDrugBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            AddDrugBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            AddDrugBtn.BorderRadius = 10;
            AddDrugBtn.BorderSize = 0;
            AddDrugBtn.FlatAppearance.BorderSize = 0;
            AddDrugBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddDrugBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            AddDrugBtn.ForeColor = System.Drawing.Color.White;
            AddDrugBtn.Location = new System.Drawing.Point(3, 6);
            AddDrugBtn.Name = "AddDrugBtn";
            AddDrugBtn.Size = new System.Drawing.Size(150, 54);
            AddDrugBtn.TabIndex = 1;
            AddDrugBtn.Text = "Добавить препарат";
            AddDrugBtn.TextColor = System.Drawing.Color.White;
            AddDrugBtn.UseVisualStyleBackColor = false;
            AddDrugBtn.Click += AddDrugBtn_Click;
            // 
            // panel
            // 
            panel.BackColor = System.Drawing.Color.White;
            panel.Controls.Add(BackBtn);
            panel.Controls.Add(EditDrugBtn);
            panel.Controls.Add(AddDrugBtn);
            panel.Dock = System.Windows.Forms.DockStyle.Top;
            panel.Location = new System.Drawing.Point(0, 77);
            panel.Name = "panel";
            panel.Size = new System.Drawing.Size(539, 66);
            panel.TabIndex = 4;
            // 
            // DrugsLabel
            // 
            DrugsLabel.AutoSize = true;
            DrugsLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            DrugsLabel.Location = new System.Drawing.Point(247, 24);
            DrugsLabel.Name = "DrugsLabel";
            DrugsLabel.Size = new System.Drawing.Size(152, 28);
            DrugsLabel.TabIndex = 1;
            DrugsLabel.Text = "Препараты";
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
            // HeaderPanel
            // 
            HeaderPanel.BackColor = System.Drawing.Color.SlateBlue;
            HeaderPanel.Controls.Add(DrugsLabel);
            HeaderPanel.Controls.Add(pictureBox1);
            HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            HeaderPanel.Location = new System.Drawing.Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new System.Drawing.Size(539, 77);
            HeaderPanel.TabIndex = 3;
            // 
            // DrugsGridView
            // 
            DrugsGridView.AutoGenerateColumns = false;
            DrugsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            DrugsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            DrugsGridView.BackgroundColor = System.Drawing.Color.White;
            DrugsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DrugsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, colName, colStatus, createUserDataGridViewTextBoxColumn, createDateDataGridViewTextBoxColumn, updateUserDataGridViewTextBoxColumn, updateDateDataGridViewTextBoxColumn });
            DrugsGridView.DataSource = spDrugBindingSource;
            DrugsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            DrugsGridView.Location = new System.Drawing.Point(0, 143);
            DrugsGridView.MultiSelect = false;
            DrugsGridView.Name = "DrugsGridView";
            DrugsGridView.ReadOnly = true;
            DrugsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DrugsGridView.Size = new System.Drawing.Size(539, 569);
            DrugsGridView.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Наименование";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Visible = false;
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
            createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
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
            // FrmDrugList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = BackBtn;
            ClientSize = new System.Drawing.Size(539, 712);
            Controls.Add(DrugsGridView);
            Controls.Add(panel);
            Controls.Add(HeaderPanel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmDrugList";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Препараты";
            Load += FrmDrugList_Load;
            panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DrugsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)spDrugBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RJControlls.RJButton BackBtn;
        private RJControlls.RJButton EditDrugBtn;
        private RJControlls.RJButton AddDrugBtn;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label DrugsLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.DataGridView DrugsGridView;
        private System.Windows.Forms.BindingSource spDrugBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn createUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDateDataGridViewTextBoxColumn;
    }
}