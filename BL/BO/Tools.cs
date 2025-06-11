using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    internal static  class Tools
    {
        public static string ToStringProperty<T>(this T obj, string prefix = " ")
        {
            StringBuilder sb = new StringBuilder();
            Type type = obj.GetType();
            foreach (PropertyInfo prop in type.GetProperties())
            {
                if (prop.PropertyType.IsPrimitive || prop.PropertyType == typeof(string)
                    || prop.PropertyType == typeof(DateTime))
                    sb.AppendLine($"{prefix}{prop.Name}= {prop.GetValue(obj)}");
                else
                    sb.Append($"{prefix}{prop.Name}=\n{prop.GetValue(obj).ToStringProperty(prefix + "\t")}");
            }
            return sb.ToString();

        }
        public static BO.Customer Convert(this DO.Customer obj)
        {
            return new BO.Customer(obj.id, obj.name, obj.address, obj.phone);
        }
        public static DO.Customer Convert(this BO.Customer obj)
        {
            return new DO.Customer(obj.id, obj.name, obj.address, obj.phone);
        }

        public static BO.Product Convert(this DO.Product obj)
        {
            return new BO.Product(obj.id,obj.name,(BO.Categories)obj.category, obj.price, obj.quantity);
        }
        public static DO.Product Convert(this BO.Product obj)
        {
            return new DO.Product(obj.id, obj.name, (DO.Categories)obj.category, obj.price??0, obj.quantity);
        }

        public static BO.Sale Convert(this DO.Sale obj)
        {
            return new BO.Sale(obj.id,obj.productId,obj.amountForSale,obj.totalPrice,obj.isForClubCustomers,obj.startDate,obj.endDate );
        }
        public static DO.Sale Convert(this BO.Sale obj)
        {
            return new DO.Sale(obj.id, obj.productId??0, obj.amountForSale, obj.totalPrice, obj.isForClubCustomers, obj.startDate, obj.endDate);
        }



    }
}
