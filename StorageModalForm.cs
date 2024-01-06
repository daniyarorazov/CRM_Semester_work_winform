using System;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;

namespace CRM_Semester_work
{
    public partial class StorageModalForm : Form
    {
        public StorageModalForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameProduct.Text;
            string category = categoryProduct.Text;
            string quantity = quantityProduct.Text;
            string price = priceProduct.Text;
            
            if (nameProduct == null || categoryProduct == null || quantityProduct == null || priceProduct == null)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            
            string fileName = "db.xlsx";
            
            AddDataToExcel(fileName, name, category, quantity, price);

            // Закрываем модальное окно с результатом OK
            DialogResult = DialogResult.OK;
        }
        
        private void AddDataToExcel(string fileName, string name, string category, string quantity, string price)
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
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets["Storage"];

                // Определяем следующую строку для добавления данных
                int nextRow = worksheet.Dimension?.End.Row + 1 ?? 2;

                // Пример добавления данных
                AddRowToWorksheet(worksheet, nextRow, nextRow - 1, name, category, quantity, price, DateTime.Now.ToShortDateString());

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