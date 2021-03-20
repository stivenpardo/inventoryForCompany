using System;
using System.Runtime.Serialization;

namespace InventoryFull.Infrastucture.Transversal.Exceptions
{
    public class HttpClientNotDefinedExceptions : Exception
    {
        public HttpClientNotDefinedExceptions() { }
        public HttpClientNotDefinedExceptions(string message):base(message) { }
        public HttpClientNotDefinedExceptions(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
