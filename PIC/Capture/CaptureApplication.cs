using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    internal class CaptureApplication
    {
        public int Id { get; set;}
        public int CountOfDogs { get; set;}
        public int CountOfCats { get; set; }
        public int General { get; set; }
        public Organization Performer { get; set; }
        public DateTime CaptureDate {get; set;}
        public string Target {get; set;}
        public CatchingApplication CatApp { get; set;}
        public MunicipalContract Contract { get; set;}

        public CaptureApplication() { }

        public CaptureApplication(int id, int number, int countOfDogs, int countOfCats, Organization organization, DateTime captureDate, 
            string target, CatchingApplication catApp, MunicipalContract contract)
        {
            if (IsDataCorrect(id, countOfDogs, countOfCats, organization, captureDate, target, catApp, contract))
            {
                Id = id;
                CountOfDogs = countOfDogs;
                CountOfCats = countOfCats;
                General = countOfCats+countOfDogs;
                Performer = organization;
                CaptureDate = captureDate;
                Target = target;
                CatApp = catApp;
                Contract = contract;
            }
        }

        private bool IsDataCorrect(int id, int countOfDogs, int countOfCats, Organization organization, DateTime captureDate, string target, CatchingApplication catApp, MunicipalContract contract)
        {
            return true;
        }
    }
}
