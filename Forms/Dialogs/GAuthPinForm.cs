using Password_Manager_Program.Backend.GAuth;
using System;
using System.Windows.Forms;

namespace Password_Manager_Program.Forms.Dialogs
{
    public partial class GAuthPinForm : Form
    {
        private readonly byte[] _secret;

        public GAuthPinForm(byte[] secret)
        {
            InitializeComponent();
            _secret = secret;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            string userInput = TxtPin.Text.Trim().Replace(" ", "");
            if (GAuth.GeneratePin(_secret).Equals(userInput))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(this, "Incorrect PIN code was entered!\nPlease try again.", "Warning!");
            }
        }
    }
}
