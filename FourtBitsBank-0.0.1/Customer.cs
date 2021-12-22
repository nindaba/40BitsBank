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
        public Customer(string name,string lastname,string contact,string email,string adress,string profilePic,
            decimal balance,string accountNumber,string customerId,Plan plan)



            :base(name, lastname, contact, email, adress, profilePic)
        {
            this.plan = plan;
            this.balance = balance;
            this.accountNumber = accountNumber;
            this.customerId = customerId;
            //asdasdsad
            
        }
    }
}
