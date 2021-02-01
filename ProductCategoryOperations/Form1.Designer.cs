
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGoCategories
            // 
            this.buttonGoCategories.Location = new System.Drawing.Point(346, 49);
            this.buttonGoCategories.Name = "buttonGoCategories";
            this.buttonGoCategories.Size = new System.Drawing.Size(221, 54);
            this.buttonGoCategories.TabIndex = 0;
            this.buttonGoCategories.Text = "Go to Category Operations";
            this.buttonGoCategories.UseVisualStyleBackColor = true;
            this.buttonGoCategories.Click += new System.EventHandler(this.buttonGoCategories_Click);
            // 
            // buttonGoProducts
            // 
            this.buttonGoProducts.Location = new System.Drawing.Point(346, 141);
            this.buttonGoProducts.Name = "buttonGoProducts";
            this.buttonGoProducts.Size = new System.Drawing.Size(221, 54);
            this.buttonGoProducts.TabIndex = 1;
            this.buttonGoProducts.Text = "Go to Product Operations";
            this.buttonGoProducts.UseVisualStyleBackColor = true;
            this.buttonGoProducts.Click += new System.EventHandler(this.buttonGoProducts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Press to go to Category Operations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Press to go to Product Operations";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(125, 327);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(92, 33);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Exit the Program";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGoProducts);
            this.Controls.Add(this.buttonGoCategories);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGoCategories;
        private System.Windows.Forms.Button buttonGoProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label3;
    }
}

