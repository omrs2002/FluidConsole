using FluidConsoleApp.Entities;

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
                    BusinessArabicName = "BusinessArabicName"
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
                    TradeNameInformation= new TradeNameInformation{
                         
                        TradeNamePrefixName  = "Cofee",
                        TradeNameMidTradeName = "Company",
                        TradeNameSuffixName = "Limited"
                    },
                    PaymentInformation = new PaymentInformation
                    {
                        PaymentDate = System.DateTime.Today
                    }

                }
            };

            return Est;
        }

    }
}
