using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace _11FileParseException
{
    public class FileParseException : Exception
    {
        public FileParseException()
        {
        }
        public FileParseException(string message)
            : base(message)
        {
        }
        public FileParseException(string message, Exception inner)
            : base(message, inner)
        {
        }
        protected FileParseException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}

