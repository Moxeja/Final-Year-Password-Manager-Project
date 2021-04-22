using Password_Manager_Program.Backend.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Password_Manager_Program.Backend.Data_Classes
{
    public class Storage
    {
        // Required information
        private List<Entry> _entries;
        private byte[] _protectedPassword;
        private readonly string _sessionFilepath;
        private byte[] _salt;
        public const int ITERATIONS = 15000;

        // Extra information
        public byte[] gAuthKey;

        // Public properties (read only)
        public int EntriesCount { get { return _entries.Count; } }
        public byte[] ProtectedPassword { get { return _protectedPassword; } }
        public string SessionPath { get { return _sessionFilepath; } }
        public byte[] Salt { get { return _salt; } }

        public Storage(byte[] password, string filepath)
        {
            // Initialise basic variables
            _entries = new List<Entry>();
            _sessionFilepath = filepath;

            // Generate new salt
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                _salt = new byte[16];
                rng.GetBytes(_salt);
            }

            // Password is already encrypted, so just store it
            _protectedPassword = password;
        }

        public Storage(byte[] password, byte[] salt, string filepath)
        {
            // Initialise basic variables
            _entries = new List<Entry>();
            _sessionFilepath = filepath;

            // Salt already generated for this storage so just use that
            _salt = salt;

            // Password is already encrypted, so just store it
            _protectedPassword = password;
        }

        public void AddEntry(Entry entry)
        {
            // Add entry to internal entries list
            _entries.Add(entry);
        }

        public void RemoveEntry(int index)
        {
            // Remove entry from interal entries list
            _entries.RemoveAt(index);
        }

        public Entry GetEntry(int index)
        {
            // Ensure index is valid
            if (index < 0 || index >= _entries.Count)
            {
                throw new ArgumentException("Index is out of range", nameof(index));
            }

            // Retrive and return the entry at specified index
            return _entries[index];
        }

        public bool ChangeMasterPassword(string oldPassword, string newPassword)
        {
            // Check the old password the user entered is correct first
            string currentPassword = PassProtect.UnProtectPassword(_protectedPassword);
            if (!currentPassword.Equals(oldPassword))
                return false;

            // Generate new protected password and salt
            byte[] newProtectedPassword = PassProtect.ProtectPassword(newPassword);
            byte[] newSalt = new byte[16];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(newSalt);
            }

            // Loop through entries and encrypt the passwords with new password
            List<Entry> newList = new List<Entry>();
            using (CryptoService csOld = new CryptoService(_salt, _protectedPassword, ITERATIONS))
            using (CryptoService csNew = new CryptoService(newSalt, newProtectedPassword, ITERATIONS))
            foreach (Entry entry in _entries)
            {
                string purpose = entry.Purpose;
                string username = entry.Username;
                string password = csNew.EncryptString(csOld.DecryptString(entry.Password));
                string comment = entry.Comment;

                newList.Add(new Entry(purpose, username, password, comment));
            }

            // Update storage variables to reflect new details
            _salt = newSalt;
            _protectedPassword = newProtectedPassword;
            _entries = newList;

            return true;
        }
    }
}
