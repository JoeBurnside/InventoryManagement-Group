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
    public partial class Create_Product : Form
    {
        public Create_Product()
        {
            InitializeComponent();
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
                                        SqlConnection product = new SqlConnection(Globals.dataconnection);
                                        product.Open();
                                        SqlCommand add = new SqlCommand("INSERT INTO Items(Name, Description, Weight, Colour, CostPrice, SalePrice, Stock) VALUES(@name, @description, @weight, @colour, @costprice, @saleprice, @stock)", product);
                                        add.Parameters.AddWithValue("@name", Nametxt.Text);
                                        add.Parameters.AddWithValue("@description", Description.Text);
                                        add.Parameters.AddWithValue("@weight", Weight.Text);
                                        add.Parameters.AddWithValue("@colour", Colour.Text);
                                        add.Parameters.AddWithValue("@costprice", Cost_Price.Text);
                                        add.Parameters.AddWithValue("@saleprice", Sale_Price.Text);
                                        add.Parameters.AddWithValue("@stock", Quantity.Text);
                                        add.ExecuteNonQuery();
                                        product.Close();
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
