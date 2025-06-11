using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class CustomerImplementation:ICustomer
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Customer item)
        {
            try
            {
                return _dal.Customer.Create(item.Convert());
            }
            catch (Exception ex)
            {
                throw new BLidAlreadyExistException("this code already exists", ex);
            }
        }
        public Customer? Read(int id)
        {
            try
            {
                return _dal.Customer.Read(id).Convert();
            }
            catch(Exception ex)
            {
                throw new BLidNotExistException("there is no such customer",ex);
            }
        }
        public List<Customer> ReadAll(Func<Customer, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                    return _dal.Customer.ReadAll().Select(c => c.Convert()).ToList();
                return _dal.Customer.ReadAll().Select(c => c.Convert()).Where(filter).ToList();
            }
            catch
            {
                throw new Exception();
            }
            
        }
        public void Update(Customer item)
        {
            try
            {
                _dal.Customer.Update(item.Convert());
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
                _dal.Customer.Delete(id);
            }
            catch
            {
                throw new Exception();
            }
        }
        public Customer? Read(Func<Customer, bool> filter)
        {
            try
            {
                return _dal.Customer.Read(c => filter(c.Convert())).Convert();
                    //.Select(x=>x.ConvertToBO()).FirstOrDefault(filter);
             }
            catch(BLnotValidInputException ex)
            {
                throw new BLnotValidInputException("input was null", ex);
            }
        }
        public bool IsExist()
        {
            return true;
        }
    }
}
