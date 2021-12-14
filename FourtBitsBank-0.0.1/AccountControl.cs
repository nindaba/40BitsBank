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
    public partial class accountControl : Form
    {
        public accountControl()
        {
            InitializeComponent();
            InitializeAccount();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Utils.displayMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO this is where you withdraw
            /*
             * variables
             * ---------
             * withdraw.Text
             */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TODO this is where you move to savings
            /*
             * variables
             * ---------
             * move.Text
             */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //TODO this is where you deposit
            //Note remember to reflesh the account info
            /*
             * variables
             * ---------
             * deposit.Text
             */
        }
        private void InitializeAccount()
        {
            /*
             * TODO Set the variables bellow to your data in order to show on the UI
             * variables
             * -----------------
             * customerId.Text
             * accountNumbeer.Text
             * balance.Text
             * savings.Text
             */
        }
    }
}
