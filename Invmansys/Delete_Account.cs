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
    public partial class Delete_Account : Form
    {
        public Delete_Account()
        {
            InitializeComponent();
        }

        private void Delete_Account_Load(object sender, EventArgs e)
        {
            Account.Text = Globals.a_Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection account = new SqlConnection(Globals.dataconnection);
            account.Open();
            SqlCommand delete = new SqlCommand("DELETE FROM Staff WHERE Username = @name", account);
            delete.Parameters.AddWithValue("@name", Globals.a_Name);
            delete.ExecuteNonQuery();
            account.Close();
            this.Close();
        }
    }
}
