using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbManager.vscommerceDB.tables
{
    [Table(Name = "category")]
    public class TableCategory
    {
        [Column(IsPrimaryKey = true, Name = "ID", IsDbGenerated = true)]
        public int ID
        { get; set; }

        [Column(IsPrimaryKey = false, Name = "name")]
        public string name
        { get; set; }

        public TableCategory(string name)
        {
            this.name = name;
        }

        public TableCategory()
        {

        }
    }
}
