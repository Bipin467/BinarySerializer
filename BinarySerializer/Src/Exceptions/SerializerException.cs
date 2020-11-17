using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializer.Src.Exceptions
{
    public class SerializerException : Exception
    {
        private SerializerException()
        {

        }
        public SerializerException(string message) : base(message)
        {

        }
    }

    public class ArrayOutOfBoundsException : SerializerException
    {
        public ArrayOutOfBoundsException(string message) : base(message)
        {

        }

        public ArrayOutOfBoundsException() : base("Array out of bound exception")
        {

        }
    }

    public class TypeMismatchException : SerializerException
    {
        public TypeMismatchException(string message) : base(message)
        {

        }

        public TypeMismatchException() : base("Type Mismatch Exception Occoured")
        {

        }
    }

    public class ValueOutOfBoundException : SerializerException
    {
        public ValueOutOfBoundException(string message) : base(message)
        {

        }

        public ValueOutOfBoundException():base("Value out of bound")
        {

        }
    }
}
