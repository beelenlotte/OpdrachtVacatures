using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpdrachtVacatures.DTO;
using OpdrachtVacatures.Interfaces;
using OpdrachtVacatures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpdrachtVacatures.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService, IMapper mapper)
        {
            _companyService = companyService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<Company> GetCompany(int companyId)
        {
            var company = _companyService.GetCompany(companyId);
            return company;
        }

        [HttpPost]
        public ActionResult CreateCompany(CompanyDTO newCompany)
        {
            Company company = _mapper.Map<Company>(newCompany);
            //var companyToInsertInDb = new Company();
            //companyToInsertInDb.Name = newCompany.Name;
            //companyToInsertInDb.Street = newCompany.Street;
            //companyToInsertInDb.HouseNumber = newCompany.HouseNumber;
            //companyToInsertInDb.Postalcode = newCompany.Postalcode;
            //companyToInsertInDb.Area = newCompany.Area;
            _companyService.CreateCompany(company);
            return Ok();
        }

    }
}
