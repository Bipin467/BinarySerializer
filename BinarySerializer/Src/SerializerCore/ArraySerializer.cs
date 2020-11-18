using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinarySerializer.Src.HelperUtils;
namespace BinarySerializer.Src.SerializerCore
{
    public class ArraySerializer : SerializerBase
    {
        public const byte CONTAINER_TYPE = ContainerType.ARRAY;
        public byte ArrayType;
        public byte DataContainerType;
        
        protected ArraySerializer(byte arrayType, byte dataContainerType)
        {
            ArrayType = arrayType;
            DataContainerType = dataContainerType;
        }

        public int AddData(byte[] dest, int pointer)
        {
            pointer = dest.WriteBytes(pointer, CONTAINER_TYPE);
            pointer = dest.WriteBytes(pointer, ArrayType);
            pointer = dest.WriteBytes(pointer, DataContainerType);
            pointer = base.AddData(dest, pointer);
            return pointer;
        }

        protected int GetSize()
        {
            return base.GetSize() + PrimitiveType.SIZE_OF_BYTE * 3;
        }
    }
}
