using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ProductInOrder
    {
        public int id { get; init; }
        public string? name { get; set; }
        public double price { get; set; }
        public int amount { get; set; }
        public List<SaleInProduct>? sales   { get; set; }
        public double totalPrice { get; set; }
        public ProductInOrder(int id, string? name, double price, int amount, List<SaleInProduct>? sales, double totalPrice)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.amount = amount;
            this.sales = sales;
            this.totalPrice = totalPrice;
        }

    }
}
