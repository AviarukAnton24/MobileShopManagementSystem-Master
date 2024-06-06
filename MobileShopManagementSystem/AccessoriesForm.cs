using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using Font = System.Drawing.Font;

namespace MobileShopManagementSystem
{
    public partial class AccessoriesForm : Form
    {
        public AccessoriesForm()
        {
            InitializeComponent();

            DisplayAccessoriesData();
        }

        public void DisplayAccessoriesData()
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            // Создаем SQL-запрос для выборки данных из таблицы
            string query = "SELECT * FROM accessories_info";

            // Создаем команду SQL
            using (MySqlCommand command = new MySqlCommand(query, database.GetConnection()))
            {
                // Создаем объект MySqlDataReader для чтения данных
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Очищаем существующие столбцы в DataGridView
                    dataGridView.Columns.Clear();

                    // Добавляем столбцы в DataGridView с использованием имен полей из таблицы
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dataGridView.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }

                    // Изменяем стиль ячеек в DataGridView
                    dataGridView.DefaultCellStyle.BackColor = Color.LightBlue; // Голубой цвет фона
                    dataGridView.DefaultCellStyle.ForeColor = Color.Black; // Черный цвет текста
                    dataGridView.DefaultCellStyle.Font = new Font("Times New Roman", 15, FontStyle.Bold); // Шрифт Times New Roman, размер 15, жирный стиль

                    // Изменяем стиль названий столбцов в DataGridView
                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        column.HeaderCell.Style.BackColor = Color.LightBlue; // Голубой цвет фона названия столбца
                        column.HeaderCell.Style.ForeColor = Color.Black; // Черный цвет текста названия столбца
                        column.HeaderCell.Style.Font = new Font("Times New Roman", 15, FontStyle.Bold); // Шрифт Times New Roman, размер 15, жирный стиль
                    }

                    // Читаем данные и добавляем их в DataGridView
                    while (reader.Read())
                    {
                        // Создаем массив объектов для хранения значений полей в текущей строке
                        object[] values = new object[reader.FieldCount];

                        // Заполняем массив значениями полей в текущей строке
                        reader.GetValues(values);

                        // Добавляем массив значений как новую строку в DataGridView
                        dataGridView.Rows.Add(values);
                    }
                }
            }

            // Закрываем подключение к базе данных
            database.CloseConnection();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Получение значений из полей ввода
            string ID = IDField.Text;
            string brand = BrandField.Text;
            string model = ModelField.Text;
            string price = PriceField.Text;
            string quantity = QuantityField.Text;

            // Проверка на пустые поля
            if (string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(brand) || string.IsNullOrEmpty(model) ||
                string.IsNullOrEmpty(price) || string.IsNullOrEmpty(quantity))
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            // Проверка поля ID на наличие только цифр
            if (!Regex.IsMatch(ID, @"^\d+$"))
            {
                MessageBox.Show("Поле 'ID' должно содержать только цифры");
                return;
            }

            // Проверка поля Brand на наличие только английских символов и не более 10 символов
            if (!Regex.IsMatch(brand, @"^[a-zA-Z]+$") || brand.Length > 10)
            {
                MessageBox.Show("Поле 'Brand' должно содержать только английские символы и не более 10 символов");
                return;
            }

            // Проверка поля Model на наличие только английских символов и цифр
            if (!Regex.IsMatch(model, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Поле 'Model' должно содержать только английские символы и цифры");
                return;
            }

            // Проверка полей Price и Quantity на наличие только цифр
            if (!Regex.IsMatch(price, @"^\d+$") || !Regex.IsMatch(quantity, @"^\d+$"))
            {
                MessageBox.Show("Поля 'Price' и 'Quantity' должны содержать только цифры");
                return;
            }

            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            try
            {   // Создаем запрос к базе данных для проверки существования записи с таким же значением ID
                string checkIDQuery = "SELECT COUNT(*) FROM accessories_info WHERE ID = @ID";

                // Создаем параметры для запроса
                MySqlCommand checkIDCommand = new MySqlCommand(checkIDQuery, database.GetConnection());
                checkIDCommand.Parameters.AddWithValue("@ID", ID);

                // Получаем результат выполнения запроса
                int existingIDCount = (int)checkIDCommand.ExecuteScalar();

                // Проверка наличия записи с таким же значением ID
                if (existingIDCount > 0)
                {
                    MessageBox.Show("Товар с таким ID уже существует");
                    return;
                }

                // Создаем запрос к базе данных для проверки существования записи с такими же значениями
                string checkQuery = "SELECT COUNT(*) FROM accessories_info WHERE ID = @ID AND Brand = @Brand AND Model = @Model AND " +
                                    "Price = @Price AND Quantity = @Quantity";

                // Создаем параметры для запроса
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, database.GetConnection());
                checkCommand.Parameters.AddWithValue("@ID", ID);
                checkCommand.Parameters.AddWithValue("@Brand", brand);
                checkCommand.Parameters.AddWithValue("@Model", model);
                checkCommand.Parameters.AddWithValue("@Price", price);
                checkCommand.Parameters.AddWithValue("@Quantity", quantity);

                // Получаем результат выполнения запроса
                int existingCount = (int)checkCommand.ExecuteScalar();

                // Проверка наличия записи с такими же значениями
                if (existingCount > 0)
                {
                    MessageBox.Show("Такой товар уже существует");
                    return;
                }

                // Запрос к базе данных для добавления строки
                string query = "INSERT INTO accessories_info (ID, Brand, Model, Price, Quantity) VALUES " +
                               "(@ID, @Brand, @Model, @Price, @Quantity)";

                // Выполнение запроса
                MySqlCommand command = new MySqlCommand(query, database.GetConnection());
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@Brand", brand);
                command.Parameters.AddWithValue("@Model", model);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Quantity", quantity);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Товар успешно добавлен");
                    DisplayAccessoriesData();
                }
                else
                {
                    MessageBox.Show("Ошибка при добавлении товара");
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибки при выполнении запроса
                MessageBox.Show("Ошибка при добавлении товара: " + ex.Message);
            }
            finally
            {
                // Закрываем подключение к базе данных
                database.CloseConnection();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            try
            {
                // Запрос к базе данных для проверки наличия записей
                string countQuery = "SELECT COUNT(*) FROM accessories_info";

                // Выполнение запроса для получения количества записей
                MySqlCommand countCommand = new MySqlCommand(countQuery, database.GetConnection());
                int rowCount = (int)countCommand.ExecuteScalar();

                if (rowCount == 0)
                {
                    MessageBox.Show("Таблица пуста. Нет товаров для изменения",
                        "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Получение значений из полей ввода
                string ID = IDField.Text;
                string brand = BrandField.Text;
                string model = ModelField.Text;
                string price = PriceField.Text;
                string quantity = QuantityField.Text;

                // Проверка на пустые поля
                if (string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(brand) || string.IsNullOrEmpty(model) ||
                    string.IsNullOrEmpty(price) || string.IsNullOrEmpty(quantity))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля");
                    return;
                }

                // Проверка поля ID на наличие только цифр
                if (!Regex.IsMatch(ID, @"^\d+$"))
                {
                    MessageBox.Show("Поле 'ID' должно содержать только цифры");
                    return;
                }

                // Проверка поля Brand на наличие только английских символов и не более 10 символов
                if (!Regex.IsMatch(brand, @"^[a-zA-Z]+$") || brand.Length > 10)
                {
                    MessageBox.Show("Поле 'Brand' должно содержать только английские символы и не более 10 символов");
                    return;
                }

                // Проверка поля Model на наличие только английских символов и цифр
                if (!Regex.IsMatch(model, @"^[a-zA-Z0-9]+$"))
                {
                    MessageBox.Show("Поле 'Model' должно содержать только английские символы и цифры");
                    return;
                }

                // Проверка полей Price и Quantity на наличие только цифр
                if (!Regex.IsMatch(price, @"^\d+$") || !Regex.IsMatch(quantity, @"^\d+$"))
                {
                    MessageBox.Show("Поля 'Price' и 'Quantity' должны содержать только цифры");
                    return;
                }

                // Запрос к базе данных для обновления записи
                string updateQuery = $"UPDATE accessories_info SET Price = '{price}', Quantity = '{quantity}' WHERE ID = '{ID}' AND Brand = '{brand}' AND Model = '{model}'";

                // Выполнение запроса
                MySqlCommand updateCommand = new MySqlCommand(updateQuery, database.GetConnection());
                int rowsAffected = updateCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Параметры товара успешно изменены");
                    DisplayAccessoriesData();
                }
                else
                {
                    MessageBox.Show("Не найден товар с указанными параметрами");
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибки при выполнении запроса
                MessageBox.Show("Ошибка при изменении параметров товара: " + ex.Message);
            }
            finally
            {
                // Закрываем подключение к базе данных
                database.CloseConnection();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            try
            {
                // Запрос к базе данных для проверки наличия записей
                string countQuery = "SELECT COUNT(*) FROM accessories_info";

                // Выполнение запроса для получения количества записей
                MySqlCommand countCommand = new MySqlCommand(countQuery, database.GetConnection());
                int rowCount = (int)countCommand.ExecuteScalar();

                if (rowCount == 0)
                {
                    MessageBox.Show("Таблица пуста. Нет товаров для удаления",
                        "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Получение значений из полей ввода
                string ID = IDField.Text;
                string brand = BrandField.Text;
                string model = ModelField.Text;
                string price = PriceField.Text;
                string quantity = QuantityField.Text;

                // Проверка на пустые поля
                if (string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(brand) || string.IsNullOrEmpty(model) ||
                    string.IsNullOrEmpty(price) || string.IsNullOrEmpty(quantity))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля");
                    return;
                }

                // Проверка поля ID на наличие только цифр
                if (!Regex.IsMatch(ID, @"^\d+$"))
                {
                    MessageBox.Show("Поле 'ID' должно содержать только цифры");
                    return;
                }

                // Проверка поля Brand на наличие только английских символов и не более 10 символов
                if (!Regex.IsMatch(brand, @"^[a-zA-Z]+$") || brand.Length > 10)
                {
                    MessageBox.Show("Поле 'Brand' должно содержать только английские символы и не более 10 символов");
                    return;
                }

                // Проверка поля Model на наличие только английских символов и цифр
                if (!Regex.IsMatch(model, @"^[a-zA-Z0-9]+$"))
                {
                    MessageBox.Show("Поле 'Model' должно содержать только английские символы и цифры");
                    return;
                }

                // Проверка полей Price и Quantity на наличие только цифр
                if (!Regex.IsMatch(price, @"^\d+$") || !Regex.IsMatch(quantity, @"^\d+$"))
                {
                    MessageBox.Show("Поля 'Price' и 'Quantity' должны содержать только цифры");
                    return;
                }

                // Запрос к базе данных для удаления записи
                string deleteQuery = $"DELETE FROM mobile_info WHERE ID = '{ID}' AND Brand = '{brand}' AND Model = '{model}' AND Price = '{price}' AND Quantity = '{quantity}'";

                // Выполнение запроса
                MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, database.GetConnection());
                int rowsAffected = deleteCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Товар успешно удален");
                    DisplayAccessoriesData();
                }
                else
                {
                    MessageBox.Show("Товар с указанными параметрами не найден");
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибки при выполнении запроса
                MessageBox.Show("Ошибка при удалении товара: " + ex.Message);
            }
            finally
            {
                // Закрываем подключение к базе данных
                database.CloseConnection();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            try
            {
                // Запрос к базе данных для проверки наличия записей
                string countQuery = "SELECT COUNT(*) FROM accessories_info";

                // Выполнение запроса для получения количества записей
                MySqlCommand countCommand = new MySqlCommand(countQuery, database.GetConnection());
                int rowCount = (int)countCommand.ExecuteScalar();

                if (rowCount == 0)
                {
                    MessageBox.Show("Таблица пуста. Нет товаров для удаления",
                        "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Запрос к базе данных для очистки таблицы
                string deleteQuery = "DELETE FROM accessories_info";

                // Выполнение запроса
                MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, database.GetConnection());
                int rowsAffected = deleteCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Таблица успешно очищена");

                    DisplayAccessoriesData();
                }
                else
                {
                    MessageBox.Show("Ошибка при очистке таблицы");
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибки при выполнении запроса
                MessageBox.Show("Ошибка при очистке таблицы: " + ex.Message);
            }
            finally
            {
                // Закрываем подключение к базе данных
                database.CloseConnection();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            this.Hide();
            homeForm.Show();
        }

        private void TableToPDF_Click(object sender, EventArgs e)
        {
            // Получаем текущую дату и время
            string currentDate = DateTime.Now.ToString("dd.MM.yyyy");
            string currentTime = DateTime.Now.ToString("HH.mm.ss");

            // Путь для сохранения PDF файла с уникальным именем
            string outputPath = $@"C:\Users\30100\source\repos\MobileShopManagementSystem\MobileShopManagementSystem\Accessories\PDF\output_{currentTime}_{currentDate}.pdf";

            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            try
            {
                // Создание команды для выборки данных из таблицы accessories_info
                string query = "SELECT * FROM accessories_info";
                MySqlCommand command = new MySqlCommand(query, database.GetConnection());

                // Создание адаптера данных
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Создание объекта DataTable для хранения результатов запроса
                System.Data.DataTable dataTable = new System.Data.DataTable();

                // Заполнение DataTable данными из базы данных
                adapter.Fill(dataTable);

                // Создание нового документа PDF
                iTextSharp.text.Document document = new iTextSharp.text.Document();
                PdfWriter.GetInstance(document, new FileStream(outputPath, FileMode.Create));
                document.Open();

                // Создание таблицы PDF
                PdfPTable pdfTable = new PdfPTable(dataTable.Columns.Count);
                PdfPCell cell;

                // Добавление заголовков таблицы
                foreach (DataColumn column in dataTable.Columns)
                {
                    cell = new PdfPCell(new Phrase(column.ColumnName));
                    pdfTable.AddCell(cell);
                }

                // Добавление данных в таблицу
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (object item in row.ItemArray)
                    {
                        cell = new PdfPCell(new Phrase(item.ToString()));
                        pdfTable.AddCell(cell);
                    }
                }

                // Добавление таблицы в документ
                document.Add(pdfTable);

                // Закрытие документа
                document.Close();

                // Вывод сообщения об успешном сохранении
                MessageBox.Show("Таблица успешно конвертирована в PDF и сохранена по указанному пути.");
            }
            catch (Exception ex)
            {
                // Вывод сообщения об ошибке при выполнении операции
                MessageBox.Show("Произошла ошибка при конвертации таблицы в PDF: " + ex.Message);
            }
            finally
            {
                // Закрываем подключение к базе данных
                database.CloseConnection();
            }
        }

        private void TableToWord_Click(object sender, EventArgs e)
        {
            // Получаем текущую дату и время
            string currentDate = DateTime.Now.ToString("dd.MM.yyyy");
            string currentTime = DateTime.Now.ToString("HH.mm.ss");

            // Путь для сохранения файла Word с добавлением даты и времени в название
            string outputPath = $@"C:\Users\30100\source\repos\MobileShopManagementSystem\MobileShopManagementSystem\Accessories\Word\output_{currentTime}_{currentDate}.docx";

            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            try
            {
                // Создание команды для выборки данных из таблицы accessories_info
                string query = "SELECT * FROM accessories_info";
                MySqlCommand command = new MySqlCommand(query, database.GetConnection());

                // Создание адаптера данных
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Создание объекта DataTable для хранения результатов запроса
                System.Data.DataTable dataTable = new System.Data.DataTable();

                // Заполнение DataTable данными из базы данных
                adapter.Fill(dataTable);

                // Создание приложения Word
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                wordApp.Visible = false; // Делаем Word невидимым

                // Создание нового документа Word
                Microsoft.Office.Interop.Word.Document document = wordApp.Documents.Add();

                // Создание таблицы Word
                Microsoft.Office.Interop.Word.Table wordTable = document.Tables.Add(document.Range(), dataTable.Rows.Count + 1, dataTable.Columns.Count);

                // Заполнение заголовков таблицы
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    wordTable.Cell(1, i + 1).Range.Text = dataTable.Columns[i].ColumnName;
                }

                // Заполнение данных в таблицу
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        wordTable.Cell(i + 2, j + 1).Range.Text = dataTable.Rows[i][j].ToString();
                    }
                }

                // Сохранение документа Word
                document.SaveAs2(outputPath);

                // Закрытие документа и приложения Word
                document.Close();
                wordApp.Quit();

                // Вывод сообщения об успешном сохранении
                MessageBox.Show("Таблица успешно конвертирована в Word и сохранена по указанному пути.");
            }
            catch (Exception ex)
            {
                // Вывод сообщения об ошибке при выполнении операции
                MessageBox.Show("Произошла ошибка при конвертации таблицы в Word: " + ex.Message);
            }
            finally
            {
                // Закрываем подключение к базе данных
                database.CloseConnection();
            }
        }

        private void TableToExcel_Click(object sender, EventArgs e)
        {
            // Получаем текущую дату и время
            string currentDate = DateTime.Now.ToString("dd.MM.yyyy");
            string currentTime = DateTime.Now.ToString("HH.mm.ss");

            // Путь для сохранения файла Excel с добавлением даты и времени в название
            string outputPath = $@"C:\Users\30100\source\repos\MobileShopManagementSystem\MobileShopManagementSystem\Accessories\Excel\output_{currentTime}_{currentDate}.xlsx";

            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            try
            {
                // Создание команды для выборки данных из таблицы accessories_info
                string query = "SELECT * FROM accessories_info";
                MySqlCommand command = new MySqlCommand(query, database.GetConnection());

                // Создание адаптера данных
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                // Создание объекта DataTable для хранения результатов запроса
                System.Data.DataTable dataTable = new System.Data.DataTable();

                // Заполнение DataTable данными из базы данных
                adapter.Fill(dataTable);

                // Создание приложения Excel
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false; // Делаем Excel невидимым

                // Создание новой книги Excel
                Excel.Workbook workbook = excelApp.Workbooks.Add();

                // Получение первого листа книги
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

                // Заполнение заголовков
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dataTable.Columns[i].ColumnName;
                }

                // Заполнение данных
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataTable.Rows[i][j].ToString();
                    }
                }

                // Сохранение книги Excel
                workbook.SaveAs(outputPath);

                // Закрытие книги и приложения Excel
                workbook.Close();
                excelApp.Quit();

                // Вывод сообщения об успешном сохранении
                MessageBox.Show("Таблица успешно конвертирована в Excel и сохранена по указанному пути.");
            }
            catch (Exception ex)
            {
                // Вывод сообщения об ошибке при выполнении операции
                MessageBox.Show("Произошла ошибка при конвертации таблицы в Excel: " + ex.Message);
            }
            finally
            {
                // Закрываем подключение к базе данных
                database.CloseConnection();
            }
        }
    }
}
