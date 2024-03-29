﻿using System.Windows.Forms;

namespace CRM_Semester_work
{
    partial class Clients
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sales_navbar_label = new System.Windows.Forms.Label();
            this.storage_navbar_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.add_client_button = new System.Windows.Forms.Button();
            this.id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact_person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.register_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.sales_navbar_label);
            this.panel1.Controls.Add(this.storage_navbar_label);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 59);
            this.panel1.TabIndex = 0;
            // 
            // sales_navbar_label
            // 
            this.sales_navbar_label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sales_navbar_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(52)))), ((int)(((byte)(139)))));
            this.sales_navbar_label.Location = new System.Drawing.Point(866, 15);
            this.sales_navbar_label.Name = "sales_navbar_label";
            this.sales_navbar_label.Size = new System.Drawing.Size(100, 32);
            this.sales_navbar_label.TabIndex = 3;
            this.sales_navbar_label.Text = "Sales";
            this.sales_navbar_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sales_navbar_label.Click += new System.EventHandler(this.sales_navbar_label_Click);
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(654, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clients";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.id_client, this.company, this.email, this.contact_person, this.phone, this.register_date, this.last_contact });
            this.dataGridView1.Location = new System.Drawing.Point(0, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(988, 406);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.label5.Location = new System.Drawing.Point(0, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 45);
            this.label5.TabIndex = 2;
            this.label5.Text = "Clients";
            // 
            // add_client_button
            // 
            this.add_client_button.Location = new System.Drawing.Point(125, 83);
            this.add_client_button.Name = "add_client_button";
            this.add_client_button.Size = new System.Drawing.Size(126, 34);
            this.add_client_button.TabIndex = 3;
            this.add_client_button.Text = "New client";
            this.add_client_button.UseVisualStyleBackColor = true;
            this.add_client_button.Click += new System.EventHandler(this.add_client_button_Click);
            // 
            // id_client
            // 
            this.id_client.HeaderText = "ID";
            this.id_client.Name = "id_client";
            // 
            // company
            // 
            this.company.HeaderText = "Company";
            this.company.MinimumWidth = 200;
            this.company.Name = "company";
            this.company.Width = 200;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 200;
            this.email.Name = "email";
            this.email.Width = 200;
            // 
            // contact_person
            // 
            this.contact_person.DataPropertyName = "ContactPerson";
            this.contact_person.HeaderText = "Contact Person";
            this.contact_person.MinimumWidth = 200;
            this.contact_person.Name = "contact_person";
            this.contact_person.Width = 200;
            // 
            // phone
            // 
            this.phone.HeaderText = "Phone";
            this.phone.MinimumWidth = 200;
            this.phone.Name = "phone";
            this.phone.Width = 200;
            // 
            // register_date
            // 
            this.register_date.HeaderText = "Register Date";
            this.register_date.Name = "register_date";
            // 
            // last_contact
            // 
            this.last_contact.HeaderText = "Last contact";
            this.last_contact.Name = "last_contact";
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 535);
            this.Controls.Add(this.add_client_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn register_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_contact;

        private System.Windows.Forms.Button add_client_button;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label storage_navbar_label;
        private System.Windows.Forms.Label sales_navbar_label;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.DataGridViewTextBoxColumn id_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact_person;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}

