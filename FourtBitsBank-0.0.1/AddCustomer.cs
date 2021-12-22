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
        
        private Boolean isAdd;
        public AddCustomer(Boolean isAdd = true)
        {
            InitializeComponent();
            plan.Items.Add(Plan.PLAN1);
            plan.Items.Add(Plan.PLAN2);
            plan.Items.Add(Plan.PLAN3);
            plan.SelectedIndex = 0;
            this.isAdd = isAdd;
            initialize();
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            clearInputs();
            Utils.displayMenu();
        }

        private void add_Or_Edit_Click(object sender, EventArgs e)
        {
            /*
             * NOTE DO NOT DELETE THE COMEMENTS WRITE THE CODE BELLOW
             * TODO Write code for saving under the comment Note to create the random Ids
             * 
             * 
             * contact.Text
             * email.Text
             * address.Text
             * balance.Text 
             * profilePicture.ImageLocation.ToString();
             * plan.SelectedIndex
             * customerId.Text
             * accountNumbeer.Text
            // */
            
            clearInputs();
            //Random random = new Random();
            //int CustomerIdRandom = random.Next(10000, 99999);
            //customerId.Text += CustomerIdRandom.ToString();
            //int AccountNumberRandom = random.Next(10000, 99999);
            //accountNumbeer.Text += AccountNumberRandom.ToString();
            //MessageBox.Show("Check the IDs");
            if (isAdd)
            {
                Customer customer = new Customer(
                    name.Text,
                    lastName.Text,
                    contact.Text,
                    email.Text,
                    address.Text,
                    profilePicture.ImageLocation.ToString(),
                    balance.Value,
                    accountNumber.Text,
                    customerId.Text
                    ) ;
                Database.saveCustomer(customer);    
            }
            else
            {
                //put the save code here
            }
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
        private void initialize()
        {
            //profilePicture.ImageLocation = "images/default.png";
            if (!isAdd)
            {
                /*
                * NOTE DO NOT DELETE THE COMEMENTS WRITE THE CODE BELLOW
                * TODO Write code for for loading the customer data in the the following valiables this is done when you load the customer for editing
                * TODO as you can see you are in !isAdd "not is add"
                * lastName.Text
                * contact.Text
                * email.Text
                * address.Text
                * balance.Text 
                * profilePicture.ImageLocation.ToString();
                * plan.SelectedIndex
                * customerId.Text
                * accountNumbeer.Text
                * savings
                * 
                */
                Customers customers;
                
                addOrEditButton.Text = "Modify";
                balance.Visible = false;
                balanceLabel.Visible = false;
                modifyBalance.Text = balance.Text;
            }
            else
            {
                accountNumber.Text = Utils.generateAccountNumber();
                customerId.Text = Utils.generateId();
                modifyBalanceLabel.Visible = false;
                modifySavingLabel.Visible = false;
                modifyBalance.Visible = false;
                modifySavings.Visible = false;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
