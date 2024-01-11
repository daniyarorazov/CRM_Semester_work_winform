using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CRM_Semester_work
{
    public partial class ClientsModalForm : Form
    {
        private readonly string connectionString = "Data Source=data.db;Version=3;";

        public ClientsModalForm()
        {
            InitializeComponent();
        }

        // Event handler for the button click in the modal form
        private void add_item_button_Click(object sender, EventArgs e)
        {
            // Retrieve data from the input fields
            string company = textBox1.Text;
            string email = emailCompany.Text;
            string name = nameContactPerson.Text;
            string phone = phoneCompany.Text;

            // Check if any of the required fields are empty
            if (string.IsNullOrEmpty(company) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Fill in all fields!");
                return;
            }

            // Add data to the SQLite database
            AddDataToDatabase(company, email, name, phone);

            // Close the modal form with the OK result
            DialogResult = DialogResult.OK;
        }

        // Method to add data to the SQLite database
        private void AddDataToDatabase(string company, string email, string name, string phone)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertQuery = @"
                    INSERT INTO Clients (Company, Email, ContactPerson, Phone, DateOfLastContact, RegistrationDate)
                    VALUES (@Company, @Email, @ContactPerson, @Phone, @DateOfLastContact, @RegistrationDate);";

                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Company", company);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@ContactPerson", name);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@DateOfLastContact", DateTime.Now.ToShortDateString());
                    command.Parameters.AddWithValue("@RegistrationDate", DateTime.Now.ToShortDateString());

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
