using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CRM_Semester_work
{
    public partial class EditSalesModalForm : Form
    {
        // Variables to store the data for the sale
        private int saleId;
        private string originalName;
        private string originalCompany;
        private string originalQuantity;
        private string originalPrice;

        public EditSalesModalForm(int id, string name, string company, string quantity, string price)
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);

            // Store the original values
            saleId = id;
            originalName = name;
            originalCompany = company;
            originalQuantity = quantity;
            originalPrice = price;

            // Initialize the form controls with the original values
            nameProduct.Text = originalName;
            companyName.Text = originalCompany;
            salesAmount.Text = originalPrice;
            quantityProduct.Text = originalQuantity;
        }
        
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
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // Load data into ComboBoxes and set maximum value for salesAmount
            LoadDataFromSQLite();
            salesAmount.Maximum = 100000000;

            // Attach event handler for the selected index change of nameProduct ComboBox
            nameProduct.SelectedIndexChanged += NameProduct_SelectedIndexChanged;
        }
        
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

        private void add_sale_button_Click(object sender, EventArgs e)
        {
            // Get the updated values from the form controls
            string updatedName = nameProduct.Text;
            string updatedCompany = companyName.Text;
            string updatedQuantity = salesAmount.Text;
            string updatedPrice = quantityProduct.Text;

            // Check if any values were changed
            if (ValuesChanged(updatedName, updatedCompany, updatedQuantity, updatedPrice))
            {
                // Update the record in the SQLite database
                UpdateSaleInDatabase(updatedName, updatedCompany, updatedQuantity, updatedPrice);

                // Close the form with OK result
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("No changes detected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValuesChanged(string name, string company, string quantity, string price)
        {
            // Check if any values were changed
            return !(
                string.Equals(name, originalName) &&
                string.Equals(company, originalCompany) &&
                string.Equals(quantity, originalQuantity) &&
                string.Equals(price, originalPrice)
            );
        }

        private void UpdateSaleInDatabase(string name, string company, string quantity, string price)
        {
            string dbPath = "data.db";
            string connectionString = $"Data Source={dbPath};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Update the sale with the specified ID
                using (SQLiteCommand command = new SQLiteCommand("UPDATE Sales SET ProductName = @Name, CompanyName = @Company, Quantity = @Quantity, Price = @Price WHERE ID = @ID", connection))
                {
                    command.Parameters.AddWithValue("@ID", saleId);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Company", company);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Price", price);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
