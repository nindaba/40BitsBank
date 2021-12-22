using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourtBitsBank_0._0._1
{
    public class Customer : Person
    {
        int balance;
        Plan plan;
        int accountNumber;
        int customerId;
        public Customer(string name,string lastname,string contact,string email,string adress,int balance,int accountNumber,int customerId)
            :base(name, lastname, contact, email, adress)
        {
            this.balance = balance;
            this.accountNumber = accountNumber;
            this.customerId = customerId;
            
        }
    }
}
