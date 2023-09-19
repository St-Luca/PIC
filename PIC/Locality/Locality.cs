using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    public class Locality
    {
        int Id { get; set; }
        internal string Region { get; set; }
        internal string City { get; set; }

        public Locality(int id, string region, string city) 
        {
            Id = id;
            Region = region;
            City = city;
        }
    }
}
