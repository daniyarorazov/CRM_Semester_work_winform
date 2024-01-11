using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace CRM_Semester_work
{
    public partial class StorageModalForm : Form
    {
        // Path to the SQLite database file
        string dbPath = "data.db";

        public StorageModalForm()
        {
            InitializeComponent();
        }

        // Event handler for the "Add Product" button click
        private void add_product_button_Click(object sender, EventArgs e)
        {
            // Get values from the input fields
            string name = nameProduct.Text;
            string category = categoryProduct.Text;
            string quantity = quantityProduct.Text;
            string price = priceProduct.Text;

            // Check if any of the required fields are empty
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(quantity) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Fill in all fields!");
                return;
            }

            // Add data to the SQLite database
            AddDataToSQLite(name, category, quantity, price);

            // Close the modal window with the OK result
            DialogResult = DialogResult.OK;
        }

        // Method to add data to the SQLite database
        private void AddDataToSQLite(string name, string category, string quantity, string price)
        {
            // Check if the file exists
            if (!File.Exists(dbPath))
            {
                MessageBox.Show("Error: Database file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = $"Data Source={dbPath};Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Insert data into the Storage table
                using (SQLiteCommand command = new SQLiteCommand("INSERT INTO Storage (ProductName, Category, Quantity, Price, DateAdded) VALUES (@Name, @Category, @Quantity, @Price, @DateAdded)", connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Category", category);
                    command.Parameters.AddWithValue("@Quantity", int.Parse(quantity));
                    command.Parameters.AddWithValue("@Price", decimal.Parse(price));
                    command.Parameters.AddWithValue("@DateAdded", DateTime.Now.ToShortDateString());

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
