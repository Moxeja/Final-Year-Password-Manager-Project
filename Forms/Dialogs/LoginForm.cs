using Password_Manager_Program.Backend.Crypto;
using System.Windows.Forms;

namespace Password_Manager_Program.Forms
{
    public partial class LoginForm : Form
    {
        public bool EnableGAuth
        {
            get { return ChkEnableGAuth.Checked; }
        }

        public byte[] Password
        {
            get
            {
                return PassProtect.ProtectPassword(TxtPassword.Text);
            }
        }

        private LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(bool creatingAccount) : this()
        {
            if (creatingAccount)
            {
                Text = "Create Account";
                ChkEnableGAuth.Visible = true;
            }
        }

        private void BtnTogglePassVis_Click(object sender, System.EventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = !TxtPassword.UseSystemPasswordChar;
        }
    }
}
