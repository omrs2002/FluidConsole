using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluidConsoleApp.Entities.NIC
{
    public class SbcEstablishmentSummaryResponseModel
    {
        public int Id { get; set; }
        public Guid? BusinessTypeId { get; set; }
        public Guid RequestId { get; set; }
        public string RequestReference { get; set; }
        public PaymentInformation PaymentInformation { get; set; }
        public ApplicantInformation ApplicantInformation { get; set; }
        public OwnerInformation OwnerInformation { get; set; }
        public ManagerInformation ManagerInformation { get; set; }
        public AddressInformation AddressInformation { get; set; }
        public ContactInformation ContactInformation { get; set; }
        public CrInformation CrInformation { get; set; }
        public FiscalYearInformation FiscalYearInformation { get; set; }
        public TradeNameInformation TradeNameInformation { get; set; }
        public SaudiPostInformation SaudiPostInformation { get; set; }
        public List<RequestActivityInformation> RequestActivityInformation { get; set; }

    }
    #region Establishment Sub Summary Models
    public class SaudiPostInformation
    {
        public DateTime? StartDateGregorian { get; set; }
        public DateTime? EndDateGregorian { get; set; }
        public decimal InvoiceAmount { get; set; }
        public decimal SettlementAmount { get; set; }
        public int SubscriptionDurationDays { get; set; }
    }
    public class PaymentInformation
    {
        public string RecieptNumber { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string BankId { get; set; }
        public string BankNumber { get; set; }
    }
    public class ApplicantInformation
    {
        public string ApplicantTypeId { get; set; }
        public string ApplicantTypeArabic { get; set; }
        public string ApplicantTypeEnglish { get; set; }
    }
    public class OwnerInformation
    {
        public string OwnerUserId { get; set; }
        public string OwnerAttachmentId { get; set; }
        public string OwnerNationalId { get; set; }
        public int? OwnerGenderId { get; set; }
        public string OwnerNationalityId { get; set; }
        public string OwnerIdentityType { get; set; }
        public string OwnerNationalityArabic { get; set; }
        public string OwnerFullNameArabic { get; set; }
        public string OwnerFullNameEnglish { get; set; }
        public string OwnerNationalityEnglish { get; set; }
        public DateTime? OwnerBirthDate { get; set; }
    }
    public class ManagerInformation
    {
        public string ManagerTypeNameAr { get; set; }
        public string ManagerTypeNameEn { get; set; }
        public int? ManagerTypeId { get; set; }
        public long? ManagerInfoIdentityNo { get; set; }
        public DateTime? ManagerInfoBirthDate { get; set; }
        public string ManagerInfoMobileNo { get; set; }
        public string ManagerInfoEmail { get; set; }
        public string ManagerInfoNameAr { get; set; }
        public string ManagerInfoNameEn { get; set; }
        public string ManagerInfoNationalityNameAr { get; set; }
        public string ManagerInfoNationalityNameEn { get; set; }
        public Guid ManagerInfoNationalityId { get; set; }
    }
    public class AddressInformation
    {
        public string AddressBuldingNo { get; set; }
        public string AddressAddressId { get; set; }
        public string AddressAdditionalNumber { get; set; }
        public string AddressUnitNumber { get; set; }
        public string AddressZipCode { get; set; }
        public string AddressBuildingArabicName { get; set; }
        public string AddressBuildingEnglishName { get; set; }
        public string AddressCityArabicName { get; set; }
        public string AddressCityEnglishName { get; set; }
        public string AddressCountryArabicName { get; set; }
        public string AddressCountryEnglishName { get; set; }
        public string AddressNeighborhoodArabicName { get; set; }
        public string AddressNeighborhoodEnglishName { get; set; }
        public string AddressRegionArabicName { get; set; }
        public string AddressRegionEnglishName { get; set; }
        public string AddressStreetArabicName { get; set; }
        public string AddressStreetEnglishName { get; set; }
        public int? AddressCityId { get; set; }
        public long? AddressNeighborhoodId { get; set; }
        public int? AddressRegionId { get; set; }
        public int? AddressStreetId { get; set; }
        public string AddressAddressLineAr { get; set; }
        public string AddressAddressLineEn { get; set; }
        public string AddressLatitude { get; set; }
        public string AddressLongitude { get; set; }
        public Guid BuildingTypeId { get; set; }
        public string FloorNumber { get; set; }
    }
    public class ContactInformation
    {
        public string ContactMobileNo { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public bool ContactHasECommerce { get; set; }
        public string ContactWebsite { get; set; }
        public string ContactMaroofLink { get; set; }
    }
    public class CrInformation
    {
        public long? CrInfoMainCRNationalNumber { get; set; }
        public long? CrInfoMainCRNumber { get; set; }
        public int? CrInfoDuration { get; set; }
        public string CrInfoChamberName { get; set; }
        public int? CrInfoChamberCode { get; set; }
        public double? CrInfoCapital { get; set; }
        public DateTime? CrInfoStartDate { get; set; }
        public string CrInfoCityNameAr { get; set; }
        public string CrInfoCityNameEn { get; set; }
        public bool? IsMain { get; set; }
        public int? CrInfoChamberSubscriptionDegree { get; set; }
        public string CrInfoCityId { get; set; }
        public string CrInfoChamberSubscriptionDegreeName { get; set; }
    }
    public class FiscalYearInformation
    {
        public DateTime? RequestFiscalYearsStartDateGregorian { get; set; }
        public string RequestFiscalYearsStartDateHijri { get; set; }
        public int? RequestFiscalYearsHijriDay { get; set; }
        public int? RequestFiscalYearsHijriMonth { get; set; }
        public int? RequestFiscalYearsGregorianDay { get; set; }
        public string RequestFiscalYearsCalenderType { get; set; }
        public int? RequestFiscalYearsGregorianMonth { get; set; }
    }
    public class TradeNameInformation
    {
        public int? TradeNameExistingEntityNo { get; set; }
        public int? TradeNameReservationNo { get; set; }
        public string TradeNameNamingMethod { get; set; }
        public int? TradeNamePrefixCode { get; set; }
        public string TradeNamePrefixName { get; set; }
        public int? TradeNameSuffixCode { get; set; }
        public string TradeNameSuffixName { get; set; }
        public string TradeNameMidTradeName { get; set; }
    }
    public class RequestActivityInformation
    {
        public string RequestActivityISICCode { get; set; }
        public string RequestActivityArabicName { get; set; }
        public string RequestActivityEnglishName { get; set; }
        public bool RequestActivityIsMcRequiredLicense { get; set; }
        public string RequestActivityLicenseIssuerArabicName { get; set; }
        public string RequestActivityLicenseIssuerCode { get; set; }
        public string RequestActivityLicenseIssuerEnglishName { get; set; }
    }
    #endregion

}
