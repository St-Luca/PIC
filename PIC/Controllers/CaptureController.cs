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

        public static void AddCapture(CapturedAnimalCard captAnimal)
        {
            //connection with db and parsing fields
        }

        public void DeleteCapture(Capture delCapture)
        {

        }

        public void ChangeCapture(Capture changeCapture, CapturedAnimalCard captAnimal)
        {

        }

        private bool IsDataCorrect(CapturedAnimalCard capturedAnimal)
        {
            return true;
        }


        private bool IsDataCorrect(Capture capture)
        {

        }
        public static void AddCapturedAnimal(CapturedAnimalCard captAnimal)
        {

        }
    }
}
