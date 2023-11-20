namespace PharmlineTestingSystem.AdminPanel
{
    partial class FrmEmployee
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
            label1 = new System.Windows.Forms.Label();
            FullNameTextBox = new System.Windows.Forms.TextBox();
            tbEmployeeBindingSource = new System.Windows.Forms.BindingSource(components);
            label2 = new System.Windows.Forms.Label();
            PasswTextBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            SaveBtn = new System.Windows.Forms.Button();
            CancelBtn = new System.Windows.Forms.Button();
            PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            label4 = new System.Windows.Forms.Label();
            StatusComboBox = new System.Windows.Forms.ComboBox();
            spStatusBindingSource = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)tbEmployeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spStatusBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(28, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Ф.И.О";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", tbEmployeeBindingSource, "FullName", true));
            FullNameTextBox.Location = new System.Drawing.Point(88, 23);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new System.Drawing.Size(182, 23);
            FullNameTextBox.TabIndex = 1;
            // 
            // tbEmployeeBindingSource
            // 
            tbEmployeeBindingSource.DataSource = typeof(Models.tbEmployee);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(28, 73);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Номер";
            // 
            // PasswTextBox
            // 
            PasswTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", tbEmployeeBindingSource, "Password", true));
            PasswTextBox.Location = new System.Drawing.Point(372, 23);
            PasswTextBox.Name = "PasswTextBox";
            PasswTextBox.Size = new System.Drawing.Size(137, 23);
            PasswTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(312, 26);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 15);
            label3.TabIndex = 4;
            label3.Text = "Пароль";
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            SaveBtn.Location = new System.Drawing.Point(344, 124);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new System.Drawing.Size(87, 23);
            SaveBtn.TabIndex = 6;
            SaveBtn.Text = "Сохранить";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            CancelBtn.ForeColor = System.Drawing.Color.Red;
            CancelBtn.Location = new System.Drawing.Point(437, 124);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new System.Drawing.Size(87, 23);
            CancelBtn.TabIndex = 7;
            CancelBtn.Text = "Отмена";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // PhoneMaskedTextBox
            // 
            PhoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", tbEmployeeBindingSource, "Phone", true));
            PhoneMaskedTextBox.Location = new System.Drawing.Point(88, 70);
            PhoneMaskedTextBox.Mask = "+(\\9\\98)-(00)-(000)-(00)-(00)";
            PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            PhoneMaskedTextBox.Size = new System.Drawing.Size(182, 23);
            PhoneMaskedTextBox.TabIndex = 8;
            PhoneMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(318, 70);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(43, 15);
            label4.TabIndex = 9;
            label4.Text = "Статус";
            // 
            // StatusComboBox
            // 
            StatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", tbEmployeeBindingSource, "Status", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            StatusComboBox.DataSource = spStatusBindingSource;
            StatusComboBox.DisplayMember = "Name";
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new System.Drawing.Point(372, 70);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new System.Drawing.Size(137, 23);
            StatusComboBox.TabIndex = 10;
            StatusComboBox.ValueMember = "Id";
            // 
            // spStatusBindingSource
            // 
            spStatusBindingSource.DataSource = typeof(Models.spStatus);
            // 
            // FrmEmployee
            // 
            AcceptButton = SaveBtn;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = CancelBtn;
            ClientSize = new System.Drawing.Size(536, 159);
            Controls.Add(StatusComboBox);
            Controls.Add(label4);
            Controls.Add(PhoneMaskedTextBox);
            Controls.Add(CancelBtn);
            Controls.Add(SaveBtn);
            Controls.Add(PasswTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(FullNameTextBox);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEmployee";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "FrmEmployee";
            Load += FrmEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)tbEmployeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)spStatusBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.BindingSource spStatusBindingSource;
        private System.Windows.Forms.BindingSource tbEmployeeBindingSource;
    }
}