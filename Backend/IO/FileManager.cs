using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Password_Manager_Program.Backend.Crypto;
using Password_Manager_Program.Backend.Data_Classes;
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Password_Manager_Program.Backend.IO
{
    public class FileManager
    {
        public static void SaveStorageToFile(Storage storage)
        {
            // Create necessary IO streams
            using (MemoryStream ms = new MemoryStream())
            using (StreamWriter sw = new StreamWriter(ms, Encoding.UTF8))
            using (JsonWriter jw = new JsonTextWriter(sw))
            {
                // Create outer JSON object
                jw.WriteStartObject();

                // Encode to Base64 and write out salt
                jw.WritePropertyName("salt");
                jw.WriteValue(Convert.ToBase64String(storage.Salt));

                // Generate HMAC key
                byte[] hmacKey = new byte[64];
                using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(hmacKey);
                }

                using (CryptoService cs = new CryptoService(storage.Salt,
                    storage.ProtectedPassword, Storage.ITERATIONS))
                {
                    // Write Google Authenticator related information to file
                    jw.WritePropertyName("gauth-key");
                    if (storage.gAuthKey != null)
                        jw.WriteValue(Convert.ToBase64String(cs.EncryptByteArray(storage.gAuthKey)));
                    else
                        jw.WriteValue("");

                    // Write integrity checking HMAC key to file
                    jw.WritePropertyName("hmac-key");
                    jw.WriteValue(Convert.ToBase64String(cs.EncryptByteArray(hmacKey)));

                    // Write entries out
                    jw.WritePropertyName("entries");
                    jw.WriteStartArray();
                    for (int i = 0; i < storage.EntriesCount; i++)
                    {
                        // Fetch entry object and start JSON object
                        Entry currentEntry = storage.GetEntry(i);
                        jw.WriteStartObject();

                        // Write out purpose
                        jw.WritePropertyName("purpose");
                        jw.WriteValue(cs.EncryptString(currentEntry.Purpose));

                        // Write out username/email
                        jw.WritePropertyName("username");
                        jw.WriteValue(cs.EncryptString(currentEntry.Username));

                        // Write out password (already encrypted)
                        jw.WritePropertyName("password");
                        jw.WriteValue(currentEntry.Password);

                        // Write out purpose
                        jw.WritePropertyName("comment");
                        jw.WriteValue(cs.EncryptString(currentEntry.Comment));

                        // Finish JSON object
                        jw.WriteEndObject();
                    }
                }
                jw.WriteEndArray();

                // Close outer JSON object
                jw.WriteEndObject();
                jw.Flush();

                // Hash current file data
                using (HMACSHA256 hmac = new HMACSHA256(hmacKey))
                {
                    string hash = Convert.ToBase64String(hmac.ComputeHash(ms.ToArray()));
                    sw.Write(hash);
                    sw.Flush();
                }

                using (CryptoService cs = new CryptoService())
                {
                    File.WriteAllBytes(storage.SessionPath, cs.EncryptByteArray(ms.ToArray()));
                    //File.WriteAllBytes(storage.SessionPath, ms.ToArray());
                }
            }
        }

        private static bool FileIntegrityCompromised(byte[] hmacKey, byte[] cipherfile)
        {
            // Create HMAC object to hash file with
            using (HMACSHA256 hmac = new HMACSHA256(hmacKey))
            {
                // Find the index where the JSON object ends
                string cipherData = Encoding.UTF8.GetString(cipherfile);
                int endOfJSONIndex = cipherData.LastIndexOf('}');

                // Create a string for the original file and for the hash
                // that it should have to match
                string mainFile = cipherData.Substring(0, endOfJSONIndex + 1);
                string hashToMatch = cipherData.Substring(endOfJSONIndex + 1);

                // Hash the file and convert the hash to match back to a byte array
                byte[] currentFileHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(mainFile));
                byte[] hashToMatchBytes = Convert.FromBase64String(hashToMatch);

                // Compare the hashes
                return !currentFileHash.SequenceEqual(hashToMatchBytes);
            }
        }

        public static Storage LoadStorageFromFile(string filepath, byte[] protectedPassword)
        {
            try
            {
                // Strip off outer encryption shell and load into byte array
                byte[] cipherfile = null;
                using (CryptoService cs = new CryptoService())
                {
                    cipherfile = cs.DecryptByteArray(File.ReadAllBytes(filepath));
                }

                // Load data into Storage object
                using (MemoryStream ms = new MemoryStream(cipherfile))
                using (StreamReader sr = new StreamReader(ms, Encoding.UTF8))
                using (JsonReader jr = new JsonTextReader(sr))
                {
                    // Retrieve salt from file header
                    JObject file = JObject.Load(jr);
                    byte[] salt = Convert.FromBase64String(file.GetValue("salt").ToObject<string>());

                    // Create new storage object with salt
                    Storage storage = new Storage(protectedPassword, salt, filepath);

                    // Create master password derived CryptoService object
                    using (CryptoService cs = new CryptoService(salt, protectedPassword, Storage.ITERATIONS))
                    {
                        // Decrypt the HMAC key and check file integrity
                        byte[] hmacKey = cs.DecryptByteArray(Convert.FromBase64String(file.GetValue("hmac-key").ToObject<string>()));
                        if (FileIntegrityCompromised(hmacKey, cipherfile))
                        {
                            // Return null if the file has failed integrity checks
                            return null;
                        }

                        // Load Google Authenticator information
                        string gAuthString = file.GetValue("gauth-key").ToObject<string>();
                        if (!String.IsNullOrWhiteSpace(gAuthString))
                        {
                            // Store the Google Authenticator secret
                            storage.gAuthKey = cs.DecryptByteArray(Convert.FromBase64String(gAuthString));
                        }

                        // Load entries into storage object
                        JToken entriesArray = file.GetValue("entries");
                        foreach (JToken entryJSON in entriesArray.Children())
                        {
                            JObject parsedEntry = JObject.Parse(entryJSON.ToString());

                            // Retrieve entry details
                            string purpose = cs.DecryptString(parsedEntry.GetValue("purpose").ToString());
                            string username = cs.DecryptString(parsedEntry.GetValue("username").ToString());
                            string password = parsedEntry.GetValue("password").ToString();
                            string comment = cs.DecryptString(parsedEntry.GetValue("comment").ToString());

                            // Create entry object and add it to storage object
                            storage.AddEntry(new Entry(purpose, username, password, comment));
                        }
                    }

                    // Return loaded storage object
                    return storage;
                }
            }
            catch
            {
                // If something goes wrong, just return nothing
                return null;
            }
        }
    }
}
