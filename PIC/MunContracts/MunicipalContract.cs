using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    internal class MunicipalContract
    {
        internal int Number { get; set; }
        internal DateTime ConclusionDate { get; set; }
        DateTime EffectiveDate { get; set; }
        Organization Performer { get; set; }
        Organization Customer { get; set; }

        public MunicipalContract() { } //потом удалить, нужен для первичной инфраструктуры
        public MunicipalContract(int number, DateTime start, DateTime end, Organization performer, Organization customer)
        {
            if (IsDataCorrect(number, start, end, performer, customer))
            {
                Number = number;
                ConclusionDate = start;
                EffectiveDate = end;
                Performer = performer;
                Customer = customer;
            }
        }

        private bool IsDataCorrect(int number, DateTime start, DateTime end, Organization performer, Organization customer)
        {
            return true;
        }
    }
}
