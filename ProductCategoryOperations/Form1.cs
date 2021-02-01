using ProductCategoryOperations.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductCategoryOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGoCategories_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CategoryOperations"] == null)
            {
                Form CategoryOperations = new CategoryForm();
                CategoryOperations.Show();
            }

        }

        private void buttonGoProducts_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ProductOperations"] == null)
            {
                Form ProductOperations = new ProductForm();
                ProductOperations.Show();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
