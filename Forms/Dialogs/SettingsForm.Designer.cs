
namespace Password_Manager_Program.Forms.Dialogs
{
    partial class SettingsForm
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
            this.BtnMasterPass = new System.Windows.Forms.Button();
            this.BtnGoogleAuth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOldPass = new System.Windows.Forms.TextBox();
            this.TxtNewPass = new System.Windows.Forms.TextBox();
            this.TxtPin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtReNewPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnMasterPass
            // 
            this.BtnMasterPass.Location = new System.Drawing.Point(12, 88);
            this.BtnMasterPass.Name = "BtnMasterPass";
            this.BtnMasterPass.Size = new System.Drawing.Size(302, 32);
            this.BtnMasterPass.TabIndex = 0;
            this.BtnMasterPass.Text = "Change Master Password";
            this.BtnMasterPass.UseVisualStyleBackColor = true;
            this.BtnMasterPass.Click += new System.EventHandler(this.BtnMasterPass_Click);
            // 
            // BtnGoogleAuth
            // 
            this.BtnGoogleAuth.Location = new System.Drawing.Point(12, 152);
            this.BtnGoogleAuth.Name = "BtnGoogleAuth";
            this.BtnGoogleAuth.Size = new System.Drawing.Size(302, 42);
            this.BtnGoogleAuth.TabIndex = 1;
            this.BtnGoogleAuth.Text = "Add Google Authenticator Protection";
            this.BtnGoogleAuth.UseVisualStyleBackColor = true;
            this.BtnGoogleAuth.Click += new System.EventHandler(this.BtnGoogleAuth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Old Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Password:";
            // 
            // TxtOldPass
            // 
            this.TxtOldPass.Location = new System.Drawing.Point(99, 10);
            this.TxtOldPass.Name = "TxtOldPass";
            this.TxtOldPass.Size = new System.Drawing.Size(215, 20);
            this.TxtOldPass.TabIndex = 4;
            this.TxtOldPass.UseSystemPasswordChar = true;
            // 
            // TxtNewPass
            // 
            this.TxtNewPass.Location = new System.Drawing.Point(99, 36);
            this.TxtNewPass.Name = "TxtNewPass";
            this.TxtNewPass.Size = new System.Drawing.Size(215, 20);
            this.TxtNewPass.TabIndex = 5;
            this.TxtNewPass.UseSystemPasswordChar = true;
            // 
            // TxtPin
            // 
            this.TxtPin.Location = new System.Drawing.Point(111, 126);
            this.TxtPin.Name = "TxtPin";
            this.TxtPin.Size = new System.Drawing.Size(203, 20);
            this.TxtPin.TabIndex = 6;
            this.TxtPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current PIN Code:";
            // 
            // TxtReNewPass
            // 
            this.TxtReNewPass.Location = new System.Drawing.Point(140, 62);
            this.TxtReNewPass.Name = "TxtReNewPass";
            this.TxtReNewPass.Size = new System.Drawing.Size(174, 20);
            this.TxtReNewPass.TabIndex = 8;
            this.TxtReNewPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Retype New Password:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 204);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtReNewPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPin);
            this.Controls.Add(this.TxtNewPass);
            this.Controls.Add(this.TxtOldPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGoogleAuth);
            this.Controls.Add(this.BtnMasterPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMasterPass;
        private System.Windows.Forms.Button BtnGoogleAuth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOldPass;
        private System.Windows.Forms.TextBox TxtNewPass;
        private System.Windows.Forms.TextBox TxtPin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtReNewPass;
        private System.Windows.Forms.Label label4;
    }
}