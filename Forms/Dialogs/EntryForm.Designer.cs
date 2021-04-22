
namespace Password_Manager_Program.Forms
{
    partial class EntryForm
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
            this.GrpEntryDetails = new System.Windows.Forms.GroupBox();
            this.TxtAccount = new System.Windows.Forms.TextBox();
            this.LblAccount = new System.Windows.Forms.Label();
            this.LblComment = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.TxtComment = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.GrpPassSettings = new System.Windows.Forms.GroupBox();
            this.NudLength = new System.Windows.Forms.NumericUpDown();
            this.LblLength = new System.Windows.Forms.Label();
            this.ChkSymbols = new System.Windows.Forms.CheckBox();
            this.ChkNumbers = new System.Windows.Forms.CheckBox();
            this.ChkUppercase = new System.Windows.Forms.CheckBox();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.GrpEntryDetails.SuspendLayout();
            this.GrpPassSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudLength)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpEntryDetails
            // 
            this.GrpEntryDetails.Controls.Add(this.TxtAccount);
            this.GrpEntryDetails.Controls.Add(this.LblAccount);
            this.GrpEntryDetails.Controls.Add(this.LblComment);
            this.GrpEntryDetails.Controls.Add(this.LblPassword);
            this.GrpEntryDetails.Controls.Add(this.LblUsername);
            this.GrpEntryDetails.Controls.Add(this.TxtComment);
            this.GrpEntryDetails.Controls.Add(this.TxtPassword);
            this.GrpEntryDetails.Controls.Add(this.TxtUsername);
            this.GrpEntryDetails.Location = new System.Drawing.Point(12, 12);
            this.GrpEntryDetails.Name = "GrpEntryDetails";
            this.GrpEntryDetails.Size = new System.Drawing.Size(366, 213);
            this.GrpEntryDetails.TabIndex = 0;
            this.GrpEntryDetails.TabStop = false;
            this.GrpEntryDetails.Text = "Entry Details";
            // 
            // TxtAccount
            // 
            this.TxtAccount.Location = new System.Drawing.Point(68, 19);
            this.TxtAccount.Name = "TxtAccount";
            this.TxtAccount.Size = new System.Drawing.Size(292, 20);
            this.TxtAccount.TabIndex = 0;
            // 
            // LblAccount
            // 
            this.LblAccount.AutoSize = true;
            this.LblAccount.Location = new System.Drawing.Point(6, 22);
            this.LblAccount.Name = "LblAccount";
            this.LblAccount.Size = new System.Drawing.Size(50, 13);
            this.LblAccount.TabIndex = 0;
            this.LblAccount.Text = "Account:";
            // 
            // LblComment
            // 
            this.LblComment.AutoSize = true;
            this.LblComment.Location = new System.Drawing.Point(6, 144);
            this.LblComment.Name = "LblComment";
            this.LblComment.Size = new System.Drawing.Size(54, 13);
            this.LblComment.TabIndex = 0;
            this.LblComment.Text = "Comment:";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(6, 74);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(56, 13);
            this.LblPassword.TabIndex = 0;
            this.LblPassword.Text = "Password:";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(6, 48);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(88, 13);
            this.LblUsername.TabIndex = 0;
            this.LblUsername.Text = "Username/Email:";
            // 
            // TxtComment
            // 
            this.TxtComment.Location = new System.Drawing.Point(68, 141);
            this.TxtComment.Multiline = true;
            this.TxtComment.Name = "TxtComment";
            this.TxtComment.Size = new System.Drawing.Size(292, 64);
            this.TxtComment.TabIndex = 3;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(68, 71);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(292, 64);
            this.TxtPassword.TabIndex = 2;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(100, 45);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(260, 20);
            this.TxtUsername.TabIndex = 1;
            // 
            // GrpPassSettings
            // 
            this.GrpPassSettings.Controls.Add(this.NudLength);
            this.GrpPassSettings.Controls.Add(this.LblLength);
            this.GrpPassSettings.Controls.Add(this.ChkSymbols);
            this.GrpPassSettings.Controls.Add(this.ChkNumbers);
            this.GrpPassSettings.Controls.Add(this.ChkUppercase);
            this.GrpPassSettings.Location = new System.Drawing.Point(384, 12);
            this.GrpPassSettings.Name = "GrpPassSettings";
            this.GrpPassSettings.Size = new System.Drawing.Size(166, 141);
            this.GrpPassSettings.TabIndex = 0;
            this.GrpPassSettings.TabStop = false;
            this.GrpPassSettings.Text = "Password Generation Settings";
            // 
            // NudLength
            // 
            this.NudLength.Location = new System.Drawing.Point(9, 111);
            this.NudLength.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NudLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudLength.Name = "NudLength";
            this.NudLength.Size = new System.Drawing.Size(120, 20);
            this.NudLength.TabIndex = 7;
            this.NudLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudLength.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // LblLength
            // 
            this.LblLength.AutoSize = true;
            this.LblLength.Location = new System.Drawing.Point(6, 95);
            this.LblLength.Name = "LblLength";
            this.LblLength.Size = new System.Drawing.Size(103, 13);
            this.LblLength.TabIndex = 0;
            this.LblLength.Text = "Length (Characters):";
            // 
            // ChkSymbols
            // 
            this.ChkSymbols.AutoSize = true;
            this.ChkSymbols.Checked = true;
            this.ChkSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkSymbols.Location = new System.Drawing.Point(6, 67);
            this.ChkSymbols.Name = "ChkSymbols";
            this.ChkSymbols.Size = new System.Drawing.Size(65, 17);
            this.ChkSymbols.TabIndex = 6;
            this.ChkSymbols.Text = "Symbols";
            this.ChkSymbols.UseVisualStyleBackColor = true;
            // 
            // ChkNumbers
            // 
            this.ChkNumbers.AutoSize = true;
            this.ChkNumbers.Checked = true;
            this.ChkNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkNumbers.Location = new System.Drawing.Point(6, 44);
            this.ChkNumbers.Name = "ChkNumbers";
            this.ChkNumbers.Size = new System.Drawing.Size(68, 17);
            this.ChkNumbers.TabIndex = 5;
            this.ChkNumbers.Text = "Numbers";
            this.ChkNumbers.UseVisualStyleBackColor = true;
            // 
            // ChkUppercase
            // 
            this.ChkUppercase.AutoSize = true;
            this.ChkUppercase.Checked = true;
            this.ChkUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkUppercase.Location = new System.Drawing.Point(6, 21);
            this.ChkUppercase.Name = "ChkUppercase";
            this.ChkUppercase.Size = new System.Drawing.Size(113, 17);
            this.ChkUppercase.TabIndex = 4;
            this.ChkUppercase.Text = "Uppercase Letters";
            this.ChkUppercase.UseVisualStyleBackColor = true;
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(383, 159);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(168, 66);
            this.BtnGenerate.TabIndex = 8;
            this.BtnGenerate.Text = "Generate Password";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(11, 231);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(540, 46);
            this.BtnOK.TabIndex = 9;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 287);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.GrpPassSettings);
            this.Controls.Add(this.GrpEntryDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntryForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entry Window";
            this.Load += new System.EventHandler(this.EntryForm_Load);
            this.GrpEntryDetails.ResumeLayout(false);
            this.GrpEntryDetails.PerformLayout();
            this.GrpPassSettings.ResumeLayout(false);
            this.GrpPassSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpEntryDetails;
        private System.Windows.Forms.Label LblComment;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.TextBox TxtComment;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.GroupBox GrpPassSettings;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.NumericUpDown NudLength;
        private System.Windows.Forms.Label LblLength;
        private System.Windows.Forms.CheckBox ChkSymbols;
        private System.Windows.Forms.CheckBox ChkNumbers;
        private System.Windows.Forms.CheckBox ChkUppercase;
        private System.Windows.Forms.TextBox TxtAccount;
        private System.Windows.Forms.Label LblAccount;
    }
}