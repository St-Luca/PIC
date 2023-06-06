using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    internal class MunicipalContractController
    {

        public static bool CanAddMunicipalContract(int userPermissionCode)
        { //смотрим на код юзера, т.е. его права в системе.
            return true;
        }

        public static bool IsMunContractCorrect(MunicipalContract mc)
        {
            return true;
        }

        public static void AddMunicipalContract(MunicipalContract mc)
        {
            //connection with db and parsing fields

        }

        public void DeleteMunicipalContract(MunicipalContract mc)
        {

        }

        public void ChangeMunicipalContract(MunicipalContract mc)
        {

        }
    }
}
