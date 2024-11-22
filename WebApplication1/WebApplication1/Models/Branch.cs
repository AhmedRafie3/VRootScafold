using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Branch
{
    public int BranchId { get; set; }

    public string? Name { get; set; }

    public string? RCode { get; set; }

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

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; } 
    public virtual ICollection<Buddy> Buddies { get; } = new List<Buddy>(); 
    public virtual Employee? CreatedByNavigation { get; set; }
    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

    
    public virtual ICollection<Employeeshift> Employeeshifts { get; } = new List<Employeeshift>();


    public virtual ICollection<Invoice> InvoiceBranches { get; } = new List<Invoice>();
    public virtual ICollection<Invoice> InvoiceToBranches { get; } = new List<Invoice>();
    public virtual ICollection<Product> Products { get; } = new List<Product>();

    public virtual ICollection<Productvarint> Productvarints { get; } = new List<Productvarint>();
    public virtual ICollection<Transactionflow> Transactionflows { get; } = new List<Transactionflow>();
    public virtual Employee? UpdatedByNavigation { get; set; }

  
}
