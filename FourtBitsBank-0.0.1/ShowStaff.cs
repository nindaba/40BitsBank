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
            initialize();
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
            initialize(Index.PREV);
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
            initialize(Index.NEXT);
        }
        public void initialize(Index index =0)
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
            Staff staff = Database.getStaff(index);

            name.Text = staff.name;
            lastName.Text = staff.lastname;
            email.Text = staff.email;
            address.Text = staff.adress;
            balance.Text = staff.balance.ToString();
            role.Text = staff.role.ToString();
            hours.Text = staff.hours.ToString();
            extraHours.Text = staff.extra_hours.ToString();
            salary.Text = staff.salary.ToString();
            page.Text = (Database.staffIndex + 1)+" / "+ Database.maxStaffs;
        }
    }
}
