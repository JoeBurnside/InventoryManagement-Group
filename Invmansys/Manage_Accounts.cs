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
    public partial class Manage_Accounts : Form
    {
        public Manage_Accounts()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String edit = AccList.SelectedItem.ToString();
            if (edit == "")
            {
                MessageBox.Show("Please Select A User");
            }
            else
            {
                Globals.a_Name = edit;
                Edit_Account Edit_Account = new Edit_Account();
                Edit_Account.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_Account Create_Account = new Create_Account();
            Create_Account.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String del = AccList.SelectedItem.ToString();
            if (del == "")
            {
                MessageBox.Show("Please Select A User");
            }
            else
            {
                Globals.a_Name = del;
                Delete_Account Delete_Account = new Delete_Account();
                Delete_Account.Show();
            }
        }

        private void Manage_Accounts_Load(object sender, EventArgs e)
        {
            AccList.Items.Clear();
            SqlConnection staff = new SqlConnection(Globals.dataconnection);
            SqlCommand show = new SqlCommand("SELECT Username FROM Staff", staff);
            staff.Open();
            SqlDataReader reader = show.ExecuteReader();
            while (reader.Read())
            {
                AccList.Items.Add(reader[0]);
            }
            staff.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AccList.Items.Clear();
            SqlConnection staff = new SqlConnection(Globals.dataconnection);
            SqlCommand show = new SqlCommand("SELECT Username FROM Staff WHERE Username LIKE @search", staff);
            staff.Open();
            show.Parameters.AddWithValue("@search", "%" + textBox1.Text + "%");
            SqlDataReader reader = show.ExecuteReader();
            while (reader.Read())
            {
                AccList.Items.Add(reader[0]);
            }
            staff.Close();
        }

        private void AccList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
