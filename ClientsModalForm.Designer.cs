using System.ComponentModel;

namespace CRM_Semester_work
{
    partial class ClientsModalForm
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
            this.add_item_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nameCompany = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emailCompany = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameContactPerson = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneCompany = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // add_item_button
            // 
            this.add_item_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.add_item_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_item_button.ForeColor = System.Drawing.Color.White;
            this.add_item_button.Location = new System.Drawing.Point(30, 378);
            this.add_item_button.Name = "add_item_button";
            this.add_item_button.Size = new System.Drawing.Size(228, 51);
            this.add_item_button.TabIndex = 0;
            this.add_item_button.Text = "Add";
            this.add_item_button.UseVisualStyleBackColor = false;
            this.add_item_button.Click += new System.EventHandler(this.add_item_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(30, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 30);
            this.textBox1.TabIndex = 1;
            // 
            // nameCompany
            // 
            this.nameCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCompany.Location = new System.Drawing.Point(30, 31);
            this.nameCompany.Margin = new System.Windows.Forms.Padding(0);
            this.nameCompany.Name = "nameCompany";
            this.nameCompany.Size = new System.Drawing.Size(204, 34);
            this.nameCompany.TabIndex = 2;
            this.nameCompany.Text = "Name company";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email";
            // 
            // emailCompany
            // 
            this.emailCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailCompany.Location = new System.Drawing.Point(30, 146);
            this.emailCompany.Name = "emailCompany";
            this.emailCompany.Size = new System.Drawing.Size(228, 30);
            this.emailCompany.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contact Person Name Surname";
            // 
            // nameContactPerson
            // 
            this.nameContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameContactPerson.Location = new System.Drawing.Point(30, 224);
            this.nameContactPerson.Name = "nameContactPerson";
            this.nameContactPerson.Size = new System.Drawing.Size(228, 30);
            this.nameContactPerson.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 267);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone";
            // 
            // phoneCompany
            // 
            this.phoneCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneCompany.Location = new System.Drawing.Point(30, 304);
            this.phoneCompany.Name = "phoneCompany";
            this.phoneCompany.Size = new System.Drawing.Size(228, 30);
            this.phoneCompany.TabIndex = 7;
            // 
            // ClientsModalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneCompany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameContactPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailCompany);
            this.Controls.Add(this.nameCompany);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.add_item_button);
            this.Name = "ClientsModalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyModalForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label nameCompany;

        private System.Windows.Forms.TextBox emailCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameContactPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneCompany;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button add_item_button;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}