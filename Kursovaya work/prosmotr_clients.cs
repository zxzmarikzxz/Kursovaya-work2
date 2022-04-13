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
        public void data()
        {
            //удаление пустой строки
            dataGridView1.AllowUserToAddRows = false;
            try
            {
                conbaza.Open();
                string commandStr = "SELECT ID_sr,fio_client,date_time,cost_service FROM Service_Rendering";//Запрос к базе данных(взять ID_sr,fio_client,brand,date_time, service из таблицы t_datetime)
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
            int a = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //Подсчёт всех данных из столбца и вывод их в текстбокс
                a += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                toolStripLabel5.Text = a.ToString()+" Рублей";

            }
            {
                //Вывод последней строки первого столбца в текстбокс
                toolStripLabel3.Text = Convert.ToString(dataGridView1.Rows.Count - 1 + 1);
                
            }
        }
        public void back()
        {
            menu_director md = new menu_director();
            md.Show();
            this.Close();
        }
        private void prosmotr_clients_Load(object sender, EventArgs e)
        {

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            data();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            back();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            back();
        }
    }
}
