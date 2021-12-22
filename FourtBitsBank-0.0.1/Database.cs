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
        private static List<Staff> staffs = new List<Staff>();
        public static void saveStaff(Staff staff)
        {
            staffs.Add(staff);
        }
        // 17:42
    }
}
