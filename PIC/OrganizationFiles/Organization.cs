using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    public class Organization
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
            Id = id;
            OrgName = orgName;
            INN = iNN;
            KPP = kPP;
            OrgAddress = orgAddress;
            OrgType = orgType;
            OrgAttribute = orgAttribute;
        }
    }
}
