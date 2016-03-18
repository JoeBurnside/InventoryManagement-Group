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
    public partial class Manage_Suppliers : Form
    {
        public Manage_Suppliers()
        {
            InitializeComponent();
        }
        String selection;
        private void button2_Click(object sender, EventArgs e)
        {
            String del = SupList.SelectedItem.ToString();
            String select = selection.ToString();
            if (select == "")
            {
                MessageBox.Show("Please Select A Supplier");
            }
            else
            {
                Globals.s_Name = del;
                Delete_Supplier Delete_Supplier = new Delete_Supplier();
                Delete_Supplier.Show();
            }
        }

        private void SupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selection = "True";
        }

        private void Manage_Suppliers_Load(object sender, EventArgs e)
        {
            SupList.Items.Clear();
            SqlConnection supplier = new SqlConnection(Globals.dataconnection);
            SqlCommand show = new SqlCommand("SELECT Name FROM Supplier", supplier);
            supplier.Open();
            SqlDataReader reader = show.ExecuteReader();
            while (reader.Read())
            {
                SupList.Items.Add(reader[0]);
            }
            supplier.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_Suppliercs Create_Suppliercs = new Create_Suppliercs();
            Create_Suppliercs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String del = SupList.SelectedItem.ToString();
            String select = selection.ToString();
            if (select == "")
            {
                MessageBox.Show("Please Select A User");
            }
            else
            {
                Globals.s_Name = del;
                Edit_Supplier Edit_Supplier = new Edit_Supplier();
                Edit_Supplier.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SupList.Items.Clear();
            SqlConnection supplier = new SqlConnection(Globals.dataconnection);
            SqlCommand show = new SqlCommand("SELECT Name FROM Supplier WHERE Name LIKE @search", supplier);
            supplier.Open();
            show.Parameters.AddWithValue("@search", "%" + textBox1.Text + "%");
            SqlDataReader reader = show.ExecuteReader();
            while (reader.Read())
            {
                SupList.Items.Add(reader[0]);
            }
            supplier.Close();
        }
    }
}
