using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }
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
    public virtual Branch Branch { get; set; } = null!;
    public virtual ICollection<Branch> BranchCreatedByNavigations { get; } = new List<Branch>();
    public virtual ICollection<Branch> BranchUpdatedByNavigations { get; } = new List<Branch>();
    public virtual ICollection<Buddy> BuddyCreatedByNavigations { get; } = new List<Buddy>();
    public virtual ICollection<Buddy> BuddyOwners { get; } = new List<Buddy>();
    public virtual ICollection<Buddy> BuddyUpdatedByNavigations { get; } = new List<Buddy>();
    public virtual Employee? CreatedByNavigation { get; set; }
    public virtual ICollection<Employeeshift> Employeeshifts { get; } = new List<Employeeshift>();
    public virtual ICollection<Employee> InverseCreatedByNavigation { get; } = new List<Employee>();
    public virtual ICollection<Employee> InverseUpdatedByNavigation { get; } = new List<Employee>();
    public virtual ICollection<Invoice> Invoices { get; } = new List<Invoice>();
    public virtual ICollection<Product> ProductCreatedByNavigations { get; } = new List<Product>();
    public virtual ICollection<Product> ProductUpdatedByNavigations { get; } = new List<Product>();
    public virtual ICollection<Productvarint> ProductvarintCreatedByNavigations { get; } = new List<Productvarint>();
    public virtual ICollection<Productvarint> ProductvarintUpdatedByNavigations { get; } = new List<Productvarint>();
    public virtual Employee? UpdatedByNavigation { get; set; }

}
