namespace WebApplication1.Models.Mongo
{
    public class InvoiceM
    {
        public string Id { get; set; } = null!; // MongoDB document ID
        public int InvoiceType { get; set; }
        public int PermissionStatus { get; set; }
        public int InvoiceStatus { get; set; }
        public int InvoiceStatusFlag { get; set; }
        public string? BuddiesId { get; set; } // References Buddy as ID
        public string? TechnicalId { get; set; } // References Buddy as Technical
        public string? DeliveryId { get; set; } // References Buddy as Delivery
        public string? WaiterId { get; set; } // References Buddy as Waiter
        public string? DriverId { get; set; }
        public string? ChefId { get; set; } // References Buddy as Chef
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
        public int SellerId { get; set; } // References Employee as Seller
        public int? StockPermissinId { get; set; }
        public int? OrderId { get; set; }
        public int BranchId { get; set; } // References Branch
        public int? ToBranchId { get; set; } // References Branch for `ToBranch`
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
        public List<string>? TransactionflowIds { get; set; } // References Transactionflows as IDs
    }
}
