using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializer.Src.HelperUtils
{
    public static class ExtentionMethods
    {
        #region bytes
        public static string ByteArrayToString(this byte[] data)
        {
            char[] temp = new char[data.Length / 2];
            for (int i = 0, mult = i * 2; i < temp.Length; i++, mult = i * 2)
            {
                temp[i] = (char)(data[mult] + data[mult + 1]);
            }
            return new string(temp);
        }

        public static char[] ByteArrayToCharArray(this byte[] data)
        {
            char[] temp = new char[data.Length / 2];
            for (int i = 0, mult = i * 2; i < temp.Length; i++, mult = i * 2)
            {
                temp[i] = (char)(data[mult] + data[mult + 1]);
            }
            return temp;
        }


        public static ushort ByteArrayToUShort(this byte[] data)
        {
            return (ushort)(data[0] << 8 | data[1]);
        }
        #endregion

        #region ushort
        public static byte[] ToByteArray(this ushort data)
        {
            byte[] temp = new byte[2];
            temp[0] = (byte)((data >> 8) & 0x000000ff);
            temp[1] = (byte)((data >> 0) & 0x000000ff);
            return temp;
        }

        #endregion

    }
}
