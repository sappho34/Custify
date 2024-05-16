using Custify.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custify.Domain.Services
{
    public class CustomerService
    {
        static List<Customer> _customers = new();

        public void Add(string name)
        {
            Random random = new Random();
            var newCustomer = new Customer()
            {
                CustomerId = random.Next(1_000, 10_000),
                CustomerName = name
             };
            _customers.Add(newCustomer); 
        }
        public List<Customer> GetAll()
        {
            return _customers;
        }
    }
}
