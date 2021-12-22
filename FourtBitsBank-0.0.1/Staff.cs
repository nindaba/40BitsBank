using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourtBitsBank_0
{
    public class Staff : Person
    {
        //this string below should be encapsulated. We use public because Mahdi does not have time
        public string staff_id;
        Role role;
        int hours, extra_hours;
        decimal salary, balance;
        public Staff(
            string name, string lastname, string contact, string email, string adress, string profilePic,
            string staff_id, Role role, int hours, int extra_hours, decimal salary, decimal balance)
            : base(name, lastname, contact, email, adress, profilePic)
        {
            this.staff_id = staff_id;
            this.role = role;
            this.hours = hours;
            this.extra_hours = extra_hours;
            this.salary = salary;
            this.balance = balance;
        }
        override
        public string ToString()
        {
            return $"{this.staff_id}_{base.ToString()}_{this.role}_{this.hours}_{this.extra_hours}_{this.extra_hours}_{this.salary}_{this.balance}";
        }
        public static Staff Parse(string staff)
        {

            string[] details = staff.Split('_');
            Role r = (Role)Enum.Parse(typeof(Role), details[7]);
            return new Staff(details[0], details[1], details[2], details[3], details[4], details[5], details[6],
                r, int.Parse(details[8]),int.Parse(details[9]), decimal.Parse(details[10]), decimal.Parse(details[11]));
        }
    }