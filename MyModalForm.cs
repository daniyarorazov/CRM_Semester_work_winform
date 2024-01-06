using System;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;

namespace CRM_Semester_work
{
    public partial class MyModalForm : Form
    {
        public MyModalForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string company = nameCompany.Text; 
            string email = emailCompany.Text;
            string name = nameContactPerson.Text;
            string phone = phoneCompany.Text;
            
            if (company == "" || email == "" || name == "" || phone == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            } 
            
            
            
            // Получаем имя файла
            string fileName = "db.xlsx";

            // Добавляем данные в файл Excel
            AddDataToExcel(fileName, company, email, name, phone);

            // Закрываем модальное окно с результатом OK
            DialogResult = DialogResult.OK;
        }
        
        private void AddDataToExcel(string fileName, string company, string email, string name, string phone)
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
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets["Clients"];

                // Определяем следующую строку для добавления данных
                int nextRow = worksheet.Dimension?.End.Row + 1 ?? 2;

                // Пример добавления данных
                AddRowToWorksheet(worksheet, nextRow, nextRow - 1, company, email, name, phone, DateTime.Now.ToShortDateString(), DateTime.Now.ToShortDateString());

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