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
    public partial class Edit_Product : Form
    {
        public Edit_Product()
        {
            InitializeComponent();
        }

        private void Edit_Product_Load(object sender, EventArgs e)
        {
            SqlConnection items = new SqlConnection(Globals.dataconnection);
            SqlCommand show = new SqlCommand("SELECT * FROM Items WHERE Name = @name", items);
            items.Open();
            show.Parameters.AddWithValue("@name", Globals.p_Name);
            SqlDataReader reader = show.ExecuteReader();
            while (reader.Read())
            {
                Nametxt.Text = reader.GetString(1);
                Cost_Price.Text = reader.GetDecimal(5).ToString();
                Sale_Price.Text = reader.GetDecimal(6).ToString();
                Colour.Text = reader.GetString(4);
                Quantity.Text = reader.GetInt32(7).ToString();
                Weight.Text = reader.GetDecimal(3).ToString();
                Description.Text = reader.GetString(2);
            }

            items.Close();
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Nametxt.Text != "")
            {
                if (Sale_Price.Text != "")
                {
                    if (Cost_Price.Text != "")
                    {
                        if (Colour.Text != "")
                        {
                            if (Quantity.Text != "")
                            {
                                if (Weight.Text!= "")
                                {
                                    if (Description.Text != "")
                                    {
                                        SqlConnection items = new SqlConnection(Globals.dataconnection);
                                        SqlCommand edit = new SqlCommand("UPDATE Items SET Description = @description, Weight = @weight, Colour = @colour, CostPrice = @costprice, SalePrice = @saleprice, Stock = @stock WHERE Name = @name", items);
                                        items.Open();
                                        
                                        edit.Parameters.AddWithValue("@weight", Weight.Text);
                                        edit.Parameters.AddWithValue("@description", Description.Text);
                                        edit.Parameters.AddWithValue("@colour", Colour.Text);
                                        edit.Parameters.AddWithValue("@costprice", Cost_Price.Text);
                                        edit.Parameters.AddWithValue("@saleprice", Sale_Price.Text);
                                        edit.Parameters.AddWithValue("@stock", Quantity.Text);
                                        edit.Parameters.AddWithValue("@name", Nametxt.Text);
                                        edit.ExecuteNonQuery();
                                        items.Close();
                                        this.Close();
                                    }
                                    else { MessageBox.Show("Seems The Description Text Box Has Not Been Filled"); }
                                }
                                else { MessageBox.Show("Seems The Weight Text Box Has Not Been Filled"); }
                            }
                            else { MessageBox.Show("Seems The Quantity Text Box Has Not Been Filled"); }
                        }
                        else { MessageBox.Show("Seems Colour Text Box Has Not Been Filled"); }
                    }
                    else { MessageBox.Show("Seems Cost Text Box Has Not Been Filled"); }
                }
                else { MessageBox.Show("Seems Sales Price Text Box Has Not Been Filled"); }
            }
            else { MessageBox.Show("Seems Product Name Text Box Has Not Been Filled"); }
        }
    }
}
