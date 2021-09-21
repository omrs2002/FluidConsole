using FluidConsoleApp.Entities;
using System.Collections.Generic;

namespace FluidConsoleApp
{
    public class FullTemplate
    {

        public Lookups Lookups { get; set; }
        public SbcEstablishmentSummaryResponseModel Est { get; set; }

        public static FullTemplate GetFilledInstance()
        {
            FullTemplate Est = new()
            {

                Lookups = new Lookups
                {
                    BusinessTypeCode = "BusinessTypeCode",
                    BusinessArabicName = "BusinessArabicName",
                    RelationTypeOwnerCode = "1"
                },
                Est = new SbcEstablishmentSummaryResponseModel
                {
                    CRNo = "2345234524",
                    CRName = "CR Name",
                    CrInformation = new CrInformation
                    {
                        IsMain = true,
                        CrInfoMainCRNationalNumber = 12341234,
                        CrInfoCapital = 999,
                        CrInfoChamberCode = 55,
                        CrInfoChamberName = "Info Chamber Name",
                        CrInfoDuration = 2

                    },
                    
                    OwnerInformation = new OwnerInformation
                    {
                        OwnerFullNameArabic = "Owner Full Name",
                        OwnerBirthDate = System.DateTime.Today.AddYears(-38),
                        OwnerNationalityId = "b01a0d5b-8d0f-491e-84de-95acf4890c46",                        
                        OwnerNationalId = "1223454321"
                    }
                    ,
                    ManagerInformation = new ManagerInformation
                    {
                        ManagerInfoMobileNo = "00966541901636",
                        ManagerInfoEmail = "omrs2002@yahoo.com",
                        ManagerInfoBirthDate = System.DateTime.Today.AddYears(-38),
                        ManagerInfoNationalityId = System.Guid.Parse("b01a0d5b-8d0f-491e-84de-95acf4890c46"),
                        ManagerInfoNameAr = "Manager Name",
                        ManagerInfoIdentityNo = 1244565432
                    },
                    TradeNameInformation = new TradeNameInformation
                    {

                        TradeNamePrefixName = "Cofee",
                        TradeNameMidTradeName = "Company",
                        TradeNameSuffixName = "Limited"
                    },
                    PaymentInformation = new PaymentInformation
                    {
                        PaymentDate = System.DateTime.Today
                    },
                    RequestActivityInformation = new List<RequestActivityInformation>
                    {
                        new RequestActivityInformation{ RequestActivityISICCode = "14332765", RequestActivityArabicName = "RequestActivityArabicName1"},
                        new RequestActivityInformation{ RequestActivityISICCode = "25467567",RequestActivityArabicName = "RequestActivityArabicName2"},
                        new RequestActivityInformation{ RequestActivityISICCode = "31223444",RequestActivityArabicName = "RequestActivityArabicName3"},

                    },
                    CRActivities = new List<CRActivity<string>>
                    {
                        new CRActivity<string>(){Id = 1, Name ="CRActivity 1"},
                        new CRActivity<string>(){Id = 2, Name ="CRActivity 2"},
                        new CRActivity<string>(){Id = 3, Name ="CRActivity 3"}
                    }


                }
            };

            return Est;
        }

    }
}
