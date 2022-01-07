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
    public partial class pribil : Form
    {
        MySqlConnection conbaza = ConnBaza.connection;
        public pribil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conbaza.Open();
                string commandStr = "SELECT ID_sr,date_time,cost_service FROM Service_Rendering";//Запрос к базе данных(взять ID_sr,fio_client,brand,date_time, service из таблицы t_datetime)
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
            int a=0;
            for (int i = 0; i< dataGridView1.Rows.Count;i++)
            {
             //Подсчёт всех данных из столбца и вывод их в текстбокс
             a+= Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
             textBox1.Text = a.ToString();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pribil_Load(object sender, EventArgs e)
        {

        }
    }
}
