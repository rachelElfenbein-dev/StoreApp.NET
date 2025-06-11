using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Product
    { 
        public int id { get; set; }
        public string? name { get; set; }
        public Categories? category { get; set; }
        public double? price { get; set; }
        public int? quantity { get; set; }
        public Product(int id, string? name, Categories? cat , double?price, int ? quantity)
        {
            this.id = id;
            this.name = name;
            this.category = cat;
            this.price = price;
            this.quantity = quantity;
        }

    }
}
