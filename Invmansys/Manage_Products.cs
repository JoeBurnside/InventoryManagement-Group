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
    public partial class Manage_Products : Form
    {
        public Manage_Products()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String edit = ProList.SelectedItem.ToString();
            if (edit == "")
            {
                MessageBox.Show("Please Select A User");
            }
            else
            {
                Globals.p_Name = edit;
                Edit_Product Edit_Product = new Edit_Product();
                Edit_Product.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_Product Create_Product = new Create_Product();
            Create_Product.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String del = ProList.SelectedItem.ToString();
            if (del == "")
            {
                MessageBox.Show("Please Select A User");
            }
            else
            {
                Globals.p_Name = del;
                Delete_Product Delete_Product = new Delete_Product();
                Delete_Product.Show();
            }
        }

        private void Manage_Products_Load(object sender, EventArgs e)
        {
            ProList.Items.Clear();
            SqlConnection products = new SqlConnection(Globals.dataconnection);
            SqlCommand show = new SqlCommand("SELECT Name FROM Items", products);
            products.Open();
            SqlDataReader reader = show.ExecuteReader();
            while (reader.Read())
            {
                ProList.Items.Add(reader[0]);
            }
            products.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ProList.Items.Clear();
            SqlConnection products = new SqlConnection(Globals.dataconnection);
            SqlCommand show = new SqlCommand("SELECT Name FROM Items WHERE Name LIKE @search", products);
            products.Open();
            show.Parameters.AddWithValue("@search", "%" + textBox1.Text + "%");
            SqlDataReader reader = show.ExecuteReader();
            while (reader.Read())
            {
                ProList.Items.Add(reader[0]);
            }
            products.Close();
        }
    }
}
