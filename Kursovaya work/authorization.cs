using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Добавление MySql
using MySql.Data.MySqlClient;
//Добавление библиотеки классов
using Library2;

namespace Kursovaya_work
{
    public partial class authorization : Form
    {
        MySqlConnection conbaza = ConnBaza.connection;  
        public int Podkluchenie(string login, string password)
        {
            int a = 0;
            //Открытие соединения
            try
            {
                conbaza.Open();
                //Выбор всех данных из таблицы Staff и их фильтрование по подходящим логину и паролю
                string commandStr = $"SELECT count(*) FROM Staff WHERE login = '{login}' AND password = '{password}'";
                MySqlCommand comm1 = new MySqlCommand(commandStr, conbaza);
                int k = Convert.ToInt32(comm1.ExecuteScalar());
                if (k != 0)
                {
                //Выбор столбца access в зависимости от логина и пароля
                string commandStr2 = $"SELECT access FROM Staff WHERE login = '{login}' AND password = '{password}'";
                    MySqlCommand comm2 = new MySqlCommand(commandStr2, conbaza);
                    a = Convert.ToInt32(comm2.ExecuteScalar());
                }
            }
            //Обработка исключений
            catch
            {

            }         
            //Закрытие соединения
            conbaza.Close();                           
            return a;
        }
        public void Sueta()
        {
            //Если возвращаемое значение a равняется 1(уровень доступа, то есть столбец access в БД), открывается форма меню сотрудника,
            //если 2 то форма меню директора
            if (Podkluchenie(textBox1.Text, textBox2.Text) == 1)
            {
                MessageBox.Show("Вы авторизированы как сотрудник");
                //Скрытие данной формы и запуск следующей в зависимости от введёных данных
                menu_employee me = new menu_employee();
                this.Hide();
                me.ShowDialog();
            }
            else if (Podkluchenie(textBox1.Text, textBox2.Text) == 2)
            {
                MessageBox.Show("Вы авторизированы как директор");
                menu_director me2 = new menu_director();
                this.Hide();
                me2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Введите правильные данные");
            }
        }
        public authorization()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sueta();
        }

        private void authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}

