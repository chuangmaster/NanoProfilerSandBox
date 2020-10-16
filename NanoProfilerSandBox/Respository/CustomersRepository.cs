using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NanoProfilerSandBox.Respository
{
    public class CustomersRepository
    {
        private NorthwindEntities _DB;

        public CustomersRepository()
        {
            _DB = new NorthwindEntities();
        }

        public List<string> GetCustomerContactName()
        {
            return _DB.Customers.Select(x => x.ContactName).Take(20).ToList();
        }
    }
}