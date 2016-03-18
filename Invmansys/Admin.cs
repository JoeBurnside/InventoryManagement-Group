using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invmansys
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void ProcessSale_Click(object sender, EventArgs e)
        {
            ProcessSale ProcessSale = new ProcessSale();
            ProcessSale.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Alert",
		MessageBoxButtons.OKCancel);
	    switch (result)
	    {
		case DialogResult.OK:
		    {
			this.Text = "[Logout]";
            Application.Exit();
			break;
		    }
		case DialogResult.Cancel:
		    {
			this.Text = "[Cancel]";
			break;
		    }
	    }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delivery Delivery = new Delivery();
            Delivery.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customerreturns Customerreturns = new Customerreturns();
            Customerreturns.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SupplierReturn SupplierReturn = new SupplierReturn();
            SupplierReturn.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reports Reports = new Reports();
            Reports.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_Suppliers Manage_Suppliers = new Manage_Suppliers();
            Manage_Suppliers.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Manage_Products Manage_Products = new Manage_Products();
            Manage_Products.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Manage_Accounts Manage_Accounts = new Manage_Accounts();
            Manage_Accounts.Show();
        }
    }
}
