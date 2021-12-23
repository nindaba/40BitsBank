using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourtBitsBank_0
{
    public enum Index { NEXT = 1, CURENT = 0, PREV = -1 }
    public static class Database
    {

        private static  List<Customer> customers = new List<Customer>();
        public static  int maxCustomers { get => customers.Count; }
        public static  int maxStaffs { get => staffs.Count; }
        public static  int customerIndex = 0;

        public static void saveCustomer(Customer customer)
        {
            try
            {
                FileStream fileStream = new FileStream("data/customers.txt", FileMode.Append,FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(customer);
                streamWriter.Close();
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static Customer getCustomer(Index index)
        {
            if(customerIndex + (int)index >= 0 && customerIndex + (int)index < customers.Count)
            Database.customerIndex += (int)index;
            return customers[customerIndex];
        }
        public static Staff getStaff(Index index)
        {
            if (staffIndex + (int)index >= 0 && staffIndex + (int)index < staffs.Count)
                Database.staffIndex += (int)index;
            return staffs[staffIndex];
        }
        public static void loadCustomers()
        {
            Database.customers.Clear();
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
                MessageBox.Show("Failed to load Customer data");
            }
        }
        private static List<Staff> staffs = new List<Staff>();
        public static int staffIndex = 0;
        public static void saveStaff(Staff staff)
        {
            staffs.Add(staff);
            try
            {
                FileStream fileStream = new FileStream("data/staffs.txt", FileMode.Append, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(staff);
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
            try
            {
                FileStream fileStream = new FileStream("data/customers.txt", FileMode.Truncate, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                customers.ForEach(streamWriter.WriteLine);
                streamWriter.Close();
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void updateStaff(Staff staff)
        {
            staffs[staffIndex] = staff;
            try
            {
                FileStream fileStream = new FileStream("data/staffs.txt", FileMode.Truncate, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                staffs.ForEach(streamWriter.WriteLine);
                streamWriter.Close();
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void loadSaff()
        {
            Database.staffs.Clear();
            try
            {
                FileStream fileStream = new FileStream("data/staffs.txt", FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(fileStream);
                while (!streamReader.EndOfStream) Database.staffs.Add(Staff.Parse(streamReader.ReadLine()));
                streamReader.Close();
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Staff data");
            }
        }
        public static string nextCustomerId()
        {
            string value = (char)new Random().Next(65, 70) + "-" + Utils.fourRandom();
            /*
             * In Utils.class there is Version one of this method which is using for loops
             */
            if (customers.Find(customer => customer.customerId == value) == null) return value;
            return nextCustomerId();
        }
        public static string nextStaffId()
        {
            string value = (char)new Random().Next(71, 76) + "-" + Utils.fourRandom();
            /*
             * In Utils.class there is Version one of this method which is using for loops
             */
            if (staffs.Find(customer => customer.staff_id == value) == null) return value;
            return nextStaffId();
        }
        public static string generateAccountNumber()
        {
            string value = "";
            for (int i = 0; i < 4; i++)
            {
                value += Utils.fourRandom();
            }
            if (customers.Find(customer => customer.accountNumber == value) == null)
            return value;
            return generateAccountNumber();
        }
    }
}
