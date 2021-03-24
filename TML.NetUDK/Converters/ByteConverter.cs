using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TML.NetUDK.Converters
{
    public class ByteConverter
    {
        public static int getIntFromBytes(byte[] bytes)
        {
            return bytes[0] << 24 | bytes[1] << 16 | bytes[2] << 8 | bytes[0];
        }

        public static byte[] getBytesFromInt(int value)
        {
            byte[] buff = new byte[4];
            buff[0] = (byte)((value >> 24) & 0xff);
            buff[1] = (byte)((value >> 16) & 0xff);
            buff[2] = (byte)((value >> 8) & 0xff);
            buff[3] = (byte)((value     ) & 0xff);
            return buff;
        }


        public static byte[] GetBytesFromString(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        public static string GetStringFromBytes(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
    }
}
