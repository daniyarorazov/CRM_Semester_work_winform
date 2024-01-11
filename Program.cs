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
            // Задайте путь к файлу базы данных SQLite
            string dbFilePath = "data.db";

            // Создайте строку подключения
            string connectionString = $"Data Source={dbFilePath};Version=3;";

            // Создайте и откройте подключение к базе данных
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Успешное подключение к базе данных SQLite.");

                    // Создайте таблицу (если она не существует)
                    CreateTable(connection);

                    // Выполните другие операции с базой данных здесь

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при подключении к базе данных: {ex.Message}");
                }
            }
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Clients());
            
            
        }
        static void CreateTable(SQLiteConnection connection)
        {
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                // SQL-запрос для создания таблицы (пример с таблицей Clients)
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
                    Console.WriteLine("Таблица 'Clients' успешно создана (если не существует).");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при создании таблицы: {ex.Message}");
                }
            }
        }
    }
}
