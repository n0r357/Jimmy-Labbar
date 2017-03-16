using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_L2_2.Models
{
    public class DataManager
    {
        static List<Customer> customers = new List<Customer>()
        {
            new Customer { Id = 1, EmployeeCount = 666, CompanyName = "Satan Inc", CompanyAddress = new Address { Street = "Lucifer Road 666", City = "Belsebub", Country ="HELL" } },
            new Customer { Id = 2, EmployeeCount = 777, CompanyName = "God Inc", CompanyAddress = new Address { Street = "Jesus Road 777", City = "Jehova", Country ="HEAVEN" } }
        };

        public static void AddCustomer(Customer customer)
        {
            customer.Id = customers.Max(o => o.Id) + 1;
            customers.Add(customer);
        }

        public static void RemoveCustomer(int id)
        {
            customers.RemoveAt(id - 1);
        }

        public static Customer[] GetAllCustomers()
        {
            return customers.ToArray();
        }

        public static Customer GetCustomer(int id)
        {
            return customers.SingleOrDefault(c => c.Id == id);
        }
    }
}
