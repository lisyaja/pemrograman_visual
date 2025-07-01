using AppInventory.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInventory.Controller
{
    public class UserController
    {
        public bool TambahUser(UsersModel user, out string pesan)
        {
            try
            {
                MySqlConnection conn = koneksi.GetConnection();
                string query = "INSERT INTO users (username, nama, password) VALUES (@username, @nama, @password)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@nama", user.Nama);
                cmd.Parameters.AddWithValue("@password", user.Password);

                int result = cmd.ExecuteNonQuery();
                koneksi.CloseConnection();

                if (result > 0)
                {
                    pesan = "Data berhasil ditambahkan ke database.";
                    return true;
                }
                else
                {
                    pesan = "Gagal menambahkan data.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                pesan = "Terjadi kesalahan: " + ex.Message;
                return false;
            }
        }

        public bool HapusUser(string username, out string pesan)
        {
            try
            {
                MySqlConnection conn = koneksi.GetConnection();
                string query = "DELETE FROM users WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                int deleted = cmd.ExecuteNonQuery();
                koneksi.CloseConnection();

                if (deleted > 0)
                {
                    pesan = "Data berhasil dihapus.";
                    return true;
                }
                else
                {
                    pesan = "Data tidak ditemukan di database.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                pesan = "Terjadi kesalahan saat menghapus: " + ex.Message;
                return false;
            }
        }

        public static bool UpdateUser(UsersModel user)
        {
            try
            {
                using (MySqlConnection conn = koneksi.GetConnection())
                {
                    string query = "UPDATE users SET nama = @nama, password = @password WHERE username = @username";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@nama", user.Nama);
                    cmd.Parameters.AddWithValue("@password", user.Password);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch
            {
                return false;
            }
        }



        public List<UsersModel> GetAllUsers(out string errorMessage)
        {
            List<UsersModel> users = new List<UsersModel>();
            errorMessage = "";

            try
            {
                MySqlConnection conn = koneksi.GetConnection();
                string query = "SELECT username, nama, password FROM users";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    users.Add(new UsersModel
                    {
                        Username = reader["username"].ToString(),
                        Nama = reader["nama"].ToString(),
                        Password = reader["password"].ToString()
                    });
                }

                reader.Close();
                koneksi.CloseConnection();
            }
            catch (Exception ex)
            {
                errorMessage = "Gagal memuat data: " + ex.Message;
            }

            return users;
        }
    }
}
