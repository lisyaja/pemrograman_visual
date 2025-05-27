using System;
using System.Windows.Forms;
using AppInventory.Controllers;
using AppInventory.Models;

namespace AppInventory.Views
{
    public partial class LoginForm : Form
    {
        private LoginController controller = new LoginController();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Username = textboxusename.Text,
                Password = textboxpassword.Text
            };

            if (controller.Login(user))
            {
                this.Hide();
                InventoryForm formInventory = new InventoryForm();
                formInventory.FormClosed += (s, args) => this.Close();
                formInventory.Show();
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
