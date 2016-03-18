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
    public partial class ProcessSale : Form
    {
        public ProcessSale()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Insert(0, listBox1.SelectedItem.ToString(), 1,Quan.Value);
        }

        private void ProcessSale_Load(object sender, EventArgs e)
        {

            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Name = "ProductName";
            dataGridView1.Columns[1].Name = "Quantity"; 
            listBox1.Items.Clear();
            SqlConnection products = new SqlConnection(Globals.dataconnection);
            SqlCommand show = new SqlCommand("SELECT Name FROM Items", products);
            products.Open();
            SqlDataReader reader = show.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader[0]);
            }
            products.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection products = new SqlConnection(Globals.dataconnection);
            SqlCommand show = new SqlCommand("SELECT Name FROM Items WHERE Name LIKE @search", products);
            products.Open();
            show.Parameters.AddWithValue("@search", "%" + textBox1.Text + "%");
            SqlDataReader reader = show.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader[0]);
            }
            products.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
