using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    internal class AuthController
    {
        public int PasswordHash;
        public int GetHash(string password)
        {
            PasswordHash = 3 * password.GetHashCode() + 42;
            return PasswordHash;
        }

        public string GetUserData()
        {

        }
    }
}
