using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInventory.Model
{
    public class UsersModel
    {
        public string Username { get; set; }
        public string Nama { get; set; }
        public string Password { get; set; }
        public bool ValidateUser(string username, string password)
        {
            try
            {
                MySqlConnection conn = koneksi.GetConnection();
                string query = "SELECT COUNT(*) FROM users WHERE username=@username AND password=@password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Database Error: " + ex.Message);
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }
    }
}
