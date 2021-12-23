using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourtBitsBank_0
{
    public partial class StaffControl : Form
    {
        public StaffControl()
        {
            InitializeComponent();
            initialize();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Utils.displayMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //TODO Pay all the staff balance
            //NOTE Remember to reflesh the user info data by putting new values
            //variable
            /*-----------------
             * balanceInfo.Text
             * extraHoursInfo.Text
             * unpaidHoursInfo.Text
             */
            Staff staff = Database.getStaff(Index.CURENT);
            staff.balance = staff.balance + ((int)staff.role * (staff.hours + Convert.ToDecimal(1.4) * staff.extra_hours));
            balanceInfo.Text = staff.balance.ToString();
            //Paying calculation ^^^^^^^
            staff.hours = 0;
            staff.extra_hours = 0;
            unpaidHoursInfo.Text = staff.hours.ToString();
            extraHoursInfo.Text= staff.extra_hours.ToString();
            MessageBox.Show(staff.balance.ToString());
            Database.updateStaff(staff);

        }
        private void initialize()
        {
            /*
             * WRITE CODE BELLOW THE COMMENTS AND DO NOT DELETE THE COMMENTS
             * 
             * TODO bind all your data to these variable to display
             * Variables
             * -----------------
             *balanceInfo.Text
             * extraHoursInfo.Text
             * unpaidHoursInfo.Text
             */
            Staff staff = Database.getStaff(Index.CURENT);
            balanceInfo.Text = staff.balance.ToString();
            customerId.Text = staff.staff_id;
            unpaidHoursInfo.Text = staff.hours.ToString();
            extraHoursInfo.Text = staff.extra_hours.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
             * WRITE CODE BELLOW THE COMMENTS AND DO NOT DELETE THE COMMENTS
             * 
             * TODO add hours to the customer account
             * NOTE REmember to reflesh the dada
             * variables
             * ---------------
             * normalHours.Value
             * extraHours.Value

             * BALANCE IS ~~~~~> (int) staff.role * (normalHours.Value + 1.4*extraHours.Value)
             * 
               */

            Staff staff = Database.getStaff(Index.CURENT);
            //balanceInfo.Text = ((int)staff.role * (normalHours.Value + Convert.ToDecimal(1.4) * extraHours.Value)).ToString();
            staff.hours = staff.hours + Convert.ToInt32(normalHours.Value);
            unpaidHoursInfo.Text = staff.hours.ToString();
            staff.extra_hours = staff.extra_hours + Convert.ToInt32(extraHours.Value);
            extraHoursInfo.Text = staff.extra_hours.ToString();
            Database.updateStaff(staff);
            MessageBox.Show($"Added {normalHours.Value} hours\nAdded {extraHours.Value} extra hours");

            normalHours.Text = extraHours.Text = "0";

        }

    }
}
