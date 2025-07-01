using AppInventory.Controller;
using AppInventory.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppInventory
{
    public partial class UserManagement : Form
    {

        private UserController userController = new UserController();
        public UserManagement()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {  

        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            tabellistuser.ColumnCount = 3;
            tabellistuser.Columns[0].Name = "Username";
            tabellistuser.Columns[1].Name = "Nama";
            tabellistuser.Columns[2].Name = "Password";

            tabellistuser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadUserData();
        }

        private void tabellist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btninventory_Click(object sender, EventArgs e)
        {
            Inventory inventoryForm = new Inventory();
            inventoryForm.Show();
            this.Hide(); // atau this.Close(); jika ingin menutup form UserManagement

        }

        private void btninput_Click(object sender, EventArgs e)
        {
            string username = textboxusername.Text.Trim();
            string nama = textboxnama.Text.Trim();
            string password = textboxpassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan Password wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UsersModel newUser = new UsersModel
            {
                Username = username,
                Nama = nama,
                Password = password
            };

            if (userController.TambahUser(newUser, out string pesan))
            {
                MessageBox.Show(pesan, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tambahkan ke DataGridView
                tabellistuser.Rows.Add(newUser.Username, newUser.Nama, newUser.Password);
            }
            else
            {
                MessageBox.Show(pesan, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textboxusername.Clear();
            textboxnama.Clear();
            textboxpassword.Clear();
            textboxusername.Focus();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            if (tabellistuser.SelectedRows.Count > 0)
            {
                string username = tabellistuser.SelectedRows[0].Cells["Username"].Value.ToString();

                DialogResult result = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (userController.HapusUser(username, out string pesan))
                    {
                        tabellistuser.Rows.RemoveAt(tabellistuser.SelectedRows[0].Index);
                        MessageBox.Show(pesan, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(pesan, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih baris yang akan dihapus terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void LoadUserData()
        {
            string errorMessage;
            List<UsersModel> users = userController.GetAllUsers(out errorMessage);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tabellistuser.Rows.Clear();

            foreach (var user in users)
            {
                tabellistuser.Rows.Add(user.Username, user.Nama, user.Password);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string username = textboxusername.Text.Trim();
            string nama = textboxnama.Text.Trim();
            string password = textboxpassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan Password wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Panggil controller untuk update user
                UsersModel user = new UsersModel
                {
                    Username = username,
                    Nama = nama,
                    Password = password
                };

                bool updated = UserController.UpdateUser(user);

                if (updated)
                {
                    MessageBox.Show("Data user berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUserData(); // Refresh tabel user

                    // Reset input
                    textboxusername.Clear();
                    textboxnama.Clear();
                    textboxpassword.Clear();
                    textboxusername.Enabled = true;
                    textboxusername.Focus();
                }
                else
                {
                    MessageBox.Show("Data user gagal diperbarui.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengedit data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabellistuser_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && tabellistuser.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow row = tabellistuser.Rows[e.RowIndex];

                textboxusername.Text = row.Cells[0].Value.ToString(); // Username
                textboxnama.Text = row.Cells[1].Value.ToString();     // Nama
                textboxpassword.Text = row.Cells[2].Value.ToString(); // Password

                textboxusername.Enabled = false; // Username tidak bisa diedit
            }
        }
    }
}
