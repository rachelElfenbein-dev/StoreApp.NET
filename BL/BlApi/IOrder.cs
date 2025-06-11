using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface IOrder
    {
        public List<SaleInProduct>	AddProductToOrder(Order order,int id,int amount);
        public void	CalcTotalPriceForProduct(ProductInOrder productInOrder);
        public void CalcTotalPrice(Order order);
        public void DoOrder(Order order);
        public void SearchSaleForProduct(ProductInOrder p, bool isFavorite);
    }
}
