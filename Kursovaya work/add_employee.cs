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
  
    public partial class add_employee : Form
    {
        MySqlConnection conbaza = ConnBaza.connection;
        public add_employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
