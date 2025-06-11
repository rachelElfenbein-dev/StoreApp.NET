﻿using BlApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class Bl : IBl
    {
        public IProduct Product => new productImplementation();
        public ICustomer Customer => new CustomerImplementation();
        public ISale Sale => new SaleImplementation();
        public IOrder Order => new OrderImplementation();
    }
}
