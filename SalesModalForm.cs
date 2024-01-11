using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace CRM_Semester_work
{
    public partial class SalesModalForm : Form
    {
        public SalesModalForm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        // Method to load data into ComboBoxes from the SQLite database
        private void LoadDataFromSQLite()
        {
            // Path to the SQLite database file
            string sqliteDbPath = "data.db";

            string connectionString = $"Data Source={sqliteDbPath};Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Clear existing items in ComboBoxes
                nameProduct.Items.Clear();
                companyName.Items.Clear();

                // Load data into the nameProduct ComboBox
                using (SQLiteCommand command = new SQLiteCommand("SELECT ProductName FROM Storage", connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nameProduct.Items.Add(reader["ProductName"].ToString());
                        }
                    }
                }

                // Load data into the companyName ComboBox
                using (SQLiteCommand command = new SQLiteCommand("SELECT Company FROM Clients", connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            companyName.Items.Add(reader["Company"].ToString());
                        }
                    }
                }
            }
        }

        // Event handler for the form's Load event
        private void Form1_Load(object sender, EventArgs e)
        {
            // Load data into ComboBoxes and set maximum value for salesAmount
            LoadDataFromSQLite();
            salesAmount.Maximum = 100000000;

            // Attach event handler for the selected index change of nameProduct ComboBox
            nameProduct.SelectedIndexChanged += NameProduct_SelectedIndexChanged;
        }

        // Event handler for the selected index change of nameProduct ComboBox
        private void NameProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected product
            string selectedProduct = nameProduct.SelectedItem?.ToString();

            // If a product is selected, set the maximum value for quantityProduct
            if (!string.IsNullOrEmpty(selectedProduct))
            {
                SetMaxQuantityForProduct(selectedProduct);
            }
        }

        // Method to set the maximum quantity for a selected product
        private void SetMaxQuantityForProduct(string productName)
        {
            // Path to the SQLite database file
            string sqliteDbPath = "data.db";

            string connectionString = $"Data Source={sqliteDbPath};Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Search for the product in the "Storage" table and get its quantity
                using (SQLiteCommand command = new SQLiteCommand($"SELECT Quantity FROM Storage WHERE ProductName = '{productName}'", connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int quantity))
                    {
                        // Found the product, set the maximum value for quantityProduct
                        quantityProduct.Maximum = quantity;
                        return;
                    }
                }

                // If the product is not found, set a fixed maximum value
                quantityProduct.Maximum = 200;
            }
        }

        // Event handler for the button click to add a new sale
        private void add_sale_button_Click(object sender, EventArgs e)
        {
            // Get values from the input fields
            string name = nameProduct.Text;
            string company = companyName.Text;
            string quantity = quantityProduct.Text;
            string price = salesAmount.Text;

            // Check if any of the required fields are empty
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(company) || string.IsNullOrEmpty(quantity) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Fill in all fields!");
                return;
            }

            // Filename for the SQLite database
            string sqliteDbPath = "data.db";

            // Add data to the SQLite database
            AddDataToSQLite(sqliteDbPath, name, company, quantity, price);

            // Close the modal form with the OK result
            DialogResult = DialogResult.OK;
        }

        // Method to add data to the SQLite database
        private void AddDataToSQLite(string databasePath, string name, string company, string quantity, string price)
        {
            string connectionString = $"Data Source={databasePath};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Execute an INSERT query to add data to the "Sales" table
                using (SQLiteCommand command = new SQLiteCommand("INSERT INTO Sales (ProductName, Price, CompanyName, Quantity, SaleDate) VALUES (@Name, @Price, @Company, @Quantity, @Date)", connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Company", company);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Date", DateTime.Now.ToShortDateString());

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
