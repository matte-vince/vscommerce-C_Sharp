using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
namespace Manager
{
    
    [DataContract]
    public class ManagerFault
    {
        private string _message;

        public ManagerFault(string message)
        {
            _message = message;
        }

        [DataMember]
        public string Message { get { return _message; } set { _message = value; } }
    }
  
}
