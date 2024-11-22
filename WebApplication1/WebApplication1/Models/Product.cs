using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Photo { get; set; }

    public int MainProductUnitId { get; set; }

    public int PurchaseDefaultProductUnitId { get; set; }

    public int SalesDefaultProductUnitId { get; set; }

    public bool Stackable { get; set; }

    public int? ClassificationId { get; set; }

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

    public int? BrandId { get; set; }

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

  
    public virtual Employee? CreatedByNavigation { get; set; }



  

    public virtual ICollection<Productvarint> Productvarints { get; } = new List<Productvarint>();

    public virtual Employee? UpdatedByNavigation { get; set; }
}
