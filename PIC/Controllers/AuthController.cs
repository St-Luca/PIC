using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    internal class AuthController
    {
        public int GetHash(string password)
        {
            return 3 * password.GetHashCode() + 42;
        }

        public Dictionary<string, string> GetUserData(string login, int passwordHash)
        {
            AuthDBAdapter authDBAdapter = new AuthDBAdapter(login, passwordHash);

            return authDBAdapter.GetUserData(login, passwordHash); //null ot not null
        }

        public User CreateUser(Dictionary<string, string> data)
        {
            return new User(data);
        }
    }
}
