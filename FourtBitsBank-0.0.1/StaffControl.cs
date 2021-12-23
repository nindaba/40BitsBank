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
            initializeInfo();
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
        }
        private void initializeInfo()
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
             * normalHours.Text
             * extraHours.Text;
             */


            //Write your code above this is for clearing 
            normalHours.Text = extraHours.Text="0";
        }

    }
}
