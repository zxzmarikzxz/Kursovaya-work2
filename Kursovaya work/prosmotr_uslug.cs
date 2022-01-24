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
    public partial class prosmotr_uslug : Form
    {
        MySqlConnection conbaza = ConnBaza.connection;
        private BindingSource bSource = new BindingSource(); //Унифицированный доступ к источнику данных          
        private DataTable table = new DataTable();
        private MySqlDataAdapter adapter = new MySqlDataAdapter(); //Получение данных из источника 
        public prosmotr_uslug()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //удаление пустой строки
            dataGridView1.AllowUserToAddRows = false;
            try
            {
                conbaza.Open();
                string commandStr = "SELECT ID_sr,fio_client,brand,date_time,service,cost_service FROM Service_Rendering";//Запрос к базе данных(взять ID_sr,fio_client,brand,date_time, service из таблицы Service_Rendering)
                MySqlDataAdapter adapter = new MySqlDataAdapter(commandStr, conbaza);
                DataTable dTable = new DataTable();
                adapter.Fill(dTable);
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dTable.Rows.Count; i++)//Добавление строк пока i не станет больше или равно количеству строк таблицы(dTable.Rows.Count количество строк таблицы)
                {
                    dataGridView1.Rows.Add(dTable.Rows[i].ItemArray);
                }
            }
            catch
            {

            }
            conbaza.Close();
        }

        private void prosmotr_uslug_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu_employee me = new menu_employee();
            this.Hide();
            me.ShowDialog();
        }

        private void prosmotr_uslug_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //удаление пустой строки
            dataGridView1.AllowUserToAddRows = false;
            //Проверка на пустоту
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || dateTimePicker1.Text == "")
            {
                MessageBox.Show("Введите данные");
            }
            else
            { 
                conbaza.Open();
                {
                    //Вставляем значения в таблицу Service_Rendering
                    string commandStr = $"INSERT INTO Service_Rendering (ID_sr,fio_client,brand,date_time,service,cost_service) VALUES (@id,@Fio_client,@brend,@dt,@servIce,@cost)";
                    MySqlCommand command = new MySqlCommand(commandStr, conbaza);
                    try
                    {
                        //берём значение из текстбоксов,комбобоксов,дататаймпикера и кидаем в базу данных
                        command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBox1.Text;
                        command.Parameters.Add("@Fio_client", MySqlDbType.VarChar).Value = textBox2.Text;
                        command.Parameters.Add("@brend", MySqlDbType.VarChar).Value = comboBox3.Text;
                        command.Parameters.Add("@dt", MySqlDbType.DateTime).Value = dateTimePicker1.Text;
                        command.Parameters.Add("@servIce", MySqlDbType.VarChar).Value = comboBox2.Text;
                        command.Parameters.Add("@cost", MySqlDbType.VarChar).Value = textBox3.Text;
                        //Изменения данных в БД
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

        private void button3_Click(object sender, EventArgs e)
        {
            menu_employee md = new menu_employee();
            md.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //удаление пустой строки
            dataGridView1.AllowUserToAddRows = false;
            try
            {
                conbaza.Open();
                //Запрос к базе данных(взять ID_sr,fio_client,brand,date_time,service,cost_service из таблицы Service_Rendering)
                string commandStr = "SELECT ID_sr,fio_client,brand,date_time,service,cost_service FROM Service_Rendering";
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
    }
}
