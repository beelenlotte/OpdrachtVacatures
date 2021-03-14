using AutoMapper;
using OpdrachtVacatures.DTO;
using OpdrachtVacatures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpdrachtVacatures.profiles
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<CompanyDTO, Company>();
        }
        
    }
}
