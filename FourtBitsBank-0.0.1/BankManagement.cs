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
    public partial class BankManagement : Form
    {
        public BankManagement()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utils.display(new AddCustomer());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Utils.display(new ShowCustomer());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Utils.display(new AddStaff());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Utils.display(new ShowStaff());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
