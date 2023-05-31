using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    internal class Organization
    {
        internal int Id { get; set; }
        internal string OrgName { get; set; }
        string INN { get; set; }
        string KPP { get; set; }
        string OrgAddress { get; set; }
        string OrgType { get; set; }
        string OrgAttribute { get; set; }

        public Organization(int id, string orgName, string iNN, string kPP, string orgAddress, string orgType, string orgAttribute)
        {
            if (IsDataCorrect(id, orgName, iNN, kPP, orgAddress, orgType, orgAttribute))
            {
                Id = id;
                OrgName = orgName;
                INN = iNN;
                KPP = kPP;
                OrgAddress = orgAddress;
                OrgType = orgType;
                OrgAttribute = orgAttribute;
            }
        }

        private bool IsDataCorrect(int id, string orgName, string iNN, string kPP, string orgAddress, string orgType, string orgAttribute)
        {
            return true;
        }
    }
}
