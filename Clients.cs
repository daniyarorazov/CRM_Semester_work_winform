using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace CRM_Semester_work
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
            CreateOrUpdateDatabase();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Загрузить данные из файла Excel в DataGridView
            LoadDataToDataGridView("db.xlsx", "Clients");
        }
        
        private void LoadDataToDataGridView(string fileName, string sheetName)
        {
            // Проверить существование файла
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Ошибка: Файл базы данных не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Очистить существующие строки в DataGridView
            dataGridView1.Rows.Clear();

            FileInfo excelFile = new FileInfo(fileName);

            using (ExcelPackage excelPackage = new ExcelPackage(excelFile))
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[sheetName];

                if (worksheet != null)
                {
                    // Получить данные из Excel и добавить их в DataGridView
                    int rows = worksheet.Dimension.End.Row;
                    int columns = worksheet.Dimension.End.Column;

                    for (int row = 2; row <= rows; row++)
                    {
                        bool isEmptyRow = true;
                        object[] rowData = new object[columns];
                
                        for (int col = 1; col <= columns; col++)
                        {
                            rowData[col - 1] = worksheet.Cells[row, col].Text;
                    
                            // Проверить, есть ли хотя бы одно пустое значение в строке
                            if (string.IsNullOrWhiteSpace(worksheet.Cells[row, col].Text))
                            {
                                isEmptyRow = true;
                                break;
                            }
                            else
                            {
                                isEmptyRow = false;
                            }
                        }

                        // Если строка не пустая, добавить данные в DataGridView
                        if (!isEmptyRow)
                        {
                            dataGridView1.Rows.Add(rowData);
                        }
                    }
                }
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Storage storage = new Storage();
            storage.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyModalForm modalForm = new MyModalForm();
    
            // Если форма закрыта с результатом OK
            if (modalForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Database created and test data added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataToDataGridView("db.xlsx", "Clients");

            }
        }

        private void CreateOrUpdateDatabase()
        {
            string fileName = "db.xlsx";

            if (!File.Exists(fileName))
            {
                FileInfo excelFile = new FileInfo(fileName);

                using (ExcelPackage excelPackage = new ExcelPackage(excelFile))
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Clients");

                    string[] headers = { "ID", "Company", "Email", "Contact Person", "Phone", "Date of last contact", "Registration date" };

                    for (int i = 0; i < headers.Length; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = headers[i];
                    }

                    excelPackage.Save();
                }
            }

            AddDataToDatabase(fileName);
        }

        private void AddDataToDatabase(string fileName)
        {
            FileInfo excelFile = new FileInfo(fileName);

            using (ExcelPackage excelPackage = new ExcelPackage(excelFile))
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets["Clients"];

                int nextRow = worksheet.Dimension?.End.Row + 1 ?? 2;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string[] rowData = {
                        row.Cells[0].Value?.ToString(),
                        row.Cells[1].Value?.ToString(),
                        row.Cells[2].Value?.ToString(),
                        row.Cells[3].Value?.ToString(),
                        row.Cells[4].Value?.ToString(),
                        // Добавьте дополнительные данные согласно вашей структуре данных
                        DateTime.Now.ToShortDateString(), // Пример для "Date of last contact"
                        DateTime.Now.ToShortDateString()  // Пример для "Registration date"
                    };

                    AddRowToWorksheet(worksheet, nextRow, rowData);
                    nextRow++;
                }

                excelPackage.Save();
            }
        }

        private void AddRowToWorksheet(ExcelWorksheet worksheet, int row, string[] values)
        {
            for (int col = 0; col < values.Length; col++)
            {
                worksheet.Cells[row, col + 1].Value = values[col];
            }
        }
    }
}
