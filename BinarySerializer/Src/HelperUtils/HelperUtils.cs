using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinarySerializer.Src.Exceptions;

namespace BinarySerializer.Src.HelperUtils
{
    public static class HelperUtils
    {



        #region Byte Write Methods
        public static int WriteBytes(this byte[] dest, int pointer, sbyte value)
        {
            if (dest.Length > pointer + PrimitiveType.SIZE_OF_SBYTE)
            {
                dest[pointer++] = (byte)value;
                return pointer;
            }
            throw new ArrayOutOfBoundsException();
        }

        public static int WriteBytes(this byte[] dest, int pointer, short value)
        {
            if (dest.Length > pointer + PrimitiveType.SIZE_OF_SHORT)
            {
                dest[pointer++] = (byte)((value >> 8) & 0xff);
                dest[pointer++] = (byte)((value >> 0) & 0xff);
                return pointer;
            }
            throw new ArrayOutOfBoundsException();
        }

        public static int WriteBytes(this byte[] dest, int pointer, char value)
        {
            if (dest.Length > pointer + PrimitiveType.SIZE_OF_CHAR)
            {
                dest[pointer++] = (byte)((value >> 8) & 0xff);
                dest[pointer++] = (byte)((value >> 0) & 0xff);
                return pointer;
            }
            throw new ArrayOutOfBoundsException();
        }

        public static int WriteBytes(this byte[] dest, int pointer, int value)
        {
            if (dest.Length > pointer + PrimitiveType.SIZE_OF_INT)
            {
                dest[pointer++] = (byte)((value >> 24) & 0xff);
                dest[pointer++] = (byte)((value >> 16) & 0xff);
                dest[pointer++] = (byte)((value >> 8) & 0xff);
                dest[pointer++] = (byte)((value >> 0) & 0xff);
                return pointer;
            }
            throw new ArrayOutOfBoundsException();
        }

        public static int WriteBytes(this byte[] dest, int pointer, long value)
        {
            if (dest.Length > pointer + PrimitiveType.SIZE_OF_LONG)
            {
                dest[pointer++] = (byte)((value >> 56) & 0xff);
                dest[pointer++] = (byte)((value >> 48) & 0xff);
                dest[pointer++] = (byte)((value >> 40) & 0xff);
                dest[pointer++] = (byte)((value >> 32) & 0xff);
                dest[pointer++] = (byte)((value >> 24) & 0xff);
                dest[pointer++] = (byte)((value >> 16) & 0xff);
                dest[pointer++] = (byte)((value >> 8) & 0xff);
                dest[pointer++] = (byte)((value >> 0) & 0xff);
                return pointer;
            }
            throw new ArrayOutOfBoundsException();
        }

        public static int WriteBytes(this byte[] dest, int pointer, float value)
        {
            return WriteBytes(dest, pointer, BitConverter.ToInt32(BitConverter.GetBytes(value), 0));
        }

        public static int WriteBytes(this byte[] dest, int pointer, double value)
        {
            return WriteBytes(dest, pointer, BitConverter.DoubleToInt64Bits(value));
        }

        public static int WriteBytes(this byte[] dest, int pointer, bool value)
        {
            return WriteBytes(dest, pointer, (byte)(value ? 1 : 0));
        }

        public static int WriteBytes(this byte[] dest, int pointer, byte value)
        {
            if (dest.Length > pointer + PrimitiveType.SIZE_OF_BYTE)
            {
                dest[pointer] = value;
                return pointer;
            }
            throw new ArrayOutOfBoundsException();

        }

        public static int WriteBytes(this byte[] dest, int pointer, ushort value)
        {
            if (dest.Length > pointer + PrimitiveType.SIZE_OF_USHORT)
            {
                dest[pointer++] = (byte)((value >> 8) & 0xff);
                dest[pointer++] = (byte)((value >> 0) & 0xff);
                return pointer;
            }
            throw new ArrayOutOfBoundsException();
        }

        public static int WriteBytes(this byte[] dest, int pointer, decimal value)
        {
            if(dest.Length> pointer + PrimitiveType.SIZE_OF_DECIMAL)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                System.IO.BinaryWriter br = new System.IO.BinaryWriter(ms);
                br.Write(value);
                return WriteBytes(dest, pointer, ms.ToArray());
            }
            throw new ArrayOutOfBoundsException();
        }

        public static int WriteBytes(this byte[] dest, int pointer, uint value)
        {
            return WriteBytes(dest, pointer, (int)value);
        }

        public static int WriteBytes(this byte[] dest, int pointer, ulong value)
        {
            return WriteBytes(dest, pointer, (long)value);
        }

        public static int WriteBytes(this byte[] dest, int pointer, sbyte[] src)
        {
            for (int i = pointer; i < src.Length; i++)
            {
                pointer = WriteBytes(dest, pointer, src[i]);
            }
            return pointer;
        }

        public static int WriteBytes(this byte[] dest, int pointer, short[] src)
        {
            for (int i = pointer; i < src.Length; i++)
            {
                pointer = WriteBytes(dest, pointer, src[i]);
            }
            return pointer;
        }

        public static int WriteBytes(this byte[] dest, int pointer, char[] src)
        {
            for (int i = pointer; i < src.Length; i++)
            {
                pointer = WriteBytes(dest, pointer, src[i]);
            }
            return pointer;
        }

        public static int WriteBytes(this byte[] dest, int pointer, int[] src)
        {
            for (int i = pointer; i < src.Length; i++)
            {
                pointer = WriteBytes(dest, pointer, src[i]);
            }
            return pointer;
        }

        public static int WriteBytes(this byte[] dest, int pointer, long[] src)
        {
            for (int i = pointer; i < src.Length; i++)
            {
                pointer = WriteBytes(dest, pointer, src[i]);
            }
            return pointer;
        }

        public static int WriteBytes(this byte[] dest, int pointer, float[] src)
        {
            for (int i = pointer; i < src.Length; i++)
            {
                pointer = WriteBytes(dest, pointer, src[i]);
            }
            return pointer;
        }

        public static int WriteBytes(this byte[] dest, int pointer, double[] src)
        {
            for (int i = pointer; i < src.Length; i++)
            {
                pointer = WriteBytes(dest, pointer, src[i]);
            }
            return pointer;
        }

        public static int WriteBytes(this byte[] dest, int pointer, bool[] src)
        {
            for (int i = pointer; i < src.Length; i++)
            {
                pointer = WriteBytes(dest, pointer, src[i]);
            }
            return pointer;
        }

        public static int WriteBytes(this byte[] dest, int pointer, byte[] src)
        {
            for (int i = pointer; i < src.Length; i++)
            {
                pointer = WriteBytes(dest, pointer, src[i]);
            }
            return pointer;
        }

        public static int WriteBytes(this byte[] dest, int pointer, ushort[] src)
        {
            for (int i = pointer; i < src.Length; i++)
            {
                pointer = WriteBytes(dest, pointer, src[i]);
            }
            return pointer;
        }

        public static int WriteBytes(this byte[] dest, int pointer, uint[] src)
        {
            for (int i = pointer; i < src.Length; i++)
            {
                pointer = WriteBytes(dest, pointer, src[i]);
            }
            return pointer;
        }

        public static int WriteBytes(this byte[] dest, int pointer, ulong[] src)
        {
            for (int i = pointer; i < src.Length; i++)
            {
                pointer = WriteBytes(dest, pointer, src[i]);
            }
            return pointer;
        }

        public static int WriteBytes(this byte[] dest, int pointer, string data)
        {
            return WriteBytes(dest, pointer, data.ToCharArray());
        }

        #endregion


        #region ReadMethods
        #endregion

        #region OtherExtraHelpers
        public static byte[] ToByteArray(this string dat)
        {
            return dat.ToCharArray().ToByteArray();
        }

        public static byte[] ToByteArray(this char[] dat)
        {
            byte[] barr = new byte[dat.Length * sizeof(char)];
            barr.WriteBytes(0, dat);
            return barr;
        }
        #endregion


    }
}
