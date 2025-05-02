using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppInventory
{
    public partial class Form1 : Form
    {
        string connStr = "server=localhost;user=root;database=db_inventory;password=;";
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection(connStr);
        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = textboxusename.Text;
            string password = textboxpassword.Text;

            // Contoh logika login sederhana
            if (username == "admin" && password == "1234")
            {
                this.Hide(); // Sembunyikan form login
                Inventory FormInventory = new Inventory();
                FormInventory.FormClosed += (s, args) => this.Close(); // Tutup login jika main form ditutup
                FormInventory.Show();
            }
            else
            {
                MessageBox.Show("Username atau password salah!");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            textboxusename.Clear();
            textboxpassword.Clear();
        }

    }
}
