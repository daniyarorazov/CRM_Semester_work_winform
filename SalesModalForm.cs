using System;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;

namespace CRM_Semester_work
{
    public partial class SalesModalForm : Form
    {
        public SalesModalForm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }
        
        private void LoadDataFromExcel()
        {
            // Путь к файлу Excel
            string excelFilePath = "db.xlsx";

            using (ExcelPackage package = new ExcelPackage(new System.IO.FileInfo(excelFilePath)))
            {
                // Получение объекта рабочего листа
                ExcelWorksheet storage_worksheet = package.Workbook.Worksheets["Storage"];
                ExcelWorksheet clients_worksheet = package.Workbook.Worksheets["Clients"];

                // Предполагаем, что данные находятся в колонке B, начиная с первой строки
                int row = 2;

                while (storage_worksheet.Cells[row, 2].Value != null) // Изменил индекс колонки на 2
                {
                    // Добавление элементов в ComboBox программно
                    nameProduct.Items.Add(storage_worksheet.Cells[row, 2].Text); // Изменил индекс колонки на 2

                    // Переход к следующей строке
                    row++;
                }
                
                while (clients_worksheet.Cells[row, 2].Value != null) // Изменил индекс колонки на 2
                {
                    // Добавление элементов в ComboBox программно
                    companyName.Items.Add(clients_worksheet.Cells[row, 2].Text); // Изменил индекс колонки на 2

                    // Переход к следующей строке
                    row++;
                }
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // Добавление элементов в ComboBox программно
           
            LoadDataFromExcel();
            salesAmount.Maximum = 100000000;
            
            nameProduct.SelectedIndexChanged += NameProduct_SelectedIndexChanged;
        }
        
        
        
        private void NameProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получаем выбранный продукт
            string selectedProduct = nameProduct.SelectedItem?.ToString();

            // Если продукт выбран, устанавливаем соответствующее максимальное значение для quantityProduct
            if (!string.IsNullOrEmpty(selectedProduct))
            {
                SetMaxQuantityForProduct(selectedProduct);
            }
        }

        private void SetMaxQuantityForProduct(string productName)
        {
            // Путь к файлу Excel
            string excelFilePath = "db.xlsx";

            using (ExcelPackage package = new ExcelPackage(new System.IO.FileInfo(excelFilePath)))
            {
                // Получение объекта рабочего листа
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Storage"];

                // Ищем продукт в листе "Storage" и получаем его количество
                int row = 2;
                while (worksheet.Cells[row, 2].Value != null) // Изменил индекс колонки на 2
                {
                    if (worksheet.Cells[row, 2].Text == productName) // Изменил индекс колонки на 2
                    {
                        // Нашли продукт, устанавливаем максимальное значение для quantityProduct
                        int quantity = Convert.ToInt32(worksheet.Cells[row, 4].Text); // Предполагается, что количество находится в колонке C
                        quantityProduct.Maximum = quantity;
                        return;
                    }

                    row++;
                }

                // Если продукт не найден, устанавливаем фиксированное максимальное значение
                quantityProduct.Maximum = 200;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameProduct.Text;
            string company = companyName.Text;
            string quantity = quantityProduct.Text;
            string price = salesAmount.Text;
            
            if (name == null || company == null || quantity == null || price == null)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            
            string fileName = "db.xlsx";
            
            AddDataToExcel(fileName, name, company, quantity, price);
            DialogResult = DialogResult.OK;
        }
        private void AddDataToExcel(string fileName, string name, string company, string quantity, string price)
        {
            // Проверяем существование файла
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Ошибка: Файл базы данных не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileInfo excelFile = new FileInfo(fileName);

            using (ExcelPackage excelPackage = new ExcelPackage(excelFile))
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets["Sales"];

                // Определяем следующую строку для добавления данных
                int nextRow = worksheet.Dimension?.End.Row + 1 ?? 2;

                // Пример добавления данных
                AddRowToWorksheet(worksheet, nextRow, nextRow - 1, name, price, company, quantity, DateTime.Now.ToShortDateString());

                // Сохраняем изменения в файле Excel
                excelPackage.Save();
            }
        }

        private void AddRowToWorksheet(ExcelWorksheet worksheet, int row, params object[] values)
        {
            for (int col = 0; col < values.Length; col++)
            {
                worksheet.Cells[row, col + 1].Value = values[col];
            }
        }
    }
}