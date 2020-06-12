using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbManager.vscommerceDB.tables
{
    [Table(Name = "orderLine")]
    public class TableOrderLine
    {
        [Column(IsPrimaryKey = true, Name = "ID", IsDbGenerated = true)]
        public int ID
        { get; set; }

        [Column(IsPrimaryKey = false, Name = "product")]
        public int product
        { get; set; }

        [Column(IsPrimaryKey = false, Name = "orderID")]
        public int order
        { get; set; }

        [Column(IsPrimaryKey = false, Name = "qty")]
        public int qty
        { get; set; }

        [Column(IsPrimaryKey = false, Name = "priceUnit")]
        public double priceUnit
        { get; set; }

        public TableOrderLine(int product, int order, int qty, double priceUnit)
        {

            this.product = product;
            this.order = order;
            this.qty = qty;
            this.priceUnit = priceUnit;
        }

        public TableOrderLine()
        {

        }
    }
}
