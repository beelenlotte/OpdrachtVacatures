using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpdrachtVacatures.DTO
{
    public class CompanyDTO
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string Postalcode { get; set; }
        public string Area { get; set; }
    }
}
