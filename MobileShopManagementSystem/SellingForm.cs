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
using Font = System.Drawing.Font;

namespace MobileShopManagementSystem
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();

            DisplayMobileData();

            DisplayAccessoriesData();

            DisplayBillData();
        }

        public void DisplayMobileData()
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            // Создаем SQL-запрос для выборки данных из таблицы
            string query = "SELECT Brand, Model, Price, Quantity FROM mobile_info";

            // Создаем команду SQL
            using (MySqlCommand command = new MySqlCommand(query, database.GetConnection()))
            {
                // Создаем объект MySqlDataReader для чтения данных
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Очищаем существующие столбцы в DataGridView
                    MobileGridView.Columns.Clear();

                    // Добавляем только нужные столбцы в DataGridView
                    MobileGridView.Columns.Add("Brand", "Brand");
                    MobileGridView.Columns.Add("Model", "Model");
                    MobileGridView.Columns.Add("Price", "Price");
                    MobileGridView.Columns.Add("Quantity", "Quantity");

                    // Изменяем стиль ячеек в DataGridView
                    MobileGridView.DefaultCellStyle.BackColor = Color.LightBlue; // Голубой цвет фона
                    MobileGridView.DefaultCellStyle.ForeColor = Color.Black; // Черный цвет текста
                    MobileGridView.DefaultCellStyle.Font = new Font("Times New Roman", 15, FontStyle.Bold); // Шрифт Times New Roman, размер 15, жирный стиль

                    // Изменяем стиль названий столбцов в DataGridView
                    foreach (DataGridViewColumn column in MobileGridView.Columns)
                    {
                        column.HeaderCell.Style.BackColor = Color.LightBlue; // Голубой цвет фона названия столбца
                        column.HeaderCell.Style.ForeColor = Color.Black; // Черный цвет текста названия столбца
                        column.HeaderCell.Style.Font = new Font("Times New Roman", 15, FontStyle.Bold); // Шрифт Times New Roman, размер 15, жирный стиль
                    }

                    // Читаем данные и добавляем их в DataGridView
                    while (reader.Read())
                    {
                        // Создаем массив объектов для хранения значений полей в текущей строке
                        object[] values = new object[4]; // Создаем массив для 4 значений

                        // Заполняем массив значениями полей в текущей строке
                        reader.GetValues(values);

                        // Добавляем массив значений как новую строку в DataGridView
                        MobileGridView.Rows.Add(values);
                    }
                }
            }

            // Закрываем подключение к базе данных
            database.CloseConnection();
        }

        public void DisplayAccessoriesData()
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            // Создаем SQL-запрос для выборки данных из таблицы
            string query = "SELECT Brand, Model, Price, Quantity FROM accessories_info";

            // Создаем команду SQL
            using (MySqlCommand command = new MySqlCommand(query, database.GetConnection()))
            {
                // Создаем объект MySqlDataReader для чтения данных
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Очищаем существующие столбцы в AccessoriesGridView
                    AccessoriesGridView.Columns.Clear();

                    // Добавляем столбцы в AccessoriesGridView с использованием имен полей из таблицы
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        string columnName = reader.GetName(i);
                        if (columnName == "Brand" || columnName == "Model" || columnName == "Price" || columnName == "Quantity")
                        {
                            AccessoriesGridView.Columns.Add(columnName, columnName);
                        }
                    }

                    // Изменяем стиль ячеек в AccessoriesGridView
                    AccessoriesGridView.DefaultCellStyle.BackColor = Color.LightBlue; // Голубой цвет фона
                    AccessoriesGridView.DefaultCellStyle.ForeColor = Color.Black; // Черный цвет текста
                    AccessoriesGridView.DefaultCellStyle.Font = new Font("Times New Roman", 15, FontStyle.Bold); // Шрифт Times New Roman, размер 15, жирный стиль

                    // Изменяем стиль названий столбцов в AccessoriesGridView
                    foreach (DataGridViewColumn column in AccessoriesGridView.Columns)
                    {
                        column.HeaderCell.Style.BackColor = Color.LightBlue; // Голубой цвет фона названия столбца
                        column.HeaderCell.Style.ForeColor = Color.Black; // Черный цвет текста названия столбца
                        column.HeaderCell.Style.Font = new Font("Times New Roman", 15, FontStyle.Bold); // Шрифт Times New Roman, размер 15, жирный стиль
                    }

                    // Читаем данные и добавляем их в AccessoriesGridView
                    while (reader.Read())
                    {
                        // Создаем массив объектов для хранения значений полей в текущей строке
                        object[] values = new object[AccessoriesGridView.Columns.Count];

                        // Заполняем массив значениями полей в текущей строке
                        for (int i = 0; i < AccessoriesGridView.Columns.Count; i++)
                        {
                            values[i] = reader[AccessoriesGridView.Columns[i].Name];
                        }

                        // Добавляем массив значений как новую строку в AccessoriesGridView
                        AccessoriesGridView.Rows.Add(values);
                    }
                }
            }

            // Закрываем подключение к базе данных
            database.CloseConnection();
        }

        public void DisplayBillData()
        {
            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            // Создаем SQL-запрос для выборки данных из таблицы
            string query = "SELECT * FROM bill_info";

            // Создаем команду SQL
            using (MySqlCommand command = new MySqlCommand(query, database.GetConnection()))
            {
                // Создаем объект MySqlDataReader для чтения данных
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Очищаем существующие столбцы в DataGridView
                    BillGridView.Columns.Clear();

                    // Добавляем столбцы в DataGridView с использованием имен полей из таблицы
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        BillGridView.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }

                    // Изменяем стиль ячеек в DataGridView
                    BillGridView.DefaultCellStyle.BackColor = Color.LightBlue; // Голубой цвет фона
                    BillGridView.DefaultCellStyle.ForeColor = Color.Black; // Черный цвет текста
                    BillGridView.DefaultCellStyle.Font = new Font("Times New Roman", 15, FontStyle.Bold); // Шрифт Times New Roman, размер 15, жирный стиль

                    // Изменяем стиль названий столбцов в DataGridView
                    foreach (DataGridViewColumn column in BillGridView.Columns)
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
                        BillGridView.Rows.Add(values);
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            this.Hide();
            homeForm.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Получение значений из полей ввода
            string brand = BrandField.Text;
            string model = ModelField.Text;
            string priceStr = PriceField.Text;
            string quantityStr = QuantityField.Text;

            // Проверка на пустые поля
            if (string.IsNullOrEmpty(brand) || string.IsNullOrEmpty(model) ||
                string.IsNullOrEmpty(priceStr) || string.IsNullOrEmpty(quantityStr))
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            // Проверка поля Brand на наличие только английских символов и не более 8 символов
            if (!Regex.IsMatch(brand, @"^[a-zA-Z]{1,8}$"))
            {
                MessageBox.Show("Поле 'Brand' должно содержать только английские символы и не более 8 символов");
                return;
            }

            // Проверка поля Model на наличие только английских символов и цифр и не более 8 символов
            if (!Regex.IsMatch(model, @"^[a-zA-Z0-9]{1,8}$"))
            {
                MessageBox.Show("Поле 'Model' должно содержать только английские символы и цифры и не более 8 символов");
                return;
            }

            // Проверка полей Price и Quantity на наличие только цифр и не более 8 символов
            if (!Regex.IsMatch(priceStr, @"^\d{1,8}$") || !Regex.IsMatch(quantityStr, @"^\d{1,8}$"))
            {
                MessageBox.Show("Поля 'Price' и 'Quantity' должны содержать только цифры и не более 8 символов");
                return;
            }

            // Преобразование ценовой и количественной информации в числовой формат
            if (!int.TryParse(priceStr, out int price) || !int.TryParse(quantityStr, out int quantity))
            {
                MessageBox.Show("Ошибка при преобразовании цены или количества в числовой формат");
                return;
            }

            // Создание нового экземпляра объекта класса DataBase
            DataBase database = new DataBase();

            // Открытие подключения к базе данных
            database.OpenConnection();

            MySqlDataReader mobileReader = null;
            MySqlDataReader accessoryReader = null;

            try
            {
                // Проверка наличия товара с указанными параметрами в таблице mobile_info
                string mobileQuery = "SELECT * FROM mobile_info WHERE Brand = @Brand AND Model = @Model AND Price >= @Price AND Quantity >= @Quantity";

                // Создание команды SQL для проверки в таблице mobile_info
                MySqlCommand mobileCommand = new MySqlCommand(mobileQuery, database.GetConnection());
                mobileCommand.Parameters.AddWithValue("@Brand", brand);
                mobileCommand.Parameters.AddWithValue("@Model", model);
                mobileCommand.Parameters.AddWithValue("@Price", price);
                mobileCommand.Parameters.AddWithValue("@Quantity", quantity);

                // Выполнение запроса и чтение результата
                mobileReader = mobileCommand.ExecuteReader();

                if (mobileReader.Read())
                {
                    int availableQuantity = mobileReader.GetInt32("Quantity");

                    // Проверка наличия достаточного количества товара
                    if (availableQuantity >= quantity)
                    {
                        // Обновление количества товара в таблице mobile_info
                        int remainingQuantity = availableQuantity - quantity;
                        UpdateQuantityInMobileInfo(database, brand, model, remainingQuantity);
                        // Добавление строки в таблицу bill_info
                        InsertIntoBillInfo(database, brand, model, price, quantity);
                        MessageBox.Show("Товар успешно добавлен");

                        DisplayMobileData();

                        DisplayAccessoriesData();

                        DisplayBillData();
                    }
                    else
                    {
                        MessageBox.Show("Недостаточное количество товара");
                    }
                }
                else
                {
                    mobileReader.Close(); // Закрытие DataReader

                    // Проверка наличия товара с указанными параметрами в таблице accessories_info
                    string accessoryQuery = "SELECT * FROM accessories_info WHERE Brand = @Brand AND Model = @Model AND Price >= @Price AND Quantity >= @Quantity";

                    // Создание команды SQL для проверки в таблице accessories_info
                    MySqlCommand accessoryCommand = new MySqlCommand(accessoryQuery, database.GetConnection());
                    accessoryCommand.Parameters.AddWithValue("@Brand", brand);
                    accessoryCommand.Parameters.AddWithValue("@Model", model);
                    accessoryCommand.Parameters.AddWithValue("@Price", price);
                    accessoryCommand.Parameters.AddWithValue("@Quantity", quantity);

                    // Выполнение запроса и чтение результата
                    accessoryReader = accessoryCommand.ExecuteReader();

                    if (accessoryReader.Read())
                    {
                        int availableQuantity = accessoryReader.GetInt32("Quantity");

                        // Проверка наличия достаточного количества товара
                        if (availableQuantity >= quantity)
                        {
                            // Обновление количества товара в таблице accessories_info
                            int remainingQuantity = availableQuantity - quantity;
                            UpdateQuantityInAccessoriesInfo(database, brand, model, remainingQuantity);
                            // Добавление строки в таблицу bill_info
                            InsertIntoBillInfo(database, brand, model, price, quantity);
                            MessageBox.Show("Товар успешно добавлен");

                            DisplayMobileData();

                            DisplayAccessoriesData();

                            DisplayBillData();
                        }
                        else
                        {
                            MessageBox.Show("Недостаточное количество товара");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Товар с указанными параметрами не найден");
                    }
                }
            }
            finally
            {
                // Закрытие DataReader'ов перед закрытием подключения к базе данных
                if (mobileReader != null)
                    mobileReader.Close();

                if (accessoryReader != null)
                    accessoryReader.Close();

                // Закрытие подключения к базе данных
                database.CloseConnection();
            }
        }

        private void UpdateQuantityInMobileInfo(DataBase database, string brand, string model, int quantity)
        {
            string updateQuery = "UPDATE mobile_info SET Quantity = @Quantity WHERE Brand = @Brand AND Model = @Model";
            MySqlCommand updateCommand = new MySqlCommand(updateQuery, database.GetConnection());
            updateCommand.Parameters.AddWithValue("@Quantity", quantity);
            updateCommand.Parameters.AddWithValue("@Brand", brand);
            updateCommand.Parameters.AddWithValue("@Model", model);
            updateCommand.ExecuteNonQuery();
        }

        private void UpdateQuantityInAccessoriesInfo(DataBase database, string brand, string model, int quantity)
        {
            string updateQuery = "UPDATE accessories_info SET Quantity = @Quantity WHERE Brand = @Brand AND Model = @Model";
            MySqlCommand updateCommand = new MySqlCommand(updateQuery, database.GetConnection());
            updateCommand.Parameters.AddWithValue("@Quantity", quantity);
            updateCommand.Parameters.AddWithValue("@Brand", brand);
            updateCommand.Parameters.AddWithValue("@Model", model);
            updateCommand.ExecuteNonQuery();
        }

        private void InsertIntoBillInfo(DataBase database, string brand, string model, int price, int quantity)
        {
            int total = price * quantity;
            string insertQuery = "INSERT INTO bill_info (Brand, Model, Price, Quantity, Total) VALUES (@Brand, @Model, @Price, @Quantity, @Total)";
            MySqlCommand insertCommand = new MySqlCommand(insertQuery, database.GetConnection());
            insertCommand.Parameters.AddWithValue("@Brand", brand);
            insertCommand.Parameters.AddWithValue("@Model", model);
            insertCommand.Parameters.AddWithValue("@Price", price);
            insertCommand.Parameters.AddWithValue("@Quantity", quantity);
            insertCommand.Parameters.AddWithValue("@Total", total);
            insertCommand.ExecuteNonQuery();
        }

        private void PrintBill_InPDF_Click(object sender, EventArgs e)
        {
            // Проверка, является ли таблица BillGridView пустой
            if (IsBillGridViewEmpty())
            {
                MessageBox.Show("Таблица 'BillGridView' пуста.");
                return;
            }

            // Создание документа PDF
            iTextSharp.text.Document document = new iTextSharp.text.Document();
            string currentDate = DateTime.Now.ToString("dd.MM.yyyy");
            string currentTime = DateTime.Now.ToString("HH.mm.ss");
            string filePath = $@"C:\Users\30100\source\repos\MobileShopManagementSystem\MobileShopManagementSystem\Bill\PDF\bill_{currentDate}_{currentTime}.pdf";

            try
            {
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                // Добавление заголовка в документ
                iTextSharp.text.Font titleFont = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph("MobileSoft 1.0", titleFont);
                title.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                document.Add(title);

                // Добавление пустого абзаца для создания отступа перед таблицей
                document.Add(new iTextSharp.text.Paragraph("\n"));

                // Добавление таблицы с данными из BillGridView
                PdfPTable table = new PdfPTable(BillGridView.Columns.Count);
                foreach (DataGridViewColumn column in BillGridView.Columns)
                {
                    table.AddCell(new Phrase(column.HeaderText));
                }

                foreach (DataGridViewRow row in BillGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            table.AddCell(cell.Value.ToString());
                        }
                        else
                        {
                            table.AddCell(""); // Добавляем пустую ячейку, если значение ячейки равно null
                        }
                    }
                }

                document.Add(table);

                // Вычисление общей суммы
                double totalAmount = 0;
                foreach (DataGridViewRow row in BillGridView.Rows)
                {
                    totalAmount += Convert.ToDouble(row.Cells["Total"].Value);
                }

                // Добавление общей суммы и текущей даты в документ на одной строке
                DateTime currentDateTime = DateTime.Now;
                string formattedDate = currentDateTime.ToString("dd-MM-yyyy HH:mm");
                string totalAndDate = $"                {formattedDate}                                                          The total amount: {totalAmount}";
                iTextSharp.text.Paragraph totalAndDateParagraph = new iTextSharp.text.Paragraph(totalAndDate);
                totalAndDateParagraph.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                document.Add(totalAndDateParagraph);


                MessageBox.Show($"PDF файл успешно сохранен по пути: {filePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении PDF файла: {ex.Message}");
            }
            finally
            {
                document.Close();
            }
        }

        // Метод для проверки, является ли таблица BillGridView пустой
        private bool IsBillGridViewEmpty()
        {
            return BillGridView.Rows.Count == 0;
        }

        private void PrintBill_InWord_Click(object sender, EventArgs e)
        {
            // Проверка, является ли таблица BillGridView пустой
            if (IsBillGridViewEmpty())
            {
                MessageBox.Show("Таблица 'BillGridView' пуста.");
                return;
            }

            // Создание нового экземпляра приложения Word
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document document = wordApp.Documents.Add();

            try
            {
                // Добавление заголовка в документ
                string titleText = "MobileSoft 1.0";
                Microsoft.Office.Interop.Word.Paragraph titleParagraph = document.Paragraphs.Add();
                titleParagraph.Range.Text = titleText;
                titleParagraph.Range.Bold = 1;
                titleParagraph.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                titleParagraph.Range.InsertParagraphAfter();

                // Добавление пустой строки для создания отступа перед таблицей
                document.Paragraphs.Add();

                // Добавление таблицы с данными из BillGridView
                Table table = document.Tables.Add(document.Paragraphs[document.Paragraphs.Count].Range, BillGridView.Rows.Count + 1, BillGridView.Columns.Count);
                foreach (DataGridViewColumn column in BillGridView.Columns)
                {
                    table.Cell(1, column.Index + 1).Range.Text = column.HeaderText;
                }

                for (int row = 0; row < BillGridView.Rows.Count; row++)
                {
                    for (int col = 0; col < BillGridView.Columns.Count; col++)
                    {
                        var cellValue = BillGridView.Rows[row].Cells[col].Value;
                        if (cellValue != null)
                        {
                            table.Cell(row + 2, col + 1).Range.Text = cellValue.ToString();
                        }
                        else
                        {
                            table.Cell(row + 2, col + 1).Range.Text = "";
                        }
                    }
                }

                // Вычисление общей суммы
                double totalAmount = CalculateTotalAmount();

                // Добавление общей суммы и текущей даты на одной строке
                DateTime currentDate = DateTime.Now;
                string formattedDate = currentDate.ToString("dd-MM-yyyy HH:mm");
                string totalAndDate = $"{formattedDate}                                                          The total amount: {totalAmount}";
                Microsoft.Office.Interop.Word.Paragraph totalAndDateParagraph = document.Paragraphs.Add();
                totalAndDateParagraph.Range.Text = totalAndDate;

                // Сохранение документа Word
                string currentDateTime = DateTime.Now.ToString("dd.MM.yyyy_HH.mm.ss");
                string filePath = $@"C:\Users\30100\source\repos\MobileShopManagementSystem\MobileShopManagementSystem\Bill\Word\bill_{currentDateTime}.docx";
                document.SaveAs(filePath);

                MessageBox.Show($"Документ Word успешно сохранен по пути: {filePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении документа Word: {ex.Message}");
            }
            finally
            {
                // Закрытие приложения Word
                wordApp.Quit();
            }
        }

        private double CalculateTotalAmount()
        {
            double totalAmount = 0;
            foreach (DataGridViewRow row in BillGridView.Rows)
            {
                totalAmount += Convert.ToDouble(row.Cells["Total"].Value);
            }
            return totalAmount;
        }
    }
}
