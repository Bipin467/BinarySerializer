using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinarySerializer.Src.HelperUtils;
namespace BinarySerializer.Src.SerializerCore
{
    public class ObjectSerializer : SerializerBase
    {
        public const byte CONTAINER_TYPE = ContainerType.OBJECT;
        public uint PrimitiveTypeCount;
        public PrimitiveSerializer[] PrimitiveSerArr;
        public uint PrimitiveStaticTypeCount;
        public PrimitiveSerializer[] PrimitiveSerStaticArr;
        public uint PrimitiveArrayCount;
        public PrimitiveArraySerializer[] PrimitiveArraySerArr;
        public uint ObjectSerializerCount;
        public ObjectSerializer[] ObjectSerArray;
        //left for string and object array  to be done after creating those types.

    }
}
