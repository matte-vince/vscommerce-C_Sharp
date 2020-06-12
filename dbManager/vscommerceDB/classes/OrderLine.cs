using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace dbManager.vscommerceDB
{
    [DataContract]
    public class OrderLine
    {
        [DataMember]
        public int ID
        { get; set; }

        [DataMember]
        public int order
        { get; set; }

        [DataMember]
        public Product product
        { get; set; }

        [DataMember]
        public int qty
        { get; set; }

        [DataMember]
        public double priceUnit
        { get; set; }

        public OrderLine(int iD, int order, Product product, int qty, double priceUnit)
        {
            ID = iD;
            this.order = order;
            this.product = product;
            this.qty = qty;
            this.priceUnit = priceUnit;
        }

        public OrderLine()
        {

        }

    }
}
