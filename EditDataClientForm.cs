using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CRM_Semester_work
{
    public partial class EditDataClientForm : Form
    {
        // Properties to store the edited values
        public string EditedCompanyName { get; private set; }
        public string EditedCompanyEmail { get; private set; }
        public string EditedCompanyContactPerson { get; private set; }
        public string EditedCompanyPhone { get; private set; }

        // Other properties can be added as needed

        private readonly int RowIndex; // Variable to store the index of the row in the database

        // Constructor to initialize the form with data from a DataGridViewRow
        public EditDataClientForm(int id, string companyName, string companyEmail, string companyContactPerson, string companyPhone)
        {
            InitializeComponent();

            // Fill the control values with the data passed from the DataGridViewRow
            nameCompany.Text = companyName;
            emailCompany.Text = companyEmail;
            nameContactPerson.Text = companyContactPerson;
            phoneCompany.Text = companyPhone;
            clientId.Text = id.ToString();
            RowIndex = id;
        }

        // Event handler for the "Edit" button click
        private void edit_item_button_Click(object sender, EventArgs e)
        {
            // Get values from the controls
            EditedCompanyName = nameCompany.Text;
            EditedCompanyEmail = emailCompany.Text;
            EditedCompanyContactPerson = nameContactPerson.Text;
            EditedCompanyPhone = phoneCompany.Text;

            // Update data in the SQLite database
            UpdateDataInDatabase();

            // Close the form with the OK result
            DialogResult = DialogResult.OK;
        }

        // Method to update data in the SQLite database
        private void UpdateDataInDatabase()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=data.db;Version=3;"))
            {
                connection.Open();

                // SQL query to update data in the 'Clients' table
                string updateQuery = @"
                    UPDATE Clients
                    SET Company = @Company, Email = @Email, ContactPerson = @ContactPerson, Phone = @Phone
                    WHERE ID = @ID;";

                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    // Set parameters for the SQL query
                    command.Parameters.AddWithValue("@Company", EditedCompanyName);
                    command.Parameters.AddWithValue("@Email", EditedCompanyEmail);
                    command.Parameters.AddWithValue("@ContactPerson", EditedCompanyContactPerson);
                    command.Parameters.AddWithValue("@Phone", EditedCompanyPhone);
                    command.Parameters.AddWithValue("@ID", RowIndex);

                    // Execute the query
                    command.ExecuteNonQuery();
                }

                // Close the connection
                connection.Close();
            }
        }
    }
}
