using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    internal class ReportMaker
    {
        DateTime Start { get; set; }
        DateTime End { get; set; }
        Locality Locality { get; set; }

        internal ReportMaker(DateTime start, DateTime end, Locality locality)
        {
            Start = start;
            End = end;
            Locality = locality;
        }

        internal void MakeReport(DateTime start, DateTime end, Locality locality, string filepath)
        {
            //drop to excel
        }
    }
}
