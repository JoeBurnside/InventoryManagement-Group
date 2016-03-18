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
    public partial class Create_Account : Form
    {
        public Create_Account()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Nametxt.Text != "")
                {
                    if (Forename.Text != "")
                    {
                        if (Surname.Text != "")
                        {
                            if (Level.Text != "")
                            {
                                if (Email.Text != "")
                                {
                                    SqlConnection staff = new SqlConnection(Globals.dataconnection);
                                    staff.Open();
                                    SqlCommand add = new SqlCommand("INSERT INTO Staff(Username, Forename, Surname, Password, Level, Email) VALUES(@username, @forename, @surname, @password, @level, @email)", staff);
                                    add.Parameters.AddWithValue("@username", Nametxt.Text);
                                    add.Parameters.AddWithValue("@forename", Forename.Text);
                                    add.Parameters.AddWithValue("@surname", Surname.Text);
                                    add.Parameters.AddWithValue("@password", Password.Text);
                                    add.Parameters.AddWithValue("@level", Level.Text);
                                    add.Parameters.AddWithValue("@email", Email.Text);
                                    add.ExecuteNonQuery();
                                    staff.Close();
                                    this.Close();
                                }
                                else { MessageBox.Show("Seems Email Text Box Has Not Been Filled"); }
                            }
                            else { MessageBox.Show("Seems An Option Has Not Been Selected For Level"); }
                        }
                        else { MessageBox.Show("Seems Surname Text Box Has Not Been Filled"); }
                    }
                    else { MessageBox.Show("Seems Forename Text Box Has Not Been Filled"); }
                }
                else { MessageBox.Show("Seems Username Text Box Has Not Been Filled"); }
            }   
    }
}
