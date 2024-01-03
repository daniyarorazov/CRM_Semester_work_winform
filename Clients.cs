using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Semester_work
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Создаем таблицу данных
            dataGridView1.Rows.Add(1, "Microsoft", "microsoft@gmail.com", "John Doe", "+1-202-555-0176");
            dataGridView1.Rows.Add(2, "Apple", "apple@gmail.com", "John Doe", "+1-202-555-0176");
            dataGridView1.Rows.Add(3, "Google", "google@gmail.com", "John Doe", "+1-202-555-0176");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }


        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Storage storage = new Storage();
            storage.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            this.Hide();
        }
    }
}
