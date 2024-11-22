namespace WebApplication1.Models.Mongo
{
    public class BuddyM
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
        public string? SpecialMark { get; set; }
        public string? Bio { get; set; }
        public string? About { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        // Relationships
        public string BranchId { get; set; } // Reference Branch as ID
        public string? ParentBuddyId { get; set; } // Reference parent Buddy
        public string? RepresentativeBuddyId { get; set; } // Reference representative Buddy
        public string? TechnicalBuddyId { get; set; } // Reference technical Buddy
        public string? CreatedByEmployeeId { get; set; } // Reference employee who created
        public string? UpdatedByEmployeeId { get; set; } // Reference employee who updated
        public List<string>? InvoiceIds { get; set; } // Reference invoices as IDs
        public List<string>? TransactionflowIds { get; set; } // Reference transaction flows
        public List<string>? ProductVariantIds { get; set; } // Reference product variants
    }
}
