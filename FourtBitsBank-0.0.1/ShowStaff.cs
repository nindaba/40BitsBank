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
    public partial class ShowStaff : Form
    {
        public ShowStaff()
        {
            InitializeComponent();
        }

        private void controlBalance_Click(object sender, EventArgs e)
        {
            Utils.display(new StaffControl());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utils.displayMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TODO Show prev staff
            /*
            *currentStaff.Text for showing current page << 12 / 30 >>
            *outOfStaff.Text for showing current page << 12 / 30 >> Max staf
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //TODO sho next staff
            /*
             * 
             * Variables
             * -----------
             * currentStaff.Text for showing current page << 12/30 >>
             * outOfStaff.Text for showing current page << 12/30 >> Max staf
             */
        }
        public void initializeInfo()
        {
            /*
             * TODO Initialize all the variables
             * ----------------------------------
             * name.Text
             * lastName.Text
             * email.Text
             * address.Text
             * balance.Text 
             * role.Text
             * balance.Text
             * hours.Text
             * extraHours.Text
             * salary.Text
             */

        }
    }
}
