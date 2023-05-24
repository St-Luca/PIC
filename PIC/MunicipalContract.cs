using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    internal class MunicipalContractForm
    {
        int Number { get; set; }
        DateTime ConclusionDate { get; set; }
        DateTime EffectiveDate { get; set; }
        Organization Performer { get; set; }
        Organization Customer { get; set; }

        List<string> contracts;

        public MunicipalContractForm(int number, DateTime start, DateTime end, Organization performer, Organization customer)
        {
            if (IsDataCorrect(number, start, end, performer, customer))
            {
                Number = number;
                ConclusionDate = start;
                EffectiveDate = end;
                Performer = performer;
                Customer = customer;
                contracts = new List<string>();
            }
        }

        private bool IsDataCorrect(int number, DateTime start, DateTime end, Organization performer, Organization customer)
        {
            return true;
        }
    }
}
