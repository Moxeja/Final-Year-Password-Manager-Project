using System.Security.Cryptography;
using System.Text;

/// ===================================================
/// Author: Jake Moxey
/// Created: 31/03/2021
/// Last Modified: 31/03/2021
/// Description: This file provides password encryption
///              and decryption functionality.
/// ===================================================

namespace Password_Manager_Program.Backend.Crypto
{
    public static class PassProtect
    {
        // Internal variables
        private static readonly byte[] _entropy;

        static PassProtect()
        {
            // Generate entropy for use with Microsoft's protect API
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                _entropy = new byte[20];
                rng.GetBytes(_entropy);
            }
        }

        /// <summary>
        /// Encrypts a password using Microsoft's data protection API.
        /// </summary>
        /// <param name="password">The password to encrypt.</param>
        /// <returns>The encrypted password as a byte array.</returns>
        public static byte[] ProtectPassword(string password)
        {
            // Convert the password into bytes
            byte[] data = Encoding.UTF8.GetBytes(password);

            // Encrypt password and return result
            return ProtectedData.Protect(data, _entropy, DataProtectionScope.CurrentUser);
        }

        /// <summary>
        /// Decrypts a password that was encrypted using Microsoft's data protection API.
        /// </summary>
        /// <param name="protectedPassword">The protected password byte array.</param>
        /// <returns>The decrypted password string.</returns>
        public static string UnProtectPassword(byte[] protectedPassword)
        {
            // Decrypt the password
            byte[] data = ProtectedData.Unprotect(protectedPassword, _entropy, DataProtectionScope.CurrentUser);

            // Convert password back into a string
            return Encoding.UTF8.GetString(data);
        }
    }
}
