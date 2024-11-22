using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Invoice
{
    public int InvoiceId { get; set; }

    public int InvoiceType { get; set; }

    public int PermissionStatus { get; set; }

    public int InvoiceStatus { get; set; }

    public int InvoiceStatusFlag { get; set; }

    public string? BuddiesId { get; set; }

    public string? TechnicalId { get; set; }

    public string? DeliveryId { get; set; }

    public string? WaiterId { get; set; }

    public string? DriverId { get; set; }

    public string? ChefId { get; set; }

    public int FlagByDateCompany { get; set; }

    public int FlagByDateBranch { get; set; }

    public string? EmployeeNote { get; set; }

    public string? ClientNote { get; set; }

    public string? PreparationNotes { get; set; }

    public string? Photo { get; set; }

    public double FinalPrice { get; set; }

    public double Commission { get; set; }

    public double TotalPrice { get; set; }

    public double TotalProductVarintTax { get; set; }

    public double TotalProductVarintDiscountListPrice { get; set; }

    public double TotalProductVarintDiscountExtraPrice { get; set; }

    public double InvoiceTax { get; set; }

    public double InvoiceDiscount { get; set; }

    public double DeliveryAreaPrice { get; set; }

    public double DeliveryCostPrice { get; set; }

    public double ServicePrice { get; set; }

    public bool WillShipping { get; set; }

    public bool WillPreparing { get; set; }

    public int SellerId { get; set; }

    public int? StockPermissinId { get; set; }

    public int? OrderId { get; set; }

    public int BranchId { get; set; }

    public int? ToBranchId { get; set; }

    public int CompanyId { get; set; }

    public int TableNumber { get; set; }

    public string? InvoiceCode { get; set; }

    public bool IsSchedule { get; set; }

    public DateTime? ScheduleDate { get; set; }

    public int Type { get; set; }

    public int Status { get; set; }

    public int PaymentType { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual Branch Branch { get; set; } = null!;

    public virtual Buddy? Buddies { get; set; }

    public virtual Buddy? Chef { get; set; }



    public virtual Buddy? Delivery { get; set; }

   
    public virtual Employee Seller { get; set; } = null!;

  
    public virtual Buddy? Technical { get; set; }

    public virtual Branch? ToBranch { get; set; }

    public virtual ICollection<Transactionflow> Transactionflows { get; } = new List<Transactionflow>();

    


    public virtual Buddy? Waiter { get; set; }
}
