using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string dbConnectionString = "Data Source=ELIS_LAPTOP\\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True";


        private void button1_Click(object sender, EventArgs e)
        {
            addProducdNameTxtBx.Visible = true;
            addProductPriceTxtBx.Visible = true;
            addProductQuantityTxtBx.Visible = true;
            AddProductNameLbl.Visible = true;
            laAddProductPriceLbl.Visible = true;
            AddProductQuantityLbl.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addProductPriceTxtBx_TextChanged(object sender, EventArgs e)
        {
            generateAddToDbBtn();

        }

        private void addProductQuantityTxtBx_TextChanged(object sender, EventArgs e)
        {
            generateAddToDbBtn();
        }

        private void generateAddToDbBtn()
        {
            if (addProductQuantityTxtBx.Text != "" && addProducdNameTxtBx.Text != "" && addProductPriceTxtBx.Text != "")
            {
                AddProductAddBtn.Visible = true;
            }
            else
            {
                AddProductAddBtn.Visible = false;
            }
            return;
        }

        private void addProducdNameTxtBx_TextChanged(object sender, EventArgs e)
        {
            generateAddToDbBtn();

        }

        private void AddProductAddBtn_Click(object sender, EventArgs e)
        {
            //bool successed = Product.addProduct(Convert.ToString(addProducdNameTxtBx), Convert.ToDecimal(addProductPriceTxtBx), Convert.ToInt32(addProductQuantityTxtBx));

            bool success = Product.addProduct(Convert.ToString(addProducdNameTxtBx.Text), Convert.ToDecimal(addProductPriceTxtBx.Text), Convert.ToInt32(addProductQuantityTxtBx.Text));
            if (success == true)
            {
                MessageBox.Show("Product added successfully");
            }
            else
            {
                MessageBox.Show("Failed to add product");
            }

            
        }
    }
}
