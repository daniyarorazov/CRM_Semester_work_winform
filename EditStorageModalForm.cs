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

            // Заполнение элементов управления значениями переданными из DataGridViewRow
            originalProductName = productName;
            originalCategory = category;
            originalProductAmount = productAmount;
            originalProductPrice = productPrice;
            originalProductId = productId;

            // Устанавливаем значения в элементы управления
            nameProduct.Text = productName;
            categoryProduct.Text = category;
            quantityProduct.Text = productAmount;
            priceProduct.Text = productPrice;
        }

        // Event handler for the "Save Changes" button click
        private void add_product_button_Click(object sender, EventArgs e)
        {
            // Получаем измененные значения из элементов управления
            string editedName = nameProduct.Text;
            string editedCategory = categoryProduct.Text;
            string editedQuantity = quantityProduct.Text;
            string editedPrice = priceProduct.Text;
            int id = originalProductId;

            // Проверяем, были ли внесены изменения
            if (ValuesChanged(editedName, editedCategory, editedQuantity, editedPrice))
            {
                // Если есть изменения, вызываем метод для сохранения изменений
                SaveChangesToDatabase(id, editedName, editedCategory, editedQuantity, editedPrice);

                DialogResult = DialogResult.OK; // Закрываем форму с результатом OK
            }
            else
            {
                MessageBox.Show("No changes made", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Метод для проверки, были ли внесены изменения
        private bool ValuesChanged(string editedName, string editedCategory, string editedQuantity, string editedPrice)
        {
            return !string.Equals(originalProductName, editedName) ||
                   !string.Equals(originalCategory, editedCategory) ||
                   !string.Equals(originalProductAmount, editedQuantity) ||
                   !string.Equals(originalProductPrice, editedPrice);
        }

        // Метод для сохранения изменений в базе данных
        private void SaveChangesToDatabase(int OriginalID, string editedName, string editedCategory, string editedQuantity, string editedPrice)
        {
            // Подключаемся к базе данных
            string dbPath = "data.db";
            string connectionString = $"Data Source={dbPath};Version=3;";
            
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Используем SQL-запрос для обновления данных в базе
                string updateQuery =
                    "UPDATE Storage SET ProductName = @Name, Category = @Category, Quantity = @Quantity, Price = @Price " +
                    "WHERE  ID = @OriginalID;";

                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", editedName);
                    command.Parameters.AddWithValue("@Category", editedCategory);
                    command.Parameters.AddWithValue("@Quantity", editedQuantity);
                    command.Parameters.AddWithValue("@Price", editedPrice);

                    // Параметры для условия WHERE
                    command.Parameters.AddWithValue("@OriginalID", OriginalID);
        
                    // Выполняем запрос
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
