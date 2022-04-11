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
    public partial class delete_employee : Form
    {
        MySqlConnection conbaza = ConnBaza.connection;
        public delete_employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите данные");
            }
            else
            {
                try
                {
                    conbaza.Open();
                    string commandStr = $"DELETE FROM Staff WHERE ID_staff = '{a}'";
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

        private void delete_employee_Load(object sender, EventArgs e)
        {

        }
    }
}
