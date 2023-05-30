using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    internal class CatchingApplicationController
    {

        public static bool CanAddCatchingApplication(int userPermissionCode)
        { //смотрим на код юзера, т.е. его права в системе.
            return true;
        }

        public void AddCatchingApplication(CatchingApplication ca)
        {
            //connection with db and parsing fields
        }
    }
}
