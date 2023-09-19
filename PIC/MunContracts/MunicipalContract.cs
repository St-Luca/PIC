using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    public class MunicipalContract
    {
        internal int Id { get; set; }
        internal DateTime ConclusionDate { get; set; }
        DateTime EffectiveDate { get; set; }
        Organization Performer { get; set; }
        Organization Customer { get; set; }
        List<Locality> Localities { get; set; }
        double PriceForAnimal { get; set; }

        double[] CoeffsForAnimal = new double[] { 0.5, 1, 2 };

        public MunicipalContract() { } //потом удалить, нужен для первичной инфраструктуры
        public MunicipalContract(int number, DateTime start, DateTime end, Organization performer, Organization customer, List<Locality> localities, double price)
        {

            Id = number;
            ConclusionDate = start;
            EffectiveDate = end;
            Performer = performer;
            Customer = customer;
            Localities = localities;
            PriceForAnimal = price; //logic with coeffs for true price

        }

        public string[] GetStringData()
        {
            string[] result = new string[7];
            result[0] = Id.ToString();
            result[1] = ConclusionDate.ToString();
            result[2] = EffectiveDate.ToString();
            result[3] = Performer.ToString();
            result[4] = Customer.ToString();
            result[5] = "loc"; //////////todo: parse list locality to string
            return result;
        }
    }
}
