using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using BO;



//using BO;

namespace BlImplementation;

internal class OrderImplementation : IOrder
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public List<SaleInProduct> AddProductToOrder(Order order, int id, int amount)
    {
        ProductInOrder pInOrder = order.ProductsInOrder.FirstOrDefault(x => x.id == id);
       DO.Product p = _dal.Product.Read(id);
     
        if(pInOrder != null)
        {
            if (  amount+ pInOrder.amount < 0)
                throw new BLOutOfStack("Not enough in...");
            //??????????????????????????????????????????
            if (p.quantity >= amount + pInOrder.amount)
                throw new Exception("mk");
            pInOrder.amount += amount;
        }
        else
        {
            if (p.quantity < amount)
                throw new BLOutOfStack("Not enough in...");
            pInOrder = new ProductInOrder(id, p.name, p.price, amount, new List<SaleInProduct>(), 0);
            order.ProductsInOrder.Add(pInOrder);

        }
        pInOrder = order.ProductsInOrder.FirstOrDefault(x => x.id == id);
        SearchSaleForProduct(pInOrder, order.isFavoriteCus??false);
        CalcTotalPriceForProduct(pInOrder);
        CalcTotalPrice(order);
        return pInOrder.sales;

    }
    public void CalcTotalPriceForProduct(ProductInOrder productInOrder)
    {
        int c = 0;
        List<SaleInProduct> sales = new List<SaleInProduct>();
        int count = productInOrder.amount;
        foreach (SaleInProduct s in productInOrder.sales)
        {
            if (count == 0)
                break;

            if (count < s.amountForSale)
                continue;
            if (s.amountForSale == 0)

                //c = count / s.amountForSale;
            count = (count % (s.amountForSale));
            double p = c * s.price;
            productInOrder.totalPrice += p;
            ////count -= count % s.amountForSale;
            sales.Add(s);


        }
        productInOrder.totalPrice += count * productInOrder.price;
        productInOrder.sales = sales;
    }
    public void CalcTotalPrice(Order order)
    {
        order.price= order.ProductsInOrder.Sum(order => order.totalPrice);
    }
    public void DoOrder(Order order)
    {
        foreach (ProductInOrder p in order.ProductsInOrder)
        {
            Product product = _dal.Product.Read(p.id).Convert();
            product.quantity -= p.amount;
            _dal.Product.Update(product.Convert());
        }
    }
    public void SearchSaleForProduct(ProductInOrder p, bool isFavorite)
    {
        List<DO.Sale> sales = _dal.Sale.ReadAll();
        if (isFavorite)
        {
            List<Sale> salesRes = sales.Where(s => s.productId == p.id && s.endDate >= DateTime.Now && s.startDate <= DateTime.Now && s.amountForSale <= p.amount)
           .Select(x => x.Convert()).ToList();
        }
        else
        {
            List<Sale> salesRes = sales.Where(s => s.productId == p.id && s.endDate >= DateTime.Now && s.startDate <= DateTime.Now && s.amountForSale <= p.amount && s.isForClubCustomers == false)
           .Select(x => x.Convert()).ToList();
        }
        //List<BO.Sale> sales2 = sales.Select(y=>y.Convert()).ToList();
        List<SaleInProduct> saleInPro = sales.Select(x => new SaleInProduct(x.id, x.amountForSale, x.totalPrice, x.isForClubCustomers)).ToList();
        saleInPro.OrderBy(x => x.price);
        p.sales = saleInPro;

    }
}
