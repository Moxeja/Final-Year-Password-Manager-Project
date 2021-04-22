using System.Text;

namespace Password_Manager_Program.Backend.GAuth
{
    // Original source code from: https://stackoverflow.com/a/12398317
    public static class Encoder32
    {
		public static string Base32Encode(byte[] data)
		{
			const int inByteSize = 8;
			const int outByteSize = 5;
			const string base32Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";

			int i = 0, index = 0;
			StringBuilder builder = new StringBuilder((data.Length + 7) * inByteSize / outByteSize);

			while (i < data.Length)
			{
				int currentByte = data[i];
				int digit;

				// Is the current digit going to span a byte boundary?
				if (index > (inByteSize - outByteSize))
				{
					int nextByte;
					if ((i + 1) < data.Length)
					{
						nextByte = data[i + 1];
					}
					else
					{
						nextByte = 0;
					}

					digit = currentByte & (0xFF >> index);
					index = (index + outByteSize) % inByteSize;
					digit <<= index;
					digit |= nextByte >> (inByteSize - index);
					i++;
				}
				else
				{
					digit = (currentByte >> (inByteSize - (index + outByteSize))) & 0x1F;
					index = (index + outByteSize) % inByteSize;

					if (index == 0)
					{
						i++;
					}
				}

				builder.Append(base32Alphabet[digit]);
			}

			return builder.ToString();
		}
	}
}
