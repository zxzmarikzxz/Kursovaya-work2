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
    public partial class add_service : Form
    {
        MySqlConnection conbaza = ConnBaza.connection;
        public add_service()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
