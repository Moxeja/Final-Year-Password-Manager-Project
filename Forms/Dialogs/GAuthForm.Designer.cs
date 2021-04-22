
namespace Password_Manager_Program.Forms
{
    partial class GAuthForm
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
            this.PicQR = new System.Windows.Forms.PictureBox();
            this.LblSecret = new System.Windows.Forms.Label();
            this.TxtSecret = new System.Windows.Forms.TextBox();
            this.BtnRegen = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.LblAuthCode = new System.Windows.Forms.Label();
            this.TxtAuthCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicQR)).BeginInit();
            this.SuspendLayout();
            // 
            // PicQR
            // 
            this.PicQR.Location = new System.Drawing.Point(12, 12);
            this.PicQR.Name = "PicQR";
            this.PicQR.Size = new System.Drawing.Size(160, 160);
            this.PicQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicQR.TabIndex = 0;
            this.PicQR.TabStop = false;
            // 
            // LblSecret
            // 
            this.LblSecret.AutoSize = true;
            this.LblSecret.Location = new System.Drawing.Point(178, 12);
            this.LblSecret.Name = "LblSecret";
            this.LblSecret.Size = new System.Drawing.Size(340, 26);
            this.LblSecret.TabIndex = 0;
            this.LblSecret.Text = "Please input the secret code below into your Google Authenticator app\r\nor scan th" +
    "e QR code to the left:";
            // 
            // TxtSecret
            // 
            this.TxtSecret.Location = new System.Drawing.Point(181, 41);
            this.TxtSecret.Name = "TxtSecret";
            this.TxtSecret.ReadOnly = true;
            this.TxtSecret.Size = new System.Drawing.Size(340, 20);
            this.TxtSecret.TabIndex = 0;
            this.TxtSecret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnRegen
            // 
            this.BtnRegen.Location = new System.Drawing.Point(181, 109);
            this.BtnRegen.Name = "BtnRegen";
            this.BtnRegen.Size = new System.Drawing.Size(193, 63);
            this.BtnRegen.TabIndex = 2;
            this.BtnRegen.Text = "Regenerate Secret";
            this.BtnRegen.UseVisualStyleBackColor = true;
            this.BtnRegen.Click += new System.EventHandler(this.BtnRegen_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(380, 109);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(141, 63);
            this.BtnOK.TabIndex = 3;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // LblAuthCode
            // 
            this.LblAuthCode.AutoSize = true;
            this.LblAuthCode.Location = new System.Drawing.Point(178, 67);
            this.LblAuthCode.Name = "LblAuthCode";
            this.LblAuthCode.Size = new System.Drawing.Size(308, 13);
            this.LblAuthCode.TabIndex = 0;
            this.LblAuthCode.Text = "Please enter the 6 digit code from your authenticator app below:";
            // 
            // TxtAuthCode
            // 
            this.TxtAuthCode.Location = new System.Drawing.Point(181, 83);
            this.TxtAuthCode.Name = "TxtAuthCode";
            this.TxtAuthCode.Size = new System.Drawing.Size(340, 20);
            this.TxtAuthCode.TabIndex = 1;
            this.TxtAuthCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GAuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 181);
            this.Controls.Add(this.TxtAuthCode);
            this.Controls.Add(this.LblAuthCode);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.BtnRegen);
            this.Controls.Add(this.TxtSecret);
            this.Controls.Add(this.LblSecret);
            this.Controls.Add(this.PicQR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GAuthForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Google Authenticator";
            this.Load += new System.EventHandler(this.GAuthForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicQR;
        private System.Windows.Forms.Label LblSecret;
        private System.Windows.Forms.TextBox TxtSecret;
        private System.Windows.Forms.Button BtnRegen;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Label LblAuthCode;
        private System.Windows.Forms.TextBox TxtAuthCode;
    }
}