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
    public partial class prosmotr_clients : Form
    {
        MySqlConnection conbaza = ConnBaza.connection;
        public prosmotr_clients()
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
                string commandStr = "SELECT ID_sr,fio_client,date_time FROM Service_Rendering";//Запрос к базе данных(взять ID_sr,fio_client,brand,date_time, service из таблицы t_datetime)
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
           
            {
                //Вывод последней строки первого столбца в текстбокс
                textBox1.Text = Convert.ToString(dataGridView1.Rows.Count - 1+1);
            }
        }

        private void prosmotr_clients_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu_director md = new menu_director();
            md.Show();
            this.Close();
        }
    }
}
