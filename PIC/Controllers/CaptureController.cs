using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIC.CapAnimal;

namespace PIC
{
    internal class CaptureController
    {
        public static bool CanMakeCapture(int userPermissionCode)
        { //смотрим на код юзера, т.е. его права в системе.
            return true;
        }

        public void AddCapture(CapturedAnimalCard captAnimal)
        {
            //connection with db and parsing fields
        }

        public void DeleteCapture()
        {

        }

        public void ChangeCapture()
        {

        }
    }
}
