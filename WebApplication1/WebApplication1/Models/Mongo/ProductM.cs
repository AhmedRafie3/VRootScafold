namespace WebApplication1.Models.Mongo
{
    public class ProductM
    {
        public string Id { get; set; } = null!; // MongoDB document ID
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Photo { get; set; }
        public int MainProductUnitId { get; set; } // Reference to the main product unit
        public int PurchaseDefaultProductUnitId { get; set; }
        public int SalesDefaultProductUnitId { get; set; }
        public bool Stackable { get; set; }
        public int? ClassificationId { get; set; } // Reference to the product classification
        public bool NotReturnable { get; set; }
        public int DiscountListType { get; set; }
        public int ContainerType { get; set; }
        public int WarrantyType { get; set; }
        public int WarrantyNumber { get; set; }
        public bool IsSerial { get; set; }
        public bool IsExpire { get; set; }
        public double TaxValue { get; set; }
        public string? Code { get; set; }
        public string? IntBarcode { get; set; }
        public string? Barcode { get; set; }
        public string? Qrcode { get; set; }
        public string? RCode { get; set; }
        public int? BrandId { get; set; } // Reference to the brand
        public int BranchId { get; set; } // Reference to the branch
        public int? CompanyId { get; set; }
        public int Type { get; set; }
        public int? Flags { get; set; }
        public int? CreatedBy { get; set; } // Reference to the creator employee
        public int? UpdatedBy { get; set; } // Reference to the updater employee
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        // Subdocuments or references
        public List<ProductvarintM> ProductVariants { get; set; } = new List<ProductvarintM>();
    }
}
