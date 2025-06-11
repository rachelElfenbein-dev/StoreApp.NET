using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface IProduct
    {
        public int Create(Product item);
        public Product? Read(int id);
        public List<Product> ReadAll(Func<Product, bool>? filter = null);
        public void Update(Product item);
        public void Delete(int id);
        public Product? Read(Func<Product, bool> filter);
        public void AllSale(SaleInProduct s ,bool isFavorit);
    }
}
