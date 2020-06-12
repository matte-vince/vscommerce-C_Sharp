using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace dbManager.vscommerceDB
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int ID
        { get; set; }

        [DataMember]
        public string name
        { get; set; }

        [DataMember]
        public string surname
        { get; set; }

        [DataMember]
        public string fiscalCode
        { get; set; }

        [DataMember]
        public string email
        { get; set; }

        [DataMember]
        public string password
        { get; set; }

        [DataMember]
        public bool isAdmin
        { get; set; }

        [DataMember]
        public DateTime birthday
        { get; set; }

        public User(int iD)
        {
            ID = iD;
        }

        public User(int ID,string email,string password, string name, string surname, bool isAdmin, string fiscalCode, DateTime birthday)
        {
            this.ID = ID;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.fiscalCode = fiscalCode;
            this.password = password;
            this.isAdmin = isAdmin;
            this.birthday = birthday;
        }
    }
}
