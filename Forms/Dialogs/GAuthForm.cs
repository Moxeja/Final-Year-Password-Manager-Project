using Password_Manager_Program.Backend.GAuth;
using QRCoder;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Password_Manager_Program.Forms
{
    public partial class GAuthForm : Form
    {
        private byte[] _secret;
        private readonly string _filename;

        public byte[] Secret { get { return _secret; } }

        public GAuthForm(string filename)
        {
            InitializeComponent();
            _filename = filename;
        }

        private void GenerateSecret()
        {
            // Generate a new secret
            _secret = new byte[10];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(_secret);
            }

            // Output textual representation of the secret
            string secretString = Encoder32.Base32Encode(_secret);
            TxtSecret.Text = secretString;

            // Output QRCode representation of the secret
            string qrCodeAuthString = $"otpauth://totp/Password%20Manager:{_filename}?secret={secretString}&issuer=Password%20Manager";
            QRCodeData qrCodeData = new QRCodeGenerator().CreateQrCode(qrCodeAuthString, QRCodeGenerator.ECCLevel.Q);
            PicQR.Image = new QRCode(qrCodeData).GetGraphic(5);
        }

        private void GAuthForm_Load(object sender, EventArgs e)
        {
            GenerateSecret();
        }

        private void BtnRegen_Click(object sender, EventArgs e)
        {
            GenerateSecret();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            // Generate current PIN and check if it matches what the user entered
            string pinToMatch = GAuth.GeneratePin(_secret);
            if (pinToMatch.Equals(TxtAuthCode.Text.Trim().Replace(" ", "")))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(this, "Entered pin is incorrect, " +
                    "please recreate your entry in Google Authenticator and try again.", "Warning!");
            }
        }
    }
}
