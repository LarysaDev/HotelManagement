using HotelManagement.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Customers
{
    public class Singleton_AllCustomers
    {
        protected HashSet<Customer> customers;

        private static Singleton_AllCustomers Instance = new Singleton_AllCustomers(50);
        private Singleton_AllCustomers(int customersAmount)
        {
            customers = new HashSet<Customer>(customersAmount);
        }

        public static Singleton_AllCustomers AllCustomers
        {
            get { return Instance; }
        }

        public HashSet<Customer> getListOfCustomers()
        {
            return customers;
        }
        public void addCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public void addCustomers(HashSet<Customer> customerSet)
        {
            customers = customerSet;
        }

    }

}
