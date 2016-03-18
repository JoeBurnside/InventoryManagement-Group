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
    public partial class Edit_Account : Form
    {
        public Edit_Account()
        {
            InitializeComponent();
        }

        private void Edit_Account_Load(object sender, EventArgs e)
        {
            SqlConnection staff = new SqlConnection(Globals.dataconnection);
            SqlCommand show = new SqlCommand("SELECT * FROM Staff WHERE UserName = @name", staff);
            staff.Open();
            show.Parameters.AddWithValue("@name", Globals.a_Name);
            SqlDataReader reader = show.ExecuteReader();
            while (reader.Read())
            {
                Nametxt.Text = reader.GetString(1);
                Forename.Text = reader.GetString(2);
                Surname.Text = reader.GetString(3);
                Level.Text = reader.GetString(5);
                Email.Text = reader.GetString(6);
                Password.Text = reader.GetString(4);
            }
            staff.Close();
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
                                    SqlConnection supplier = new SqlConnection(Globals.dataconnection);
                                    SqlCommand edit = new SqlCommand("UPDATE Staff SET Forename = @forename, Surname = @surname, Password = @password, Level = @level, Email = @email WHERE Username = @username", supplier);
                                    supplier.Open();
                                    
                                    edit.Parameters.AddWithValue("@forename", Forename.Text);
                                    edit.Parameters.AddWithValue("@surname", Surname.Text);
                                    edit.Parameters.AddWithValue("@password", Password.Text);
                                    edit.Parameters.AddWithValue("@level", Level.Text);
                                    edit.Parameters.AddWithValue("@email", Email.Text);
                                    edit.Parameters.AddWithValue("@username", Nametxt.Text);
                                    edit.ExecuteNonQuery();
                                    supplier.Close();
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

        private void Level_SelectedIndexChanged(object sender, EventArgs e)
        {

        } 
        }
    }
