using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
namespace dbManager.vscommerceDB
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int ID
        { get; set; }

        [DataMember]
        public string name
        { get; set; }

        [DataMember]
        public string description
        { get; set; }

        [DataMember]
        public int tax
        { get; set; }

        [DataMember]
        public double price
        { get; set; }

        [DataMember]
        public int qty
        { get; set; }

        [DataMember]
        public string image
        { get; set; }

        [DataMember]
        public string barcode
        { get; set; }

        [DataMember]
        public Brand brand
        { get; set; }

        [DataMember]
        public Category category
        { get; set; }
        public Product(int ID, string name, string description, double price, int tax, int qty, string barcode, Brand brand, Category category, string image)
        {
            this.ID = ID;
            this.name = name;
            this.description = description;
            this.price = price;
            this.tax = tax;
            this.qty = qty;
            this.barcode = barcode;
            this.brand = brand;
            this.category = category;
            this.image = image;
        }

    }
}
