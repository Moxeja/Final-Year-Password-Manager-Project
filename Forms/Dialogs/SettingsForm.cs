using Password_Manager_Program.Backend.GAuth;
using System;
using System.IO;
using System.Windows.Forms;

namespace Password_Manager_Program.Forms.Dialogs
{
    public partial class SettingsForm : Form
    {
        private readonly bool _gAuthEnabled = false;

        public SettingsForm()
        {
            InitializeComponent();

            // Check if Google Authenticator is enabled for current database
            _gAuthEnabled = (Program.storage.gAuthKey != null);

            // Change button text appropriately
            if (_gAuthEnabled)
            {
                BtnGoogleAuth.Text = "Remove Google Authenticator Protection";
            }
            else
            {
                TxtPin.Enabled = false;
            }
        }

        private void BtnMasterPass_Click(object sender, EventArgs e)
        {
            // Check the new master passwords match
            if (!TxtNewPass.Text.Equals(TxtReNewPass.Text))
            {
                MessageBox.Show(this, "Your new password and retyped new master password do not match!", "Warning!");
                return;
            }

            // Update master password and prompt user
            bool success = Program.storage.ChangeMasterPassword(TxtOldPass.Text, TxtNewPass.Text);
            MessageBox.Show(this, success ? "Master password has been successfully updated.\nMake sure to save your changes."
                : "Failed to update master password, please try again.", success ? "Success!" : "Warning!");

            // Update DialogResult to hint to MainForm that something has changed
            if (success)
                DialogResult = DialogResult.OK;
        }

        private void BtnGoogleAuth_Click(object sender, EventArgs e)
        {
            if (_gAuthEnabled)
            {
                // Before removing authenticator, check that they can input a correct PIN
                string userPin = TxtPin.Text.Trim().Replace(" ", "");
                string softPin = GAuth.GeneratePin(Program.storage.gAuthKey);
                if (!softPin.Equals(userPin))
                {
                    // PIN is incorrect
                    MessageBox.Show(this, "Entered PIN is incorrect, please try again.", "Warning!");
                    return;
                }

                // PIN entered was correct, so remove GAuth data from storage object
                Program.storage.gAuthKey = null;

                // Inform user that Google Authenticator has been disabled
                MessageBox.Show(this, "Google Authenticator has been disabled for the current database.\n" +
                    "Please remember to save these changes to file.", "Success!");

                // Show success DialogResult
                DialogResult = DialogResult.OK;
            }
            else
            {
                using (GAuthForm gAuth = new GAuthForm(Path.GetFileName(Program.storage.SessionPath)))
                {
                    if (gAuth.ShowDialog() == DialogResult.OK)
                    {
                        // Enable Google Authenticator in storage object
                        Program.storage.gAuthKey = gAuth.Secret;

                        // Inform the user that Google Authenticator has been enabled
                        MessageBox.Show(this, "Google Authenticator has been enabled for the current database.\n" +
                            "Please remember to save these changes to file.", "Success!");

                        // Show success DialogResult
                        DialogResult = DialogResult.OK;
                    }
                }
            }
        }
    }
}
