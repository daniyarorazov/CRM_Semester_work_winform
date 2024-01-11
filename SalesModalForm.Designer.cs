using System.ComponentModel;

namespace CRM_Semester_work
{
    partial class SalesModalForm
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
            this.add_sale_button = new System.Windows.Forms.Button();
            this.companyName = new System.Windows.Forms.ComboBox();
            this.nameProduct = new System.Windows.Forms.ComboBox();
            this.quantityProduct = new System.Windows.Forms.NumericUpDown();
            this.salesAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.quantityProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(40, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 34);
            this.label3.TabIndex = 17;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 34);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sales Amount (price)";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "Who bought product (Company/Client)";
            // 
            // nameCompany
            // 
            this.nameCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCompany.Location = new System.Drawing.Point(40, 24);
            this.nameCompany.Margin = new System.Windows.Forms.Padding(0);
            this.nameCompany.Name = "nameCompany";
            this.nameCompany.Size = new System.Drawing.Size(204, 34);
            this.nameCompany.TabIndex = 11;
            this.nameCompany.Text = "Name Product";
            // 
            // add_sale_button
            // 
            this.add_sale_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.add_sale_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_sale_button.ForeColor = System.Drawing.Color.White;
            this.add_sale_button.Location = new System.Drawing.Point(40, 371);
            this.add_sale_button.Name = "add_sale_button";
            this.add_sale_button.Size = new System.Drawing.Size(228, 51);
            this.add_sale_button.TabIndex = 9;
            this.add_sale_button.Text = "Add";
            this.add_sale_button.UseVisualStyleBackColor = false;
            this.add_sale_button.Click += new System.EventHandler(this.add_sale_button_Click);
            // 
            // companyName
            // 
            this.companyName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.companyName.FormattingEnabled = true;
            this.companyName.Location = new System.Drawing.Point(40, 139);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(228, 36);
            this.companyName.TabIndex = 18;
            // 
            // nameProduct
            // 
            this.nameProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nameProduct.FormattingEnabled = true;
            this.nameProduct.Location = new System.Drawing.Point(40, 61);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(228, 36);
            this.nameProduct.TabIndex = 19;
            // 
            // quantityProduct
            // 
            this.quantityProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.quantityProduct.Location = new System.Drawing.Point(40, 308);
            this.quantityProduct.Name = "quantityProduct";
            this.quantityProduct.Size = new System.Drawing.Size(228, 34);
            this.quantityProduct.TabIndex = 20;
            // 
            // salesAmount
            // 
            this.salesAmount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.salesAmount.Location = new System.Drawing.Point(40, 223);
            this.salesAmount.Name = "salesAmount";
            this.salesAmount.Size = new System.Drawing.Size(228, 34);
            this.salesAmount.TabIndex = 21;
            // 
            // SalesModalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salesAmount);
            this.Controls.Add(this.quantityProduct);
            this.Controls.Add(this.nameProduct);
            this.Controls.Add(this.companyName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameCompany);
            this.Controls.Add(this.add_sale_button);
            this.Name = "SalesModalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesModalForm";
            ((System.ComponentModel.ISupportInitialize)(this.quantityProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesAmount)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.NumericUpDown salesAmount;

        private System.Windows.Forms.NumericUpDown numericUpDown1;

        private System.Windows.Forms.NumericUpDown quantityProduct;

        private System.Windows.Forms.ComboBox nameProduct;

        private System.Windows.Forms.ComboBox companyName;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameCompany;
        private System.Windows.Forms.Button add_sale_button;

        #endregion
    }
}