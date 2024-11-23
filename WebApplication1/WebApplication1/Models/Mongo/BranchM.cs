using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace WebApplication1.Models.Mongo
{
    public class BranchM
    {
        public string Id { get; set; } // MongoDB uses string or ObjectId for IDs
        public string? Name { get; set; }
        public string? R_Code { get; set; }
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
        public int Type { get; set; }
        public string? Address { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public int? GovernmentId { get; set; }
        public int? AreaId { get; set; }
        public string? SpecialMark { get; set; }
        public int CompanyId { get; set; }
        public int? IndustryId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        // Relationships
        public List<EmployeeM>? Employees { get; set; } // Embed employees
        public List<string>? ProductIds { get; set; } // Reference product IDs
        public List<string>? TransactionflowIds { get; set; } // Reference transaction flow IDs
        public List<string>? InvoiceIds { get; set; } // Reference invoice IDs
        public int CreatedBy { get; set; } // Reference to the creator
        public int UpdatedBy { get; set; } // Reference to the updater
    
}
}
