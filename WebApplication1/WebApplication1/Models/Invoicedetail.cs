﻿using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Invoicedetail
{
    public int InvoiceDetailsId { get; set; }

    public int ProductVarintId { get; set; }

    public int ProductUnitId { get; set; }

    public double Quantity { get; set; }

    public double QuantityOfmainUnit { get; set; }

    public double ProductVarintPrice { get; set; }

    public double ProductVarintDiscount { get; set; }

    public double ProductVarintDiscountPercent { get; set; }

    public double ProductVarintTax { get; set; }

    public double ProductVarintTaxPercent { get; set; }

    public double ProductVarintFinalPrice { get; set; }

    public double TotalProductVarintFinalPrice { get; set; }

    public string? Notes { get; set; }

    public int ImageTempId { get; set; }

    public int StockId { get; set; }

    public int? InvoiceId { get; set; }

    public int? ReturnInvoiceId { get; set; }

    public int DiscountListId { get; set; }

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

 

    public virtual Invoice? Invoice { get; set; }


    public virtual Productvarint ProductVarint { get; set; } = null!;

    public virtual Invoice? ReturnInvoice { get; set; }

   
}
