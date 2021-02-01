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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        CategoryOperations categoryOperations=new CategoryOperations();
        Category newCategory = new Category();
        ProductCategoryDB db = new ProductCategoryDB();
        Category selectedCategory;
        void getCategories()
        {
            dataGridViewCategories.DataSource = db.Categories.ToList();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            if (textBoxCategoryName.Text == string.Empty || textBoxCategoryDesc.Text == string.Empty)
            {
                MessageBox.Show("Please fill in the fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Category isRecorded = db.Categories.SingleOrDefault(x => x.Name == category.Name);
                if (isRecorded != null)
                {
                    MessageBox.Show("This category is already added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    category.Name = textBoxCategoryName.Text;
                    category.Description = textBoxCategoryDesc.Text;
                    int affectedRow = categoryOperations.AddCategory(category);
                    if (affectedRow > 0)
                    {
                        MessageBox.Show("Category adding is successful!", "Information", MessageBoxButtons.OK);
                        getCategories();
                        FillComboBoxCategories();
                        Cleartxt(this);
                    }
                    else
                    {
                        MessageBox.Show("Category is couldn't be added!", "Information", MessageBoxButtons.OK);
                    }
                }
            }         
        }

        public void FillComboBoxCategories()
        {
            comboBoxCategories.DataSource = db.Categories.ToList();
            comboBoxCategories.DisplayMember = "Name";
            comboBoxCategories.ValueMember = "Id";
        }

        private void CategoryOperations_Load(object sender, EventArgs e)
        {
            getCategories();
            FillComboBoxCategories();
        }

        private void comboBoxCategories_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedCategoryId = (int)comboBoxCategories.SelectedValue;
            var category = categoryOperations.GetCategoriesById(selectedCategoryId);
            selectedCategory = category;
            textBoxUpdCatName.Text = category.Name;
            textBoxUpdCatDesc.Text = category.Description;
        }

        private void buttonUpdateCat_Click(object sender, EventArgs e)
        {
            selectedCategory.Name = textBoxUpdCatName.Text;
            selectedCategory.Description = textBoxUpdCatDesc.Text;
            int affectedRow = categoryOperations.UpdateCategory(selectedCategory);
            if (affectedRow > 0)
            {
                MessageBox.Show("Category updating is successful!", "Information", MessageBoxButtons.OK);
                Cleartxt(this);
                getCategories();
                FillComboBoxCategories();
            }
            else
            {
                MessageBox.Show("Category is couldn't be updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Delete this category? {selectedCategory.Name}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                categoryOperations.DeleteCategory(selectedCategory);
                FillComboBoxCategories();
                getCategories();
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

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
