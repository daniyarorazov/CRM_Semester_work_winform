using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace CRM_Semester_work
{
    public partial class Storage : Form
    {
        // Path to the SQLite database file
        string dbPath = "data.db";

        public Storage()
        {
            InitializeComponent();
            AddButtonColumns();
            this.Load += new System.EventHandler(this.Storage_Load);
        }

        // Event handler for the form's Load event
        private void Storage_Load(object sender, EventArgs e)
        {
            // Load data from the SQLite database into the DataGridView
            LoadDataToDataGridView(dbPath, "Storage");
        }

        // Event handler for clicking on the "Clients" navigation label
        private void clients_navbar_label_Click(object sender, EventArgs e)
        {
            // Show the Clients form and hide the current form
            Clients clients = new Clients();
            clients.Show();
            this.Hide();
        }

        // Event handler for clicking on the "Sales" navigation label
        private void sales_navbar_label_Click(object sender, EventArgs e)
        {
            // Show the Sales form and hide the current form
            Sales sales = new Sales();
            sales.Show();
            this.Hide();
        }

        // Method to load data into the DataGridView from an SQLite database
        private void LoadDataToDataGridView(string databasePath, string tableName)
        {
            // Check if the file exists
            if (!File.Exists(databasePath))
            {
                MessageBox.Show("Error: Database file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Clear existing rows in the DataGridView
            dataGridView1.Rows.Clear();

            string connectionString = $"Data Source={databasePath};Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Load data into the DataGridView
                using (SQLiteCommand command = new SQLiteCommand($"SELECT * FROM {tableName}", connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            object[] rowData = new object[reader.FieldCount];
                            reader.GetValues(rowData);
                            dataGridView1.Rows.Add(rowData);
                        }
                    }
                }
            }
        }

        // Event handler for clicking on the "Add Product" button
        private void add_product_button_Click(object sender, EventArgs e)
        {
            // Show the StorageModalForm for adding a new product
            StorageModalForm modalForm = new StorageModalForm();

            // If the form is closed with the OK result
            if (modalForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Added new product", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataToDataGridView(dbPath, "Storage");
            }
        }

        // Event handler for clicking on the "Edit Product" button
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["btnDelete"].Index)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Extract the ID for deletion
                    int productId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_client"].Value);
                    DeleteProductFromDatabase(productId);
                    LoadDataToDataGridView(dbPath, "Storage");
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["btnEdit"].Index)
            {
                if (e.RowIndex >= 0)
                {
                    int rowIndex = e.RowIndex;

                    // Extract data for editing
                    string name = dataGridView1.Rows[rowIndex].Cells["Name"].Value.ToString();
                    string category = dataGridView1.Rows[rowIndex].Cells["Category"].Value.ToString();
                    string quantity = dataGridView1.Rows[rowIndex].Cells["Quantity"].Value.ToString();
                    string price = dataGridView1.Rows[rowIndex].Cells["Price"].Value.ToString();
                    int productId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["id_client"].Value);

                    // Show the EditStorageModalForm for editing the product
                    EditStorageModalForm modalForm = new EditStorageModalForm(productId, name, category, quantity, price);

                    // If the form is closed with the OK result
                    if (modalForm.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Product updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataToDataGridView(dbPath, "Storage");
                    }
                }
            }
        }


        // Method to delete a product from the database
        private void DeleteProductFromDatabase(int productId)
        {
            string connectionString = $"Data Source={dbPath};Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Delete the product with the specified ID
                using (SQLiteCommand command = new SQLiteCommand("DELETE FROM Storage WHERE ID = @ID", connection))
                {
                    command.Parameters.AddWithValue("@ID", productId);
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
