using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbManager.vscommerceDB.tables
{
    [Table(Name = "user")]
    [Serializable]
    public class TableUser
    {
        [Column(IsPrimaryKey = true, Name = "ID", IsDbGenerated = true)]
        public int ID
        { get; set; }

        [Column(IsPrimaryKey = false, Name = "name")]
        public string name
        { get; set; }

        [Column(IsPrimaryKey = false, Name = "surname")]
        public string surname
        { get; set; }

        [Column(IsPrimaryKey = false, Name = "birthday")]
        public DateTime birthday
        { get; set; }

        [Column(IsPrimaryKey = false, Name = "fiscalCode")]
        public string fiscalCode
        { get; set; }

        [Column(IsPrimaryKey = false, Name = "email")]
        public string email
        { get; set; }

        [Column(IsPrimaryKey = false, Name = "password")]
        public string password
        { get; set; }

        [Column(IsPrimaryKey = false, Name = "isAdmin")]
        public bool isAdmin
        { get; set; }

        public TableUser(string name, string surname, DateTime birthday, string fiscalCode, string email, string password, bool isAdmin)
        {
            this.name = name;
            this.surname = surname;
            this.birthday = birthday;
            this.fiscalCode = fiscalCode;
            this.email = email;
            this.password = password;
            this.isAdmin = isAdmin;
        }

        public TableUser()
        {
            
        }
    }
}
