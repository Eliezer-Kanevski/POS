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
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addProducdNameTxtBx = new System.Windows.Forms.TextBox();
            this.addProductQuantityTxtBx = new System.Windows.Forms.TextBox();
            this.addProductPriceTxtBx = new System.Windows.Forms.TextBox();
            this.AddProductNameLbl = new System.Windows.Forms.Label();
            this.laAddProductPriceLbl = new System.Windows.Forms.Label();
            this.AddProductQuantityLbl = new System.Windows.Forms.Label();
            this.AddProductAddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(38, 44);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(296, 52);
            this.AddProductBtn.TabIndex = 0;
            this.AddProductBtn.Text = "Add product";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 12);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addProducdNameTxtBx
            // 
            this.addProducdNameTxtBx.Location = new System.Drawing.Point(197, 125);
            this.addProducdNameTxtBx.Name = "addProducdNameTxtBx";
            this.addProducdNameTxtBx.Size = new System.Drawing.Size(137, 22);
            this.addProducdNameTxtBx.TabIndex = 5;
            this.addProducdNameTxtBx.Visible = false;
            this.addProducdNameTxtBx.TextChanged += new System.EventHandler(this.addProducdNameTxtBx_TextChanged);
            // 
            // addProductQuantityTxtBx
            // 
            this.addProductQuantityTxtBx.Location = new System.Drawing.Point(197, 224);
            this.addProductQuantityTxtBx.Name = "addProductQuantityTxtBx";
            this.addProductQuantityTxtBx.Size = new System.Drawing.Size(137, 22);
            this.addProductQuantityTxtBx.TabIndex = 6;
            this.addProductQuantityTxtBx.Visible = false;
            this.addProductQuantityTxtBx.TextChanged += new System.EventHandler(this.addProductQuantityTxtBx_TextChanged);
            // 
            // addProductPriceTxtBx
            // 
            this.addProductPriceTxtBx.Location = new System.Drawing.Point(197, 175);
            this.addProductPriceTxtBx.Name = "addProductPriceTxtBx";
            this.addProductPriceTxtBx.Size = new System.Drawing.Size(137, 22);
            this.addProductPriceTxtBx.TabIndex = 7;
            this.addProductPriceTxtBx.Visible = false;
            this.addProductPriceTxtBx.TextChanged += new System.EventHandler(this.addProductPriceTxtBx_TextChanged);
            // 
            // AddProductNameLbl
            // 
            this.AddProductNameLbl.AutoSize = true;
            this.AddProductNameLbl.Location = new System.Drawing.Point(35, 131);
            this.AddProductNameLbl.Name = "AddProductNameLbl";
            this.AddProductNameLbl.Size = new System.Drawing.Size(44, 16);
            this.AddProductNameLbl.TabIndex = 8;
            this.AddProductNameLbl.Text = "Name";
            this.AddProductNameLbl.Visible = false;
            // 
            // laAddProductPriceLbl
            // 
            this.laAddProductPriceLbl.AutoSize = true;
            this.laAddProductPriceLbl.Location = new System.Drawing.Point(35, 175);
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
            this.AddProductQuantityLbl.Location = new System.Drawing.Point(35, 230);
            this.AddProductQuantityLbl.Name = "AddProductQuantityLbl";
            this.AddProductQuantityLbl.Size = new System.Drawing.Size(55, 16);
            this.AddProductQuantityLbl.TabIndex = 10;
            this.AddProductQuantityLbl.Text = "Quantity";
            this.AddProductQuantityLbl.Visible = false;
            // 
            // AddProductAddBtn
            // 
            this.AddProductAddBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.AddProductAddBtn.Location = new System.Drawing.Point(84, 285);
            this.AddProductAddBtn.Name = "AddProductAddBtn";
            this.AddProductAddBtn.Size = new System.Drawing.Size(128, 23);
            this.AddProductAddBtn.TabIndex = 11;
            this.AddProductAddBtn.Text = "Add";
            this.AddProductAddBtn.UseVisualStyleBackColor = false;
            this.AddProductAddBtn.Visible = false;
            this.AddProductAddBtn.Click += new System.EventHandler(this.AddProductAddBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 618);
            this.Controls.Add(this.AddProductAddBtn);
            this.Controls.Add(this.AddProductQuantityLbl);
            this.Controls.Add(this.laAddProductPriceLbl);
            this.Controls.Add(this.AddProductNameLbl);
            this.Controls.Add(this.addProductPriceTxtBx);
            this.Controls.Add(this.addProductQuantityTxtBx);
            this.Controls.Add(this.addProducdNameTxtBx);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddProductBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox addProducdNameTxtBx;
        private System.Windows.Forms.TextBox addProductQuantityTxtBx;
        private System.Windows.Forms.TextBox addProductPriceTxtBx;
        private System.Windows.Forms.Label AddProductNameLbl;
        private System.Windows.Forms.Label laAddProductPriceLbl;
        private System.Windows.Forms.Label AddProductQuantityLbl;
        private System.Windows.Forms.Button AddProductAddBtn;
    }
}

