using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    public class SaleImplementation:ISale
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Sale item)
        {
            try
            {
                return _dal.Sale.Create(item.Convert());
            }
            catch
            {
                throw new Exception();
            }
        }
        public Sale? Read(int id)
        {
            try
            {
                return _dal.Sale.Read(x => x.id == id).Convert();
            }
            catch(Exception ex)
            {
                throw new BLidNotExistException("there is no such sale",ex);
            }
        }
        public List<Sale> ReadAll(Func<Sale, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                    return _dal.Sale.ReadAll().Select(c => c.Convert()).ToList();
                return _dal.Sale.ReadAll().Select(c => c.Convert()).Where(filter).ToList();
            }
            catch
            {
                throw new Exception();
            }

        }
        public void Update(Sale item)
        {
            try
            {
                _dal.Sale.Update(item.Convert());
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
                _dal.Sale.Delete(id);
            }
            catch
            {
                throw new Exception();
            }
        }
        public Sale? Read(Func< Sale, bool> filter)
        {
            try
            {
                return _dal.Sale.Read(c => filter(c.Convert())).Convert();
                //.Select(x=>x.ConvertToBO()).FirstOrDefault(filter);
            }
            catch(Exception ex)
            {
                throw new BLnotValidInputException("input was null", ex);
            }
        }
    }
}
