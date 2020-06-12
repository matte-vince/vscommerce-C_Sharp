using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Manager
{
    [Serializable]
    internal class UnAuthorizedExc : Exception
    {
        public UnAuthorizedExc()
        {
        }

        public UnAuthorizedExc(string message) : base(message)
        {
        }

        public UnAuthorizedExc(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnAuthorizedExc(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
