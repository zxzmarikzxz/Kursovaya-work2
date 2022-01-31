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

    public partial class change_service : Form
    {
        MySqlConnection conbaza = ConnBaza.connection;
        private BindingSource bSource = new BindingSource(); //Унифицированный доступ к источнику данных          
        private DataTable table = new DataTable();
        private MySqlDataAdapter adapter = new MySqlDataAdapter(); //Получение данных из источника
        public change_service()
        {
            InitializeComponent();
        }
        public void Vivod()
        {
            try
            {
                //удаление пустой строки
                dataGridView1.AllowUserToAddRows = false;
                conbaza.Open();
                //Запрос к базе данных(взять ID_service,service,cose_service из таблицы service)
                string commandStr = "SELECT ID_service,service,cost_service FROM Service";
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
        public void Delete()
        {
            //удаление пустой строки
            dataGridView1.AllowUserToAddRows = false;
            string a = textBox3.Text;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Введите данные");
            }
            else
            {
                try
                {
                    conbaza.Open();
                    string commandStr = $"DELETE FROM Service WHERE ID_service = '{a}'";
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
        public void Dobavlenie()
        {
            //Проверка на пустоту
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Введите данные");
            }
            else
            {
                conbaza.Open();
                {
                    //Вставляем значения в таблицу Service
                    string commandStr = $"INSERT INTO Service (ID_service,service, cost_service) VALUES (@id,@servic,@cost)";
                    MySqlCommand command = new MySqlCommand(commandStr, conbaza);
                    try
                    {
                        //берём значение из текстбокса и кидаем в базу данных
                        command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBox3.Text;
                        command.Parameters.Add("@servic", MySqlDbType.VarChar).Value = textBox1.Text;
                        command.Parameters.Add("@cost", MySqlDbType.VarChar).Value = textBox2.Text;
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
        private void Change_cash()
        {
            //удаление пустой строки
            dataGridView1.AllowUserToAddRows = false;
            {
                string a = textBox3.Text;
                string b = textBox2.Text;
                if (textBox2.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Введите данные");
                }
                else
                {
                    try
                    {
                        conbaza.Open();
                        //Обновить значения cost_service и ID_service в таблице Service
                        string commandStr = $"UPDATE Service SET cost_service = '{b}' WHERE ID_service = '{a}'";
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
        public void Obnovit()
        {
            //удаление пустой строки
            dataGridView1.AllowUserToAddRows = false;
            try
            {
                conbaza.Open();
                //Запрос к базе данных(взять ID_service,service,cose_service из таблицы service)
                string commandStr = "SELECT ID_service,service,cost_service FROM Service";
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
        public void Nazad()
        {
            menu_director md = new menu_director();
            md.Show();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Dobavlenie();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            Vivod();       
        }

        private void change_service_Load(object sender, EventArgs e)
        {

        }

        private void change_service_FormClosed(object sender, FormClosedEventArgs e)
        {           
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete();      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Change_cash();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Obnovit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Nazad();
        }
    }
}
