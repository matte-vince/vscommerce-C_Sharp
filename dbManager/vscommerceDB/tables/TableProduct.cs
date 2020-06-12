using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbManager.vscommerceDB.tables
{
    [Table(Name = "prodotti")]
    [Serializable]
    public class TableProduct
    {
        [Column(IsPrimaryKey = true, Name = "ID", IsDbGenerated = true)]
        public int ID
        { get; set; }

        [Column(IsPrimaryKey = false, Name = "name")]
        public string name
        { get; set; }

        [Column(IsPrimaryKey = false, Name = "description")]
        public string description
        { get; set; }

        [Column(IsPrimaryKey = false, Name = "price")]
        public double price
        { get; set; }

        [Column(IsPrimaryKey = false, Name = "tax")]
        public int tax
        { get; set; }

        [Column(IsPrimaryKey = false, Name = "qty")]
        public int qty
        { get; set; }


        [Column(IsPrimaryKey = false, Name = "barcode")]
        public string barcode
        { get; set; }

        [Column(IsPrimaryKey = false, Name = "brand")]
        public int brand
        { get; set; }

        [Column(IsPrimaryKey = false, Name = "category")]
        public int category
        { get; set; }

        [Column(IsPrimaryKey = false, Name = "image")]
        public string image
        { get; set; }

        public TableProduct(string name, string description, double price, int tax, int qty, string barcode, int brand, int category, string image)
        {
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

        public TableProduct()
        {
            
        }

    }
}
