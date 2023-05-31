using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIC.CapAnimal;

namespace PIC
{
    class CapturedAnimalCardController
    {
        public static bool CanAddCapturedAnimal(int userPermissionCode)
        { //смотрим на код юзера, т.е. его права в системе.
            return true;
        }

        public void AddCapturedAnimal(CapturedAnimalCard captAnimal)
        {
            //connection with db and parsing fields
        }
    }
}
