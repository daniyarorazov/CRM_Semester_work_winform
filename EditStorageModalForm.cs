using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CRM_Semester_work
{
    public partial class EditStorageModalForm : Form
    {
        private string originalProductName;
        private string originalCategory;
        private string originalProductAmount;
        private string originalProductPrice;
        private int originalProductId;

        public EditStorageModalForm(int productId, string productName, string category, string productAmount, string productPrice)
        {
            InitializeComponent();

            // Fill the control values with the data passed from the DataGridViewRow
            originalProductName = productName;
            originalCategory = category;
            originalProductAmount = productAmount;
            originalProductPrice = productPrice;
            originalProductId = productId;

            // Set values in the controls
            nameProduct.Text = productName;
            categoryProduct.Text = category;
            quantityProduct.Text = productAmount;
            priceProduct.Text = productPrice;
        }

        // Event handler for the "Save Changes" button click
        private void add_product_button_Click(object sender, EventArgs e)
        {
            // Get the modified values from the controls
            string editedName = nameProduct.Text;
            string editedCategory = categoryProduct.Text;
            string editedQuantity = quantityProduct.Text;
            string editedPrice = priceProduct.Text;
            int id = originalProductId;

            // Check if any changes were made
            if (ValuesChanged(editedName, editedCategory, editedQuantity, editedPrice))
            {
                // If there are changes, call the method to save the changes
                SaveChangesToDatabase(id, editedName, editedCategory, editedQuantity, editedPrice);

                DialogResult = DialogResult.OK; // Close the form with the OK result
            }
            else
            {
                MessageBox.Show("No changes made", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Method to check if any changes were made
        private bool ValuesChanged(string editedName, string editedCategory, string editedQuantity, string editedPrice)
        {
            return !string.Equals(originalProductName, editedName) ||
                   !string.Equals(originalCategory, editedCategory) ||
                   !string.Equals(originalProductAmount, editedQuantity) ||
                   !string.Equals(originalProductPrice, editedPrice);
        }

        // Method to save changes to the database
        private void SaveChangesToDatabase(int OriginalID, string editedName, string editedCategory, string editedQuantity, string editedPrice)
        {
            // Connect to the database
            string dbPath = "data.db";
            string connectionString = $"Data Source={dbPath};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Use an SQL query to update data in the database
                string updateQuery =
                    "UPDATE Storage SET ProductName = @Name, Category = @Category, Quantity = @Quantity, Price = @Price " +
                    "WHERE  ID = @OriginalID;";

                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", editedName);
                    command.Parameters.AddWithValue("@Category", editedCategory);
                    command.Parameters.AddWithValue("@Quantity", editedQuantity);
                    command.Parameters.AddWithValue("@Price", editedPrice);

                    // Parameters for the WHERE condition
                    command.Parameters.AddWithValue("@OriginalID", OriginalID);

                    // Execute the query
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
