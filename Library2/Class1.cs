using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Library2
{
    public class ConnBaza
    {
        public static MySqlConnection connection = new MySqlConnection("server=chuc.caseum.ru;port=33333;user=st_3_19_20;database=is_3_19_st20_KURS;password=84678543;");
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}

