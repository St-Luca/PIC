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
        public int Number { get; set;}
        public int CountOfDogs { get; set;}
        public int CountOfCats { get; set; }
        public int General { get; set; }
        public Organization Organization { get; set; }
        public DateTime CaptureDate {get; set;}
        public string Target {get; set;}
        public CatchingApplication CatApp { get; set;}
        public MunicipalContract Contract { get; set;}

        public CaptureApplication() { }

        public CaptureApplication(int id, int number, int countOfDogs, int countOfCats, int general, Organization organization, DateTime captureDate, string target, CatchingApplication catApp, MunicipalContract contract)
        {
            if (IsDataCorrect(id, number, countOfDogs, countOfCats, general, organization, captureDate, target, catApp, contract))
            {
                Number = number;
                CountOfDogs = countOfDogs;
                CountOfCats = countOfCats;
                General = general;
                Organization = organization;
                CaptureDate = captureDate;
                Target = target;
                CatApp = catApp;
                Contract = contract;
            }
        }

        private bool IsDataCorrect(int id, int number, int countOfDogs, int countOfCats, int general, Organization organization, DateTime captureDate, string target, CatchingApplication catApp, MunicipalContract contract)
        {
            return true;
        }
    }
}
