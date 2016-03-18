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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void ProcessSale_Click(object sender, EventArgs e)
        {
            ProcessSale ProcessSale = new ProcessSale();
            ProcessSale.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Customerreturns Customerreturns = new Customerreturns();
            Customerreturns.Show();
        }
    }
}
