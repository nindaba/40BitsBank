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
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
            initialize();
        }

        private void initialize()
        {
            profilePicture.ImageLocation = @"images/default.png";
            role.Items.Add(Role.DIRECTOR);
            role.Items.Add(Role.CASHIER);
            role.Items.Add(Role.ACCOUNTANT);
            role.Items.Add(Role.MANAGER);
            role.SelectedIndex = 0;
            staffId.Text = Database.nextStaffId();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            clearInputs();
            Utils.display(new BankManagement());
        }

        private void add_Click_1(object sender, EventArgs e)
        {
            //TODO Write code for saving under the comment Note to create the random Ids
            /*
             * variables
             * --------------
             * name.Text
             * lastName.Text
             * contact.Text
             * email.Text
             * address.Text
             * balance.Text 
             * profilePicture.ImageLocation.ToString();
             * role.SelectedIndex
             * staffId.Text
             */
            Staff staff = new Staff(
                    staffId.Text,
                    name.Text,
                    lastName.Text,
                    contact.Text,
                    email.Text,
                    address.Text,
                    profilePicture.ImageLocation.ToString(),
                    (Role)role.SelectedItem,
                    0,                    
                    0,
                    balance.Value);
            if (isValid())
            {
                Database.saveStaff(staff);
                clearInputs();
                Utils.display(new BankManagement());
            }
            else MessageBox.Show("Please fill in all the staff details");
        }
        private void clearInputs()
        {
            name.Text = lastName.Text = contact.Text = email.Text = address.Text = balance.Text = "";
        }
        private void chooseProfile_Click_1(object sender, EventArgs e)
        {
            Utils.selectPicture(profilePicture);
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
