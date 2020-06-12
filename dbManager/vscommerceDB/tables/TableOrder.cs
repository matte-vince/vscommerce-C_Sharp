using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbManager.vscommerceDB.tables
{
    [Table(Name = "order")]
    public class TableOrder
    {
        [Column(IsPrimaryKey = true, Name = "ID", IsDbGenerated = true)]
        public int ID
        { get; set; }

        [Column(IsPrimaryKey = false, Name = "customer")]
        public int customer
        { get; set; }

        [Column(IsPrimaryKey = false, Name = "date")]
        public DateTime date
        { get; set; }

        [Column(IsPrimaryKey = false, Name = "total")]
        public double total
        { get; set; }

        public TableOrder(int customer, DateTime date, double total)
        {
            this.customer = customer;
            this.date = date;
            this.total = total;
        }

        public TableOrder()
        {
        }
    }
}
