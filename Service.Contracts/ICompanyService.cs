using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Contracts
{
    public interface ICompanyService
    {
        IEnumerable<CompanyDto> GetAllCompanies(bool trackChanges);
    }
}
