using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    internal class AuthDBAdapter
    {
        internal Dictionary<string, string> userData { get; set; }
        public AuthDBAdapter(string login, int passwordHash) 
        {
            userData = new Dictionary<string, string>();  //     
        }

        public AuthDBAdapter(string login, string passwordHash)
        {

        }

        public static bool CheckUserInDb(string login, int passwordHash)
        {//связь с бд
            return true;
        }

        public Dictionary<string, string> GetUserData(string login, int passwordHash)
        {
            return userData;
        }
    }
}
