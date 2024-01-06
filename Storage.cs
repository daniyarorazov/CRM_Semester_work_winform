using System;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;

namespace CRM_Semester_work
{
    public partial class Storage : Form
    {
        public Storage()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Storage_Load);
        }
        
        private void Storage_Load(object sender, EventArgs e)
        {
            // Загрузить данные из файла Excel в DataGridView
            LoadDataToDataGridView("db.xlsx", "Storage");
        }

      

        private void label2_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            this.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            StorageModalForm modalForm = new StorageModalForm();
    
            // Если форма закрыта с результатом OK
            if (modalForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Database created and test data added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataToDataGridView("db.xlsx", "Storage");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}