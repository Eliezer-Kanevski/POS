namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.addProducdNameTxtBx = new System.Windows.Forms.TextBox();
            this.addProductPriceTxtBx = new System.Windows.Forms.TextBox();
            this.addProductQuantityTxtBx = new System.Windows.Forms.TextBox();
            this.AddProductNameLbl = new System.Windows.Forms.Label();
            this.laAddProductPriceLbl = new System.Windows.Forms.Label();
            this.AddProductQuantityLbl = new System.Windows.Forms.Label();
            this.AddProductAddBtn = new System.Windows.Forms.Button();
            this.AddCustomerBtn = new System.Windows.Forms.Button();
            this.AddCustomerNameLbl = new System.Windows.Forms.Label();
            this.AddCustomerEmailLbl = new System.Windows.Forms.Label();
            this.AddCustomerPhoneLbl = new System.Windows.Forms.Label();
            this.AddCustomerAddressLbl = new System.Windows.Forms.Label();
            this.AddCustomerNameTxtBx = new System.Windows.Forms.TextBox();
            this.AddCustomerEmailTxtBx = new System.Windows.Forms.TextBox();
            this.AddCustomerPhoneTxtBx = new System.Windows.Forms.TextBox();
            this.AddCustomerAddressTxtBx = new System.Windows.Forms.TextBox();
            this.AddCustomerAddBtn = new System.Windows.Forms.Button();
            this.ViewProductsBtn = new System.Windows.Forms.Button();
            this.pOSDBDataSet = new WindowsFormsApp1.POSDBDataSet();
            this.pOSDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ViewProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.pOSDBDataSet1 = new WindowsFormsApp1.POSDBDataSet1();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new WindowsFormsApp1.POSDBDataSet1TableAdapters.ProductsTableAdapter();
            this.ViewCustomersBtn = new System.Windows.Forms.Button();
            this.ViewCustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new WindowsFormsApp1.POSDBDataSetTableAdapters.CustomersTableAdapter();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateOrderBtn = new System.Windows.Forms.Button();
            this.CreateOrderStartOrderBtn = new System.Windows.Forms.Button();
            this.CreateOrderCustomerIdTxtBx = new System.Windows.Forms.TextBox();
            this.CreateOrderCustomerIdLbl = new System.Windows.Forms.Label();
            this.AddProductIdToOrderLbl = new System.Windows.Forms.Label();
            this.AddProductQuantityToOrderLbl = new System.Windows.Forms.Label();
            this.AddProductIdToOrderTxtBx = new System.Windows.Forms.TextBox();
            this.AddProductQuantityToOrderTxtBx = new System.Windows.Forms.TextBox();
            this.AddProductToOrderBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCustomersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddProductBtn.Location = new System.Drawing.Point(38, 44);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(195, 52);
            this.AddProductBtn.TabIndex = 0;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.UseVisualStyleBackColor = false;
            this.AddProductBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // addProducdNameTxtBx
            // 
            this.addProducdNameTxtBx.Location = new System.Drawing.Point(96, 110);
            this.addProducdNameTxtBx.Name = "addProducdNameTxtBx";
            this.addProducdNameTxtBx.Size = new System.Drawing.Size(137, 22);
            this.addProducdNameTxtBx.TabIndex = 5;
            this.addProducdNameTxtBx.Visible = false;
            this.addProducdNameTxtBx.TextChanged += new System.EventHandler(this.addProducdNameTxtBx_TextChanged);
            // 
            // addProductPriceTxtBx
            // 
            this.addProductPriceTxtBx.Location = new System.Drawing.Point(96, 141);
            this.addProductPriceTxtBx.Name = "addProductPriceTxtBx";
            this.addProductPriceTxtBx.Size = new System.Drawing.Size(137, 22);
            this.addProductPriceTxtBx.TabIndex = 6;
            this.addProductPriceTxtBx.Visible = false;
            this.addProductPriceTxtBx.TextChanged += new System.EventHandler(this.addProductQuantityTxtBx_TextChanged);
            // 
            // addProductQuantityTxtBx
            // 
            this.addProductQuantityTxtBx.Location = new System.Drawing.Point(96, 169);
            this.addProductQuantityTxtBx.Name = "addProductQuantityTxtBx";
            this.addProductQuantityTxtBx.Size = new System.Drawing.Size(137, 22);
            this.addProductQuantityTxtBx.TabIndex = 7;
            this.addProductQuantityTxtBx.Visible = false;
            this.addProductQuantityTxtBx.TextChanged += new System.EventHandler(this.addProductPriceTxtBx_TextChanged);
            // 
            // AddProductNameLbl
            // 
            this.AddProductNameLbl.AutoSize = true;
            this.AddProductNameLbl.Location = new System.Drawing.Point(35, 116);
            this.AddProductNameLbl.Name = "AddProductNameLbl";
            this.AddProductNameLbl.Size = new System.Drawing.Size(44, 16);
            this.AddProductNameLbl.TabIndex = 8;
            this.AddProductNameLbl.Text = "Name";
            this.AddProductNameLbl.Visible = false;
            this.AddProductNameLbl.Click += new System.EventHandler(this.AddProductNameLbl_Click);
            // 
            // laAddProductPriceLbl
            // 
            this.laAddProductPriceLbl.AutoSize = true;
            this.laAddProductPriceLbl.Location = new System.Drawing.Point(35, 147);
            this.laAddProductPriceLbl.Name = "laAddProductPriceLbl";
            this.laAddProductPriceLbl.Size = new System.Drawing.Size(38, 16);
            this.laAddProductPriceLbl.TabIndex = 9;
            this.laAddProductPriceLbl.Text = "Price";
            this.laAddProductPriceLbl.Visible = false;
            this.laAddProductPriceLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // AddProductQuantityLbl
            // 
            this.AddProductQuantityLbl.AutoSize = true;
            this.AddProductQuantityLbl.Location = new System.Drawing.Point(35, 175);
            this.AddProductQuantityLbl.Name = "AddProductQuantityLbl";
            this.AddProductQuantityLbl.Size = new System.Drawing.Size(55, 16);
            this.AddProductQuantityLbl.TabIndex = 10;
            this.AddProductQuantityLbl.Text = "Quantity";
            this.AddProductQuantityLbl.Visible = false;
            // 
            // AddProductAddBtn
            // 
            this.AddProductAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddProductAddBtn.Location = new System.Drawing.Point(53, 215);
            this.AddProductAddBtn.Name = "AddProductAddBtn";
            this.AddProductAddBtn.Size = new System.Drawing.Size(128, 23);
            this.AddProductAddBtn.TabIndex = 11;
            this.AddProductAddBtn.Text = "Add";
            this.AddProductAddBtn.UseVisualStyleBackColor = false;
            this.AddProductAddBtn.Visible = false;
            this.AddProductAddBtn.Click += new System.EventHandler(this.AddProductAddBtn_Click);
            // 
            // AddCustomerBtn
            // 
            this.AddCustomerBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddCustomerBtn.Location = new System.Drawing.Point(29, 265);
            this.AddCustomerBtn.Name = "AddCustomerBtn";
            this.AddCustomerBtn.Size = new System.Drawing.Size(224, 52);
            this.AddCustomerBtn.TabIndex = 12;
            this.AddCustomerBtn.Text = "Add Customer";
            this.AddCustomerBtn.UseVisualStyleBackColor = false;
            this.AddCustomerBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AddCustomerNameLbl
            // 
            this.AddCustomerNameLbl.AutoSize = true;
            this.AddCustomerNameLbl.Location = new System.Drawing.Point(26, 337);
            this.AddCustomerNameLbl.Name = "AddCustomerNameLbl";
            this.AddCustomerNameLbl.Size = new System.Drawing.Size(44, 16);
            this.AddCustomerNameLbl.TabIndex = 13;
            this.AddCustomerNameLbl.Text = "Name";
            this.AddCustomerNameLbl.Visible = false;
            this.AddCustomerNameLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddCustomerEmailLbl
            // 
            this.AddCustomerEmailLbl.AutoSize = true;
            this.AddCustomerEmailLbl.Location = new System.Drawing.Point(26, 368);
            this.AddCustomerEmailLbl.Name = "AddCustomerEmailLbl";
            this.AddCustomerEmailLbl.Size = new System.Drawing.Size(41, 16);
            this.AddCustomerEmailLbl.TabIndex = 14;
            this.AddCustomerEmailLbl.Text = "Email";
            this.AddCustomerEmailLbl.Visible = false;
            // 
            // AddCustomerPhoneLbl
            // 
            this.AddCustomerPhoneLbl.AutoSize = true;
            this.AddCustomerPhoneLbl.Location = new System.Drawing.Point(26, 396);
            this.AddCustomerPhoneLbl.Name = "AddCustomerPhoneLbl";
            this.AddCustomerPhoneLbl.Size = new System.Drawing.Size(46, 16);
            this.AddCustomerPhoneLbl.TabIndex = 15;
            this.AddCustomerPhoneLbl.Text = "Phone";
            this.AddCustomerPhoneLbl.Visible = false;
            // 
            // AddCustomerAddressLbl
            // 
            this.AddCustomerAddressLbl.AutoSize = true;
            this.AddCustomerAddressLbl.Location = new System.Drawing.Point(26, 422);
            this.AddCustomerAddressLbl.Name = "AddCustomerAddressLbl";
            this.AddCustomerAddressLbl.Size = new System.Drawing.Size(58, 16);
            this.AddCustomerAddressLbl.TabIndex = 16;
            this.AddCustomerAddressLbl.Text = "Address";
            this.AddCustomerAddressLbl.Visible = false;
            // 
            // AddCustomerNameTxtBx
            // 
            this.AddCustomerNameTxtBx.Location = new System.Drawing.Point(96, 334);
            this.AddCustomerNameTxtBx.Name = "AddCustomerNameTxtBx";
            this.AddCustomerNameTxtBx.Size = new System.Drawing.Size(157, 22);
            this.AddCustomerNameTxtBx.TabIndex = 18;
            this.AddCustomerNameTxtBx.Visible = false;
            this.AddCustomerNameTxtBx.TextChanged += new System.EventHandler(this.AddCustomerNameTxtBx_TextChanged);
            // 
            // AddCustomerEmailTxtBx
            // 
            this.AddCustomerEmailTxtBx.ForeColor = System.Drawing.SystemColors.GrayText;
            this.AddCustomerEmailTxtBx.Location = new System.Drawing.Point(96, 366);
            this.AddCustomerEmailTxtBx.Name = "AddCustomerEmailTxtBx";
            this.AddCustomerEmailTxtBx.Size = new System.Drawing.Size(157, 22);
            this.AddCustomerEmailTxtBx.TabIndex = 19;
            this.AddCustomerEmailTxtBx.Text = "example@example.com";
            this.AddCustomerEmailTxtBx.Visible = false;
            this.AddCustomerEmailTxtBx.TextChanged += new System.EventHandler(this.AddCustomerEmailTxtBx_TextChanged);
            // 
            // AddCustomerPhoneTxtBx
            // 
            this.AddCustomerPhoneTxtBx.ForeColor = System.Drawing.SystemColors.GrayText;
            this.AddCustomerPhoneTxtBx.Location = new System.Drawing.Point(96, 393);
            this.AddCustomerPhoneTxtBx.Name = "AddCustomerPhoneTxtBx";
            this.AddCustomerPhoneTxtBx.Size = new System.Drawing.Size(157, 22);
            this.AddCustomerPhoneTxtBx.TabIndex = 20;
            this.AddCustomerPhoneTxtBx.Text = "XXX-XXX-XXXX";
            this.AddCustomerPhoneTxtBx.Visible = false;
            this.AddCustomerPhoneTxtBx.TextChanged += new System.EventHandler(this.AddCustomerPhoneTxtBx_TextChanged);
            // 
            // AddCustomerAddressTxtBx
            // 
            this.AddCustomerAddressTxtBx.Location = new System.Drawing.Point(96, 419);
            this.AddCustomerAddressTxtBx.Name = "AddCustomerAddressTxtBx";
            this.AddCustomerAddressTxtBx.Size = new System.Drawing.Size(157, 22);
            this.AddCustomerAddressTxtBx.TabIndex = 21;
            this.AddCustomerAddressTxtBx.Visible = false;
            this.AddCustomerAddressTxtBx.TextChanged += new System.EventHandler(this.AddCustomerAddressTxtBx_TextChanged);
            // 
            // AddCustomerAddBtn
            // 
            this.AddCustomerAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddCustomerAddBtn.Location = new System.Drawing.Point(65, 462);
            this.AddCustomerAddBtn.Name = "AddCustomerAddBtn";
            this.AddCustomerAddBtn.Size = new System.Drawing.Size(128, 23);
            this.AddCustomerAddBtn.TabIndex = 22;
            this.AddCustomerAddBtn.Text = "Add";
            this.AddCustomerAddBtn.UseVisualStyleBackColor = false;
            this.AddCustomerAddBtn.Visible = false;
            this.AddCustomerAddBtn.Click += new System.EventHandler(this.AddCustomerAddBtn_Click);
            // 
            // ViewProductsBtn
            // 
            this.ViewProductsBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ViewProductsBtn.Location = new System.Drawing.Point(980, 21);
            this.ViewProductsBtn.Name = "ViewProductsBtn";
            this.ViewProductsBtn.Size = new System.Drawing.Size(98, 52);
            this.ViewProductsBtn.TabIndex = 23;
            this.ViewProductsBtn.Text = "View Products";
            this.ViewProductsBtn.UseVisualStyleBackColor = false;
            this.ViewProductsBtn.Click += new System.EventHandler(this.ViewProductsBtn_Click);
            // 
            // pOSDBDataSet
            // 
            this.pOSDBDataSet.DataSetName = "POSDBDataSet";
            this.pOSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pOSDBDataSetBindingSource
            // 
            this.pOSDBDataSetBindingSource.DataSource = this.pOSDBDataSet;
            this.pOSDBDataSetBindingSource.Position = 0;
            // 
            // ViewProductsDataGridView
            // 
            this.ViewProductsDataGridView.AutoGenerateColumns = false;
            this.ViewProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.ViewProductsDataGridView.DataSource = this.productsBindingSource;
            this.ViewProductsDataGridView.Location = new System.Drawing.Point(602, 306);
            this.ViewProductsDataGridView.Name = "ViewProductsDataGridView";
            this.ViewProductsDataGridView.RowHeadersWidth = 4;
            this.ViewProductsDataGridView.RowTemplate.Height = 24;
            this.ViewProductsDataGridView.Size = new System.Drawing.Size(314, 221);
            this.ViewProductsDataGridView.TabIndex = 24;
            this.ViewProductsDataGridView.Visible = false;
            // 
            // pOSDBDataSet1
            // 
            this.pOSDBDataSet1.DataSetName = "POSDBDataSet1";
            this.pOSDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.pOSDBDataSet1;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // ViewCustomersBtn
            // 
            this.ViewCustomersBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ViewCustomersBtn.Location = new System.Drawing.Point(860, 21);
            this.ViewCustomersBtn.Name = "ViewCustomersBtn";
            this.ViewCustomersBtn.Size = new System.Drawing.Size(98, 52);
            this.ViewCustomersBtn.TabIndex = 25;
            this.ViewCustomersBtn.Text = "View Customers";
            this.ViewCustomersBtn.UseVisualStyleBackColor = false;
            this.ViewCustomersBtn.Click += new System.EventHandler(this.ViewCustomersBtn_Click);
            // 
            // ViewCustomersDataGridView
            // 
            this.ViewCustomersDataGridView.AutoGenerateColumns = false;
            this.ViewCustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewCustomersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.ViewCustomersDataGridView.DataSource = this.customersBindingSource;
            this.ViewCustomersDataGridView.Location = new System.Drawing.Point(548, 334);
            this.ViewCustomersDataGridView.Name = "ViewCustomersDataGridView";
            this.ViewCustomersDataGridView.RowHeadersWidth = 4;
            this.ViewCustomersDataGridView.RowTemplate.Height = 24;
            this.ViewCustomersDataGridView.Size = new System.Drawing.Size(530, 219);
            this.ViewCustomersDataGridView.TabIndex = 26;
            this.ViewCustomersDataGridView.Visible = false;
            this.ViewCustomersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.pOSDBDataSetBindingSource;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 75;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 80;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 50;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 50;
            // 
            // CreateOrderBtn
            // 
            this.CreateOrderBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CreateOrderBtn.Location = new System.Drawing.Point(259, 44);
            this.CreateOrderBtn.Name = "CreateOrderBtn";
            this.CreateOrderBtn.Size = new System.Drawing.Size(161, 45);
            this.CreateOrderBtn.TabIndex = 27;
            this.CreateOrderBtn.Text = "Create Order";
            this.CreateOrderBtn.UseVisualStyleBackColor = false;
            this.CreateOrderBtn.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // CreateOrderStartOrderBtn
            // 
            this.CreateOrderStartOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CreateOrderStartOrderBtn.Location = new System.Drawing.Point(282, 147);
            this.CreateOrderStartOrderBtn.Name = "CreateOrderStartOrderBtn";
            this.CreateOrderStartOrderBtn.Size = new System.Drawing.Size(99, 28);
            this.CreateOrderStartOrderBtn.TabIndex = 28;
            this.CreateOrderStartOrderBtn.Text = "Start Order";
            this.CreateOrderStartOrderBtn.UseVisualStyleBackColor = false;
            this.CreateOrderStartOrderBtn.Visible = false;
            this.CreateOrderStartOrderBtn.Click += new System.EventHandler(this.CreateOrderStartOrderBtn_Click);
            // 
            // CreateOrderCustomerIdTxtBx
            // 
            this.CreateOrderCustomerIdTxtBx.Location = new System.Drawing.Point(365, 113);
            this.CreateOrderCustomerIdTxtBx.Name = "CreateOrderCustomerIdTxtBx";
            this.CreateOrderCustomerIdTxtBx.Size = new System.Drawing.Size(55, 22);
            this.CreateOrderCustomerIdTxtBx.TabIndex = 29;
            this.CreateOrderCustomerIdTxtBx.Visible = false;
            this.CreateOrderCustomerIdTxtBx.TextChanged += new System.EventHandler(this.CreateOrderCustomerIdTxtBx_TextChanged);
            // 
            // CreateOrderCustomerIdLbl
            // 
            this.CreateOrderCustomerIdLbl.AutoSize = true;
            this.CreateOrderCustomerIdLbl.Location = new System.Drawing.Point(256, 116);
            this.CreateOrderCustomerIdLbl.Name = "CreateOrderCustomerIdLbl";
            this.CreateOrderCustomerIdLbl.Size = new System.Drawing.Size(80, 16);
            this.CreateOrderCustomerIdLbl.TabIndex = 30;
            this.CreateOrderCustomerIdLbl.Text = "Customer ID";
            this.CreateOrderCustomerIdLbl.Visible = false;
            this.CreateOrderCustomerIdLbl.Click += new System.EventHandler(this.CreateOrderCustomerIdLbl_Click);
            // 
            // AddProductIdToOrderLbl
            // 
            this.AddProductIdToOrderLbl.AutoSize = true;
            this.AddProductIdToOrderLbl.Location = new System.Drawing.Point(256, 189);
            this.AddProductIdToOrderLbl.Name = "AddProductIdToOrderLbl";
            this.AddProductIdToOrderLbl.Size = new System.Drawing.Size(69, 16);
            this.AddProductIdToOrderLbl.TabIndex = 31;
            this.AddProductIdToOrderLbl.Text = "Product ID";
            this.AddProductIdToOrderLbl.Visible = false;
            // 
            // AddProductQuantityToOrderLbl
            // 
            this.AddProductQuantityToOrderLbl.AutoSize = true;
            this.AddProductQuantityToOrderLbl.Location = new System.Drawing.Point(256, 222);
            this.AddProductQuantityToOrderLbl.Name = "AddProductQuantityToOrderLbl";
            this.AddProductQuantityToOrderLbl.Size = new System.Drawing.Size(55, 16);
            this.AddProductQuantityToOrderLbl.TabIndex = 32;
            this.AddProductQuantityToOrderLbl.Text = "Quantity";
            this.AddProductQuantityToOrderLbl.Visible = false;
            // 
            // AddProductIdToOrderTxtBx
            // 
            this.AddProductIdToOrderTxtBx.Location = new System.Drawing.Point(365, 189);
            this.AddProductIdToOrderTxtBx.Name = "AddProductIdToOrderTxtBx";
            this.AddProductIdToOrderTxtBx.Size = new System.Drawing.Size(55, 22);
            this.AddProductIdToOrderTxtBx.TabIndex = 33;
            this.AddProductIdToOrderTxtBx.Visible = false;
            this.AddProductIdToOrderTxtBx.TextChanged += new System.EventHandler(this.AddProductIdToOrderTxtBx_TextChanged);
            // 
            // AddProductQuantityToOrderTxtBx
            // 
            this.AddProductQuantityToOrderTxtBx.Location = new System.Drawing.Point(365, 222);
            this.AddProductQuantityToOrderTxtBx.Name = "AddProductQuantityToOrderTxtBx";
            this.AddProductQuantityToOrderTxtBx.Size = new System.Drawing.Size(55, 22);
            this.AddProductQuantityToOrderTxtBx.TabIndex = 34;
            this.AddProductQuantityToOrderTxtBx.Visible = false;
            this.AddProductQuantityToOrderTxtBx.TextChanged += new System.EventHandler(this.AddProductQuantityToOrderTxtBx_TextChanged);
            // 
            // AddProductToOrderBtn
            // 
            this.AddProductToOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddProductToOrderBtn.Location = new System.Drawing.Point(295, 265);
            this.AddProductToOrderBtn.Name = "AddProductToOrderBtn";
            this.AddProductToOrderBtn.Size = new System.Drawing.Size(99, 28);
            this.AddProductToOrderBtn.TabIndex = 35;
            this.AddProductToOrderBtn.Text = "Add Product";
            this.AddProductToOrderBtn.UseVisualStyleBackColor = false;
            this.AddProductToOrderBtn.Visible = false;
            this.AddProductToOrderBtn.Click += new System.EventHandler(this.AddProductToOrderBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1151, 711);
            this.Controls.Add(this.AddProductToOrderBtn);
            this.Controls.Add(this.AddProductQuantityToOrderTxtBx);
            this.Controls.Add(this.AddProductIdToOrderTxtBx);
            this.Controls.Add(this.AddProductQuantityToOrderLbl);
            this.Controls.Add(this.AddProductIdToOrderLbl);
            this.Controls.Add(this.CreateOrderCustomerIdLbl);
            this.Controls.Add(this.CreateOrderCustomerIdTxtBx);
            this.Controls.Add(this.CreateOrderStartOrderBtn);
            this.Controls.Add(this.CreateOrderBtn);
            this.Controls.Add(this.ViewCustomersDataGridView);
            this.Controls.Add(this.ViewCustomersBtn);
            this.Controls.Add(this.ViewProductsDataGridView);
            this.Controls.Add(this.ViewProductsBtn);
            this.Controls.Add(this.AddCustomerAddBtn);
            this.Controls.Add(this.AddCustomerAddressTxtBx);
            this.Controls.Add(this.AddCustomerPhoneTxtBx);
            this.Controls.Add(this.AddCustomerEmailTxtBx);
            this.Controls.Add(this.AddCustomerNameTxtBx);
            this.Controls.Add(this.AddCustomerAddressLbl);
            this.Controls.Add(this.AddCustomerPhoneLbl);
            this.Controls.Add(this.AddCustomerEmailLbl);
            this.Controls.Add(this.AddCustomerNameLbl);
            this.Controls.Add(this.AddCustomerBtn);
            this.Controls.Add(this.AddProductAddBtn);
            this.Controls.Add(this.AddProductQuantityLbl);
            this.Controls.Add(this.laAddProductPriceLbl);
            this.Controls.Add(this.AddProductNameLbl);
            this.Controls.Add(this.addProductQuantityTxtBx);
            this.Controls.Add(this.addProductPriceTxtBx);
            this.Controls.Add(this.addProducdNameTxtBx);
            this.Controls.Add(this.AddProductBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pOSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCustomersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.TextBox addProducdNameTxtBx;
        private System.Windows.Forms.TextBox addProductPriceTxtBx;
        private System.Windows.Forms.TextBox addProductQuantityTxtBx;
        private System.Windows.Forms.Label AddProductNameLbl;
        private System.Windows.Forms.Label laAddProductPriceLbl;
        private System.Windows.Forms.Label AddProductQuantityLbl;
        private System.Windows.Forms.Button AddProductAddBtn;
        private System.Windows.Forms.Button AddCustomerBtn;
        private System.Windows.Forms.Label AddCustomerNameLbl;
        private System.Windows.Forms.Label AddCustomerEmailLbl;
        private System.Windows.Forms.Label AddCustomerPhoneLbl;
        private System.Windows.Forms.Label AddCustomerAddressLbl;
        private System.Windows.Forms.TextBox AddCustomerNameTxtBx;
        private System.Windows.Forms.TextBox AddCustomerEmailTxtBx;
        private System.Windows.Forms.TextBox AddCustomerPhoneTxtBx;
        private System.Windows.Forms.TextBox AddCustomerAddressTxtBx;
        private System.Windows.Forms.Button AddCustomerAddBtn;
        private System.Windows.Forms.Button ViewProductsBtn;
        private System.Windows.Forms.BindingSource pOSDBDataSetBindingSource;
        private POSDBDataSet pOSDBDataSet;
        private System.Windows.Forms.DataGridView ViewProductsDataGridView;
        private POSDBDataSet1 pOSDBDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private POSDBDataSet1TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Button ViewCustomersBtn;
        private System.Windows.Forms.DataGridView ViewCustomersDataGridView;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private POSDBDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button CreateOrderBtn;
        private System.Windows.Forms.Button CreateOrderStartOrderBtn;
        private System.Windows.Forms.TextBox CreateOrderCustomerIdTxtBx;
        private System.Windows.Forms.Label CreateOrderCustomerIdLbl;
        private System.Windows.Forms.Label AddProductIdToOrderLbl;
        private System.Windows.Forms.Label AddProductQuantityToOrderLbl;
        private System.Windows.Forms.TextBox AddProductIdToOrderTxtBx;
        private System.Windows.Forms.TextBox AddProductQuantityToOrderTxtBx;
        private System.Windows.Forms.Button AddProductToOrderBtn;
    }
}

