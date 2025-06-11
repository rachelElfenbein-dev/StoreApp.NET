using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Sale
        (
        int id,
        int productId,
        int amountForSale,//כמות נדרשת לקבלת מבצע
        double totalPrice,
        bool? isForClubCustomers,
        DateTime?startDate,
        DateTime? endDate
        )
    {
        public Sale() : this(0, 0, 0, 0, false, DateTime.Now, DateTime.Now)
        {

        }
    }
}
