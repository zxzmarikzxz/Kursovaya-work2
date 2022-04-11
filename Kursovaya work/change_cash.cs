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
    public partial class change_cash : Form
    {
        MySqlConnection conbaza = ConnBaza.connection;
        public change_cash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string a = textBox1.Text;
                string b = textBox2.Text;
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Введите данные");
                }
                else
                {
                    try
                    {
                        conbaza.Open();
                        //Обновить значения cost_service и ID_service в таблице Service
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
        }

        private void change_cash_Load(object sender, EventArgs e)
        {

        }
    }
}
