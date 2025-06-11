using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace BlApi
{
    public interface ICustomer
    {
        public int Create(Customer item);
        public Customer? Read(int id);
        public List<Customer> ReadAll(Func<Customer, bool>? filter = null);
        public void Update(Customer item);
        public void Delete(int id);
        public Customer? Read(Func<Customer, bool> filter);
        public bool IsExist();
    }
}
