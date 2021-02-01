
namespace ProductCategoryOperations.Forms
{
    partial class ProductForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonUpdateProd = new System.Windows.Forms.Button();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.textBoxProductDesc = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.PRODUCTS = new System.Windows.Forms.Label();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxCatOfProd = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxUpdProdDesc = new System.Windows.Forms.TextBox();
            this.textBoxUpdProdName = new System.Windows.Forms.TextBox();
            this.textBoxUpdPrice = new System.Windows.Forms.TextBox();
            this.comboBoxUpdCtOfPro = new System.Windows.Forms.ComboBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonGoCategoryOp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Select Product:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(697, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Delete Selected Product:";
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(717, 218);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(133, 50);
            this.buttonDeleteProduct.TabIndex = 32;
            this.buttonDeleteProduct.Text = "Delete Product";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonUpdateProd
            // 
            this.buttonUpdateProd.Location = new System.Drawing.Point(401, 466);
            this.buttonUpdateProd.Name = "buttonUpdateProd";
            this.buttonUpdateProd.Size = new System.Drawing.Size(148, 35);
            this.buttonUpdateProd.TabIndex = 31;
            this.buttonUpdateProd.Text = "Update Product";
            this.buttonUpdateProd.UseVisualStyleBackColor = true;
            this.buttonUpdateProd.Click += new System.EventHandler(this.buttonUpdateProd_Click);
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(438, 221);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(239, 24);
            this.comboBoxProducts.TabIndex = 28;
            this.comboBoxProducts.SelectionChangeCommitted += new System.EventHandler(this.comboBoxProducts_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Update Selected Product:";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(31, 385);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(104, 33);
            this.buttonAddProduct.TabIndex = 26;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // textBoxProductDesc
            // 
            this.textBoxProductDesc.Location = new System.Drawing.Point(196, 286);
            this.textBoxProductDesc.Multiline = true;
            this.textBoxProductDesc.Name = "textBoxProductDesc";
            this.textBoxProductDesc.Size = new System.Drawing.Size(130, 40);
            this.textBoxProductDesc.TabIndex = 25;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(196, 253);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(130, 22);
            this.textBoxProductName.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Product Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Add New Products:";
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(31, 39);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.Size = new System.Drawing.Size(628, 134);
            this.dataGridViewProducts.TabIndex = 20;
            // 
            // PRODUCTS
            // 
            this.PRODUCTS.AutoSize = true;
            this.PRODUCTS.Location = new System.Drawing.Point(28, 10);
            this.PRODUCTS.Name = "PRODUCTS";
            this.PRODUCTS.Size = new System.Drawing.Size(85, 17);
            this.PRODUCTS.TabIndex = 19;
            this.PRODUCTS.Text = "PRODUCTS";
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Location = new System.Drawing.Point(28, 456);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(128, 55);
            this.buttonGoBack.TabIndex = 35;
            this.buttonGoBack.Text = "Go Back To Home Page";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(196, 339);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(130, 22);
            this.textBoxProductPrice.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Product Price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Category of the Product:";
            // 
            // comboBoxCatOfProd
            // 
            this.comboBoxCatOfProd.FormattingEnabled = true;
            this.comboBoxCatOfProd.Location = new System.Drawing.Point(196, 218);
            this.comboBoxCatOfProd.Name = "comboBoxCatOfProd";
            this.comboBoxCatOfProd.Size = new System.Drawing.Size(166, 24);
            this.comboBoxCatOfProd.TabIndex = 41;
            this.comboBoxCatOfProd.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCatOfProd_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Category of the Product:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(376, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 44;
            this.label10.Text = "Product Price:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(376, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 17);
            this.label11.TabIndex = 43;
            this.label11.Text = "Product Description:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(376, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 17);
            this.label12.TabIndex = 42;
            this.label12.Text = "Product Name:";
            // 
            // textBoxUpdProdDesc
            // 
            this.textBoxUpdProdDesc.Location = new System.Drawing.Point(547, 360);
            this.textBoxUpdProdDesc.Multiline = true;
            this.textBoxUpdProdDesc.Name = "textBoxUpdProdDesc";
            this.textBoxUpdProdDesc.Size = new System.Drawing.Size(130, 40);
            this.textBoxUpdProdDesc.TabIndex = 47;
            // 
            // textBoxUpdProdName
            // 
            this.textBoxUpdProdName.Location = new System.Drawing.Point(547, 327);
            this.textBoxUpdProdName.Name = "textBoxUpdProdName";
            this.textBoxUpdProdName.Size = new System.Drawing.Size(130, 22);
            this.textBoxUpdProdName.TabIndex = 46;
            // 
            // textBoxUpdPrice
            // 
            this.textBoxUpdPrice.Location = new System.Drawing.Point(547, 411);
            this.textBoxUpdPrice.Name = "textBoxUpdPrice";
            this.textBoxUpdPrice.Size = new System.Drawing.Size(130, 22);
            this.textBoxUpdPrice.TabIndex = 48;
            // 
            // comboBoxUpdCtOfPro
            // 
            this.comboBoxUpdCtOfPro.FormattingEnabled = true;
            this.comboBoxUpdCtOfPro.Location = new System.Drawing.Point(547, 292);
            this.comboBoxUpdCtOfPro.Name = "comboBoxUpdCtOfPro";
            this.comboBoxUpdCtOfPro.Size = new System.Drawing.Size(166, 24);
            this.comboBoxUpdCtOfPro.TabIndex = 49;
            this.comboBoxUpdCtOfPro.SelectionChangeCommitted += new System.EventHandler(this.comboBoxUpdCtOfPro_SelectionChangeCommitted);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(737, 468);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(92, 33);
            this.buttonExit.TabIndex = 50;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonGoCategoryOp
            // 
            this.buttonGoCategoryOp.Location = new System.Drawing.Point(174, 456);
            this.buttonGoCategoryOp.Name = "buttonGoCategoryOp";
            this.buttonGoCategoryOp.Size = new System.Drawing.Size(128, 54);
            this.buttonGoCategoryOp.TabIndex = 51;
            this.buttonGoCategoryOp.Text = "Go To Category Operations";
            this.buttonGoCategoryOp.UseVisualStyleBackColor = true;
            this.buttonGoCategoryOp.Click += new System.EventHandler(this.buttonGoCategoryOp_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 560);
            this.Controls.Add(this.buttonGoCategoryOp);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.comboBoxUpdCtOfPro);
            this.Controls.Add(this.textBoxUpdPrice);
            this.Controls.Add(this.textBoxUpdProdDesc);
            this.Controls.Add(this.textBoxUpdProdName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxCatOfProd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxProductPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.buttonUpdateProd);
            this.Controls.Add(this.comboBoxProducts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.textBoxProductDesc);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.PRODUCTS);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductOperations";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonUpdateProd;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.TextBox textBoxProductDesc;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Label PRODUCTS;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxCatOfProd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxUpdProdDesc;
        private System.Windows.Forms.TextBox textBoxUpdProdName;
        private System.Windows.Forms.TextBox textBoxUpdPrice;
        private System.Windows.Forms.ComboBox comboBoxUpdCtOfPro;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonGoCategoryOp;
    }
}