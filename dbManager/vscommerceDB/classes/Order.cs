using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace dbManager.vscommerceDB
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int ID
        { get; set; }

        [DataMember]
        public User customer
        { get; set; }

        [DataMember]
        public DateTime date
        { get; set; }

        [DataMember]
        public double total
        { get; set; }

        [DataMember]
        public List<OrderLine> orderLines
        { get; set; }

        public Order(int iD, User customer, DateTime date, double total, List<OrderLine> orderLines)
        {
            ID = iD;
            this.customer = customer;
            this.date = date;
            this.total = total;
            this.orderLines = orderLines;
        }

        public Order()
        {

        }
    }
}
