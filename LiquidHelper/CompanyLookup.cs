using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquidHelper
{
    public class PaymentInformation
    {
        public string RecieptNumber { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string BankId { get; set; }
        public string BankNumber { get; set; }
    }

    public class CompanyLookup
    {
        public BaladyCrLookup BaladyLookups { get; set; }
        public LookupsForCompany GosiLookups { get; set; }
        public LookupsForCompany GaztLookups { get; set; }
        public HRSDLookupsForCompany HrsdLookups { get; set; }
    }

    public class LookupsForCompany
    {
        public List<LookupBase> ManagersNationalities { get; set; }
        public List<LookupBase> OwnerNationalities { get; set; }
    }



    public class HRSDLookupsForCompany
    {
        public List<LookupBase> ManagersNationalities { get; set; }
        public List<LookupBase> OwnerNationalities { get; set; }
        public LookupBase LaborOffice { get; set; }
    }
    public class LookupBase
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class BaladyCrLookup
    {
        public string SubmitterNationalityId { get; set; }
        public string SubmitterIdentityTypeId { get; set; }
        public List<LicenseLookup> LicenseLookups { get; set; }

    }
    public class LicenseLookup
    {
        public LicenseUnitType LicenseUnitType { get; set; }
    }
    public class LicenseUnitType
    {
        public Guid LicenseId { get; set; }
        public string UnitType { get; set; }
    }

    public class test
    {
        test()
        {
            CompanyLookup lo = new CompanyLookup();
            
            
        }
    }

}
