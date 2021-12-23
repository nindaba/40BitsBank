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
            if (isAdd) Utils.displayMenu();
            else Utils.display(new ShowCustomer());
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
             * plan.SelectedValue
             * customerId.Text
             * accountNumbeer.Text
             */
            if (isValid())
            {
                Customer customer = new Customer(customerId.Text,
                    name.Text,
                    lastName.Text,
                    contact.Text,
                    email.Text,
                    address.Text,
                    profilePicture.ImageLocation.ToString(),
                    balance.Value,
                    accountNumber.Text,
                    (Plan) plan.SelectedIndex,
                    Decimal.Parse(modifySavings.Text)
                    );
                if (isAdd)
                {
                    Database.saveCustomer(customer);
                    Utils.displayMenu();
                }
                else
                {
                    Database.updateCustomer(customer);
                    Utils.display(new ShowCustomer());
                }

                clearInputs();
            }
            else MessageBox.Show("Wrong Input Data");
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
            profilePicture.ImageLocation = @"images/default.png";
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
                * plan.SelectedValue
                * customerId.Text
                * accountNumbeer.Text
                * savings
                * 
                */


                Customer customer = Database.getCustomer(Index.CURENT);

                name.Text = customer.name;
                lastName.Text = customer.lastname;
                contact.Text = customer.contact;
                email.Text = customer.email;
                address.Text = customer.adress;
                balance.Text = customer.balance.ToString();
                profilePicture.ImageLocation = customer.profilePic;
                plan.SelectedValue = customer.plan;
                customerId.Text = customer.customerId;
                accountNumber.Text = customer.accountNumber;
                modifySavings.Text = customer.savings.ToString();






                title.Text = "Edit Customer";               
                addOrEditButton.Text = "Modify";
                balance.Visible = false;
                balanceLabel.Visible = false;
                modifyBalance.Text = balance.Text;
            }
            else
            {
                accountNumber.Text = Database.generateAccountNumber();
                customerId.Text = Database.nextCustomerId();
                modifyBalanceLabel.Visible = false;
                modifySavingLabel.Visible = false;
                modifyBalance.Visible = false;
                modifySavings.Visible = false;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        Boolean isValid()
        {
            return !(
                name.Text.Equals("") &&
                lastName.Text.Equals("") &&
                contact.Text.Equals("") &&
                email.Text.Equals("") &&
                address.Text.Equals("")
                );
        }
    }
}
