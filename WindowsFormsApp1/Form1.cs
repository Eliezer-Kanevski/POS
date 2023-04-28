using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddCustomerPhoneTxtBx.Enter += AddCustomerPhoneTxtBx_Enter;
            AddCustomerEmailTxtBx.Enter += AddCustomerEmailTxtBx_Enter;

        }
        public static string dbConnectionString = "Data Source=ELIS_LAPTOP\\SQLEXPRESS;Initial Catalog=POSDB;Integrated Security=True";


        private void button1_Click(object sender, EventArgs e)
        {
            addProducdNameTxtBx.Visible = true;
            addProductQuantityTxtBx.Visible = true;
            addProductPriceTxtBx.Visible = true;
            AddProductNameLbl.Visible = true;
            laAddProductPriceLbl.Visible = true;
            AddProductQuantityLbl.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addProductPriceTxtBx_TextChanged(object sender, EventArgs e)
        {
            generateAddProductToDbBtn();

        }

        private void addProductQuantityTxtBx_TextChanged(object sender, EventArgs e)
        {
            generateAddProductToDbBtn();
        }

        private void generateAddProductToDbBtn()
        {
            if (addProductPriceTxtBx.Text != "" && addProducdNameTxtBx.Text != "" && addProductQuantityTxtBx.Text != "")
            {
                AddProductAddBtn.Visible = true;
            }
            else
            {
                AddProductAddBtn.Visible = false;
            }
            return;
        }

        private void generateAddCustomerToDbBtn()
        {
            if (AddCustomerNameTxtBx.Text != "" && AddCustomerEmailTxtBx.Text != "" && AddCustomerPhoneTxtBx.Text != "" && AddCustomerAddressTxtBx.Text != "")
            {
                AddCustomerAddBtn.Visible = true;
            }
            else
            {
                AddCustomerAddBtn.Visible = false;
            }
            return;
        }

        private void addProducdNameTxtBx_TextChanged(object sender, EventArgs e)
        {
            generateAddProductToDbBtn();

        }

        private void AddProductAddBtn_Click(object sender, EventArgs e)
        {
            bool success;
            if (decimal.TryParse(addProductPriceTxtBx.Text, out decimal price) && int.TryParse(addProductQuantityTxtBx.Text, out int quantity))
            {
                try
                {
                    success = Product.addProduct(Convert.ToString(addProducdNameTxtBx.Text), Convert.ToDecimal(addProductPriceTxtBx.Text), Convert.ToInt32(addProductQuantityTxtBx.Text));

                    if (success == true)
                    {
                        MessageBox.Show("Product added successfully");
                        //Clear text boxes.
                        addProducdNameTxtBx.Text = "";
                        addProductQuantityTxtBx.Text = "";
                        addProductPriceTxtBx.Text = "";

                        //Change visibility after adding product successfully.
                        AddProductAddBtn.Visible = false;
                        addProducdNameTxtBx.Visible = false;
                        addProductQuantityTxtBx.Visible = false;
                        addProductPriceTxtBx.Visible = false;
                        AddProductNameLbl.Visible = false;
                        laAddProductPriceLbl.Visible = false;
                        AddProductQuantityLbl.Visible = false;

                    }
                    else
                    {
                        MessageBox.Show("Failed to add product");

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Name must be text.\n" +
                    "Price must be a number.\n" +
                    "Quantity must be an integer.\n\n" +
                    "Please review your entries and try again.");
            }
              
            

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddProductNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddCustomerAddressLbl.Visible = true;
            AddCustomerEmailLbl.Visible = true;
            AddCustomerNameLbl.Visible = true;
            AddCustomerPhoneLbl.Visible = true;
            AddCustomerAddressTxtBx.Visible = true;
            AddCustomerEmailTxtBx.Visible = true;
            AddCustomerNameTxtBx.Visible = true; 
            AddCustomerPhoneTxtBx.Visible =true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddCustomerEmailTxtBx_Enter(object sender, EventArgs e)
        {
            if (AddCustomerEmailTxtBx.Text == "example@example.com")
            {
                AddCustomerEmailTxtBx.Text = "";
                AddCustomerEmailTxtBx.ForeColor = Color.Black;
            }
        }

        private void AddCustomerNameTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (AddCustomerEmailTxtBx.BackColor == Color.LightGreen && AddCustomerPhoneTxtBx.BackColor == Color.LightGreen)
            {
                generateAddCustomerToDbBtn();
            }
        }

            private void AddCustomerEmailTxtBx_TextChanged(object sender, EventArgs e)
        {
            string emailRegex = @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$";
            bool isEmailValid = Regex.IsMatch(AddCustomerEmailTxtBx.Text, emailRegex);
            if (isEmailValid)
            {
                AddCustomerEmailTxtBx.BackColor = Color.LightGreen;
                if (AddCustomerPhoneTxtBx.BackColor == Color.LightGreen)
                {
                    generateAddCustomerToDbBtn();
                }
            }
            else
            {
                AddCustomerEmailTxtBx.BackColor = Color.Pink;
                AddCustomerAddBtn.Visible = false;
            }
        }

        private void AddCustomerPhoneTxtBx_Enter(object sender, EventArgs e)
        {
            if (AddCustomerPhoneTxtBx.Text == "XXX-XXX-XXXX")
            {
                AddCustomerPhoneTxtBx.Text = "";
                AddCustomerPhoneTxtBx.ForeColor = Color.Black;
            }
        }
        private void AddCustomerPhoneTxtBx_TextChanged(object sender, EventArgs e)
        {

            // Validate phone number
            string phoneRegex = @"^\d{3}-\d{3}-\d{4}$";
            bool isPhoneNumberValid = Regex.IsMatch(AddCustomerPhoneTxtBx.Text, phoneRegex);
            if (isPhoneNumberValid)
            {
                AddCustomerPhoneTxtBx.BackColor = Color.LightGreen;
                if (AddCustomerEmailTxtBx.BackColor == Color.LightGreen)
                {
                    generateAddCustomerToDbBtn();
                }
            }
            else
            {
                AddCustomerPhoneTxtBx.BackColor = Color.Pink;
                AddCustomerAddBtn.Visible = false;
            }
        }

        private void AddCustomerAddressTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (AddCustomerEmailTxtBx.BackColor == Color.LightGreen && AddCustomerPhoneTxtBx.BackColor == Color.LightGreen)
            {
                generateAddCustomerToDbBtn();
            }
        }

        private void AddCustomerAddBtn_Click(object sender, EventArgs e)
        {
            bool success;
            
            try
            {
                success = Customer.addCustomer(Convert.ToString(AddCustomerNameTxtBx.Text), Convert.ToString(AddCustomerEmailTxtBx.Text), Convert.ToString(AddCustomerPhoneTxtBx.Text), Convert.ToString(AddCustomerAddressTxtBx.Text));

                if (success == true)
                {
                    MessageBox.Show("Product added successfully");
                    //Clear text boxes.
                    AddCustomerNameTxtBx.Text = "";
                    AddCustomerEmailTxtBx.Text = "";
                    AddCustomerPhoneTxtBx.Text = "";
                    AddCustomerAddressTxtBx.Text = "";

                    

                    //Change visibility after adding product successfully.
                    AddCustomerNameLbl.Visible = false;
                    AddCustomerEmailLbl.Visible = false;
                    AddCustomerAddressLbl.Visible = false;
                    AddCustomerPhoneLbl.Visible = false;

                    AddCustomerNameTxtBx.Visible = false;
                    AddCustomerEmailTxtBx.Visible = false;
                    AddCustomerAddressTxtBx.Visible = false;
                    AddCustomerPhoneTxtBx.Visible = false; 
                    AddCustomerAddBtn.Visible = false;

                    AddCustomerEmailTxtBx.BackColor = Color.White;
                    AddCustomerPhoneTxtBx.BackColor = Color.White;


                    AddProductAddBtn.Visible = false;
                    addProducdNameTxtBx.Visible = false;
                    addProductQuantityTxtBx.Visible = false;
                    addProductPriceTxtBx.Visible = false;
                    AddProductNameLbl.Visible = false;
                    laAddProductPriceLbl.Visible = false;
                    AddProductQuantityLbl.Visible = false;


                }
                else
                {
                    MessageBox.Show("Failed to add product");

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            /*
            else
            {
                MessageBox.Show("Name must be text.\n" +
                    "Email must be a valid email address (example@example.com.\n" +
                    "Phone must be in the form XXX-XXX-XXXX.\n" +
                    "Address must be text.\n\n" +
                    "Please review your entries and try again.");
            }
            */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDBDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.pOSDBDataSet.Orders);
            // TODO: This line of code loads data into the 'pOSDBDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.pOSDBDataSet.Customers);
            // TODO: This line of code loads data into the 'pOSDBDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.pOSDBDataSet1.Products);

        }

        private void ViewProductsBtn_Click(object sender, EventArgs e)
        {
            ViewProductsDataGridView.Visible = true;
            ViewCustomersDataGridView.Visible = false;
            ViewOrdersDataGridView.Visible = false;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewCustomersBtn_Click(object sender, EventArgs e)
        {
            ViewCustomersDataGridView.Visible = true;
            ViewProductsDataGridView.Visible = false;
            ViewOrdersDataGridView.Visible = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            CreateOrderCustomerIdLbl.Visible = true;
            CreateOrderCustomerIdTxtBx.Visible = true;
        }

        private void CreateOrderCustomerIdTxtBx_TextChanged(object sender, EventArgs e)
        {
            if(CreateOrderCustomerIdTxtBx.Text != "" && int.TryParse(CreateOrderCustomerIdTxtBx.Text, out int id)) CreateOrderStartOrderBtn.Visible = true;
            else CreateOrderStartOrderBtn.Visible = false;
        }

        private void CreateOrderStartOrderBtn_Click(object sender, EventArgs e)
        {
            CreateOrderStartOrderBtn.Visible = false;
            try
            {
                bool success = Order.createOrder(Convert.ToInt32(CreateOrderCustomerIdTxtBx.Text));
                if(success)
                {
                    MessageBox.Show("New order has been started, proceed to add items.");

                    //Rveal add product to order boxes and labels.
                    AddProductIdToOrderLbl.Visible = true;
                    AddProductIdToOrderTxtBx.Visible= true;
                    AddProductQuantityToOrderLbl.Visible = true;
                    AddProductQuantityToOrderTxtBx.Visible = true;

                    //invisible customerId lable and textbox.
                    CreateOrderCustomerIdLbl.Visible = false;
                    CreateOrderCustomerIdTxtBx.Visible = false;



                }
                else
                {
                    MessageBox.Show("Something went wrong, please check that you have entered a valid customer ID.");
                }
            }
              catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddProductQuantityToOrderTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (AddProductIdToOrderTxtBx.Text != "" && int.TryParse(AddProductIdToOrderTxtBx.Text, out int productId) && AddProductQuantityToOrderTxtBx.Text != null && int.TryParse(AddProductQuantityToOrderTxtBx.Text, out int productQuantity))
            {
                AddProductToOrderBtn.Visible = true;
            }
            else
            {
                AddProductToOrderBtn.Visible = false;
            }
        }


        private void AddProductIdToOrderTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (AddProductIdToOrderTxtBx.Text != "" && int.TryParse(AddProductIdToOrderTxtBx.Text, out int productId) && AddProductQuantityToOrderTxtBx.Text != null && int.TryParse(AddProductQuantityToOrderTxtBx.Text, out int productQuantity))
            {
                AddProductToOrderBtn.Visible = true;
            }
            else
            {
                AddProductToOrderBtn.Visible = false;
            }

        }

        private void AddProductToOrderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation method not working so continuing without validating and will fix this later.
                //bool success = OrderDetail.validateOrderProduct(Convert.ToInt16(AddProductIdToOrderTxtBx.Text), Convert.ToInt16(AddProductQuantityToOrderTxtBx.Text));
                bool success = true;


                if(success)
                {
                    bool productAdded = OrderDetail.AddProductToOrder(Convert.ToInt32(CreateOrderCustomerIdTxtBx.Text), Convert.ToInt32(AddProductIdToOrderTxtBx.Text), Convert.ToInt32(AddProductQuantityToOrderTxtBx.Text));
                    if (productAdded)
                    {
                        MessageBox.Show("Product added");
                        AddProductIdToOrderTxtBx.Text = "";
                        AddProductQuantityToOrderTxtBx.Text = "";
                        AddCustomerAddBtn.Visible = false;
                        SubmitOrderBtn.Visible = true;
                        return;
                    }
                }

                else
                {
                    MessageBox.Show("The Quantity for the product you picked is too large, please refer to the \"View Products\" to view the stock.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.InnerException.Message);
            }


        }

        private void CreateOrderCustomerIdLbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            ViewOrdersDataGridView.Visible = true;
            ViewCustomersDataGridView.Visible = false;
            ViewProductsDataGridView.Visible = false;
        }

        private void SubmitOrderBtn_Click(object sender, EventArgs e)
        {
            //submit order code.
        }
    }
}
