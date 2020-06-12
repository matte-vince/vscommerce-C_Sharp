using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace dbManager.vscommerceDB
{
    [DataContract]
    public class Brand
    {
        [DataMember]
        public int ID
        { get; set; }

        [DataMember]
        public string name
        { get; set; }

        public Brand(int ID, string name)
        {
            this.ID = ID;
            this.name = name;
        }
    }
}
