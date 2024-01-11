using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace CRM_Semester_work
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Set the path to the SQLite database file
            string dbFilePath = "data.db";

            // Create the connection string
            string connectionString = $"Data Source={dbFilePath};Version=3;";

            // Create and open a connection to the database
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Successfully connected to the SQLite database.");

                    // Create the table (if it does not exist)
                    CreateTable(connection);

                    // Perform other database operations here

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error connecting to the database: {ex.Message}");
                }
            }
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Clients());
        }

        // Method to create tables in the database
        static void CreateTable(SQLiteConnection connection)
        {
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                // SQL query to create tables (example with the 'Clients' table)
                string createTablesQuery = @"
                CREATE TABLE IF NOT EXISTS Clients (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Company TEXT,
                    Email TEXT,
                    ContactPerson TEXT,
                    Phone TEXT,
                    DateOfLastContact TEXT,
                    RegistrationDate TEXT
                );

                CREATE TABLE IF NOT EXISTS Storage (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    ProductName TEXT,
                    Category TEXT,
                    Quantity INTEGER,
                    Price REAL,
                    DateAdded TEXT
                );

                CREATE TABLE IF NOT EXISTS Sales (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    ProductName TEXT,
                    CompanyName TEXT,
                    Quantity INTEGER,
                    Price REAL,
                    SaleDate TEXT
                );";

                command.CommandText = createTablesQuery;

                try
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Table 'Clients' successfully created (if not exists).");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error creating table: {ex.Message}");
                }
            }
        }
    }
}
