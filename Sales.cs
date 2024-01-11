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
            AddButtonColumns();

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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;

                // Check if "Delete" button was clicked
                if (e.ColumnIndex == dataGridView1.Columns["btnDelete"].Index)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Extract the ID for deletion
                        int productId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["id_client"].Value);
                        DeleteSaleFromDatabase(productId);
                        LoadDataToDataGridView(dbPath, "Sales");
                    }
                }
                else if (e.ColumnIndex == dataGridView1.Columns["btnEdit"].Index)
                {
                    // Extract data for editing
                    string name = dataGridView1.Rows[rowIndex].Cells["Name"].Value.ToString();
                    string company = dataGridView1.Rows[rowIndex].Cells["Company"].Value.ToString();
                    string quantity = dataGridView1.Rows[rowIndex].Cells["Quantity"].Value.ToString();
                    string price = dataGridView1.Rows[rowIndex].Cells["sumSales"].Value.ToString();
                    int productId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["id_client"].Value);

                    // Show the EditStorageModalForm for editing the product
                    EditSalesModalForm modalForm = new EditSalesModalForm(productId, name, company, quantity, price);

                    // If the form is closed with the OK result
                    if (modalForm.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Product updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataToDataGridView(dbPath, "Sales");
                    }
                }
            }
        }

        // Method to delete a sale from the database
        private void DeleteSaleFromDatabase(int saleId)
        {
            string connectionString = $"Data Source={dbPath};Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Delete the sale with the specified ID
                using (SQLiteCommand command = new SQLiteCommand("DELETE FROM Sales WHERE ID = @ID", connection))
                {
                    command.Parameters.AddWithValue("@ID", saleId);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void AddButtonColumns()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Edit";
            buttonColumn.Name = "btnEdit";
            buttonColumn.Text = "Edit";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonColumn);

            DataGridViewButtonColumn buttonColumn2 = new DataGridViewButtonColumn();
            buttonColumn2.HeaderText = "Delete";
            buttonColumn2.Name = "btnDelete";
            buttonColumn2.Text = "Delete";
            buttonColumn2.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonColumn2);
        }
    }
}
