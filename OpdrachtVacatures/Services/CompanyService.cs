using OpdrachtVacatures.Db;
using OpdrachtVacatures.Interfaces;
using OpdrachtVacatures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpdrachtVacatures.Services
{
    public class CompanyService : ICompanyService
    {
        public Company GetCompany(int companyId)
        {
            using var db = new JobsContext();
            var company = db.Companies.FirstOrDefault(x => x.Id == companyId);
            return company;
        }
        public void CreateCompany(Company newCompany)
        {
            using var db = new JobsContext();
            db.Add(newCompany);
            db.SaveChanges();
        }
    }
}
