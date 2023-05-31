using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PIC
{
    internal class CaptureRegister
    {
        int Id;
        List<Capture> captures;

        public List<Capture> GetUserFilter(User user)
        { //какая то проверка на права юзера и проход по карточкам. Как то привязать к органищациям и ролям
            if (PermissionController.IsPermitted(user))
            {
                return captures;
            }
            else return captures;
        }

        public static List<Capture> GetFinalFilter(List<Capture> f1, List<Capture> f2)
        {
            return f1.Concat(f2).ToList(); //Финальный список заявок, который увидит пользователь
        }

        public List<Capture> LoadCaptureRegister(Dictionary<string, string> filter, Dictionary<string, string> sort)
        {
            //parsing sort and filter dictionaries to cat app fields?
            captures = captures.Where(c => c.CaptureDate < new DateTime(23 - 10 - 2023)).OrderBy(c => c.Id).ToList();
            return captures;
        }

        public List<Capture> LoadCapureRegister(List<Capture> finalFilter, Dictionary<string, string> sort)
        {
            //parsing sort dictionary to cat app fields?
            captures = finalFilter.OrderBy(c => c.Id).ToList();
            return captures;
        }
    }
}
