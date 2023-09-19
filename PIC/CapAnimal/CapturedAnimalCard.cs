using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PIC
{
    internal class CapturedAnimalCard
    {
        int Id { get; set; }
        Animal Animal { get; set; }
        Locality Locality { get; set; }
        CaptureApplication Capture { get; set; }

        public void CapturedAnimalRegister(int id, Animal animal, Locality locality, CaptureApplication capture)
        {
            Id = id;
            Animal = animal;
            Locality = locality;
            Capture = capture;
        }
    }
}
