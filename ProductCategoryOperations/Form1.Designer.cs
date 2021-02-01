
namespace ProductCategoryOperations
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
            this.buttonGoCategories = new System.Windows.Forms.Button();
            this.buttonGoProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGoCategories
            // 
            this.buttonGoCategories.Location = new System.Drawing.Point(123, 86);
            this.buttonGoCategories.Name = "buttonGoCategories";
            this.buttonGoCategories.Size = new System.Drawing.Size(129, 43);
            this.buttonGoCategories.TabIndex = 0;
            this.buttonGoCategories.Text = "Go to Category Operations";
            this.buttonGoCategories.UseVisualStyleBackColor = true;
            this.buttonGoCategories.Click += new System.EventHandler(this.buttonGoCategories_Click);
            // 
            // buttonGoProducts
            // 
            this.buttonGoProducts.Location = new System.Drawing.Point(331, 86);
            this.buttonGoProducts.Name = "buttonGoProducts";
            this.buttonGoProducts.Size = new System.Drawing.Size(129, 43);
            this.buttonGoProducts.TabIndex = 1;
            this.buttonGoProducts.Text = "Go to Product Operations";
            this.buttonGoProducts.UseVisualStyleBackColor = true;
            this.buttonGoProducts.Click += new System.EventHandler(this.buttonGoProducts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGoProducts);
            this.Controls.Add(this.buttonGoCategories);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGoCategories;
        private System.Windows.Forms.Button buttonGoProducts;
    }
}

