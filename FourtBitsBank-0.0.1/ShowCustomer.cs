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
            initialize();
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
        private void prevClick(object sender, EventArgs e)
        {
            //TODO show the prev
            /*
            * current.Text  //this is for the pagination;showing the current page << 1/10 >>
            * outOf.Text    //this is for the pagination;showing the current page << 1/10 >>
            */
            initialize(Index.PREV);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //TODO show the next
            /*
            * current.Text  //this is for the pagination;showing the current page << 1/10 >>
            * outOf.Text    //this is for the pagination;showing the current page << 1/10 >>
            */
            initialize(Index.NEXT);
        }

        private void editCustomer(object sender, EventArgs e)
        {
            AddCustomer editCustomer = new AddCustomer(false);
            Utils.display(editCustomer);
        }
        private void initialize(Index index = 0)
        {
            /*
            * lastName.Text
            * contact.Text
            * email.Text
            * address.Text
            * balance.Text 
            * profilePicture.ImageLocation.ToString();
            * plan.SelectedDatabase.customerIndex
            * customerId.Text
            * accountNumbeer.Text
            * balance.TexT
            * savings.Text
            * plan.Text
            * current.Text  //this is for the pagination;showing the current page << 1/10 >>
            * outOf.Text    //this is for the pagination;showing the current page << 1/10 >>
            */
            Customer customer = Database.getCustomer(index);
            name.Text = customer.name;
            lastName.Text = customer.lastname;
            contact.Text = customer.contact;
            email.Text = customer.email;
            address.Text = customer.adress;
            balance.Text = customer.balance.ToString();
            profilePicture.ImageLocation = customer.profilePic;
            current.Text = "" + (Database.customerIndex + 1);
            customerId.Text = customer.customerId;
            accountNumbeer.Text = customer.accountNumber;
            savings.Text = customer.savings.ToString();
            outOf.Text =" / "+ Database.maxCustomers.ToString();
            plan.Text = customer.plan.ToString();

            //Bonusssss
            button3.Enabled = Database.customerIndex+1 != Database.maxCustomers;
            button2.Enabled = Database.customerIndex != 0;
        }
    }
}
