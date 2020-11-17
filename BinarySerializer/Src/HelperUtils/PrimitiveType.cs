using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializer.Src.HelperUtils
{
    class PrimitiveType
    {


        public const byte UNKNOWN = 0;
        public const byte BYTE = 1;
        public const byte SBYTE = 2;
        public const byte SHORT = 3;
        public const byte USHORT = 4;
        public const byte CHAR = 5;
        public const byte INT = 6;
        public const byte UINT = 7;
        public const byte LONG = 8;
        public const byte ULONG = 9;
        public const byte FLOAT = 10;
        public const byte DOUBLE = 11;
        public const byte BOOLEAN = 12;
        public const byte DECIMAL = 13;


        public const byte SIZE_OF_UNKNOWN = 0;
        public const byte SIZE_OF_BYTE = sizeof(byte);
        public const byte SIZE_OF_SBYTE = sizeof(sbyte);
        public const byte SIZE_OF_SHORT = sizeof(short);
        public const byte SIZE_OF_USHORT = sizeof(ushort);
        public const byte SIZE_OF_CHAR = sizeof(char);
        public const byte SIZE_OF_INT = sizeof(int);
        public const byte SIZE_OF_UINT = sizeof(uint);
        public const byte SIZE_OF_LONG = sizeof(long);
        public const byte SIZE_OF_ULONG = sizeof(ulong);
        public const byte SIZE_OF_FLOAT = sizeof(float);
        public const byte SIZE_OF_DOUBLE = sizeof(double);
        public const byte SIZE_OF_BOOLEAN = sizeof(bool);
        public const byte SIZE_OF_DECIMAL = sizeof(decimal);
        public static byte GetSize(byte type)
        {
            switch (type)
            {
                case BYTE: return sizeof(byte);
                case SBYTE: return sizeof(sbyte);
                case SHORT: return sizeof(short);
                case USHORT: return sizeof(ushort);
                case CHAR: return sizeof(char);
                case INT: return sizeof(int);
                case UINT: return sizeof(uint);
                case LONG: return sizeof(long);
                case ULONG: return sizeof(ulong);
                case FLOAT: return sizeof(float);
                case DOUBLE: return sizeof(double);
                case BOOLEAN: return sizeof(bool);
            }
            return 0;
        }


    }
}
