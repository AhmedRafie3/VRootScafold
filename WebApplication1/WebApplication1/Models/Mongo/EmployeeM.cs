namespace WebApplication1.Models.Mongo
{
    public class EmployeeM
    {
        public string Id { get; set; } // MongoDB prefers string or ObjectId for IDs
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Mobile { get; set; }
        public string? OtherMobile { get; set; }
        public string? HomePhone { get; set; }
        public string? Photo { get; set; }
        public string? WhatsAppNo { get; set; }
        public double Rating { get; set; }
        public string? Description { get; set; }
        public string? FacebookPage { get; set; }
        public string? LinkedPage { get; set; }
        public string? Email { get; set; }
        public bool HasTreasury { get; set; }
        public int TimeZone { get; set; }
        public string? Address { get; set; }
        public string? UrlPath { get; set; }
        public string? RCode { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public int? GovernmentId { get; set; }
        public int? AreaId { get; set; }
        public string? SpecialMark { get; set; }
        public int Type { get; set; }
        public int BranchId { get; set; }
        public int? CompanyId { get; set; }
        public int? AccTreeId { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        // Embedded relationships (denormalized for simpler queries)
        public BranchM? Branch { get; set; } // Embed essential branch data
        public List<EmployeeShiftM>? EmployeeShifts { get; set; }

        // Referenced relationships (normalized for scalability)
        public List<string>? InvoiceIds { get; set; } // Store Invoice IDs only
        public List<string>? BuddyIds { get; set; }   // Store Buddy IDs only
        public string? CreatedByEmployeeId { get; set; }
        public string? UpdatedByEmployeeId { get; set; }
    }
}
