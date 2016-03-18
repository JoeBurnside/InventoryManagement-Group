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
    public partial class Customerreturns : Form
    {
        public Customerreturns()
        {
            InitializeComponent();

        }
        int orderno, itemno;

        private void button1_Click(object sender, EventArgs e)
        {
            if (Productname.Text != "")
            {
                SqlConnection supplier = new SqlConnection(Globals.dataconnection);
                SqlCommand edit = new SqlCommand("UPDATE Items SET Stock = Stock + @quantity WHERE Name = @name", supplier);
                supplier.Open();
                edit.Parameters.AddWithValue("@quantity", Quan.Value);
                edit.Parameters.AddWithValue("@name", listBox1.SelectedItem.ToString());
                edit.ExecuteNonQuery();
                supplier.Close();
                SqlConnection returns = new SqlConnection(Globals.dataconnection);
                SqlCommand add = new SqlCommand("INSERT INTO CustomerTransaction (StaffId, Date, TransactionType) VALUES (@staffid, @date, @type)", returns);
                supplier.Open();
                add.Parameters.AddWithValue("@staffid", Globals.s_Number);
                add.Parameters.AddWithValue("@date", DateTime.Now.Date);
                add.Parameters.AddWithValue("@type", "Return");
                add.ExecuteNonQuery();
                returns.Close();
                SqlConnection item = new SqlConnection(Globals.dataconnection);
                SqlCommand show = new SqlCommand("SELECT * FROM Items WHERE Name = @name", item);
                item.Open();
                show.Parameters.AddWithValue("@name", Productname.Text);
                SqlDataReader reader = show.ExecuteReader();
                while (reader.Read())
                {
                    itemno = reader.GetInt32(0);
                }
                item.Close();
                SqlConnection trans = new SqlConnection(Globals.dataconnection);
                SqlCommand transac = new SqlCommand("SELECT * FROM CustomerTransaction", trans);
                trans.Open();
                SqlDataReader readers = show.ExecuteReader();
                while (readers.Read())
                {
                    orderno = reader.GetInt32(0);
                }
                trans.Close();
                SqlConnection transitem = new SqlConnection(Globals.dataconnection);
                SqlCommand addnew = new SqlCommand("INSERT INTO CTransactionItem (CustomerTransactionId, ItemId, Quantity) VALUES (@transid, @itemid, @quantity)", transitem);
                supplier.Open();
                addnew.Parameters.AddWithValue("@transid", orderno);
                addnew.Parameters.AddWithValue("@itemid", itemno);
                addnew.Parameters.AddWithValue("@quantity", Quan.Value);
                addnew.ExecuteNonQuery();
                transitem.Close();
                this.Close();
            }
        }

        private void Customerreturns_Load(object sender, EventArgs e)
        {
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

        private void Productname_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection products = new SqlConnection(Globals.dataconnection);
            SqlCommand show = new SqlCommand("SELECT Name FROM Items WHERE Name LIKE @search", products);
            products.Open();
            show.Parameters.AddWithValue("@search", "%" + Productname.Text + "%");
            SqlDataReader reader = show.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader[0]);
            }
            products.Close();
        }

        private void Quan_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
