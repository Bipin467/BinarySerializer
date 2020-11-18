using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinarySerializer.Src.HelperUtils;

namespace BinarySerializer.Src.SerializerCore
{
    public class PrimitiveArraySerializer : ArraySerializer
    {
        public byte Type;
        public uint Length;
        public byte[] Data;
        public PrimitiveArraySerializer(string name, byte arrayType, byte dataContainerType, bool[] value) :
            base(arrayType, dataContainerType)
        {
            Type = PrimitiveType.BOOLEAN;
            SetName(name);
            Data = new byte[value.Length * PrimitiveType.SIZE_OF_BOOLEAN];
            Length = (uint)value.Length;
            Data.WriteBytes(0, value);
        }

        public PrimitiveArraySerializer(string name, byte arrayType, byte dataContainerType, byte[] value) :
    base(arrayType, dataContainerType)
        {
            Type = PrimitiveType.BYTE;
            SetName(name);
            Length = (uint)value.Length;
            Data = new byte[value.Length * PrimitiveType.SIZE_OF_BYTE];
            Data.WriteBytes(0, value);
        }


        public PrimitiveArraySerializer(string name, byte arrayType, byte dataContainerType, sbyte[] value) :
    base(arrayType, dataContainerType)
        {
            Type = PrimitiveType.SBYTE;
            Length = (uint)value.Length;
            SetName(name);
            Data = new byte[value.Length * PrimitiveType.SIZE_OF_SBYTE];
            Data.WriteBytes(0, value);
        }


        public PrimitiveArraySerializer(string name, byte arrayType, byte dataContainerType, char[] value) :
    base(arrayType, dataContainerType)
        {
            Type = PrimitiveType.CHAR;
            Length = (uint)value.Length;
            SetName(name);
            Data = new byte[value.Length * PrimitiveType.SIZE_OF_CHAR];
            Data.WriteBytes(0, value);
        }

        public PrimitiveArraySerializer(string name, byte arrayType, byte dataContainerType, short[] value) :
    base(arrayType, dataContainerType)
        {
            Type = PrimitiveType.SHORT;
            Length = (uint)value.Length;
            SetName(name);
            Data = new byte[value.Length * PrimitiveType.SIZE_OF_SHORT];
            Data.WriteBytes(0, value);
        }

        public PrimitiveArraySerializer(string name, byte arrayType, byte dataContainerType, ushort[] value) :
    base(arrayType, dataContainerType)
        {
            Type = PrimitiveType.USHORT;
            Length = (uint)value.Length;
            SetName(name);
            Data = new byte[value.Length * PrimitiveType.SIZE_OF_USHORT];
            Data.WriteBytes(0, value);
        }


        public PrimitiveArraySerializer(string name, byte arrayType, byte dataContainerType, int[] value) :
    base(arrayType, dataContainerType)
        {
            Type = PrimitiveType.INT;
            Length = (uint)value.Length;
            SetName(name);
            Data = new byte[value.Length * PrimitiveType.SIZE_OF_INT];
            Data.WriteBytes(0, value);
        }


        public PrimitiveArraySerializer(string name, byte arrayType, byte dataContainerType, uint[] value) :
    base(arrayType, dataContainerType)
        {
            Type = PrimitiveType.UINT;
            Length = (uint)value.Length;
            SetName(name);
            Data = new byte[value.Length * PrimitiveType.SIZE_OF_UINT];
            Data.WriteBytes(0, value);
        }


        public PrimitiveArraySerializer(string name, byte arrayType, byte dataContainerType, float[] value) :
    base(arrayType, dataContainerType)
        {
            Type = PrimitiveType.FLOAT;
            Length = (uint)value.Length;
            SetName(name);
            Data = new byte[value.Length * PrimitiveType.SIZE_OF_FLOAT];
            Data.WriteBytes(0, value);
        }


        public PrimitiveArraySerializer(string name, byte arrayType, byte dataContainerType, long[] value) :
    base(arrayType, dataContainerType)
        {
            Type = PrimitiveType.LONG;
            Length = (uint)value.Length;
            SetName(name);
            Data = new byte[value.Length * PrimitiveType.SIZE_OF_LONG];
            Data.WriteBytes(0, value);
        }


        public PrimitiveArraySerializer(string name, byte arrayType, byte dataContainerType, ulong[] value) :
    base(arrayType, dataContainerType)
        {
            Type = PrimitiveType.ULONG;
            Length = (uint)value.Length;
            SetName(name);
            Data = new byte[value.Length * PrimitiveType.ULONG];
            Data.WriteBytes(0, value);
        }

        public PrimitiveArraySerializer(string name, byte arrayType, byte dataContainerType, decimal[] value) :
    base(arrayType, dataContainerType)
        {
            Type = PrimitiveType.DECIMAL;
            Length = (uint)value.Length;
            SetName(name);
            Data = new byte[value.Length * PrimitiveType.SIZE_OF_DECIMAL];
            Data.WriteBytes(0, value);
        }

        public PrimitiveArraySerializer(string name, byte arrayType, byte dataContainerType, double[] value) :
    base(arrayType, dataContainerType)
        {
            Type = PrimitiveType.DOUBLE;
            Length = (uint)value.Length;
            SetName(name);
            Data = new byte[value.Length * PrimitiveType.SIZE_OF_DOUBLE];
            Data.WriteBytes(0, value);
        }

        public int AddData(byte[] dest, int pointer)
        {
            pointer = base.AddData(dest, pointer);
            pointer = dest.WriteBytes(pointer, Type);
            pointer = dest.WriteBytes(pointer, Length);
            pointer = dest.WriteBytes(pointer, Data);
            return pointer;
        }

        public int GetSize()
        {
            return base.GetSize() + PrimitiveType.SIZE_OF_BYTE + PrimitiveType.SIZE_OF_UINT + Data.Length;
        }
    }
}
