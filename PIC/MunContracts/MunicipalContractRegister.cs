using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    internal class MunicipalContractRegister
    {
        int Id;
        List<MunicipalContract> contracts;

        public List<MunicipalContract> GetUserFilter(User user)
        { //какая то проверка на права юзера и проход по карточкам. Как то привязать к органищациям и ролям
            if (PermissionController.IsPermitted(user))
            {
                return contracts;
            }
            else return contracts;
        }

        public static List<MunicipalContract> GetFinalFilter(List<MunicipalContract> f1, List<MunicipalContract> f2)
        {
            return f1.Concat(f2).ToList(); //Финальный список заявок, который увидит пользователь
        }

        public List<MunicipalContract> LoadMunicipalContractRegister(Dictionary<string, string> filter, Dictionary<string, string> sort)
        {
            //parsing sort and filter dictionaries to cat app fields?
            contracts = contracts.Where(c => c.ConclusionDate < new DateTime(23 - 10 - 2023)).OrderBy(c => c.Id).ToList();
            return contracts;
        }

        public List<MunicipalContract> LoadMunicipalContractRegister(List<MunicipalContract> finalFilter, Dictionary<string, string> sort)
        {
            //parsing sort dictionary to cat app fields?
            contracts = finalFilter.OrderBy(c => c.Id).ToList();
            return contracts;
        }

        public void DeleteMunicipalContract(MunicipalContract mc)
        {

        }

        public void ChangeMunicipalContract(MunicipalContract mc)
        {

        }

        public void GetCountOfClosedContracts(DateTime start, DateTime end, Locality city)
        {

        }
    }
}
