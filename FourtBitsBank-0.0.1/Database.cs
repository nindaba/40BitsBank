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
            try
            {
                FileStream fileStream = new FileStream("data/customers.txt", FileMode.Append,FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.Write(customer.ToString());
                streamWriter.Close();
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static List<Customer> getCustomers()
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                FileStream fileStream = new FileStream("data/customers.txt", FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(fileStream);
                while (!streamReader.EndOfStream) customers.Add(Customer.Parse(streamReader.ReadLine()));
                streamReader.Close();
                fileStream.Close();
            } 
            catch(Exception ex)
            {
                MessageBox.Show("Failed to load data from the file");
            }
            return customers;
        }
        private static List<Staff> staffs = new List<Staff>();
        public static void saveStaff(Staff staff)
        {
            staffs.Add(staff);
            try
            {
                FileStream fileStream = new FileStream("data/customers.txt", FileMode.Append, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.Write(staff.ToString());
                streamWriter.Close();
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static List<Staff> getSaff()
        {
            List<Staff> staffs = new List<Staff>();
            try
            {
                FileStream fileStream = new FileStream("data/customers.txt", FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(fileStream);
                while (!streamReader.EndOfStream) staffs.Add(Staff.Parse(streamReader.ReadLine()));
                streamReader.Close();
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data from the file");
            }
            return staffs;
        }
    }
}
