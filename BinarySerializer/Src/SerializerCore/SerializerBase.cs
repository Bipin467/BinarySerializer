using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinarySerializer.Src.HelperUtils;
namespace BinarySerializer.Src.SerializerCore
{
    public abstract class SerializerBase
    {
        protected ushort NameLength;
        protected byte[] Name;

        public int AddData(byte[] dest,int pointer)
        {
            pointer = dest.WriteBytes(pointer, NameLength);
            pointer = dest.WriteBytes(pointer, Name);
            return pointer;
        }

        protected int GetSize()
        {
            return PrimitiveType.SIZE_OF_USHORT + Name.Length;
        }

        public void SetName(string name)
        {
            if (name.Length > ushort.MaxValue)
            {
                throw new Exceptions.ValueOutOfBoundException();
            }
            NameLength = (ushort)name.Length;
            Name = name.ToCharArray().ToByteArray();
        }
    }
}
