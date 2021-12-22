using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourtBitsBank_0
{
<<<<<<< HEAD
    public class Customer : Person //
=======
    internal class Customer : Person
>>>>>>> ebd80494c7a9a32667e3c6847d82784e75f1bd10
    {
        decimal balance;
        Plan plan;
        string accountNumber;
        string customerId;
        public Customer(string name,string lastname,string contact,string email,string adress,string profilePic,
            decimal balance,string accountNumber,string customerId)



            :base(name, lastname, contact, email, adress, profilePic)
        {
            this.balance = balance;
            this.accountNumber = accountNumber;
            this.customerId = customerId;
            //asdasdsad
            
        }
    }
}
