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
    public partial class add_service_rendering : Form
    {
        MySqlConnection conbaza = ConnBaza.connection;
        public add_service_rendering()
        {
            InitializeComponent();
        }
        public void add_data()
        {
           
            //Проверка на пустоту
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox2.Text == "" || dateTimePicker1.Text == "")
            {
                MessageBox.Show("Введите данные");
            }
            else
            {
                conbaza.Open();
                {
                    //Вставляем значения в таблицу Service_Rendering
                    string commandStr = $"INSERT INTO Service_Rendering (ID_sr,fio_client,date_time,service,cost_service) VALUES (@id,@Fio_client,@dt,@servIce,@cost)";
                    MySqlCommand command = new MySqlCommand(commandStr, conbaza);
                    try
                    {
                        //берём значение из текстбоксов,комбобоксов,дататаймпикера и кидаем в базу данных
                        command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBox1.Text;
                        command.Parameters.Add("@Fio_client", MySqlDbType.VarChar).Value = textBox2.Text;
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

        private void button1_Click(object sender, EventArgs e)
        {
            add_data();
        }
    }
}
