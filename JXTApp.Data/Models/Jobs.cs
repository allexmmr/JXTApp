using System;

namespace JXTApp.Data.Models
{
    public class Jobs
    {
        public int JobId { get; set; }
        public int SiteId { get; set; }
        public string JobName { get; set; }
        public string Description { get; set; }
        public string FullDescription { get; set; }
        public DateTime DatePosted { get; set; }
        public bool Visible { get; set; }
        public int? Expired { get; set; }
        public bool ShowSalaryDetails { get; set; }
        public bool ShowSalaryRange { get; set; }
        public string SalaryText { get; set; }
        public int? AdvertiserId { get; set; }
        public int? ApplicationMethod { get; set; }
        public string ApplicationUrl { get; set; }
        public int? AdvertiserJobTemplateLogoId { get; set; }
        public string CompanyName { get; set; }
        public bool? ShowLocationDetails { get; set; }
        public string BulletPoint1 { get; set; }
        public string BulletPoint2 { get; set; }
        public string BulletPoint3 { get; set; }
        public bool HotJob { get; set; }
        public string ApplicationEmailAddress { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string ContactDetails { get; set; }
        public string RefNo { get; set; }
        public string AdvertiserName { get; set; }
        public string CurrencySymbol { get; set; }
        public decimal SalaryUpperBand { get; set; }
        public decimal SalaryLowerBand { get; set; }
        public int SalaryTypeId { get; set; }
        public string SalaryTypeName { get; set; }
        public string WorkTypeName { get; set; }
        public int CountryId { get; set; }
        public int LocationId { get; set; }
        public int AreaId { get; set; }
        public string CountryName { get; set; }
        public string LocationName { get; set; }
        public string AreaName { get; set; }
        public int ProfessionId { get; set; }
        public int RoleId { get; set; }
        public string SiteProfessionName { get; set; }
        public string SiteRoleName { get; set; }
        public string BreadCrumbNavigation { get; set; }
        public int WorkTypeId { get; set; }
        public string JobFriendlyName { get; set; }
        public string SalaryDisplay { get; set; }
        public int? JobItemTypeId { get; set; }
        public double? JobLatitude { get; set; }
        public double? JobLongitude { get; set; }
        public int? AddressStatus { get; set; }
        public int HasAdvertiserLogo { get; set; }
        public string AdvertiserLogo { get; set; }
        public string AdvertiserJobTemplateLogo { get; set; }
        public string CustomXml { get; set; }
        public string Address { get; set; }
        public string PublicTransport { get; set; }
        public DateTime? ProposedStartDate { get; set; }
        public DateTime? ProposedEndDate { get; set; }
        public decimal? ReferralAmount { get; set; }
        public string ReferralUrl { get; set; }
        public object Tag { get; set; }
    }
}