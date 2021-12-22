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
            role.Items.Add(Role.ROLE1);
            role.Items.Add(Role.ROLE2);
            role.Items.Add(Role.ROLE3);
            role.Items.Add(Role.ROLE4);
            role.SelectedIndex = 0;
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
                    name.Text,
                    lastName.Text,
                    contact.Text,
                    email.Text,
                    address.Text,
                    profilePicture.ImageLocation.ToString(),
                    Utils.generateId(),
                    (Role) role.SelectedIndex,
                    0,
                    0,
                    0,
                    0);
           // Database
            clearInputs();
            Utils.display(new BankManagement());
        }
        private void clearInputs()
        {
            name.Text = lastName.Text = contact.Text = email.Text = address.Text = balance.Text = "";
        }

        private void chooseProfile_Click(object sender, EventArgs e)
        {
            Utils.selectPicture(profilePicture);
        }
    }
}
