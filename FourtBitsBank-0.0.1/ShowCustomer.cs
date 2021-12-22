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
    public partial class ShowCustomer : Form
    {
        public ShowCustomer()
        {
            InitializeComponent();
        }

        private void controlBalance_Click(object sender, EventArgs e)
        {
            Utils.display(new accountControl());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utils.displayMenu();
        }

        private void changeProfile_Click(object sender, EventArgs e)
        {
            Utils.selectPicture(profilePicture);
        }
        /*
        * lastName.Text
        * contact.Text
        * email.Text
        * address.Text
        * balance.Text 
        * profilePicture.ImageLocation.ToString();
        * plan.SelectedIndex
        * customerId.Text
        * accountNumbeer.Text
        * balance.TexT
        * savings.Text
        * plan.Text
        * current.Text  //this is for the pagination;showing the current page << 1/10 >>
        * outOf.Text    //this is for the pagination;showing the current page << 1/10 >>
        */
        private void button2_Click(object sender, EventArgs e)
        {
            //TODO show the prev
            /*
            * current.Text  //this is for the pagination;showing the current page << 1/10 >>
            * outOf.Text    //this is for the pagination;showing the current page << 1/10 >>
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //TODO show the next
            /*
            * current.Text  //this is for the pagination;showing the current page << 1/10 >>
            * outOf.Text    //this is for the pagination;showing the current page << 1/10 >>
            */
        }

        private void editCustomer(object sender, EventArgs e)
        {

            AddCustomer editCustomer = new AddCustomer(false);
            Utils.display(editCustomer);
        }
    }
}
