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
            delete_service delete_service = new delete_service();
            delete_service.ShowDialog();
        }
        public void Dobavlenie()
        {
            add_service add_service = new add_service();
            add_service.ShowDialog();
        }
        private void Change_cash()
        {
            change_cash change_cash = new change_cash();
            change_cash.ShowDialog();
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
         private void change_service_Load(object sender, EventArgs e)
        {

        }

        private void change_service_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu_director md = new menu_director();
            md.Show();
            this.Close();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Obnovit();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Change_cash();
            
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Nazad();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Obnovit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Dobavlenie();
        }
    }
}
