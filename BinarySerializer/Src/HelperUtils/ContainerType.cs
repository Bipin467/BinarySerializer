using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializer.Src.HelperUtils
{
    public class ContainerType
    {
        public const byte UNKNOWN = 0;
        public const byte PRIMITIVETYPE = 1;
        public const byte ARRAY = 2;
        public const byte STRING = 3;
        public const byte OBJECT = 4;
        public const byte SERIALIZERDATABSE = 5;
    }
}
