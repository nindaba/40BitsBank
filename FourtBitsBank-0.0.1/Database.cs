using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourtBitsBank_0
{
    public static class Database
    {


        public static  List<Customer> customers = new List<Customer>();
        public static  int customerIndex = 0;
        public static void saveCustomer(Customer customer)
        {
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
        public static Customer getCustomer(int index)
        {
            return customers[index];
        }
        public static void loadCustomers()
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                FileStream fileStream = new FileStream("data/customers.txt", FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(fileStream);
                while (!streamReader.EndOfStream) Database.customers.Add(Customer.Parse(streamReader.ReadLine()));
                streamReader.Close();
                fileStream.Close();
            } 
            catch(Exception ex)
            {
                MessageBox.Show("Failed to load data from the file");
            }
        }
        private static List<Staff> staffs = new List<Staff>();
        private static int staffIndex = 0;
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

        public static void updateCustomer(Customer customer)
        {
            customers[customerIndex] = customer;
            string custms = "";
            foreach(var cust in customers)
            {
                custms += cust.ToString()+"\n";
            }
            try
            {
                FileStream fileStream = new FileStream("data/customers.txt", FileMode.Open, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.Write(custms);
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
                FileStream fileStream = new FileStream("data/staff.txt", FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(fileStream);
                while (!streamReader.EndOfStream) Database.staffs.Add(Staff.Parse(streamReader.ReadLine()));
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
