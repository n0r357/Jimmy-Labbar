using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_L6.Models
{
    public static class DataManager
    {
        static List<Customer> customers = new List<Customer>()
        {
            new Customer { Id = 1, Name = "Jango Fett", City = "Concord Dawn" },
            new Customer { Id = 2, Name = "Bobba Fett", City = "Kamino" },
            new Customer { Id = 3, Name = "Darth Vader", City = "Tatooine" }
        };
        public static Customer[] GetAllCustomers()
        {
            return customers.ToArray();
        }
    }
}
