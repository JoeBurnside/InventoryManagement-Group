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
    public partial class Edit_Supplier : Form
    {
        public Edit_Supplier()
        {
            InitializeComponent();
        }
        int supplierno;

        private void Edit_Supplier_Load(object sender, EventArgs e)
        {
            SqlConnection supplier = new SqlConnection(Globals.dataconnection);
            SqlCommand show = new SqlCommand("SELECT * FROM Supplier WHERE Name = @name", supplier);
            supplier.Open();
            show.Parameters.AddWithValue("@name", Globals.s_Name);
            SqlDataReader reader = show.ExecuteReader();
            while (reader.Read())
            {
                supplierno = reader.GetInt32(0);
                Names.Text = reader.GetString(1);
            }
            supplier.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Names.Text != "")
            {
                SqlConnection supplier = new SqlConnection(Globals.dataconnection);
                SqlCommand edit = new SqlCommand("UPDATE Supplier SET Name = @name WHERE Id = @id", supplier);
                supplier.Open();
                edit.Parameters.AddWithValue("@name", Names.Text);
                edit.Parameters.AddWithValue("@id", supplierno);
                edit.ExecuteNonQuery();
                supplier.Close();
                this.Close();
            }
        }
    }
}
