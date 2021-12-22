using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourtBitsBank_0
{
    public class Customer : Person 
    {
        decimal balance;
        Plan plan;
        string accountNumber;
        string customerId;
        public Customer(string customerId,string name,string lastname,string contact,string email,string adress,string profilePic,
            decimal balance,string accountNumber,Plan plan)



            :base(name, lastname, contact, email, adress, profilePic)
        {
            this.plan = plan;
            this.balance = balance;
            this.accountNumber = accountNumber;
            this.customerId = customerId;
            //
            
        }
        override
        public string ToString()
        {
            return $"{this.customerId}_{base.ToString()}_{this.balance}_{this.accountNumber}_{this.plan} \n";
        }
        public static Customer Parse(string customer)
        {
            string[] details = customer.Split('_');
            return new Customer(details[0], details[1], details[2], details[3], details[4], details[5], details[6],
                Decimal.Parse(details[7]), details[8], (Plan)Enum.Parse(typeof(Plan), details[9]));
        }
    }
}
