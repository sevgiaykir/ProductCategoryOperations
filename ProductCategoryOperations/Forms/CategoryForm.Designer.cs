
namespace ProductCategoryOperations.Forms
{
    partial class CategoryForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.textBoxCategoryDesc = new System.Windows.Forms.TextBox();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.textBoxUpdCatName = new System.Windows.Forms.TextBox();
            this.textBoxUpdCatDesc = new System.Windows.Forms.TextBox();
            this.buttonUpdateCat = new System.Windows.Forms.Button();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add New Category:";
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Location = new System.Drawing.Point(62, 47);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.RowHeadersWidth = 51;
            this.dataGridViewCategories.RowTemplate.Height = 24;
            this.dataGridViewCategories.Size = new System.Drawing.Size(628, 134);
            this.dataGridViewCategories.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "CATEGORIES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Category Description:";
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(211, 226);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(130, 22);
            this.textBoxCategoryName.TabIndex = 8;
            // 
            // textBoxCategoryDesc
            // 
            this.textBoxCategoryDesc.Location = new System.Drawing.Point(211, 256);
            this.textBoxCategoryDesc.Multiline = true;
            this.textBoxCategoryDesc.Name = "textBoxCategoryDesc";
            this.textBoxCategoryDesc.Size = new System.Drawing.Size(130, 40);
            this.textBoxCategoryDesc.TabIndex = 9;
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(62, 296);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(104, 33);
            this.buttonAddCategory.TabIndex = 10;
            this.buttonAddCategory.Text = "Add Category";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Update Selected Category:";
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(427, 229);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(239, 24);
            this.comboBoxCategories.TabIndex = 12;
            this.comboBoxCategories.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCategories_SelectionChangeCommitted);
            // 
            // textBoxUpdCatName
            // 
            this.textBoxUpdCatName.Location = new System.Drawing.Point(389, 319);
            this.textBoxUpdCatName.Name = "textBoxUpdCatName";
            this.textBoxUpdCatName.Size = new System.Drawing.Size(187, 22);
            this.textBoxUpdCatName.TabIndex = 13;
            // 
            // textBoxUpdCatDesc
            // 
            this.textBoxUpdCatDesc.Location = new System.Drawing.Point(389, 356);
            this.textBoxUpdCatDesc.Multiline = true;
            this.textBoxUpdCatDesc.Name = "textBoxUpdCatDesc";
            this.textBoxUpdCatDesc.Size = new System.Drawing.Size(187, 42);
            this.textBoxUpdCatDesc.TabIndex = 14;
            // 
            // buttonUpdateCat
            // 
            this.buttonUpdateCat.Location = new System.Drawing.Point(389, 413);
            this.buttonUpdateCat.Name = "buttonUpdateCat";
            this.buttonUpdateCat.Size = new System.Drawing.Size(148, 35);
            this.buttonUpdateCat.TabIndex = 15;
            this.buttonUpdateCat.Text = "Update Category";
            this.buttonUpdateCat.UseVisualStyleBackColor = true;
            this.buttonUpdateCat.Click += new System.EventHandler(this.buttonUpdateCat_Click);
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.Location = new System.Drawing.Point(654, 319);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(133, 50);
            this.buttonDeleteCategory.TabIndex = 16;
            this.buttonDeleteCategory.Text = "Delete Category";
            this.buttonDeleteCategory.UseVisualStyleBackColor = true;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(634, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Delete Selected Category:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Select Category:";
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Location = new System.Drawing.Point(59, 393);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(128, 55);
            this.buttonGoBack.TabIndex = 36;
            this.buttonGoBack.Text = "Go Back To Home Page";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // CategoryOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 497);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonDeleteCategory);
            this.Controls.Add(this.buttonUpdateCat);
            this.Controls.Add(this.textBoxUpdCatDesc);
            this.Controls.Add(this.textBoxUpdCatName);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAddCategory);
            this.Controls.Add(this.textBoxCategoryDesc);
            this.Controls.Add(this.textBoxCategoryName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewCategories);
            this.Controls.Add(this.label1);
            this.Name = "CategoryOperations";
            this.Text = "CategoryOperations";
            this.Load += new System.EventHandler(this.CategoryOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.TextBox textBoxCategoryDesc;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.TextBox textBoxUpdCatName;
        private System.Windows.Forms.TextBox textBoxUpdCatDesc;
        private System.Windows.Forms.Button buttonUpdateCat;
        private System.Windows.Forms.Button buttonDeleteCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonGoBack;
    }
}