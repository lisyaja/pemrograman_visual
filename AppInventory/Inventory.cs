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
    public partial class Inventory : Form
    {
        private InventoryController controller = new InventoryController();
        public Inventory()
        {
            InitializeComponent();
        }
        private void Inventory_Load(object sender, EventArgs e)
        {
            tabellistbrg.ColumnCount = 6;
            tabellistbrg.Columns[0].Name = "ID";
            tabellistbrg.Columns[1].Name = "Kode Barang";
            tabellistbrg.Columns[2].Name = "Nama Barang";
            tabellistbrg.Columns[3].Name = "Kondisi";
            tabellistbrg.Columns[4].Name = "Jumlah";
            tabellistbrg.Columns[5].Name = "Satuan";

            // Sembunyikan kolom ID dari user
            tabellistbrg.Columns[0].Visible = false;

            tabellistbrg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadInventoryData();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Ambil nilai dari TextBox
            InventoryModel barang = new InventoryModel
            {
                Kode = textboxkodebrg.Text.Trim(),
                Nama = textboxnamabrg.Text.Trim(),
                Kondisi = textboxkondisi.Text.Trim(),
                Jumlah = textboxjml.Text.Trim(),
                Satuan = textboxstn.Text.Trim()
            };

            // Validasi sederhana
            if (string.IsNullOrWhiteSpace(barang.Kode) || string.IsNullOrWhiteSpace(barang.Nama))
            {
                MessageBox.Show("Kode dan Nama Barang wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Simpan lewat controller
            if (controller.SimpanBarang(barang, out string pesan))
            {
                MessageBox.Show(pesan, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadInventoryData(); // Refresh tampilan
            }
            else
            {
                MessageBox.Show(pesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Bersihkan TextBox
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
                // Ambil ID dari datagrid
                string id = tabellistbrg.CurrentRow.Cells[0].Value.ToString();

                InventoryModel barang = new InventoryModel
                {
                    Id = id,
                    Kode = textboxkodebrg.Text.Trim(),
                    Nama = textboxnamabrg.Text.Trim(),
                    Kondisi = textboxkondisi.Text.Trim(),
                    Jumlah = textboxjml.Text.Trim(),
                    Satuan = textboxstn.Text.Trim()
                };

                // Validasi sederhana
                if (string.IsNullOrWhiteSpace(barang.Kode) || string.IsNullOrWhiteSpace(barang.Nama))
                {
                    MessageBox.Show("Kode dan Nama Barang wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (controller.UpdateBarang(barang, out string pesan))
                {
                    MessageBox.Show(pesan, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInventoryData(); // Refresh tampilan
                }
                else
                {
                    MessageBox.Show(pesan, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Pilih baris yang ingin diedit terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabellistbrg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tabellistbrg.Rows[e.RowIndex];
                textboxkodebrg.Text = row.Cells[1].Value.ToString();
                textboxnamabrg.Text = row.Cells[2].Value.ToString();
                textboxkondisi.Text = row.Cells[3].Value.ToString();
                textboxjml.Text = row.Cells[4].Value.ToString();
                textboxstn.Text = row.Cells[5].Value.ToString();
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
                    // Ambil ID dari datagrid
                    string id = tabellistbrg.SelectedRows[0].Cells[0].Value.ToString();

                    if (controller.HapusBarang(id, out string pesan))
                    {
                        MessageBox.Show(pesan, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadInventoryData(); // Refresh tampilan
                    }
                    else
                    {
                        MessageBox.Show(pesan, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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

        private void LoadInventoryData()
        {
            string error;
            List<InventoryModel> data = controller.GetAllInventori(out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tabellistbrg.Rows.Clear();

            foreach (var item in data)
            {
                tabellistbrg.Rows.Add(item.Id, item.Kode, item.Nama, item.Kondisi, item.Jumlah, item.Satuan);
            }
        }

    }

}
