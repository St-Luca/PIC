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
        List<Locality> Localities { get; set; }
        int CountOfCatApp { get; set; }
        int CountOfAnimal { get; set; }
        double FinalSum { get; set; }

        internal ReportMaker(DateTime start, DateTime end, List<Locality> locality)
        {
            Start = start;
            End = end;
            Localities = locality;
        }

        internal void MakeReport(DateTime start, DateTime end, Locality locality, string filepath)
        {
            //drop to excel
        }
    }
}
