using System;
using System.Globalization;
using System.Security.Cryptography;

namespace Password_Manager_Program.Backend.GAuth
{
	// Original source code from: https://stackoverflow.com/a/12398317
	public static class GAuth
    {
		private const int intervalLength = 30;
		private const int pinLength = 6;
		private const int sizeOfInt = 4;
		private static readonly int pinModulo = (int)Math.Pow(10, pinLength);
		private static readonly DateTime unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

		private static long CurrentInterval
		{
			get
			{
				long elapsedSeconds = (long)Math.Floor((DateTime.UtcNow - unixEpoch).TotalSeconds);
				return elapsedSeconds / intervalLength;
			}
		}

		public static string GeneratePin(byte[] key)
		{
			byte[] counterBytes = BitConverter.GetBytes(CurrentInterval);
			if (BitConverter.IsLittleEndian)
			{
				// Spec requires bytes in big-endian order
				Array.Reverse(counterBytes);
			}

			byte[] hash = null;
			using (HMACSHA1 hasher = new HMACSHA1(key))
			{
				hash = hasher.ComputeHash(counterBytes);
			}
			int offset = hash[hash.Length - 1] & 0xF;

			byte[] selectedBytes = new byte[sizeOfInt];
			Buffer.BlockCopy(hash, offset, selectedBytes, 0, sizeOfInt);
			if (BitConverter.IsLittleEndian)
			{
				// Spec interprets bytes in big-endian order
				Array.Reverse(selectedBytes);
			}

			int selectedInteger = BitConverter.ToInt32(selectedBytes, 0);

			// Remove the most significant bit for interoperability per spec
			int truncatedHash = selectedInteger & 0x7FFFFFFF;

			// Generate number of digits for given pin length
			int pin = truncatedHash % pinModulo;
			return pin.ToString(CultureInfo.InvariantCulture).PadLeft(pinLength, '0');
		}
	}
}
