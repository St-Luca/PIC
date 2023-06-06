using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    internal class CapturedAnimalCard
    {
        int Id { get; set; }
        List<string> Parameters { get; set; }
        string Coloring { get; set; }
        string Ears { get; set; }
        string Tail { get; set; }
        string SpecialSigns { get; set; }
        int IdTag { get; set; }
        int ChipNumber { get; set; }
        Locality Locality { get; set; }
        int CaptureId { get; set; }

        public void CapturedAnimalRegister(int id, List<string> parameters, string coloring, string ears, string tail, string specialSigns, int idTag, int chipNumber, Locality locality, int captureId)
        {
            Id = id;
            Parameters = parameters;
            Coloring = coloring;
            Ears = ears;
            Tail = tail;
            SpecialSigns = specialSigns;
            IdTag = idTag;
            ChipNumber = chipNumber;
            Locality = locality;
            CaptureId = captureId;            
        }
    }
}
