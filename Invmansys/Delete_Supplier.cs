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
    public partial class Delete_Supplier : Form
    {
        public Delete_Supplier()
        {
            InitializeComponent();
        }

        private void Delete_Supplier_Load(object sender, EventArgs e)
        {
            Supplyer.Text = Globals.s_Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection supplier = new SqlConnection(Globals.dataconnection);
            supplier.Open();
            SqlCommand delete = new SqlCommand("DELETE FROM Supplier WHERE Name = @name", supplier);
            delete.Parameters.AddWithValue("@name", Globals.s_Name);
            delete.ExecuteNonQuery();
            supplier.Close();
            this.Close();
        }
    }
}
