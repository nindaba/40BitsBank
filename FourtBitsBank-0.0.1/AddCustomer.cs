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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
            plan.Items.Add(Plan.PLAN1);
            plan.Items.Add(Plan.PLAN2);
            plan.Items.Add(Plan.PLAN3);
            plan.SelectedIndex = 0;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            clearInputs();
            Utils.displayMenu();
        }

        private void add_Click(object sender, EventArgs e)
        {
            /*
             * NOTE DO NOT DELETE THE COMEMENTS WRITE THE CODE BELLOW
             * TODO Write code for saving under the comment Note to create the random Ids
             * 
             * lastName.Text
             * contact.Text
             * email.Text
             * address.Text
             * balance.Text 
             * profilePicture.ImageLocation.ToString();
             * plan.SelectedIndex
             * customerId.Text
             * accountNumbeer.Text
             */
            clearInputs();
            Utils.displayMenu();
        }
        private void clearInputs()
        {
            name.Text = lastName.Text = contact.Text = email.Text = address.Text = balance.Text = "";
        }

        private void chooseProfile_Click(object sender, EventArgs e)
        {
            Utils.selectPicture(profilePicture);
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
