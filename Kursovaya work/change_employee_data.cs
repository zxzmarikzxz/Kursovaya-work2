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
    public partial class change_employee_data : Form
    {
        MySqlConnection conbaza = ConnBaza.connection;
        public change_employee_data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                string a = textBox3.Text;
                string k = textBox1.Text;
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Введите данные");
                }
                else
                {
                    try
                    {
                        conbaza.Open();
                        //Обновить значения cost_service и ID_service в таблице Service
                        string commandStr = $"UPDATE Staff SET login = '{k}' WHERE ID_staff = '{a}'";
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
        }

        private void button2_Click(object sender, EventArgs e)
        {

                string a = textBox3.Text;
                string k = textBox2.Text;
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Введите данные");
                }
                else
                {
                    try
                    {
                        conbaza.Open();
                        //Обновить значения cost_service и ID_service в таблице Service
                        string commandStr = $"UPDATE Staff SET password = '{k}' WHERE ID_staff = '{a}'";
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
    }
}
