using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AppInventory
{
    public class koneksi
    {
        private static string connStr = "server=localhost;user=root;password=;database=db_inventori;";
        private static MySqlConnection conn = new MySqlConnection(connStr);

        public static MySqlConnection GetConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed || conn.State == System.Data.ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        public static void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
