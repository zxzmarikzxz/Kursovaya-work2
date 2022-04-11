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
    public partial class change_employee : Form      
    {      
        MySqlConnection conbaza = ConnBaza.connection;    
        public change_employee()
        {
            InitializeComponent();
        }
        public void Change_employee()
        {
            //Открытие соединения
            try
            {
                conbaza.Open();
                //удаление пустой строки
                dataGridView1.AllowUserToAddRows = false;
                //Запрос к базе данных(взять ID_staff,fio_employee,login,password,access из таблицы Staff)
                string commandStr = "SELECT ID_staff,fio_employee,login,password,access FROM Staff";
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
        public void Delete_employee()
        {
            delete_employee delete_employee = new delete_employee();
            delete_employee.ShowDialog();
        }
        public void Add_employee()
        {
            add_employee add_employee = new add_employee();
            add_employee.ShowDialog();
        }
        public void Change_data()
        {
            change_employee_data change_employee_data = new change_employee_data();
            change_employee_data.ShowDialog();
        }
        
        public void Reload()
        {
            //Открытие соединения
            try
            {
                conbaza.Open();
                //Запрос к базе данных(взять ID_staff,fio_employee,login,password,access из таблицы Staff)
                string commandStr = "SELECT ID_staff,fio_employee,login,password,access FROM Staff";
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
        public void Back()
        {
            menu_director md = new menu_director();
            md.Show();
            this.Close();
        }
        private void change_employee_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Change_employee();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Delete_employee();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Add_employee();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Change_employee();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Change_data();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Back();
        }
    }
}
