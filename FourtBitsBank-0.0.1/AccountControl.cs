﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO this is where you withdraw
            /*
             * variables
             * ---------
             * withdraw.Valvue
             */
            Customer customer = Database.getCustomer(Index.CURENT);
            decimal result = customer.balance - decimal.Parse(withdraw.Text);
            if (withdraw.Value > customer.balance)
            {
                MessageBox.Show("Withdraw amount is more than balance");
                return;
            }
            else
            customer.balance = result;
            balance.Text = customer.balance.ToString();
            MessageBox.Show($"Withdrawed {withdraw.Text} from the balance");
            Database.updateCustomer(customer);
            clearInputs();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TODO this is where you move to savings
            /*
             * variables
             * ---------
             * move.Text
             */
            Customer customer = Database.getCustomer(Index.CURENT);
            decimal result = customer.balance - decimal.Parse(move.Text);

            if (move.Value > customer.balance)  
            {
                MessageBox.Show("Moving amount is more than balance");
                return;
            }
            else 
            customer.savings += decimal.Parse(move.Text);
            customer.balance= result;
            balance.Text=customer.balance.ToString();
            savings.Text = customer.savings.ToString();
            MessageBox.Show($"Moved {move.Text} to the savings");
            Database.updateCustomer(customer);
            clearInputs();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //TODO this is where you deposit
            //Note remember to reflesh the account info
            /*
             * variables
             * ---------
             * deposit.value
             */
            Customer customer = Database.getCustomer(Index.CURENT);
            decimal result = customer.balance + deposit.Value;
            customer.balance = result;
            balance.Text = customer.balance.ToString();
            MessageBox.Show($"Deposited {deposit.Value} to the the balance");
            Database.updateCustomer(customer);
            clearInputs();
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
            Customer customer = Database.getCustomer(Index.CURENT);
            customerId.Text = customer.customerId;
            accountNumbeer.Text = customer.accountNumber;
            balance.Text = customer.balance.ToString();
            savings.Text = customer.savings.ToString();
        }
        private void clearInputs()
        {
            deposit.Value = move.Value = withdraw.Value = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Utils.display(new ShowCustomer());
        }
    }
}
