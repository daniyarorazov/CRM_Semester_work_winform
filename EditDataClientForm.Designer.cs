using System.ComponentModel;

namespace CRM_Semester_work
{
    partial class EditDataClientForm
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
            this.phoneCompany = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameContactPerson = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailCompany = new System.Windows.Forms.TextBox();
            this.nameCompanyLabel = new System.Windows.Forms.Label();
            this.nameCompany = new System.Windows.Forms.TextBox();
            this.edit_item_button = new System.Windows.Forms.Button();
            this.clientId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 34);
            this.label3.TabIndex = 17;
            this.label3.Text = "Phone";
            // 
            // phoneCompany
            // 
            this.phoneCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneCompany.Location = new System.Drawing.Point(31, 297);
            this.phoneCompany.Name = "phoneCompany";
            this.phoneCompany.Size = new System.Drawing.Size(228, 30);
            this.phoneCompany.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 34);
            this.label2.TabIndex = 15;
            this.label2.Text = "Contact Person Name Surname";
            // 
            // nameContactPerson
            // 
            this.nameContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameContactPerson.Location = new System.Drawing.Point(31, 217);
            this.nameContactPerson.Name = "nameContactPerson";
            this.nameContactPerson.Size = new System.Drawing.Size(228, 30);
            this.nameContactPerson.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "Email";
            // 
            // emailCompany
            // 
            this.emailCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailCompany.Location = new System.Drawing.Point(31, 139);
            this.emailCompany.Name = "emailCompany";
            this.emailCompany.Size = new System.Drawing.Size(228, 30);
            this.emailCompany.TabIndex = 12;
            // 
            // nameCompanyLabel
            // 
            this.nameCompanyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCompanyLabel.Location = new System.Drawing.Point(31, 24);
            this.nameCompanyLabel.Margin = new System.Windows.Forms.Padding(0);
            this.nameCompanyLabel.Name = "nameCompanyLabel";
            this.nameCompanyLabel.Size = new System.Drawing.Size(204, 34);
            this.nameCompanyLabel.TabIndex = 11;
            this.nameCompanyLabel.Text = "Name company";
            // 
            // nameCompany
            // 
            this.nameCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCompany.Location = new System.Drawing.Point(31, 61);
            this.nameCompany.Name = "nameCompany";
            this.nameCompany.Size = new System.Drawing.Size(228, 30);
            this.nameCompany.TabIndex = 10;
            // 
            // edit_item_button
            // 
            this.edit_item_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.edit_item_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_item_button.ForeColor = System.Drawing.Color.White;
            this.edit_item_button.Location = new System.Drawing.Point(31, 371);
            this.edit_item_button.Name = "edit_item_button";
            this.edit_item_button.Size = new System.Drawing.Size(228, 51);
            this.edit_item_button.TabIndex = 9;
            this.edit_item_button.Text = "Edit";
            this.edit_item_button.UseVisualStyleBackColor = false;
            this.edit_item_button.Click += new System.EventHandler(this.edit_item_button_Click);
            // 
            // clientId
            // 
            this.clientId.Location = new System.Drawing.Point(688, 24);
            this.clientId.Name = "clientId";
            this.clientId.Size = new System.Drawing.Size(100, 31);
            this.clientId.TabIndex = 18;
            // 
            // EditDataClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clientId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneCompany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameContactPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailCompany);
            this.Controls.Add(this.nameCompanyLabel);
            this.Controls.Add(this.nameCompany);
            this.Controls.Add(this.edit_item_button);
            this.Name = "EditDataClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditDataClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label clientId;

        private System.Windows.Forms.Label nameCompanyLabel;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameContactPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailCompany;
        private System.Windows.Forms.TextBox nameCompany;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button edit_item_button;

        #endregion
    }
}