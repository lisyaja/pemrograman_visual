using System;
using System.Windows.Forms;
using AppInventory.Models;
using AppInventory.Controllers;
using System.Linq;

namespace AppInventory.Views
{
    public partial class InventoryForm : Form
    {
        private InventoryController controller = new InventoryController();

        public InventoryForm()
        {
            InitializeComponent();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            tabellistbrg.ColumnCount = 5;
            tabellistbrg.Columns[0].Name = "Kode Barang";
            tabellistbrg.Columns[1].Name = "Nama Barang";
            tabellistbrg.Columns[2].Name = "Kondisi";
            tabellistbrg.Columns[3].Name = "Jumlah";
            tabellistbrg.Columns[4].Name = "Satuan";

            tabellistbrg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            var barang = new Barang
            {
                Kode = textboxkodebrg.Text,
                Nama = textboxnamabrg.Text,
                Kondisi = textboxkondisi.Text,
                Jumlah = textboxjml.Text,
                Satuan = textboxstn.Text
            };

            controller.Add(barang);
            TampilkanBarang();
            BersihkanInput();
        }

        private void tabellistbrg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = tabellistbrg.Rows[e.RowIndex];
                textboxkodebrg.Text = row.Cells[0].Value?.ToString();
                textboxnamabrg.Text = row.Cells[1].Value?.ToString();
                textboxkondisi.Text = row.Cells[2].Value?.ToString();
                textboxjml.Text = row.Cells[3].Value?.ToString();
                textboxstn.Text = row.Cells[4].Value?.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = tabellistbrg.CurrentRow?.Index ?? -1;

            if (index >= 0)
            {
                var barang = new Barang
                {
                    Kode = textboxkodebrg.Text,
                    Nama = textboxnamabrg.Text,
                    Kondisi = textboxkondisi.Text,
                    Jumlah = textboxjml.Text,
                    Satuan = textboxstn.Text
                };

                controller.Update(index, barang);
                TampilkanBarang();
                MessageBox.Show("Data berhasil diupdate.");
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            int index = tabellistbrg.CurrentRow?.Index ?? -1;

            if (index >= 0)
            {
                DialogResult result = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    controller.Delete(index);
                    TampilkanBarang();
                }
            }
        }

        private void TampilkanBarang()
        {
            tabellistbrg.Rows.Clear();
            foreach (var b in controller.GetAll())
            {
                tabellistbrg.Rows.Add(b.Kode, b.Nama, b.Kondisi, b.Jumlah, b.Satuan);
            }
        }

        private void BersihkanInput()
        {
            textboxkodebrg.Clear();
            textboxnamabrg.Clear();
            textboxkondisi.Clear();
            textboxjml.Clear();
            textboxstn.Clear();
            textboxkodebrg.Focus();
        }
    }
}
