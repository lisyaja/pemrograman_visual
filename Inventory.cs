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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }
        private void Inventory_Load(object sender, EventArgs e)
        {
            tabellistbrg.ColumnCount = 5;
            tabellistbrg.Columns[0].Name = "Kode Barang";
            tabellistbrg.Columns[1].Name = "Nama Barang";
            tabellistbrg.Columns[2].Name = "Kondisi";
            tabellistbrg.Columns[3].Name = "Jumlah";
            tabellistbrg.Columns[4].Name = "Satuan";

            tabellistbrg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string kode = textboxkodebrg.Text.Trim();
            string nama = textboxnamabrg.Text.Trim();
            string kondisi = textboxkondisi.Text.Trim();
            string jumlah = textboxjml.Text.Trim();
            string satuan = textboxstn.Text.Trim();

            // Validasi sederhana
            if (string.IsNullOrWhiteSpace(kode) || string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Kode dan Nama Barang wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tambahkan baris ke DataGridView
            string[] row = new string[] { kode, nama, kondisi, jumlah, satuan };
            tabellistbrg.Rows.Add(row);

            // Bersihkan textbox
            textboxkodebrg.Clear();
            textboxnamabrg.Clear();
            textboxkondisi.Clear();
            textboxjml.Clear();
            textboxstn.Clear();
            textboxkodebrg.Focus();
        }

        private void tabellistbrg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tabellistbrg.CurrentRow != null)
            {
                tabellistbrg.CurrentRow.Cells[0].Value = textboxkodebrg.Text.Trim();
                tabellistbrg.CurrentRow.Cells[1].Value = textboxnamabrg.Text.Trim();
                tabellistbrg.CurrentRow.Cells[2].Value = textboxkondisi.Text.Trim();
                tabellistbrg.CurrentRow.Cells[3].Value = textboxjml.Text.Trim();
                tabellistbrg.CurrentRow.Cells[4].Value = textboxstn.Text.Trim();

                MessageBox.Show("Data berhasil diupdate.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tabellistbrg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tabellistbrg.Rows[e.RowIndex];
                textboxkodebrg.Text = row.Cells[0].Value.ToString();
                textboxnamabrg.Text = row.Cells[1].Value.ToString();
                textboxkondisi.Text = row.Cells[2].Value.ToString();
                textboxjml.Text = row.Cells[3].Value.ToString();
                textboxstn.Text = row.Cells[4].Value.ToString();
            }
        }

        private void tabellistbrg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (tabellistbrg.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    tabellistbrg.Rows.RemoveAt(tabellistbrg.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Pilih baris yang akan dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnusermanagement_Click(object sender, EventArgs e)
        {
            UserManagement userForm = new UserManagement();
            userForm.Show();
            this.Hide(); // Sembunyikan form saat ini (opsional)
        }
    }

}
