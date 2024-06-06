using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShopManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Получение значений из полей ввода
            string login = UserIDField.Text;
            string password = PasswordField.Text;

            // Проверка на пустые поля
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            // Проверка поля login на наличие только английских символов и количество символов не более 8
            if (!Regex.IsMatch(login, @"^[a-zA-Z]+$") || login.Length > 8)
            {
                MessageBox.Show("Поле 'UserID' должно содержать только английские символы и не более 8 символов");
                return;
            }

            // Проверка поля password на наличие только цифр и количество символов не более 8
            if (!Regex.IsMatch(password, @"^\d+$") || password.Length > 8)
            {
                MessageBox.Show("Поле 'Password' должно содержать только цифры и не более 8 символов");
                return;
            }

            // Создаем новый экземпляр подключения к базе данных
            DataBase database = new DataBase();

            // Открываем подключение к базе данных
            database.OpenConnection();

            try
            {
                // Запрос к базе данных
                string query = $"SELECT COUNT(*) FROM customers WHERE UserID = '{login}' AND Password = '{password}'";

                // Выполнение запроса
                MySqlCommand command = new MySqlCommand(query, database.GetConnection());
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Авторизация прошла успешно");
                }
                else
                {
                    MessageBox.Show("Ошибка при авторизации: Неверный UserID или Password");
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибки при выполнении запроса
                MessageBox.Show("Ошибка при авторизации: " + ex.Message);
            }
            finally
            {
                // Закрываем подключение к базе данных
                database.CloseConnection();
            }
        }

        private void ClearLabel_Click(object sender, EventArgs e)
        {
            UserIDField.Text = "";
            PasswordField.Text = "";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}