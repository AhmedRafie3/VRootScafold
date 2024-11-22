using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Buddy
{
    public string Id { get; set; } = null!;

    public int Key { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? RCode { get; set; }

    public string? Code { get; set; }

    public int BuddiesType { get; set; }

    public int BodyTypes { get; set; }

    public int SignupType { get; set; }

    public string? DeviceToken { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Mobile { get; set; }

    public string? OtherMobile { get; set; }

    public string? HomePhone { get; set; }

    public string? Photo { get; set; }

    public string? WhatsAppNo { get; set; }

    public double Rating { get; set; }

    public string? Description { get; set; }

    public int NumberOfEmployee { get; set; }

    public string? OwnerShip { get; set; }

    public string? Website { get; set; }

    public string? FacebookPage { get; set; }

    public string? LinkedPage { get; set; }

    public string? Email { get; set; }

    public int TimeZone { get; set; }

    public string? Address { get; set; }

    public string? NationalId { get; set; }

    public int InvoiceLimit { get; set; }

    public DateTime DateLimit { get; set; }

    public DateTime DateOfBirth { get; set; }

    public double CreditLimit { get; set; }

    public bool StopTheSale { get; set; }

    public int PriceSegment { get; set; }

    public DateTime WhatsAppSessionDate { get; set; }

    public int Type { get; set; }

    public bool TurnOffAutomaticClassificationSystemForClient { get; set; }

    public int BranchId { get; set; }

    public int? CompanyId { get; set; }

    public int? BuddiesClassId { get; set; }

    public int? CountryId { get; set; }

    public int? CityId { get; set; }

    public int? GovernmentId { get; set; }

    public int? AreaId { get; set; }

    public string? SpecialMark { get; set; }

    public string? ArabicName { get; set; }

    public string? CivilId { get; set; }

    public string? CustomerServiceEmployee { get; set; }

    public string? SalesEmployee { get; set; }

    public string? HouseNumber { get; set; }

    public string? StreetLine1 { get; set; }

    public string? StreetLine2 { get; set; }

    public string? PostZipCode { get; set; }

    public string? ImageDriverLicense { get; set; }

    public string? ImageNationalId { get; set; }

    public string? ImagePassport { get; set; }

    public int? AccTreeId { get; set; }

    public string? ParentId { get; set; }

    public string? TechnicalId { get; set; }

    public int? OwnerId { get; set; }

    public string? RepresentativeId { get; set; }

    public int? IndustryId { get; set; }

    public bool AutoCreditLimit { get; set; }

    public int AutoCreditLimitPaymentDays { get; set; }

    public bool MaximumLimit { get; set; }

    public double MaximumLimitAmount { get; set; }

    public int? LeadSourceTypeId { get; set; }

    public string? Bio { get; set; }

    public string? About { get; set; }

    public bool AccountApproved { get; set; }

    public DateTime AccountApprovedDate { get; set; }

    public string? ImageDriverLicenseCode { get; set; }

    public string? ImageProfile { get; set; }

    public string? ImageCover { get; set; }

    public string? ImageHygieneCert { get; set; }

    public bool IsHygiene { get; set; }

    public string? ImageAuthorityReg { get; set; }

    public string? ImageAddressProof { get; set; }

    public string? ImageRiskAssessment { get; set; }

    public string? ImageContract { get; set; }

    public string? ImageDrivingLicense { get; set; }

    public string? ImageFoodDeliveryInsurance { get; set; }

    public string? ImageProfile1 { get; set; }

    public string? ImageProfile2 { get; set; }

    public string? ImageProfile3 { get; set; }

    public string? ImageProfile4 { get; set; }

    public string? ImageProfile5 { get; set; }

    public bool PickupAllowed { get; set; }

    public bool PickupOnly { get; set; }

    public string? ImageId { get; set; }

    public bool IsBlacklist { get; set; }

    public bool IsInvestors { get; set; }

    public int StatusOnWorkTime { get; set; }

    public int StatusIsActive { get; set; }

    public int StatusWork { get; set; }

    public string? TwitterPage { get; set; }

    public string? LangarooPage { get; set; }

    public decimal AddressLatitude { get; set; }

    public decimal AddressLongitude { get; set; }

    public string? ImageBankStatement { get; set; }

    public string? ImageEvidenceOfResidence { get; set; }

    public bool MobileVerified { get; set; }

    public DateTime? MobileVerifiedDate { get; set; }

    public string? MobileOtp { get; set; }

    public DateTime? MobileOtpDate { get; set; }

    public bool ContractApproved { get; set; }

    public DateTime ContractApprovedDate { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public virtual Branch Branch { get; set; } = null!;
    public virtual Employee? CreatedByNavigation { get; set; }
    public virtual ICollection<Buddy> InverseParent { get; } = new List<Buddy>();
    public virtual ICollection<Buddy> InverseRepresentative { get; } = new List<Buddy>();
    public virtual ICollection<Buddy> InverseTechnical { get; } = new List<Buddy>();
    public virtual ICollection<Invoice> InvoiceBuddies { get; } = new List<Invoice>();
    public virtual ICollection<Invoice> InvoiceChefs { get; } = new List<Invoice>();
    public virtual ICollection<Invoice> InvoiceDeliveries { get; } = new List<Invoice>();
    public virtual ICollection<Invoice> InvoiceTechnicals { get; } = new List<Invoice>();
    public virtual ICollection<Invoice> InvoiceWaiters { get; } = new List<Invoice>();
  
   public virtual Employee? Owner { get; set; }
    public virtual Buddy? Parent { get; set; } 
    public virtual Buddy? Representative { get; set; }
    public virtual Buddy? Technical { get; set; }
    public virtual ICollection<Transactionflow> Transactionflows { get; } = new List<Transactionflow>();
    public virtual Employee? UpdatedByNavigation { get; set; }
    public virtual ICollection<Productvarint> ProductVarints { get; } = new List<Productvarint>();

}
