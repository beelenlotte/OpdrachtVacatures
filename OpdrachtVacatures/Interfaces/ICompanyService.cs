using OpdrachtVacatures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpdrachtVacatures.Interfaces
{
    public interface ICompanyService
    {
        Company GetCompany(int companyId);
        void CreateCompany(Company newCompany);
    }
}
