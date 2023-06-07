using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    internal class CaptureController
    {
        public static bool CanMakeCapture(int userPermissionCode)
        { //смотрим на код юзера, т.е. его права в системе.
            return true;
        }

        public static bool IsCaptureCorrect(CaptureApplication capture)
        {
            return true;
        }

        public static void AddCapture(CaptureApplication capture)
        {
            //connection with db and parsing fields
        }

        public void DeleteCapture(CaptureApplication delCapture)
        {

        }

        public void ChangeCapture(CaptureApplication changeCapture, CapturedAnimalCard captAnimal)
        {

        }

        public static void AddCapturedAnimal(CapturedAnimalCard captAnimal)
        {

        }
    }
}
