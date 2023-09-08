using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PIC
{
    internal class Animal
    {
        int Id;
        List<string> Parameters { get; set; }
        string Color { get; set; }
        string Ears { get; set; }
        string Tail { get; set; }
        string SpecialSigns { get; set; }
        int IdTag { get; set; }
        int IdChip { get; set; }
        

        public Animal(int id, List<string> parameters, string coloring, string ears, string tail, string specialSigns, int idTag, int chipNumber)
        {
            Id = id;
            Parameters = parameters;
            Color = coloring;
            Ears = ears;
            Tail = tail;
            SpecialSigns = specialSigns;
            IdTag = idTag;
            IdChip = chipNumber;
        }

        public List<string> GetDescription()
        {
            //скомпоновать свойства в список и передать catchingApplication
            return new List<string>();
        }
    }
}
