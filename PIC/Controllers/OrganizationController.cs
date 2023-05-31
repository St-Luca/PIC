using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    class OrganizationController
    {
        public static bool CanAddOrganization(int userPermissionCode)
        { //смотрим на код юзера, т.е. его права в системе.
            return true;
        }

        public static void AddOrganization(Organization organization)
        {
            //connection with db and parsing fields
        }

        public void DeleteOrganization(Organization organization)
        {

        }

        public void ChangeOrganization(Organization organization)
        {

        }
    }
}
