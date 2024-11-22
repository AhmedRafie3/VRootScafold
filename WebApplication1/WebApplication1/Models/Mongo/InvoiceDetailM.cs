namespace WebApplication1.Models.Mongo
{
    public class InvoiceDetailM
    {
        public string Id { get; set; } = null!; // MongoDB document ID
        public int ProductVarintId { get; set; } // Reference to the product variant
        public int ProductUnitId { get; set; } // Reference to the unit of the product
        public double Quantity { get; set; }
        public double QuantityOfMainUnit { get; set; }
        public double ProductVarintPrice { get; set; }
        public double ProductVarintDiscount { get; set; }
        public double ProductVarintDiscountPercent { get; set; }
        public double ProductVarintTax { get; set; }
        public double ProductVarintTaxPercent { get; set; }
        public double ProductVarintFinalPrice { get; set; }
        public double TotalProductVarintFinalPrice { get; set; }
        public string? Notes { get; set; }
        public int ImageTempId { get; set; }
        public int StockId { get; set; } // Reference to stock
        public string? InvoiceId { get; set; } // Reference to the parent invoice
        public string? ReturnInvoiceId { get; set; } // Reference to the return invoice
        public int DiscountListId { get; set; } // Reference to discount details
        public double DiscountListValue { get; set; }
        public string? Note { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
