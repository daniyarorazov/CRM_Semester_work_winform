using System.ComponentModel;

namespace CRM_Semester_work
{
    partial class Sales
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.storage_navbar_label = new System.Windows.Forms.Label();
            this.clients_navbar_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_sale_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.storage_navbar_label);
            this.panel1.Controls.Add(this.clients_navbar_label);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 59);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(866, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sales";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // storage_navbar_label
            // 
            this.storage_navbar_label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.storage_navbar_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(52)))), ((int)(((byte)(139)))));
            this.storage_navbar_label.Location = new System.Drawing.Point(760, 15);
            this.storage_navbar_label.Name = "storage_navbar_label";
            this.storage_navbar_label.Size = new System.Drawing.Size(100, 32);
            this.storage_navbar_label.TabIndex = 2;
            this.storage_navbar_label.Text = "Storage";
            this.storage_navbar_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.storage_navbar_label.Click += new System.EventHandler(this.storage_navbar_label_Click);
            // 
            // clients_navbar_label
            // 
            this.clients_navbar_label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.clients_navbar_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(52)))), ((int)(((byte)(139)))));
            this.clients_navbar_label.Location = new System.Drawing.Point(654, 15);
            this.clients_navbar_label.Name = "clients_navbar_label";
            this.clients_navbar_label.Size = new System.Drawing.Size(100, 32);
            this.clients_navbar_label.TabIndex = 1;
            this.clients_navbar_label.Text = "Clients";
            this.clients_navbar_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clients_navbar_label.Click += new System.EventHandler(this.clients_navbar_label_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRM";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.label5.Location = new System.Drawing.Point(0, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 45);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sales";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.id_client, this.name, this.sumSales, this.company, this.quantity, this.dateSale });
            this.dataGridView1.Location = new System.Drawing.Point(0, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(979, 406);
            this.dataGridView1.TabIndex = 9;
            // 
            // id_client
            // 
            this.id_client.HeaderText = "ID";
            this.id_client.Name = "id_client";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // sumSales
            // 
            this.sumSales.HeaderText = "Sum Sale";
            this.sumSales.Name = "sumSales";
            // 
            // company
            // 
            this.company.HeaderText = "Company";
            this.company.Name = "company";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);

            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // dateSale
            // 
            this.dateSale.HeaderText = "Date of sale";
            this.dateSale.Name = "dateSale";
            // 
            // add_sale_button
            // 
            this.add_sale_button.Location = new System.Drawing.Point(118, 105);
            this.add_sale_button.Name = "add_sale_button";
            this.add_sale_button.Size = new System.Drawing.Size(148, 34);
            this.add_sale_button.TabIndex = 11;
            this.add_sale_button.Text = "New sale product";
            this.add_sale_button.UseVisualStyleBackColor = true;
            this.add_sale_button.Click += new System.EventHandler(this.add_sale_button_Click_1);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 565);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add_sale_button);
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;

        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSale;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label storage_navbar_label;
        private System.Windows.Forms.Label clients_navbar_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_client;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_sale_button;

        #endregion
    }
}