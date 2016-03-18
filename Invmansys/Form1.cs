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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Globals.s_Number = 3;
            Staff Main = new Staff();
            Main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.s_Number = 3;
            Staff Staff = new Staff();
            Staff.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Globals.s_Number = 2;
            Manager Manager = new Manager();
            Manager.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Globals.s_Number = 1;
            Admin Admin = new Admin();
            Admin.Show();
        }
    }
}
