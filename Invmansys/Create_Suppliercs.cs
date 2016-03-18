using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Invmansys
{
    public partial class Create_Suppliercs : Form
    {
        public Create_Suppliercs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Nametxt.Text != "")
            {
                SqlConnection supplier = new SqlConnection(Globals.dataconnection);
                supplier.Open();
                SqlCommand add = new SqlCommand("INSERT INTO Supplier(Name) VALUES(@name)", supplier);
                add.Parameters.AddWithValue("@name", Nametxt.Text);
                add.ExecuteNonQuery();
                supplier.Close();
                this.Close();
            }
        }
    }
}
