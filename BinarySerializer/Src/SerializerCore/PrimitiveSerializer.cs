using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinarySerializer.Src.HelperUtils;

namespace BinarySerializer.Src.SerializerCore
{
    public class PrimitiveSerializer : SerializerBase
    {
        public const byte CONTAINER_TYPE = ContainerType.PRIMITIVETYPE;
        public byte Type;
        public byte[] Data;

        public PrimitiveSerializer(string name, bool value)
        {
            Type = PrimitiveType.BOOLEAN;
            Data = new byte[PrimitiveType.SIZE_OF_BOOLEAN];
            Data.WriteBytes(0, value);
            SetName(name);
        }

        public PrimitiveSerializer(string name, byte value)
        {
            Type = PrimitiveType.BYTE;
            Data = new byte[PrimitiveType.SIZE_OF_BYTE];
            Data.WriteBytes(0, value);
            SetName(name);
        }

        public PrimitiveSerializer(string name, sbyte value)
        {
            Type = PrimitiveType.SBYTE;
            Data = new byte[PrimitiveType.SIZE_OF_SBYTE];
            Data.WriteBytes(0, value);
            SetName(name);
        }

        public PrimitiveSerializer(string name, char value)
        {
            Type = PrimitiveType.CHAR;
            Data = new byte[PrimitiveType.SIZE_OF_CHAR];
            Data.WriteBytes(0, value);
            SetName(name);
        }

        public PrimitiveSerializer(string name, short value)
        {
            Type = PrimitiveType.SHORT;
            Data = new byte[PrimitiveType.SIZE_OF_SHORT];
            Data.WriteBytes(0, value);
            SetName(name);
        }

        public PrimitiveSerializer(string name, ushort value)
        {
            Type = PrimitiveType.USHORT;
            Data = new byte[PrimitiveType.SIZE_OF_USHORT];
            Data.WriteBytes(0, value);
            SetName(name);
        }

        public PrimitiveSerializer(string name, int value)
        {
            Type = PrimitiveType.INT;
            Data = new byte[PrimitiveType.SIZE_OF_INT];
            Data.WriteBytes(0, value);
            SetName(name);
        }

        public PrimitiveSerializer(string name, uint value)
        {
            Type = PrimitiveType.UINT;
            Data = new byte[PrimitiveType.SIZE_OF_UINT];
            Data.WriteBytes(0, value);
            SetName(name);
        }

        public PrimitiveSerializer(string name, float value)
        {
            Type = PrimitiveType.FLOAT;
            Data = new byte[PrimitiveType.SIZE_OF_FLOAT];
            Data.WriteBytes(0, value);
            SetName(name);
        }

        public PrimitiveSerializer(string name, decimal value)
        {
            Type = PrimitiveType.DECIMAL;
            Data = new byte[PrimitiveType.SIZE_OF_DECIMAL];
            Data.WriteBytes(0, value);
            SetName(name);
        }

        public PrimitiveSerializer(string name, long value)
        {
            Type = PrimitiveType.LONG;
            Data = new byte[PrimitiveType.SIZE_OF_LONG];
            Data.WriteBytes(0, value);
            SetName(name);
        }

        public PrimitiveSerializer(string name, ulong value)
        {
            Type = PrimitiveType.ULONG;
            Data = new byte[PrimitiveType.SIZE_OF_ULONG];
            Data.WriteBytes(0, value);
            SetName(name);
        }

        public PrimitiveSerializer(string name, double value)
        {
            Type = PrimitiveType.DOUBLE;
            Data = new byte[PrimitiveType.SIZE_OF_DOUBLE];
            Data.WriteBytes(0, value);
            SetName(name);
        }


        public int AddData(byte[] dest,int pointer)
        {
            pointer = dest.WriteBytes(pointer,CONTAINER_TYPE);
            pointer = dest.WriteBytes(pointer, Type);
            pointer = base.AddData(dest, pointer);
            pointer = dest.WriteBytes(pointer, Data);
            return pointer;
        }


        public int GetSize()
        {
            return base.GetSize() + 1 + 1 + Data.Length;
        }
    }
}
