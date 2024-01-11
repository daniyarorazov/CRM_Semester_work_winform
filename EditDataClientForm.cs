using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CRM_Semester_work
{
    public partial class EditDataClientForm : Form
    {
        // Передаваемые значения
        public string EditedCompanyName { get; private set; }
        public string EditedCompanyEmail { get; private set; }
        public string EditedCompanyContactPerson { get; private set; }
        public string EditedCompanyPhone { get; private set; }
        // Добавьте другие свойства по необходимости

        private readonly int RowIndex; // Переменная для хранения индекса строки в базе данных

        public EditDataClientForm(int id, string companyName, string companyEmail, string companyContactPerson, string companyPhone)
        {
            InitializeComponent();

            // Заполнение элементов управления значениями переданными из DataGridViewRow
            nameCompany.Text = companyName;
            emailCompany.Text = companyEmail;
            nameContactPerson.Text = companyContactPerson;
            phoneCompany.Text = companyPhone;
            clientId.Text = id.ToString();
            RowIndex = id;
        }

        private void edit_item_button_Click(object sender, EventArgs e)
        {
            // Получите значения из элементов управления
            EditedCompanyName = nameCompany.Text;
            EditedCompanyEmail = emailCompany.Text;
            EditedCompanyContactPerson = nameContactPerson.Text;
            EditedCompanyPhone = phoneCompany.Text;

            // Обновление данных в базе данных SQLite
            UpdateDataInDatabase();

            // Закройте форму с результатом OK
            DialogResult = DialogResult.OK;
        }

        private void UpdateDataInDatabase()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=data.db;Version=3;"))
            {
                connection.Open();

                string updateQuery = @"
                    UPDATE Clients
                    SET Company = @Company, Email = @Email, ContactPerson = @ContactPerson, Phone = @Phone
                    WHERE ID = @ID;";

                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Company", EditedCompanyName);
                    command.Parameters.AddWithValue("@Email", EditedCompanyEmail);
                    command.Parameters.AddWithValue("@ContactPerson", EditedCompanyContactPerson);
                    command.Parameters.AddWithValue("@Phone", EditedCompanyPhone);
                    command.Parameters.AddWithValue("@ID", RowIndex);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
