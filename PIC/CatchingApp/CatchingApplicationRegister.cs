using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    internal class CatchingApplicationRegister
    {
        int Id;
        List<CatchingApplication> applications;

        public List<CatchingApplication> GetUserFilter(User user)
        { //какая то проверка на права юзера и проход по карточкам. Как то привязать к органищациям и ролям
            if(PermissionController.IsPermitted(user))
            {
                return applications;
            }
            else return applications;
        }

        public static List<CatchingApplication> GetFinalFilter(List<CatchingApplication> f1, List<CatchingApplication> f2)
        {
            return f1.Concat(f2).ToList(); //Финальный список заявок, который увидит пользователь
        }

        public List<CatchingApplication> LoadCatchingApplicationRegister(Dictionary<string, string> filter, Dictionary<string, string> sort)
        {
            //parsing sort and filter dictionaries to cat app fields?
            applications = applications.Where(c => c.RegistrationDate < new DateTime(23-10-2023)).OrderBy(c => c.Id).ToList();
            return applications;
        }

        public List<CatchingApplication> LoadCatchingApplicationRegister(List<CatchingApplication> finalFilter, Dictionary<string, string> sort)
        {
            //parsing sort dictionary to cat app fields?
            applications = finalFilter.OrderBy(c => c.Id).ToList();
            return applications;
        }

        public void AddCatchingApplication(CatchingApplication ca)
        {
            applications.Add(ca);
        }

        public void DeleteCatchingApplication(CatchingApplication ca)
        {
            applications.RemoveAll(x => x.Id == ca.Id);
        }

        public void ChangeCatchingApplication(CatchingApplication ca)
        {

        }

        public void GetCaptureInfo(DateTime start, DateTime end, Locality city)
        {

        }
    }
}
