using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CRM_Semester_work
{
    public partial class Sales : Form
    {
        // Path to the SQLite database file
        string dbPath = "data.db";

        // Constructor for the Sales form
        public Sales()
        {
            InitializeComponent();

            // Load data into the DataGridView on form initialization
            LoadDataToDataGridView(dbPath, "Sales");
        }

        // Event handler for clicking on the "Clients" navigation label
        private void clients_navbar_label_Click(object sender, EventArgs e)
        {
            // Show the Clients form and hide the current form
            Clients clients = new Clients();
            clients.Show();
            this.Hide();
        }

        // Method to load data into the DataGridView from an SQLite database
        private void LoadDataToDataGridView(string databasePath, string tableName)
        {
            string connectionString = $"Data Source={databasePath};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Clear existing rows in the DataGridView
                dataGridView1.Rows.Clear();

                // Execute a SELECT query to retrieve data from the SQLite database
                string query = $"SELECT * FROM {tableName}";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Get data from SQLiteDataReader and add it to the DataGridView
                            object[] rowData = new object[reader.FieldCount];
                            reader.GetValues(rowData);

                            dataGridView1.Rows.Add(rowData);
                        }
                    }
                }
            }
        }

        // Event handler for clicking on the "Storage" navigation label
        private void storage_navbar_label_Click(object sender, EventArgs e)
        {
            // Show the Storage form and hide the current form
            Storage storage = new Storage();
            storage.Show();
            this.Hide();
        }

        // Event handler for clicking on the "Add Sale" button
        private void add_sale_button_Click_1(object sender, EventArgs e)
        {
            // Show the SalesModalForm for adding a new sale
            SalesModalForm modalForm = new SalesModalForm();

            // If the form is closed with the OK result
            if (modalForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Database created and test data added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataToDataGridView(dbPath, "Sales");
            }
        }
    }
}
