using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

/// =====================================================
/// Author: Jake Moxey
/// Created: 20/02/2021
/// Last Modified: 20/02/2021
/// Description: This file provides configurable password
///              generation functionality.
/// =====================================================

namespace Password_Manager_Program.Backend.Crypto
{
    // Code adapted from: https://stackoverflow.com/a/1344255/11559130
    public static class PasswordGenerator
    {
        // Password generator character groups
        private static readonly string PASSWORD_CHARS_LCASE = "abcdefghijklmnopqrstuvwxyz";
        private static readonly string PASSWORD_CHARS_UCASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly string PASSWORD_CHARS_NUMERIC = "0123456789";
        private static readonly string PASSWORD_CHARS_SPECIAL = "!#$£%&()*+-/<>=_?@[]^{}~";

        /// <summary>
        /// Generates a password string according to selected charsets and length.
        /// </summary>
        /// <param name="useUppercase">Whether uppercase characters should be used for the generated password.</param>
        /// <param name="useNumbers">Whether numbers should be used for the generated password.</param>
        /// <param name="useSymbols">Whether symbols should be used for the generated password.</param>
        /// <param name="length">The length of the password in characters.</param>
        /// <returns>The generated password string.</returns>
        public static string GeneratePassword(bool useUppercase, bool useNumbers, bool useSymbols, int length)
        {
            // Holds the selected password characters
            List<char> selectedCharGroups = new List<char>();

            // Add character groups depending on user selection
            selectedCharGroups.AddRange(PASSWORD_CHARS_LCASE);
            if (useUppercase)
            {
                selectedCharGroups.AddRange(PASSWORD_CHARS_UCASE);
            }
            if (useNumbers)
            {
                selectedCharGroups.AddRange(PASSWORD_CHARS_NUMERIC);
            }
            if (useSymbols)
            {
                selectedCharGroups.AddRange(PASSWORD_CHARS_SPECIAL);
            }

            // Generate array of cryptographically secure bytes to be used as indexes later
            byte[] selection = new byte[length * 4];
            using (RNGCryptoServiceProvider csp = new RNGCryptoServiceProvider())
            {
                csp.GetBytes(selection);
            }

            // Generate password by indexing into character list
            // and appending result into StringBuilder object
            StringBuilder password = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                uint randomNumber = BitConverter.ToUInt32(selection, i * 4);
                int index = (int)(randomNumber % selectedCharGroups.Count);

                password.Append(selectedCharGroups[index]);
            }

            // Return generated password
            return password.ToString();
        }

    }
}
