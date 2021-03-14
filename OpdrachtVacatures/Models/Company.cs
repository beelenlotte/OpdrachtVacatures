using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpdrachtVacatures.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string Postalcode { get; set; }
        public string Area { get; set; }
        public int JobId { get; set; } //
        public List<Jobs> Jobs { get; set; } // 
    }
}
