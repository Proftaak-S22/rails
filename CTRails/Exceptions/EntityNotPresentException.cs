using System;
using System.Runtime.Serialization;


namespace CTRails.Exceptions
{
    [Serializable]
    public class EntityNotPresentException : Exception
    {
        public EntityNotPresentException()
        {
            
        }

        public EntityNotPresentException(string message) : base(message)
        {
        }

        public EntityNotPresentException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EntityNotPresentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

}