using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Library2;

namespace Kursovaya_work
{
    public partial class change_employee : Form      
    {      
        MySqlConnection conbaza = ConnBaza.connection;
        public change_employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Открытие соединения
            try
            {
                conbaza.Open();
                //удаление пустой строки
                dataGridView1.AllowUserToAddRows = false;
                //Запрос к базе данных(взять ID_staff,fio_employee,login,password,access из таблицы Staff)
                string commandStr = "SELECT ID_staff,fio_employee,login,password,access FROM Staff";
                MySqlDataAdapter adapter = new MySqlDataAdapter(commandStr, conbaza);
                DataTable dTable = new DataTable();
                adapter.Fill(dTable);
                dataGridView1.Rows.Clear();
                //Добавление строк пока i не станет больше или равно количеству строк таблицы(dTable.Rows.Count количество строк таблицы)
                for (int i = 0; i < dTable.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dTable.Rows[i].ItemArray);
                }
            }
            catch
            {

            }
            conbaza.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Проверка на пустоту
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Введите данные");
            }
            else
            {
                conbaza.Open();
                {
                    //Вставляем значения в таблицу Service
                    string commandStr = $"INSERT INTO Staff (ID_staff,fio_employee,login,password,access) VALUES (@id,@fio,@log,@pass,@acces)";
                    MySqlCommand command = new MySqlCommand(commandStr, conbaza);
                    try
                    {
                        //берём значение из текстбокса и кидаем в базу данных
                        command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBox1.Text;
                        command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = textBox2.Text;
                        command.Parameters.Add("@log", MySqlDbType.VarChar).Value = textBox3.Text;
                        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBox4.Text;
                        command.Parameters.Add("@acces", MySqlDbType.VarChar).Value = textBox5.Text;
                        //Изменения данных в базе данных
                        command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex}");
                    }
                    finally
                    {
                        conbaza.Close();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите данные");
            }
            else
            {
                try
                {
                    conbaza.Open();
                    string commandStr = $"DELETE FROM Staff WHERE ID_staff = '{a}'";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(commandStr, conbaza);
                    DataTable dTable = new DataTable();
                    adapter.Fill(dTable);
                }
                catch
                {

                }
                conbaza.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Открытие соединения
            try
            {
                conbaza.Open();
                //Запрос к базе данных(взять ID_staff,fio_employee,login,password,access из таблицы Staff)
                string commandStr = "SELECT ID_staff,fio_employee,login,password,access FROM Staff";
                MySqlDataAdapter adapter = new MySqlDataAdapter(commandStr, conbaza);
                DataTable dTable = new DataTable();
                adapter.Fill(dTable);
                dataGridView1.Rows.Clear();
                //Добавление строк пока i не станет больше или равно количеству строк таблицы(dTable.Rows.Count количество строк таблицы)
                for (int i = 0; i < dTable.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dTable.Rows[i].ItemArray);
                }
            }
            catch
            {

            }
            conbaza.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {

                string a = textBox1.Text;
                string k = textBox3.Text;
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Введите данные");
                }
                else
                {
                    try
                    {
                        conbaza.Open();
                        //Обновить значения cost_service и ID_service в таблице Service
                        string commandStr = $"UPDATE Staff SET login = '{k}' WHERE ID_staff = '{a}'";
                        MySqlDataAdapter adapter = new MySqlDataAdapter(commandStr, conbaza);
                        DataTable dTable = new DataTable();
                        adapter.Fill(dTable);
                    }
                    catch
                    {

                    }
                    conbaza.Close();
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {

                string a = textBox1.Text;
                string k = textBox4.Text;
                if (textBox4.Text == "")
                {
                    MessageBox.Show("Введите данные");
                }
                else
                {
                    try
                    {
                        conbaza.Open();
                        //Обновить значения cost_service и ID_service в таблице Service
                        string commandStr = $"UPDATE Staff SET password = '{k}' WHERE ID_staff = '{a}'";
                        MySqlDataAdapter adapter = new MySqlDataAdapter(commandStr, conbaza);
                        DataTable dTable = new DataTable();
                        adapter.Fill(dTable);
                    }
                    catch
                    {

                    }
                    conbaza.Close();
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            menu_director md = new menu_director();
            md.Show();
            this.Close();
        }

        private void change_employee_Load(object sender, EventArgs e)
        {

        }
    }
}
