using System.ComponentModel;

namespace CRM_Semester_work
{
    partial class StorageModalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameCompany = new System.Windows.Forms.Label();
            this.nameProduct = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.categoryProduct = new System.Windows.Forms.ComboBox();
            this.priceProduct = new System.Windows.Forms.NumericUpDown();
            this.quantityProduct = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.priceProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 34);
            this.label3.TabIndex = 17;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 34);
            this.label2.TabIndex = 15;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "Category";
            // 
            // nameCompany
            // 
            this.nameCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCompany.Location = new System.Drawing.Point(31, 21);
            this.nameCompany.Margin = new System.Windows.Forms.Padding(0);
            this.nameCompany.Name = "nameCompany";
            this.nameCompany.Size = new System.Drawing.Size(204, 34);
            this.nameCompany.TabIndex = 11;
            this.nameCompany.Text = "Name item";
            // 
            // nameProduct
            // 
            this.nameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameProduct.Location = new System.Drawing.Point(31, 58);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(228, 30);
            this.nameProduct.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(31, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 51);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // categoryProduct
            // 
            this.categoryProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryProduct.FormattingEnabled = true;
            this.categoryProduct.Items.AddRange(new object[] { "TVs", "Laptops", "Desktop PCs", "Smartphones", "Tablets", "Electronics Accessories", "Photo and Video Equipment", "Audio Devices", "Gaming Devices and Consoles", "Smart Devices and Home Automation", "Wearable Electronics (Smartwatches, Fitness Trackers, etc.)", "Computer Components and Accessories", "Networking Equipment", "Car Electronics", "E-books and E-readers", "Video Games and Gaming Accessories", "Electronics for Home and Kitchen", "Gadgets and Tech Innovations", "Robots and Drones", "Virtual Reality and VR Devices" });
            this.categoryProduct.Location = new System.Drawing.Point(31, 136);
            this.categoryProduct.Name = "categoryProduct";
            this.categoryProduct.Size = new System.Drawing.Size(228, 33);
            this.categoryProduct.TabIndex = 18;
            // 
            // priceProduct
            // 
            this.priceProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.priceProduct.Location = new System.Drawing.Point(31, 294);
            this.priceProduct.Name = "priceProduct";
            this.priceProduct.Size = new System.Drawing.Size(228, 34);
            this.priceProduct.TabIndex = 22;
            // 
            // quantityProduct
            // 
            this.quantityProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.quantityProduct.Location = new System.Drawing.Point(31, 214);
            this.quantityProduct.Name = "quantityProduct";
            this.quantityProduct.Size = new System.Drawing.Size(228, 34);
            this.quantityProduct.TabIndex = 23;
            // 
            // StorageModalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quantityProduct);
            this.Controls.Add(this.priceProduct);
            this.Controls.Add(this.categoryProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameCompany);
            this.Controls.Add(this.nameProduct);
            this.Controls.Add(this.button1);
            this.Name = "StorageModalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StorageModalForm";
            ((System.ComponentModel.ISupportInitialize)(this.priceProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.NumericUpDown priceProduct;
        private System.Windows.Forms.NumericUpDown quantityProduct;

        private System.Windows.Forms.ComboBox categoryProduct;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameCompany;
        private System.Windows.Forms.TextBox nameProduct;
        private System.Windows.Forms.Button button1;

        #endregion
    }
}