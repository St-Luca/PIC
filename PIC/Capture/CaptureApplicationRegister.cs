using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PIC
{
    internal class CaptureApplicationRegister
    {
        int Id;
        List<CaptureApplication> captures;

        public List<CaptureApplication> GetUserFilter(User user)
        { //какая то проверка на права юзера и проход по карточкам. Как то привязать к органищациям и ролям
            if (PermissionController.IsPermitted(user))
            {
                return captures;
            }
            else return captures;
        }

        public static List<CaptureApplication> GetFinalFilter(List<CaptureApplication> f1, List<CaptureApplication> f2)
        {
            return f1.Concat(f2).ToList(); //Финальный список заявок, который увидит пользователь
        }

        public List<CaptureApplication> LoadCaptureRegister(Dictionary<string, string> filter, Dictionary<string, string> sort)
        {
            //parsing sort and filter dictionaries to cat app fields?
            captures = captures.Where(c => c.CaptureDate < new DateTime(23 - 10 - 2023)).OrderBy(c => c.Id).ToList();
            return captures;
        }

        public List<CaptureApplication> LoadCaptureRegister(List<CaptureApplication> finalFilter, Dictionary<string, string> sort)
        {
            //parsing sort dictionary to cat app fields?
            captures = finalFilter.OrderBy(c => c.Id).ToList();
            return captures;
        }

        public static void AddCapturedAnimal(CapturedAnimalCard captAnimal)
        {

        }

        public void DeleteCapture(CaptureApplication delCapture)
        {

        }

        public void ChangeCapture(CaptureApplication changeCapture, CapturedAnimalCard captAnimal)
        {

        }
    }
}
