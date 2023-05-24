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
    }
}
