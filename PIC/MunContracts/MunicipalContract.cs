using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    internal class MunicipalContract
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
        public MunicipalContract(int number, DateTime start, DateTime end, Organization performer, Organization customer, double price)
        {

            Id = number;
            ConclusionDate = start;
            EffectiveDate = end;
            Performer = performer;
            Customer = customer;
            PriceForAnimal = price; //logic with coeffs for true price

        }
    }
}
