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
    public partial class Delivery : Form
    {
        public Delivery()
        {
            InitializeComponent();
        }
        int suppno, itemno, orderno;

        private void button1_Click(object sender, EventArgs e)
        {
            if (Product.Text != "")
            {
                SqlConnection supplier = new SqlConnection(Globals.dataconnection);
                SqlCommand edit = new SqlCommand("UPDATE Items SET Stock = Stock + @quantity WHERE Name = @name", supplier);
                supplier.Open();
                edit.Parameters.AddWithValue("@quantity", Quan.Value);
                edit.Parameters.AddWithValue("@name", listBox1.SelectedItem.ToString());
                edit.ExecuteNonQuery();
                supplier.Close();
                this.Close();
                SqlConnection supp = new SqlConnection(Globals.dataconnection);
                SqlCommand showsup = new SqlCommand("SELECT * FROM Supplier WHERE Name = @name", supp);
                supp.Open();
                showsup.Parameters.AddWithValue("@name", comboBox1.SelectedItem.ToString());
                SqlDataReader reader = showsup.ExecuteReader();
                while (reader.Read())
                {
                    suppno = reader.GetInt32(0);
                }
                supp.Close();
                SqlConnection returns = new SqlConnection(Globals.dataconnection);
                SqlCommand add = new SqlCommand("INSERT INTO SupplierTransaction (SupplierId, Date, TransactionType) VALUES (@staffid, @date, @type)", returns);
                supplier.Open();
                add.Parameters.AddWithValue("@staffid", suppno);
                add.Parameters.AddWithValue("@date", DateTime.Now.Date);
                add.Parameters.AddWithValue("@type", "Delivery");
                add.ExecuteNonQuery();
                returns.Close();
                SqlConnection item = new SqlConnection(Globals.dataconnection);
                SqlCommand show = new SqlCommand("SELECT * FROM Items WHERE Name = @name", item);
                item.Open();
                show.Parameters.AddWithValue("@name", listBox1.SelectedItem.ToString());
                SqlDataReader reader2 = show.ExecuteReader();
                while (reader2.Read())
                {
                    itemno = reader.GetInt32(0);
                }
                item.Close();
                SqlConnection trans = new SqlConnection(Globals.dataconnection);
                SqlCommand transac = new SqlCommand("SELECT * FROM SupplierTransaction", trans);
                trans.Open();
                SqlDataReader readers = show.ExecuteReader();
                while (readers.Read())
                {
                    orderno = reader.GetInt32(0);
                }
                trans.Close();
                SqlConnection transitem = new SqlConnection(Globals.dataconnection);
                SqlCommand addnew = new SqlCommand("INSERT INTO STransactionItem (SupplierTransactionId, ItemId, Quantity) VALUES (@transid, @itemid, @quantity)", transitem);
                supplier.Open();
                addnew.Parameters.AddWithValue("@transid", orderno);
                addnew.Parameters.AddWithValue("@itemid", itemno);
                addnew.Parameters.AddWithValue("@quantity", Quan.Value);
                addnew.ExecuteNonQuery();
                transitem.Close();
            }
        }

        private void Delivery_Load(object sender, EventArgs e)
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
            comboBox1.Items.Clear();
            SqlConnection supplier = new SqlConnection(Globals.dataconnection);
            SqlCommand combo = new SqlCommand("SELECT Name FROM Supplier", supplier);
            products.Open();
            SqlDataReader reader1 = show.ExecuteReader();
            while (reader1.Read())
            {
                comboBox1.Items.Add(reader[0]);
            }
            supplier.Close();
        }

        private void Product_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection products = new SqlConnection(Globals.dataconnection);
            SqlCommand show = new SqlCommand("SELECT Name FROM Items WHERE Name LIKE @search", products);
            products.Open();
            show.Parameters.AddWithValue("@search", "%" + Product.Text + "%");
            SqlDataReader reader = show.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader[0]);
            }
            products.Close();
        }
    }
}
