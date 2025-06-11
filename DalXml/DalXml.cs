using DalXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalApi;

namespace Dal
{
    internal class DalXml:IDal
    {
        public ISale Sale => new SaleImplementation();
        public IProduct Product => new ProductImplementation();
        public ICustomer Customer => new CustomerImplementation();
        private static DalXml instance;
        public static DalXml Instance
        {
            get { return instance; }
        }
        static DalXml()
        {
            instance = new DalXml();
        }

        private DalXml() { }
    }
}
