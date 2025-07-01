using AppInventory.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInventory.Controller
{
    public class InventoryController
    {
        public bool SimpanBarang(InventoryModel barang, out string pesan)
        {
            try
            {
                MySqlConnection conn = koneksi.GetConnection();
                string query = "INSERT INTO inventori (kode_barang, nama_barang, kondisi, jumlah, satuan) " +
                               "VALUES (@kode, @nama, @kondisi, @jumlah, @satuan)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kode", barang.Kode);
                cmd.Parameters.AddWithValue("@nama", barang.Nama);
                cmd.Parameters.AddWithValue("@kondisi", barang.Kondisi);
                cmd.Parameters.AddWithValue("@jumlah", barang.Jumlah);
                cmd.Parameters.AddWithValue("@satuan", barang.Satuan);

                int result = cmd.ExecuteNonQuery();
                koneksi.CloseConnection();

                if (result > 0)
                {
                    pesan = "Data berhasil disimpan ke database.";
                    return true;
                }
                else
                {
                    pesan = "Gagal menyimpan data.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                pesan = "Terjadi kesalahan: " + ex.Message;
                return false;
            }
        }

        public bool UpdateBarang(InventoryModel barang, out string pesan)
        {
            try
            {
                MySqlConnection conn = koneksi.GetConnection();
                string query = "UPDATE inventori SET kode_barang = @kode, nama_barang = @nama, kondisi = @kondisi, jumlah = @jumlah, satuan = @satuan WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kode", barang.Kode);
                cmd.Parameters.AddWithValue("@nama", barang.Nama);
                cmd.Parameters.AddWithValue("@kondisi", barang.Kondisi);
                cmd.Parameters.AddWithValue("@jumlah", barang.Jumlah);
                cmd.Parameters.AddWithValue("@satuan", barang.Satuan);
                cmd.Parameters.AddWithValue("@id", barang.Id);

                int result = cmd.ExecuteNonQuery();
                koneksi.CloseConnection();

                if (result > 0)
                {
                    pesan = "Data berhasil diperbarui di database.";
                    return true;
                }
                else
                {
                    pesan = "Gagal memperbarui data.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                pesan = "Terjadi kesalahan: " + ex.Message;
                return false;
            }
        }

        public bool HapusBarang(string id, out string pesan)
        {
            try
            {
                MySqlConnection conn = koneksi.GetConnection();
                string query = "DELETE FROM inventori WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                int result = cmd.ExecuteNonQuery();
                koneksi.CloseConnection();

                if (result > 0)
                {
                    pesan = "Data berhasil dihapus dari database.";
                    return true;
                }
                else
                {
                    pesan = "Data tidak ditemukan atau gagal dihapus.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                pesan = "Terjadi kesalahan saat menghapus data: " + ex.Message;
                return false;
            }
        }

        public List<InventoryModel> GetAllInventori(out string error)
        {
            List<InventoryModel> data = new List<InventoryModel>();
            error = "";

            try
            {
                MySqlConnection conn = koneksi.GetConnection();
                string query = "SELECT id, kode_barang, nama_barang, kondisi, jumlah, satuan FROM inventori";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    InventoryModel item = new InventoryModel
                    {
                        Id = reader["id"].ToString(),
                        Kode = reader["kode_barang"].ToString(),
                        Nama = reader["nama_barang"].ToString(),
                        Kondisi = reader["kondisi"].ToString(),
                        Jumlah = reader["jumlah"].ToString(),
                        Satuan = reader["satuan"].ToString()
                    };
                    data.Add(item);
                }

                reader.Close();
                koneksi.CloseConnection();
            }
            catch (Exception ex)
            {
                error = "Gagal memuat data: " + ex.Message;
            }

            return data;
        }

    }
}
