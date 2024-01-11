using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace CRM_Semester_work
{
    public partial class Clients : Form
    {
        private readonly string connectionString = "Data Source=data.db;Version=3;";

        public Clients()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load data into the DataGridView and add button columns on form initialization
            LoadDataToDataGridView();
            AddButtonColumns();
        }

        // Click event for navigating to the "Storage" form
        private void storage_navbar_label_Click(object sender, EventArgs e)
        {
            Storage storage = new Storage();
            storage.Show();
            this.Hide();
        }

        // Click event for navigating to the "Sales" form
        private void sales_navbar_label_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            this.Hide();
        }

        // Event handler for cell content click in the DataGridView
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["btnDelete"].Index)
            {
                // Prompt user for confirmation before deleting a record
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Delete the selected row from the database
                    DeleteRowFromDatabase(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_client"].Value));
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["btnEdit"].Index)
            {
                if (e.RowIndex >= 0)
                {
                    // Get data from the selected row for editing
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    string companyName = selectedRow.Cells["Company"].Value.ToString();
                    string companyEmail = selectedRow.Cells["Email"].Value.ToString();
                    string companyContactPerson = selectedRow.Cells["contact_person"].Value.ToString();
                    string companyPhone = selectedRow.Cells["Phone"].Value.ToString();
                    int clientId = Convert.ToInt32(selectedRow.Cells["id_client"].Value);

                    // Show the EditDataClientForm for editing the client data
                    EditDataClientForm editForm = new EditDataClientForm(clientId, companyName, companyEmail, companyContactPerson, companyPhone);

                    // If the form is closed with the OK result
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Database edited success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataToDataGridView();
                    }
                }
            }
        }

        // Method to load data into the DataGridView from the Clients table
        private void LoadDataToDataGridView()
        {
            dataGridView1.Rows.Clear();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Clients;";

                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            object[] rowData = new object[reader.FieldCount];

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                rowData[i] = reader[i];
                            }

                            dataGridView1.Rows.Add(rowData);
                        }
                    }
                }

                connection.Close();
            }
        }

        // Method to delete a row from the Clients table in the database
        private void DeleteRowFromDatabase(int idToDelete)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Clients WHERE ID = @ID;";

                using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@ID", idToDelete);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record successfully deleted from the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataToDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Record with the specified ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                connection.Close();
            }
        }

        // Method to add "Edit" and "Delete" button columns to the DataGridView
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

        // Click event for adding a new client
        private void add_client_button_Click(object sender, EventArgs e)
        {
            // Show the ClientsModalForm for adding a new client
            ClientsModalForm modalForm = new ClientsModalForm();

            // If the form is closed with the OK result
            if (modalForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Database created and test data added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataToDataGridView();
            }
        }
    }
}
