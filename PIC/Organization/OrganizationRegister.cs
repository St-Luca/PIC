using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    internal class OrganizationRegister
    {
        int Id;
        List<Organization> organizations;

        public List<Organization> GetUserFilter(User user)
        { //какая то проверка на права юзера и проход по карточкам. Как то привязать к органищациям и ролям
            if (PermissionController.IsPermitted(user))
            {
                return organizations;
            }
            else return organizations;
        }

        public static List<Organization> GetFinalFilter(List<Organization> f1, List<Organization> f2)
        {
            return f1.Concat(f2).ToList(); //Финальный список заявок, который увидит пользователь
        }

        public List<Organization> LoadOrganizationRegister(Dictionary<string, string> filter, Dictionary<string, string> sort)
        {
            //parsing sort and filter dictionaries to cat app fields?
            organizations = organizations.Where(c => c.Id < 10).OrderBy(c => c.OrgName).ToList();
            return organizations;
        }

        public List<Organization> LoadOrganizationRegister(List<Organization> finalFilter, Dictionary<string, string> sort)
        {
            //parsing sort dictionary to cat app fields?
            organizations = finalFilter.OrderBy(c => c.Id).ToList();
            return organizations;
        }
    }
}
