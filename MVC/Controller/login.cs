using AppInventory.Models;

namespace AppInventory.Controllers
{
    public class LoginController
    {
        public bool Login(User user)
        {
            // Validasi sederhana
            return user.Username == "admin" && user.Password == "1234";
        }
    }
}
