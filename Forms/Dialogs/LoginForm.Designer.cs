
namespace Password_Manager_Program.Forms
{
    partial class LoginForm
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
            this.LblMasterPass = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.ChkEnableGAuth = new System.Windows.Forms.CheckBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnTogglePassVis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblMasterPass
            // 
            this.LblMasterPass.AutoSize = true;
            this.LblMasterPass.Location = new System.Drawing.Point(12, 9);
            this.LblMasterPass.Name = "LblMasterPass";
            this.LblMasterPass.Size = new System.Drawing.Size(91, 13);
            this.LblMasterPass.TabIndex = 0;
            this.LblMasterPass.Text = "Master Password:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(109, 6);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(259, 20);
            this.TxtPassword.TabIndex = 0;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // ChkEnableGAuth
            // 
            this.ChkEnableGAuth.AutoSize = true;
            this.ChkEnableGAuth.Location = new System.Drawing.Point(155, 32);
            this.ChkEnableGAuth.Name = "ChkEnableGAuth";
            this.ChkEnableGAuth.Size = new System.Drawing.Size(213, 17);
            this.ChkEnableGAuth.TabIndex = 1;
            this.ChkEnableGAuth.Text = "Enable Google Authenticator Protection";
            this.ChkEnableGAuth.UseVisualStyleBackColor = true;
            this.ChkEnableGAuth.Visible = false;
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(12, 55);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(213, 41);
            this.BtnOK.TabIndex = 2;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(231, 55);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(137, 41);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnTogglePassVis
            // 
            this.BtnTogglePassVis.Location = new System.Drawing.Point(12, 28);
            this.BtnTogglePassVis.Name = "BtnTogglePassVis";
            this.BtnTogglePassVis.Size = new System.Drawing.Size(137, 23);
            this.BtnTogglePassVis.TabIndex = 4;
            this.BtnTogglePassVis.Text = "Toggle Password Visibility";
            this.BtnTogglePassVis.UseVisualStyleBackColor = true;
            this.BtnTogglePassVis.Click += new System.EventHandler(this.BtnTogglePassVis_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 106);
            this.Controls.Add(this.BtnTogglePassVis);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.ChkEnableGAuth);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblMasterPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMasterPass;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.CheckBox ChkEnableGAuth;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnTogglePassVis;
    }
}