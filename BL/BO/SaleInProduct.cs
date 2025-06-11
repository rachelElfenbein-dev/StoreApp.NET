using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class SaleInProduct
    {
        public int id { get; init; }
        public int amountForSale { get; set; }
        public double price { get; set; }
        public bool? isForEveryone { get; set; }
        public SaleInProduct(int id,int amountForSale,double price,bool? isForEveryone)
        {
            this.id = id;
            this.amountForSale = amountForSale;
            this.price = price;
            this.isForEveryone = isForEveryone; 
        }

    }
}
