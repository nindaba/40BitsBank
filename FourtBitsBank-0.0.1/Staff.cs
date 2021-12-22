using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourtBitsBank_0
{
    public class Staff:Person
    {
        //this string below should be encapsulated. We use public because Mahdi does not have time
        public string staff_id, role, hours, extra_hours, salary, balance;
        public Staff(
            string name, string lastname, string contact, string email, string adress,string profilePic,
            string staff_id, string role, string hours, string extra_hours, string salary, string balance)
            :base(name, lastname, contact, email, adress,profilePic)
        {
            this.staff_id = staff_id;
            this.role = role;
            this.hours = hours;
            this.extra_hours = extra_hours;
            this.salary = salary;
            this.balance = balance;
        }

        public string printData()
        {
            return $"{this.staff_id}_{this.role}_{this.hours}_{this.extra_hours}_{this.extra_hours}_{this.salary}_{this.balance}";
        }
    }
}
