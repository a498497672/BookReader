using System;
using System.Runtime.Serialization;

namespace Utility.Exceptions
{
    public class SimpleBadRequestException : Exception
    {
        public SimpleBadRequestException()
        {
        }

        public SimpleBadRequestException(string message) : base(message)
        {
        }

        public SimpleBadRequestException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SimpleBadRequestException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
