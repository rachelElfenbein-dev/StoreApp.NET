using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Order
    {
        public bool? isFavoriteCus { get; set; }
        public List<ProductInOrder>? ProductsInOrder { get; set; }
        public double price { get; set; }
        public Order(bool? isFavoriteCus, List<ProductInOrder> ProductsInOrder, double price)
        {
            this.price = price;
            this.ProductsInOrder=new List<ProductInOrder>(ProductsInOrder);
            this.isFavoriteCus = isFavoriteCus;
        }

    }
}
