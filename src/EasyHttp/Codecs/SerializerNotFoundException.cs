using System;
using System.Runtime.Serialization;

namespace EasyHttp.Codecs
{
    public class SerializerNotFoundException : Exception 
    {
        public SerializerNotFoundException(){}

        public SerializerNotFoundException(string message) : base(message) { }

        public SerializerNotFoundException(string message, Exception innerException) : base(message, innerException) { }

        protected SerializerNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
