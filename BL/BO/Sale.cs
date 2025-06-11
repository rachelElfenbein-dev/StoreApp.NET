using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Sale
    {
        public int id { get; set; }
        public int? productId { get; set; }
        public int amountForSale { get; set; }
        public double totalPrice { get; set; }
        public bool? isForClubCustomers { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public Sale(int id,int? pID, int amuont, double price , bool ? cc, DateTime? start , DateTime ? end)
        {
            this.id = id;
            this.productId = pID;
            this.amountForSale =amuont;
            this.totalPrice = price;
            this.startDate = start;
            this.endDate = end;

        }

    }
}
