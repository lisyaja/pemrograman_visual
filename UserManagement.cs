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

            string[] row = new string[] { username, nama, password };
            tabellistuser.Rows.Add(row);

            // Bersihkan input
            textboxusername.Clear();
            textboxnama.Clear();
            textboxpassword.Clear();
            textboxusername.Focus();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            if (tabellistuser.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    tabellistuser.Rows.RemoveAt(tabellistuser.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Pilih baris yang akan dihapus terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
