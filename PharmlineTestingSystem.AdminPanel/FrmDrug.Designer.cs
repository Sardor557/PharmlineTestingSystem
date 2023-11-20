namespace PharmlineTestingSystem.AdminPanel
{
    partial class FrmDrug
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
            CancelBtn = new System.Windows.Forms.Button();
            SaveBtn = new System.Windows.Forms.Button();
            NameLabel = new System.Windows.Forms.Label();
            NameTextBox = new System.Windows.Forms.TextBox();
            spDrugBindingSource = new System.Windows.Forms.BindingSource(components);
            StatusLabel = new System.Windows.Forms.Label();
            StatusComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)spDrugBindingSource).BeginInit();
            SuspendLayout();
            // 
            // CancelBtn
            // 
            CancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            CancelBtn.ForeColor = System.Drawing.Color.Red;
            CancelBtn.Location = new System.Drawing.Point(339, 102);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new System.Drawing.Size(87, 23);
            CancelBtn.TabIndex = 9;
            CancelBtn.Text = "Отмена";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            SaveBtn.Location = new System.Drawing.Point(246, 102);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new System.Drawing.Size(87, 23);
            SaveBtn.TabIndex = 8;
            SaveBtn.Text = "Сохранить";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new System.Drawing.Point(12, 38);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new System.Drawing.Size(90, 15);
            NameLabel.TabIndex = 10;
            NameLabel.Text = "Наименование";
            // 
            // NameTextBox
            // 
            NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", spDrugBindingSource, "Name", true));
            NameTextBox.Location = new System.Drawing.Point(108, 35);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new System.Drawing.Size(136, 23);
            NameTextBox.TabIndex = 11;
            // 
            // spDrugBindingSource
            // 
            spDrugBindingSource.DataSource = typeof(Models.spDrug);
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new System.Drawing.Point(255, 39);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new System.Drawing.Size(43, 15);
            StatusLabel.TabIndex = 12;
            StatusLabel.Text = "Статус";
            // 
            // StatusComboBox
            // 
            StatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", spDrugBindingSource, "Status", true));
            StatusComboBox.DisplayMember = "Name";
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new System.Drawing.Point(304, 35);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new System.Drawing.Size(121, 23);
            StatusComboBox.TabIndex = 13;
            StatusComboBox.ValueMember = "Id";
            // 
            // FrmDrug
            // 
            AcceptButton = SaveBtn;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = CancelBtn;
            ClientSize = new System.Drawing.Size(441, 137);
            Controls.Add(StatusComboBox);
            Controls.Add(StatusLabel);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            Controls.Add(CancelBtn);
            Controls.Add(SaveBtn);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmDrug";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Препарат";
            Load += FrmDrug_Load;
            ((System.ComponentModel.ISupportInitialize)spDrugBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.BindingSource spDrugBindingSource;
    }
}