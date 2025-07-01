using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AppInventory;
using AppInventory.Controller;


namespace AppInventory
{
    public partial class Form1 : Form
    {
        private LoginController loginController;

        public Form1()
        {
            InitializeComponent();
            //conn = new MySqlConnection(connStr);
            loginController = new LoginController();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = textboxusename.Text;
            string password = textboxpassword.Text;
            loginController.Login(username, password, this);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            textboxusename.Clear();
            textboxpassword.Clear();
        }

    }
}
