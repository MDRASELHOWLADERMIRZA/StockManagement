using StockManagementSystem.Models;
using StockManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.BLL
{
    class CompanyManager
    {
        CompanyRepository _companyRepository = new CompanyRepository();
        public string InsertCompany(Company company)
        {
            string message;

            int countCompanyName = _companyRepository.CountCompany(company);
            if (countCompanyName>0)
            {
                return message = "This Company Already Added !!";
            }
            else
            {
                _companyRepository.Insert(company);
                return message = "Saved";
            }
        }

        public DataTable GetCompanies()
        {
            return _companyRepository.GetCompanies();
        }
    }
}
