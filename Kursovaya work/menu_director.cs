using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya_work
{
    public partial class menu_director : Form
    {
        public menu_director()
        {
            InitializeComponent();
        }

        private void menu_director_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            change_service cs = new change_service();
            this.Hide();
            cs.ShowDialog();
        }

        private void menu_director_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pribil cs = new pribil();
            this.Hide();
            cs.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            prosmotr_clients cs = new prosmotr_clients();
            this.Hide();
            cs.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            change_employee cs = new change_employee();
            this.Hide();
            cs.ShowDialog();
        }
    }
}
