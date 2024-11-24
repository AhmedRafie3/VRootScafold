using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace WebApplication1.Models.Mongo
{
    public class ProductvarintM
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? Barcode { get; set; }
        public string? IntBarcode { get; set; }
        public string? Code { get; set; }
        public string? RCode { get; set; }
        public string? Description { get; set; }
        public string? Photo { get; set; }
        public double ConsumerPrice { get; set; }
        public string? DefaultStock { get; set; }
        public string? DefaultSecStock { get; set; }
        public int MaximumLimitForBranch { get; set; }
        public int MinimumLimitForBranch { get; set; }
        public int MaximumLimitForCompany { get; set; }
        public int MinimumLimitForCompany { get; set; }
        public int MaximumOrder { get; set; }
        public int ExchangeLimit { get; set; }
        public string? ImagePath { get; set; }
        public bool NewPurchasePriceTurnOffFromPurchase { get; set; }
        public double? NewPurchasePrice { get; set; }
        public string? NewPurchaseTurnOffNote { get; set; }
        public DateTime? NewPurchaseDate { get; set; }
        public bool Isasleep { get; set; }
        public double PurchasePrice { get; set; }
        public double SalesPrice1 { get; set; }
        public double SalesPrice2 { get; set; }
        public double SalesPrice3 { get; set; }
        public double SalesPrice4 { get; set; }
        public double SalesPrice5 { get; set; }
        public double SalesPrice6 { get; set; }
        public double SalesPrice7 { get; set; }
        public double SalesPrice8 { get; set; }
        public double SalesPrice9 { get; set; }
        public double SalesPrice10 { get; set; }
        public double Price { get; set; }
        public double CaloriesValue { get; set; }
        public double PortionPersons { get; set; }
        public bool IsOrder { get; set; }
        public bool IsPreOrder { get; set; }
        public int? ProductId { get; set; }
        public int BranchId { get; set; }
        public int? CompanyId { get; set; }
        public int Type { get; set; }
        public int? Flags { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual Branch Branch { get; set; } = null!;
        public virtual List<Invoicedetail> Invoicedetails { get; } = new List<Invoicedetail>();
        public virtual Product? Product { get; set; }
        public virtual Employee? UpdatedByNavigation { get; set; }
        public virtual List<Buddy> Buddies { get; } = new List<Buddy>();
    }
}
