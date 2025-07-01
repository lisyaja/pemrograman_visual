using AppInventory.Model;
using System;
using System.Windows.Forms;

namespace AppInventory.Controller
{
    public class LoginController
    {
        private UsersModel userModel;

        public LoginController()
        {
            userModel = new UsersModel();
        }

        public void Login(string username, string password, Form loginForm)
        {
            try
            {
                if (userModel.ValidateUser(username, password))
                {
                    loginForm.Hide();
                    Inventory formInventory = new Inventory();
                    formInventory.FormClosed += (s, args) => loginForm.Close();
                    formInventory.Show();
                }
                else
                {
                    MessageBox.Show("Username atau password salah!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
