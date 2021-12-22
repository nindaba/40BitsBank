using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourtBitsBank_0
{
    public class Customer : Person
    {
        int balance;
        Plan plan;
        int accountNumber;
        int customerId;
        public Customer(string name,string lastname,string contact,string email,string adress,string profilePic,
            int balance,int accountNumber,int customerId)



            :base(name, lastname, contact, email, adress, profilePic)
        {
            this.balance = balance;
            this.accountNumber = accountNumber;
            this.customerId = customerId;
            //asdasdsad
            
        }
    }
}
