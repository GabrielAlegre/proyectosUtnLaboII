using System;
using System.Runtime.Serialization;

namespace BcI101MiPrimerCRUD
{
    [Serializable]
    public class SqlCrudException : Exception
    {
        public SqlCrudException()
        {
        }

        public SqlCrudException(string message) : base(message)
        {
        }

        public SqlCrudException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SqlCrudException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}