using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Password_Manager_Program.Backend.Crypto
{
    public sealed class CryptoService : IDisposable
    {
        // Default cipher values
        private static readonly byte[] _defaultKey =
        {
            0x58, 0x67, 0xA0, 0x90, 0x08, 0x30, 0x60, 0x26,
            0x85, 0x0B, 0x0A, 0x2F, 0x38, 0x57, 0xDC, 0x92,
            0xE3, 0x5A, 0xFE, 0x2B, 0x98, 0xFE, 0x46, 0xB6,
            0x57, 0x25, 0xB7, 0x0B, 0x5E, 0xA2, 0xCC, 0x41
        };
        private static readonly byte[] _defaultIV =
        {
            0x54, 0x21, 0x32, 0x5C, 0xCA, 0xD0, 0xF2, 0x0A,
            0xA5, 0x9E, 0x33, 0xFF, 0xF2, 0x71, 0x71, 0x5A
        };

        // Cryptographic objects
        private readonly SymmetricAlgorithm _algorithm;
        private Rfc2898DeriveBytes _rfckdf;

        public CryptoService()
        {
            // Create a usable default crypto algorithm
            _algorithm = Aes.Create();
            _algorithm.Mode = CipherMode.CBC;
            _algorithm.KeySize = 256;
            _algorithm.BlockSize = 128;
            _algorithm.Key = _defaultKey;
            _algorithm.IV = _defaultIV;
            _algorithm.Padding = PaddingMode.PKCS7;
        }

        public CryptoService(byte[] salt, byte[] password, int iterations)
        {
            // Create RFC PBKDF2
            SetupRFC(salt, password, iterations);

            // Create a usable crypto algorithm
            _algorithm = Aes.Create();
            _algorithm.Mode = CipherMode.CBC;
            _algorithm.KeySize = 256;
            _algorithm.BlockSize = 128;
            _algorithm.Key = _rfckdf.GetBytes(_algorithm.KeySize / 8);
            _algorithm.IV = _rfckdf.GetBytes(_algorithm.BlockSize / 8);
            _algorithm.Padding = PaddingMode.PKCS7;

            // Clear up RFC PBKDF2
            _rfckdf.Dispose();
        }

        public void Dispose()
        {
            // Cleanup
            _rfckdf?.Dispose();
            _algorithm?.Dispose();
        }

        private void SetupRFC(byte[] salt, byte[] password, int iterations)
        {
            // Decrypt password
            string plaintext = PassProtect.UnProtectPassword(password);

            // Setup RFC PBKDF2 for use
            _rfckdf = new Rfc2898DeriveBytes(plaintext, salt, iterations, HashAlgorithmName.SHA512);
        }

        public byte[] EncryptByteArray(byte[] plainArray)
        {
            using (ICryptoTransform ct = _algorithm.CreateEncryptor())
            using (MemoryStream ms = new MemoryStream())
            using (CryptoStream cs = new CryptoStream(ms, ct, CryptoStreamMode.Write))
            {
                cs.Write(plainArray, 0, plainArray.Length);
                cs.FlushFinalBlock();
                return ms.ToArray();
            }
        }

        public byte[] DecryptByteArray(byte[] cipherArray)
        {
            using (ICryptoTransform ct = _algorithm.CreateDecryptor())
            using (MemoryStream ms = new MemoryStream())
            using (CryptoStream cs = new CryptoStream(ms, ct, CryptoStreamMode.Write))
            {
                cs.Write(cipherArray, 0, cipherArray.Length);
                cs.FlushFinalBlock();
                return ms.ToArray();
            }
        }

        public string EncryptString(string plaintext)
        {
            return Convert.ToBase64String(EncryptByteArray(Encoding.UTF8.GetBytes(plaintext)));
        }

        public string DecryptString(string ciphertext)
        {
            return Encoding.UTF8.GetString(DecryptByteArray(Convert.FromBase64String(ciphertext)));
        }
    }
}
