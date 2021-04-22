using Password_Manager_Program.Backend.Crypto;
using Password_Manager_Program.Backend.Data_Classes;
using Password_Manager_Program.Backend.IO;
using Password_Manager_Program.Forms;
using Password_Manager_Program.Forms.Dialogs;
using System;
using System.IO;
using System.Windows.Forms;

namespace Password_Manager_Program
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SetLoggedOutUI()
        {
            // Context menu
            CmsMenu.Enabled = false;

            // Database buttons
            BtnSaveDB.Enabled = false;
            BtnCloseDB.Enabled = false;
            BtnSettings.Enabled = false;

            // Entry buttons
            BtnAddEntry.Enabled = false;
            BtnEditEntry.Enabled = false;
            BtnDeleteEntry.Enabled = false;

            // Search bar
            TxtSearch.Enabled = false;

            // Copying buttons
            BtnCopyUser.Enabled = false;
            BtnCopyPass.Enabled = false;
            BtnCopyComment.Enabled = false;

            // Entries list view
            LstEntries.Enabled = false;

            // Update title
            Text = "Password Manager - Logged Out";
        }

        private void SetLoggedInUI()
        {
            // Context menu
            CmsMenu.Enabled = true;

            // Database buttons
            BtnSaveDB.Enabled = false;
            BtnCloseDB.Enabled = true;
            BtnSettings.Enabled = true;

            // Entry buttons
            BtnAddEntry.Enabled = true;
            BtnEditEntry.Enabled = true;
            BtnDeleteEntry.Enabled = true;

            // Search bar
            TxtSearch.Enabled = true;

            // Copying buttons
            BtnCopyUser.Enabled = true;
            BtnCopyPass.Enabled = true;
            BtnCopyComment.Enabled = true;

            // Entries list view
            LstEntries.Enabled = true;

            // Update title
            Text = "Password Manager";
        }

        private void RefreshListView()
        {
            LstEntries.Items.Clear();
            for (int i = 0; i < (Program.storage?.EntriesCount ?? 0); i++)
            {
                // Retrieve entry object and create ListViewItem from it
                Entry currentEntry = Program.storage.GetEntry(i);
                if (!currentEntry.Purpose.StartsWith(TxtSearch.Text))
                    continue;

                ListViewItem item = new ListViewItem(currentEntry.Purpose);
                item.Tag = i;
                item.SubItems.Add(currentEntry.Username);
                item.SubItems.Add(currentEntry.Comment);

                // Add item to ListView control
                LstEntries.Items.Add(item);
            }
        }

        private void EntriesChanged()
        {
            Text = "Password Manager - Unsaved Changes!";
            BtnSaveDB.Enabled = true;
        }

        private void EntriesSaved()
        {
            Text = "Password Manager";
            BtnSaveDB.Enabled = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set the UI to logged out mode
            SetLoggedOutUI();
        }

        private void BtnClearClip_Click(object sender, EventArgs e)
        {
            // Remove all data from the system clipboard
            Clipboard.Clear();
        }

        private void BtnNewDB_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            using (LoginForm login = new LoginForm(true))
            {
                // Set file extension type to .vault
                sfd.Filter = "Password Vault (*.vault)|*.vault";

                // Ask user where they want to create the vault file
                if (sfd.ShowDialog() == DialogResult.OK
                    && login.ShowDialog() == DialogResult.OK)
                {
                    // Ask user for a master password and if they want
                    // Google Authentication protection
                    if (login.EnableGAuth)
                    {
                        using (GAuthForm gAuth = new GAuthForm(Path.GetFileName(sfd.FileName)))
                        {
                            if (gAuth.ShowDialog() == DialogResult.OK)
                            {
                                // Create new storage object with password and filepath
                                Program.storage = new Storage(login.Password, sfd.FileName);

                                // Enable Google Authenticator in storage object
                                Program.storage.gAuthKey = gAuth.Secret;

                                // Save to file
                                FileManager.SaveStorageToFile(Program.storage);

                                // Enable relevant UI controls and refresh controls
                                SetLoggedInUI();
                                RefreshListView();
                            }
                        }
                    }
                    else
                    {
                        // Create new storage object with password and filepath
                        Program.storage = new Storage(login.Password, sfd.FileName);

                        // Save to file
                        FileManager.SaveStorageToFile(Program.storage);

                        // Enable relevant UI controls and refresh controls
                        SetLoggedInUI();
                        RefreshListView();
                    }
                }
            }
        }

        private void BtnLoadDB_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            using (LoginForm login = new LoginForm(false))
            {
                // Set file extension type to .vault
                ofd.Filter = "Password Vault (*.vault)|*.vault";

                // Ask user which vault they want to open and their master password
                if (ofd.ShowDialog() == DialogResult.OK
                    && login.ShowDialog() == DialogResult.OK)
                {
                    Storage temp = FileManager.LoadStorageFromFile(ofd.FileName, login.Password);
                    if (temp != null)
                    {
                        if (temp.gAuthKey != null)
                        {
                            using (GAuthPinForm authCheck = new GAuthPinForm(temp.gAuthKey))
                            {
                                if (authCheck.ShowDialog() != DialogResult.OK)
                                    return;
                            }
                        }

                        // Move temp storage into main storage
                        Program.storage = temp;

                        // Enable relevant UI controls and refresh controls
                        SetLoggedInUI();
                        RefreshListView();
                    }
                    else
                    {
                        MessageBox.Show(this, "Failed to load vault file!\n" +
                            "Master password could have been wrong or the" +
                            " file integrity could be comprimised.", "Warning!");
                    }
                }
            }
        }

        private void BtnSaveDB_Click(object sender, EventArgs e)
        {
            try
            {
                // Save current database to disk
                FileManager.SaveStorageToFile(Program.storage);
                EntriesSaved();
            }
            catch
            {
                MessageBox.Show(this, "Failed to save database to file!", "Warning!");
            }
        }

        private void BtnCloseDB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,
                "Are you sure you want to close the database?",
                "Close database?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Program.storage = null;
                RefreshListView();
                SetLoggedOutUI();
            }
        }

        private void BtnAddEntry_Click(object sender, EventArgs e)
        {
            using (EntryForm entryForm = new EntryForm())
            {
                if (entryForm.ShowDialog() == DialogResult.OK)
                {
                    // Refresh and update UI accordingly
                    RefreshListView();
                    EntriesChanged();
                }
            }
        }

        private void BtnEditEntry_Click(object sender, EventArgs e)
        {
            // Make sure only 1 entry is selected
            if (LstEntries.SelectedItems == null || LstEntries.SelectedItems.Count != 1)
                return;

            using (EntryForm entryForm = new EntryForm(Convert.ToInt32(LstEntries.SelectedItems[0].Tag)))
            {
                if (entryForm.ShowDialog() == DialogResult.OK)
                {
                    // Refresh and update UI accordingly
                    RefreshListView();
                    EntriesChanged();
                }
            }
        }

        private void BtnDeleteEntry_Click(object sender, EventArgs e)
        {
            // Make sure only 1 entry is selected
            if (LstEntries.SelectedItems == null || LstEntries.SelectedItems.Count != 1)
                return;

            if (MessageBox.Show(this,
                "Are you sure you want to delete the selected entry:\n" +
                $"(\"{LstEntries.SelectedItems[0].Text}\")?",
                "Delete Entry?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                // Remove the selected entry from the storage object and refresh UI controls
                Program.storage.RemoveEntry(Convert.ToInt32(LstEntries.SelectedItems[0].Tag));
                EntriesChanged();
                RefreshListView();
            }
        }

        private void BtnCopyUser_Click(object sender, EventArgs e)
        {
            // Make sure only 1 entry is selected
            if (LstEntries.SelectedItems == null || LstEntries.SelectedItems.Count != 1)
                return;

            try
            {
                // Copy to clipboard
                DataObject data = new DataObject();
                data.SetData(DataFormats.UnicodeText, true,
                    Program.storage.GetEntry(Convert.ToInt32(LstEntries.SelectedItems[0].Tag)).Username);

                Clipboard.SetDataObject(data, true, 25, 100);
            }
            catch
            {
                MessageBox.Show(this, "Failed to copy username to clipboard!", "Warning!");
            }
        }

        private void BtnCopyPass_Click(object sender, EventArgs e)
        {
            // Make sure only 1 entry is selected
            if (LstEntries.SelectedItems == null || LstEntries.SelectedItems.Count != 1)
                return;

            try
            {
                // Create CryptoService for use with decrypting password
                using (CryptoService cs = new CryptoService(Program.storage.Salt,
                    Program.storage.ProtectedPassword, Storage.ITERATIONS))
                {
                    // Copy to clipboard
                    DataObject data = new DataObject();
                    data.SetData(DataFormats.UnicodeText, true,
                        cs.DecryptString(Program.storage.GetEntry(Convert.ToInt32(
                            LstEntries.SelectedItems[0].Tag)).Password));

                    Clipboard.SetDataObject(data, true, 25, 100);
                }
            }
            catch
            {
                MessageBox.Show(this, "Failed to copy password to clipboard!", "Warning!");
            }
        }

        private void BtnCopyComment_Click(object sender, EventArgs e)
        {
            // Make sure only 1 entry is selected
            if (LstEntries.SelectedItems == null || LstEntries.SelectedItems.Count != 1)
                return;

            try
            {
                // Copy to clipboard
                DataObject data = new DataObject();
                data.SetData(DataFormats.UnicodeText, true,
                    Program.storage.GetEntry(Convert.ToInt32(LstEntries.SelectedItems[0].Tag)).Comment);

                Clipboard.SetDataObject(data, true, 25, 100);
            }
            catch
            {
                MessageBox.Show(this, "Failed to copy comment to clipboard!", "Warning!");
            }
        }

        private void TsmEditEntry_Click(object sender, EventArgs e)
        {
            // Pass through to button event handler
            BtnEditEntry_Click(sender, e);
        }

        private void TsmCopyUser_Click(object sender, EventArgs e)
        {
            // Pass through to button event handler
            BtnCopyUser_Click(sender, e);
        }

        private void TsmCopyPass_Click(object sender, EventArgs e)
        {
            // Pass through to button event handler
            BtnCopyPass_Click(sender, e);
        }

        private void TsmCopyComment_Click(object sender, EventArgs e)
        {
            // Pass through to button event handler
            BtnCopyComment_Click(sender, e);
        }

        private void TsmDeleteEntry_Click(object sender, EventArgs e)
        {
            // Pass through to button event handler
            BtnDeleteEntry_Click(sender, e);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshListView();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            using (SettingsForm settings = new SettingsForm())
            {
                if (settings.ShowDialog() == DialogResult.OK)
                {
                    RefreshListView();
                    EntriesChanged();
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Warn user about any unsaved changes if any
            if (BtnSaveDB.Enabled)
            {
                if (MessageBox.Show(this, "Are you sure you want to discard unsaved changes?",
                    "Warning!", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    // Cancel the form closing
                    e.Cancel = true;
                }
            }
        }
    }
}
