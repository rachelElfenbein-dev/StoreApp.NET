using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    public class productImplementation:IProduct
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Product item)
        {
             
            try
            {
                return _dal.Product.Create(item.Convert());
            }
            catch
            {
                throw new Exception();
            }
        }
        public Product? Read(int id)
        {
            try
            {
                return _dal.Product.Read(x => x.id == id).Convert();
            }
            catch
            {
                throw new BLidAlreadyExistException("there is no such product");
            }
        }
        public List<Product> ReadAll(Func<Product, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                    return _dal.Product.ReadAll().Select(c => c.Convert()).ToList();
                return _dal.Product.ReadAll().Select(c => c.Convert()).Where(filter).ToList();
            }
            catch
            {
                throw new Exception();
            }

        }
        public void Update(Product item)
        {
            try
            {
                _dal.Product.Update(item.Convert());
            }
            catch
            {
                throw new Exception();
            }
        }
        public void Delete(int id)
        {
            try
            {
                _dal.Product.Delete(id);
            }
            catch
            {
                throw new Exception();
            }
        }
        public Product? Read(Func<Product, bool> filter)
        {
            try
            {
                return _dal.Product.Read(c => filter(c.Convert())).Convert();
                //.Select(x=>x.ConvertToBO()).FirstOrDefault(filter);
            }
            catch
            {
                throw new BLnotValidInputException("input was null");
            }
        }
        public void AllSale(SaleInProduct s, bool isFavorit)
        {

        }

    }


}

