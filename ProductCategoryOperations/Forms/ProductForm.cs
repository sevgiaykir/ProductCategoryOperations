using ProductCategoryOperations.Data;
using ProductCategoryOperations.Models;
using ProductCategoryOperations.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductCategoryOperations.Forms
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        ProductOperations productOperations = new ProductOperations();
        ProductCategoryDB db = new ProductCategoryDB();
        Category selectedCategory;
        Product selectedProduct;
        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            FillAllComboBox();
            getProducts();
        }

        void getProducts()
        {
            dataGridViewProducts.DataSource = db.Products.ToList();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            if (textBoxProductName.Text == string.Empty || textBoxProductDesc.Text == string.Empty || textBoxProductPrice.Text == string.Empty)
            {
                MessageBox.Show("Please fill in the fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Product isRecorded = db.Products.SingleOrDefault(x => x.Name == product.Name);
                if (isRecorded != null)
                {
                    MessageBox.Show("This product is already added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    product.Name = textBoxProductName.Text;
                    product.CategoryId = (int)comboBoxCatOfProd.SelectedValue;
                    product.Description = textBoxProductDesc.Text;
                    product.Price = Convert.ToDecimal(textBoxProductPrice.Text);
                    int affectedRow = productOperations.AddProduct(product);
                    if (affectedRow > 0)
                    {
                        MessageBox.Show("Product adding is successful!", "Information", MessageBoxButtons.OK);
                        Cleartxt(this);
                        getProducts();
                        FillAllComboBox();
                    }
                    else
                    {
                        MessageBox.Show("Product is couldn't be added!", "Information", MessageBoxButtons.OK);
                    }
                }
            }
        }

        public void FillAllComboBox()
        {
            //categories of product comboBox
            comboBoxCatOfProd.DataSource = db.Categories.ToList();
            comboBoxCatOfProd.DisplayMember = "Name";
            comboBoxCatOfProd.ValueMember = "Id";
            //products comboBox
            comboBoxProducts.DataSource = db.Products.ToList();
            comboBoxProducts.DisplayMember = "Name";
            comboBoxProducts.ValueMember = "Id";
        }


        private void comboBoxCatOfProd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedCategoryId = (int)comboBoxCatOfProd.SelectedValue;
            var category = productOperations.GetCategoryById(selectedCategoryId);
            selectedCategory = category;
        }

        private void comboBoxProducts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedProductId = (int)comboBoxProducts.SelectedValue;
            var product = productOperations.GetProductById(selectedProductId);
            selectedProduct = product;
            textBoxUpdProdName.Text = product.Name;
            textBoxUpdProdDesc.Text = product.Description;
            textBoxUpdPrice.Text=product.Price.ToString();

            //seçilen ürünün kategorisini de değiştirebilmek için yeni bir comboBox
            comboBoxUpdCtOfPro.DataSource = db.Categories.ToList();
            comboBoxUpdCtOfPro.DisplayMember = "Name";
            comboBoxUpdCtOfPro.ValueMember = "Id";

            comboBoxUpdCtOfPro.SelectedValue = product.CategoryId;
        }

        private void buttonUpdateProd_Click(object sender, EventArgs e)
        {
            if (textBoxUpdProdName.Text == string.Empty || textBoxUpdProdDesc.Text == string.Empty || textBoxUpdPrice.Text == string.Empty)
            {
                MessageBox.Show("Please fill in the fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                selectedProduct.Name = textBoxUpdProdName.Text;
                selectedProduct.Description = textBoxUpdProdDesc.Text;
                selectedProduct.Price = Convert.ToDecimal(textBoxUpdPrice.Text);

                int selectedCategoryId = (int)comboBoxUpdCtOfPro.SelectedValue;//
                var category = productOperations.GetCategoryById(selectedCategoryId);
                selectedProduct.CategoryId = category.Id;

                int affectedRow = productOperations.UpdateProduct(selectedProduct);
                if (affectedRow > 0)
                {
                    MessageBox.Show("Product updating is successful!", "Information", MessageBoxButtons.OK);
                    getProducts();
                    FillAllComboBox();
                    Cleartxt(this);
                }
                else
                {
                    MessageBox.Show("Product is couldn't be updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void comboBoxUpdCtOfPro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedCategoryId = (int)comboBoxCatOfProd.SelectedValue;
            var category = productOperations.GetCategoryById(selectedCategoryId);
            selectedCategory = category;
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Delete this product? {selectedProduct.Name}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int affectedRow = productOperations.DeleteProduct(selectedProduct);
                if (affectedRow > 0)
                {
                    MessageBox.Show("Product deleting is successful!", "Information", MessageBoxButtons.OK);
                    getProducts();
                    FillAllComboBox();
                    Cleartxt(this);
                }
                else
                {
                    MessageBox.Show("Product is couldn't be deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public static void Cleartxt(Control ctl)
        {
            foreach (Control c in ctl.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGoCategoryOp_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CategoryOperations"] == null)
            {
                Form CategoryOperations = new CategoryForm();
                CategoryOperations.Show();
            }
        }
    }
}
