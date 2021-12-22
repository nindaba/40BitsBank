using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourtBitsBank_0
{
    public static class Database
    {
        private static List<Customer> customers = new List<Customer>();
        public static void saveCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        //private static List<Staff> staff = new List<Staff>();
        //public static void saveStaff(Staff staff)
        //{
        //    customers.Add(staff);
        //}
    }
}
