using Password_Manager_Program.Backend.Crypto;
using Password_Manager_Program.Backend.Data_Classes;
using System;
using System.Windows.Forms;

namespace Password_Manager_Program.Forms
{
    public partial class EntryForm : Form
    {
        private readonly bool _editMode = false;
        private readonly int _loadedID = -1;

        public EntryForm()
        {
            InitializeComponent();
        }

        public EntryForm(int entryID): this()
        {
            _editMode = true;
            _loadedID = entryID;
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {
            if (_editMode)
            {
                // Create CryptoService object for use with decrypting password
                using (CryptoService cs = new CryptoService(Program.storage.Salt,
                    Program.storage.ProtectedPassword, Storage.ITERATIONS))
                {
                    // Retrieve entry object from storage
                    Entry temp = Program.storage.GetEntry(_loadedID);

                    // Populate form controls with information
                    TxtAccount.Text = temp.Purpose;
                    TxtUsername.Text = temp.Username;
                    TxtPassword.Text = cs.DecryptString(temp.Password);
                    TxtComment.Text = temp.Comment;
                }
            }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            // Generate a password based on the users preferences and assign value to text box
            TxtPassword.Text = PasswordGenerator.GeneratePassword(ChkUppercase.Checked,
                ChkNumbers.Checked, ChkSymbols.Checked, (int)NudLength.Value);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (_editMode)
            {
                Program.storage.RemoveEntry(_loadedID);
            }

            using (CryptoService cs = new CryptoService(Program.storage.Salt,
                Program.storage.ProtectedPassword, Storage.ITERATIONS))
            {
                string encryptedPass = cs.EncryptString(TxtPassword.Text);
                Program.storage.AddEntry(new Entry(TxtAccount.Text,
                    TxtUsername.Text, encryptedPass, TxtComment.Text));
            }
        }
    }
}
