using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIC
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private User Authorize(string login, string password)
        {
            AuthController authController = new AuthController();
            int passwordHash = authController.GetHash(password);
            Dictionary<string, string> userData = authController.GetUserData(login, passwordHash);
            // if (passwordHash == 0 ) { } проверка словаря на налл, т е нет такого юзера
            User user = authController.CreateUser(userData);

            return user; 
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            User appUser = Authorize(login, password);

            CatchingApplicationRegisterForm form1 = new CatchingApplicationRegisterForm(appUser);
            form1.ShowDialog();
        }
    }
}
