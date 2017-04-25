using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JQuerygrupp.Models
{
    public class DataManager
    {
        public static List<Customer> Customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "Hinken", City = "Göteborg" },
            new Customer { Id = 2, Name = "Victor", City = "Atlanten (havet är djup, havet är dju..)" },
            new Customer { Id = 3, Name = "Linus", City = "Sundsvall" },
            new Customer { Id = 4, Name = "Niklas", City = "Kumla (Bunkern?)" },
            new Customer { Id = 5, Name = "Mads", City = "Täby" }

        };

        public static CustomerIndexVM[] GetCustomers()
        {               
            var q = Customers.Select(c => new CustomerIndexVM
            {
                Name = c.Name,
                Id = c.Id,
                City = c.City,
            }).ToArray();

            return q;
        }

        public static CustomerIndexVM GetCustomerById(int id)
        {
            var customers = GetCustomers();
            return customers.FirstOrDefault(c => c.Id == id);
        }
    }
}
