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
    public partial class Delete_Product : Form
    {
        public Delete_Product()
        {
            InitializeComponent();
        }

        private void Delete_Product_Load(object sender, EventArgs e)
        {
            Product.Text = Globals.p_Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection product = new SqlConnection(Globals.dataconnection);
            product.Open();
            SqlCommand delete = new SqlCommand("DELETE FROM Items WHERE Name = @name", product);
            delete.Parameters.AddWithValue("@name", Globals.p_Name);
            delete.ExecuteNonQuery();
            product.Close();
            this.Close();
        }
    }
}
