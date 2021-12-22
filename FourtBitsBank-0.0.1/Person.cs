using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourtBitsBank_0
{
    public class Person
    {
        string name, lastname, contact, email, adress,profilePic;
        public Person(string name, string lastname, string contact, string email, string adress, string profilePic)
        {
            this.name = name;
            this.lastname = lastname;
            this.contact = contact;
            this.email = email;
            this.adress = adress;
            this.profilePic = profilePic;
        }

    }
}
