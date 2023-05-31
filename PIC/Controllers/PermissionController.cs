using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    internal class PermissionController
    {

        public static void GivePermissions(User user)/////////
        {//connection to db ?
            user.PermissionCode = 0;
        }

        public static bool IsPermitted(User user)
        {
            return user.PermissionCode==1 || user.PermissionCode ==2;
        }
    }
}
