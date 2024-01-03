using System;
using System.Windows.Forms;

namespace CRM_Semester_work
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Storage storage = new Storage();
            storage.Show();
            this.Hide();
        }
    }
}