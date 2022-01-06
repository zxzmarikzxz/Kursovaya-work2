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
        private void button1_Click(object sender, EventArgs e)
        {
            conbaza.Open();
            {
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
        
        private void button5_Click(object sender, EventArgs e)
        {
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

        private void change_service_Load(object sender, EventArgs e)
        {

        }

        private void change_service_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = textBox3.Text;
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

        private void button3_Click(object sender, EventArgs e)
        {
            {
                string a = textBox3.Text;
                string b = textBox2.Text;
                try
                {
                    conbaza.Open();
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

        private void button4_Click(object sender, EventArgs e)
        {
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

        private void button6_Click(object sender, EventArgs e)
        {
            menu_director md = new menu_director();
            md.Show();
            this.Close();
        }
    }
}
