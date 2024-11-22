using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public partial class vRootDbContext : DbContext
{
    public vRootDbContext()
    {
    }

    public vRootDbContext(DbContextOptions<vRootDbContext> options)
        : base(options)
    {
    }
    public virtual DbSet<Branch> Branches { get; set; }
    public virtual DbSet<Buddy> Buddies { get; set; }
    public virtual DbSet<Employee> Employees { get; set; }
    public virtual DbSet<Employeeshift> Employeeshifts { get; set; }
    public virtual DbSet<Invoice> Invoices { get; set; }
    public virtual DbSet<Invoicedetail> Invoicedetails { get; set; }  
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Productvarint> Productvarints { get; set; }
    public virtual DbSet<Transactionflow> Transactionflows { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3308;database=_master3;user=root;password=123456", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.40-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");



        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.BranchId).HasName("PRIMARY");

            entity
                .ToTable("branch")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.AreaId, "IX_Branch_AreaId");

            entity.HasIndex(e => e.CityId, "IX_Branch_CityId");

            entity.HasIndex(e => e.CompanyId, "IX_Branch_CompanyId");

            entity.HasIndex(e => e.CountryId, "IX_Branch_CountryId");

            entity.HasIndex(e => e.CreatedBy, "IX_Branch_CreatedBy");

            entity.HasIndex(e => e.GovernmentId, "IX_Branch_GovernmentId");

            entity.HasIndex(e => e.IndustryId, "IX_Branch_IndustryId");

            entity.HasIndex(e => e.UpdatedBy, "IX_Branch_UpdatedBy");

            entity.Property(e => e.Address).HasColumnType("text");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Email).HasColumnType("text");
            entity.Property(e => e.FacebookPage).HasColumnType("text");
            entity.Property(e => e.Fax).HasColumnType("text");
            entity.Property(e => e.HomePhone).HasColumnType("text");
            entity.Property(e => e.LinkedPage).HasColumnType("text");
            entity.Property(e => e.Mobile).HasColumnType("text");
            entity.Property(e => e.Name).HasColumnType("text");
            entity.Property(e => e.OtherMobile).HasColumnType("text");
            entity.Property(e => e.OwnerShip).HasColumnType("text");
            entity.Property(e => e.Phone).HasColumnType("text");
            entity.Property(e => e.Photo).HasColumnType("text");
            entity.Property(e => e.RCode)
                .HasColumnType("text")
                .HasColumnName("R_Code");
            entity.Property(e => e.SpecialMark).HasColumnType("text");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Website).HasColumnType("text");
            entity.Property(e => e.WhatsAppNo).HasColumnType("text");

           

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.BranchCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_Branch_Employee_CreatedBy");

          

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.BranchUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK_Branch_Employee_UpdatedBy");

           
        });


        modelBuilder.Entity<Buddy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("buddies")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.AccTreeId, "IX_Buddies_AccTreeId").IsUnique();

            entity.HasIndex(e => e.AreaId, "IX_Buddies_AreaId");

            entity.HasIndex(e => e.BranchId, "IX_Buddies_BranchId");

            entity.HasIndex(e => e.BuddiesClassId, "IX_Buddies_BuddiesClassId");

            entity.HasIndex(e => e.CityId, "IX_Buddies_CityId");

            entity.HasIndex(e => e.Code, "IX_Buddies_Code").IsUnique();

            entity.HasIndex(e => e.CountryId, "IX_Buddies_CountryId");

            entity.HasIndex(e => e.CreatedBy, "IX_Buddies_CreatedBy");

            entity.HasIndex(e => e.GovernmentId, "IX_Buddies_GovernmentId");

            entity.HasIndex(e => e.IndustryId, "IX_Buddies_IndustryId");

            entity.HasIndex(e => e.LeadSourceTypeId, "IX_Buddies_LeadSourceTypeID");

            entity.HasIndex(e => e.OwnerId, "IX_Buddies_OwnerId");

            entity.HasIndex(e => e.ParentId, "IX_Buddies_ParentId");

            entity.HasIndex(e => e.RepresentativeId, "IX_Buddies_RepresentativeId");

            entity.HasIndex(e => e.TechnicalId, "IX_Buddies_TechnicalId");

            entity.HasIndex(e => e.UpdatedBy, "IX_Buddies_UpdatedBy");

            entity.Property(e => e.Id)
                .HasMaxLength(767)
                .HasColumnName("ID");
            entity.Property(e => e.About).HasColumnType("text");
            entity.Property(e => e.AccountApproved).HasColumnName("Account_Approved");
            entity.Property(e => e.AccountApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Approved_Date");
            entity.Property(e => e.Address).HasColumnType("text");
            entity.Property(e => e.AddressLatitude)
                .HasPrecision(18, 2)
                .HasColumnName("Address_Latitude");
            entity.Property(e => e.AddressLongitude)
                .HasPrecision(18, 2)
                .HasColumnName("Address_Longitude");
            entity.Property(e => e.ArabicName).HasColumnType("text");
            entity.Property(e => e.Bio).HasColumnType("text");
            entity.Property(e => e.CivilId)
                .HasColumnType("text")
                .HasColumnName("CivilID");
            entity.Property(e => e.Code).HasMaxLength(767);
            entity.Property(e => e.ContractApproved).HasColumnName("Contract_Approved");
            entity.Property(e => e.ContractApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("Contract_Approved_Date");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerServiceEmployee).HasColumnType("text");
            entity.Property(e => e.DateLimit).HasColumnType("datetime");
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.DeviceToken).HasColumnType("text");
            entity.Property(e => e.Email).HasColumnType("text");
            entity.Property(e => e.FacebookPage).HasColumnType("text");
            entity.Property(e => e.Fax).HasColumnType("text");
            entity.Property(e => e.FirstName).HasColumnType("text");
            entity.Property(e => e.HomePhone).HasColumnType("text");
            entity.Property(e => e.HouseNumber).HasColumnType("text");
            entity.Property(e => e.ImageAddressProof)
                .HasColumnType("text")
                .HasColumnName("Image_Address_Proof");
            entity.Property(e => e.ImageAuthorityReg)
                .HasColumnType("text")
                .HasColumnName("Image_Authority_Reg");
            entity.Property(e => e.ImageBankStatement)
                .HasColumnType("text")
                .HasColumnName("Image_Bank_Statement");
            entity.Property(e => e.ImageContract)
                .HasColumnType("text")
                .HasColumnName("Image_Contract");
            entity.Property(e => e.ImageCover)
                .HasColumnType("text")
                .HasColumnName("Image_Cover");
            entity.Property(e => e.ImageDriverLicense)
                .HasColumnType("text")
                .HasColumnName("Image_Driver_License");
            entity.Property(e => e.ImageDriverLicenseCode)
                .HasColumnType("text")
                .HasColumnName("Image_Driver_License_Code");
            entity.Property(e => e.ImageDrivingLicense)
                .HasColumnType("text")
                .HasColumnName("Image_Driving_License");
            entity.Property(e => e.ImageEvidenceOfResidence)
                .HasColumnType("text")
                .HasColumnName("Image_Evidence_Of_Residence");
            entity.Property(e => e.ImageFoodDeliveryInsurance)
                .HasColumnType("text")
                .HasColumnName("Image_Food_Delivery_Insurance");
            entity.Property(e => e.ImageHygieneCert)
                .HasColumnType("text")
                .HasColumnName("Image_Hygiene_Cert");
            entity.Property(e => e.ImageId)
                .HasColumnType("text")
                .HasColumnName("Image_ID");
            entity.Property(e => e.ImageNationalId)
                .HasColumnType("text")
                .HasColumnName("Image_National_ID");
            entity.Property(e => e.ImagePassport)
                .HasColumnType("text")
                .HasColumnName("Image_Passport");
            entity.Property(e => e.ImageProfile)
                .HasColumnType("text")
                .HasColumnName("Image_Profile");
            entity.Property(e => e.ImageProfile1)
                .HasColumnType("text")
                .HasColumnName("Image_Profile_1");
            entity.Property(e => e.ImageProfile2)
                .HasColumnType("text")
                .HasColumnName("Image_Profile_2");
            entity.Property(e => e.ImageProfile3)
                .HasColumnType("text")
                .HasColumnName("Image_Profile_3");
            entity.Property(e => e.ImageProfile4)
                .HasColumnType("text")
                .HasColumnName("Image_Profile_4");
            entity.Property(e => e.ImageProfile5)
                .HasColumnType("text")
                .HasColumnName("Image_Profile_5");
            entity.Property(e => e.ImageRiskAssessment)
                .HasColumnType("text")
                .HasColumnName("Image_Risk_Assessment");
            entity.Property(e => e.IsBlacklist).HasColumnName("Is_Blacklist");
            entity.Property(e => e.IsHygiene).HasColumnName("Is_Hygiene");
            entity.Property(e => e.IsInvestors).HasColumnName("Is_Investors");
            entity.Property(e => e.LangarooPage)
                .HasColumnType("text")
                .HasColumnName("Langaroo_Page");
            entity.Property(e => e.LastName).HasColumnType("text");
            entity.Property(e => e.LeadSourceTypeId).HasColumnName("LeadSourceTypeID");
            entity.Property(e => e.LinkedPage).HasColumnType("text");
            entity.Property(e => e.Mobile).HasColumnType("text");
            entity.Property(e => e.MobileOtp)
                .HasColumnType("text")
                .HasColumnName("Mobile_OTP");
            entity.Property(e => e.MobileOtpDate)
                .HasColumnType("timestamp")
                .HasColumnName("Mobile_OTP_Date");
            entity.Property(e => e.MobileVerified).HasColumnName("Mobile_Verified");
            entity.Property(e => e.MobileVerifiedDate)
                .HasColumnType("timestamp")
                .HasColumnName("Mobile_Verified_Date");
            entity.Property(e => e.NationalId)
                .HasColumnType("text")
                .HasColumnName("NationalID");
            entity.Property(e => e.OtherMobile).HasColumnType("text");
            entity.Property(e => e.OwnerShip).HasColumnType("text");
            entity.Property(e => e.ParentId).HasMaxLength(767);
            entity.Property(e => e.Phone).HasColumnType("text");
            entity.Property(e => e.Photo).HasColumnType("text");
            entity.Property(e => e.PickupAllowed).HasColumnName("Pickup_Allowed");
            entity.Property(e => e.PickupOnly).HasColumnName("Pickup_Only");
            entity.Property(e => e.PostZipCode)
                .HasColumnType("text")
                .HasColumnName("Post_ZipCode");
            entity.Property(e => e.RCode)
                .HasColumnType("text")
                .HasColumnName("R_Code");
            entity.Property(e => e.RepresentativeId).HasMaxLength(767);
            entity.Property(e => e.SalesEmployee).HasColumnType("text");
            entity.Property(e => e.SpecialMark).HasColumnType("text");
            entity.Property(e => e.StatusIsActive).HasColumnName("Status_IsActive");
            entity.Property(e => e.StatusOnWorkTime).HasColumnName("Status_On_Work_Time");
            entity.Property(e => e.StatusWork).HasColumnName("Status_Work");
            entity.Property(e => e.StreetLine1).HasColumnType("text");
            entity.Property(e => e.StreetLine2).HasColumnType("text");
            entity.Property(e => e.TechnicalId).HasMaxLength(767);
            entity.Property(e => e.TwitterPage)
                .HasColumnType("text")
                .HasColumnName("Twitter_Page");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Website).HasColumnType("text");
            entity.Property(e => e.WhatsAppNo).HasColumnType("text");
            entity.Property(e => e.WhatsAppSessionDate).HasColumnType("datetime");

            

            entity.HasOne(d => d.Branch).WithMany(p => p.Buddies)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK_Buddies_Branch_BranchId");

         

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.BuddyCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_Buddies_Employee_CreatedBy");

           

            entity.HasOne(d => d.Owner).WithMany(p => p.BuddyOwners)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK_Buddies_Employee_OwnerId");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_Buddies_Buddies_ParentId");

            entity.HasOne(d => d.Representative).WithMany(p => p.InverseRepresentative)
                .HasForeignKey(d => d.RepresentativeId)
                .HasConstraintName("FK_Buddies_Buddies_RepresentativeId");

            entity.HasOne(d => d.Technical).WithMany(p => p.InverseTechnical)
                .HasForeignKey(d => d.TechnicalId)
                .HasConstraintName("FK_Buddies_Buddies_TechnicalId");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.BuddyUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK_Buddies_Employee_UpdatedBy");

            
        });

       


        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PRIMARY");

            entity
                .ToTable("employee")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.AccTreeId, "IX_Employee_AccTreeId").IsUnique();

            entity.HasIndex(e => e.AreaId, "IX_Employee_AreaId");

            entity.HasIndex(e => e.BranchId, "IX_Employee_BranchId");

            entity.HasIndex(e => e.CityId, "IX_Employee_CityId");

            entity.HasIndex(e => e.CountryId, "IX_Employee_CountryId");

            entity.HasIndex(e => e.CreatedBy, "IX_Employee_CreatedBy");

            entity.HasIndex(e => e.GovernmentId, "IX_Employee_GovernmentId");

            entity.HasIndex(e => e.UpdatedBy, "IX_Employee_UpdatedBy");

            entity.Property(e => e.Address).HasColumnType("text");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Email).HasColumnType("text");
            entity.Property(e => e.FacebookPage).HasColumnType("text");
            entity.Property(e => e.Fax).HasColumnType("text");
            entity.Property(e => e.FirstName).HasColumnType("text");
            entity.Property(e => e.HomePhone).HasColumnType("text");
            entity.Property(e => e.LastName).HasColumnType("text");
            entity.Property(e => e.LinkedPage).HasColumnType("text");
            entity.Property(e => e.Mobile).HasColumnType("text");
            entity.Property(e => e.OtherMobile).HasColumnType("text");
            entity.Property(e => e.Phone).HasColumnType("text");
            entity.Property(e => e.Photo).HasColumnType("text");
            entity.Property(e => e.RCode)
                .HasColumnType("text")
                .HasColumnName("R_Code");
            entity.Property(e => e.SpecialMark).HasColumnType("text");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UrlPath)
                .HasColumnType("text")
                .HasColumnName("URL_Path");
            entity.Property(e => e.WhatsAppNo).HasColumnType("text");


            entity.HasOne(d => d.Branch).WithMany(p => p.Employees)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK_Employee_Branch_BranchId");

          

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.InverseCreatedByNavigation)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_Employee_Employee_CreatedBy");

            

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.InverseUpdatedByNavigation)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK_Employee_Employee_UpdatedBy");

           
        });



        modelBuilder.Entity<Employeeshift>(entity =>
        {
            entity.HasKey(e => e.EmployeeShiftId).HasName("PRIMARY");

            entity
                .ToTable("employeeshift")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.BranchId, "IX_EmployeeShift_BranchId");

            entity.HasIndex(e => e.EmployeeId, "IX_EmployeeShift_EmployeeId");

            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.StartTime).HasColumnType("datetime");

            entity.HasOne(d => d.Branch).WithMany(p => p.Employeeshifts)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK_EmployeeShift_Branch_BranchId");

            entity.HasOne(d => d.Employee).WithMany(p => p.Employeeshifts)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_EmployeeShift_Employee_EmployeeId");
        });

      

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasKey(e => e.InvoiceId).HasName("PRIMARY");

            entity
                .ToTable("invoice")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.BranchId, "IX_Invoice_BranchId");

            entity.HasIndex(e => e.BuddiesId, "IX_Invoice_BuddiesId");

            entity.HasIndex(e => e.ChefId, "IX_Invoice_Chef_ID");

            entity.HasIndex(e => e.CreatedBy, "IX_Invoice_CreatedBy");

            entity.HasIndex(e => e.DeletedBy, "IX_Invoice_DeletedBy");

            entity.HasIndex(e => e.DeliveryId, "IX_Invoice_DeliveryId");

            entity.HasIndex(e => e.InvoiceCode, "IX_Invoice_InvoiceCode").IsUnique();

            entity.HasIndex(e => e.OrderId, "IX_Invoice_OrderId").IsUnique();

            entity.HasIndex(e => e.SellerId, "IX_Invoice_SellerId");

            entity.HasIndex(e => e.TechnicalId, "IX_Invoice_TechnicalId");

            entity.HasIndex(e => e.ToBranchId, "IX_Invoice_ToBranchId");

            entity.HasIndex(e => e.UpdatedBy, "IX_Invoice_UpdatedBy");

            entity.HasIndex(e => e.WaiterId, "IX_Invoice_WaiterId");

            entity.Property(e => e.BuddiesId).HasMaxLength(767);
            entity.Property(e => e.ChefId)
                .HasMaxLength(767)
                .HasColumnName("Chef_ID");
            entity.Property(e => e.ClientNote).HasColumnType("text");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(767);
            entity.Property(e => e.DeletedBy).HasMaxLength(767);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.DeliveryId).HasMaxLength(767);
            entity.Property(e => e.DriverId)
                .HasColumnType("text")
                .HasColumnName("Driver_ID");
            entity.Property(e => e.EmployeeNote).HasColumnType("text");
            entity.Property(e => e.InvoiceCode).HasMaxLength(767);
            entity.Property(e => e.IsSchedule).HasColumnName("Is_Schedule");
            entity.Property(e => e.Photo).HasColumnType("text");
            entity.Property(e => e.PreparationNotes).HasColumnType("text");
            entity.Property(e => e.ScheduleDate)
                .HasColumnType("datetime")
                .HasColumnName("Schedule_Date");
            entity.Property(e => e.TechnicalId).HasMaxLength(767);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(767);
            entity.Property(e => e.WaiterId).HasMaxLength(767);

            entity.HasOne(d => d.Branch).WithMany(p => p.InvoiceBranches)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK_Invoice_Branch_BranchId");

            entity.HasOne(d => d.Buddies).WithMany(p => p.InvoiceBuddies)
                .HasForeignKey(d => d.BuddiesId)
                .HasConstraintName("FK_Invoice_Buddies_BuddiesId");

            entity.HasOne(d => d.Chef).WithMany(p => p.InvoiceChefs)
                .HasForeignKey(d => d.ChefId)
                .HasConstraintName("FK_Invoice_Buddies_Chef_ID");

           

            entity.HasOne(d => d.Delivery).WithMany(p => p.InvoiceDeliveries)
                .HasForeignKey(d => d.DeliveryId)
                .HasConstraintName("FK_Invoice_Buddies_DeliveryId");

          

            entity.HasOne(d => d.Seller).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.SellerId)
                .HasConstraintName("FK_Invoice_Employee_SellerId");

            entity.HasOne(d => d.Technical).WithMany(p => p.InvoiceTechnicals)
                .HasForeignKey(d => d.TechnicalId)
                .HasConstraintName("FK_Invoice_Buddies_TechnicalId");

            entity.HasOne(d => d.ToBranch).WithMany(p => p.InvoiceToBranches)
                .HasForeignKey(d => d.ToBranchId)
                .HasConstraintName("FK_Invoice_Branch_ToBranchId");

           
            entity.HasOne(d => d.Waiter).WithMany(p => p.InvoiceWaiters)
                .HasForeignKey(d => d.WaiterId)
                .HasConstraintName("FK_Invoice_Buddies_WaiterId");
        });

      

        modelBuilder.Entity<Invoicedetail>(entity =>
        {
            entity.HasKey(e => e.InvoiceDetailsId).HasName("PRIMARY");

            entity
                .ToTable("invoicedetails")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.CreatedBy, "IX_InvoiceDetails_CreatedBy");

            entity.HasIndex(e => e.InvoiceId, "IX_InvoiceDetails_InvoiceId");

            entity.HasIndex(e => e.ProductUnitId, "IX_InvoiceDetails_ProductUnitId");

            entity.HasIndex(e => e.ProductVarintId, "IX_InvoiceDetails_ProductVarintId");

            entity.HasIndex(e => e.ReturnInvoiceId, "IX_InvoiceDetails_ReturnInvoiceId");

            entity.HasIndex(e => e.StockId, "IX_InvoiceDetails_StockId");

            entity.HasIndex(e => e.UpdatedBy, "IX_InvoiceDetails_UpdatedBy");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(767);
            entity.Property(e => e.DeletedBy).HasColumnType("text");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Note).HasColumnType("text");
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(767);

            entity.HasOne(d => d.ProductVarint).WithMany(p => p.Invoicedetails)
                .HasForeignKey(d => d.ProductVarintId)
                .HasConstraintName("FK_InvoiceDetails_ProductVarint_ProductVarintId");
           
        });

      

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PRIMARY");

            entity
                .ToTable("product")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.BranchId, "IX_Product_BranchId");

            entity.HasIndex(e => e.BrandId, "IX_Product_BrandId");

            entity.HasIndex(e => e.ClassificationId, "IX_Product_ClassificationId");

            entity.HasIndex(e => e.CreatedBy, "IX_Product_CreatedBy");

            entity.HasIndex(e => e.MainProductUnitId, "IX_Product_MainProductUnitID");

            entity.HasIndex(e => e.UpdatedBy, "IX_Product_UpdatedBy");

            entity.Property(e => e.Barcode).HasColumnType("text");
            entity.Property(e => e.Code).HasColumnType("text");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.IntBarcode)
                .HasColumnType("text")
                .HasColumnName("Int_Barcode");
            entity.Property(e => e.MainProductUnitId).HasColumnName("MainProductUnitID");
            entity.Property(e => e.Name).HasColumnType("text");
            entity.Property(e => e.Photo).HasColumnType("text");
            entity.Property(e => e.PurchaseDefaultProductUnitId).HasColumnName("PurchaseDefaultProductUnitID");
            entity.Property(e => e.Qrcode)
                .HasColumnType("text")
                .HasColumnName("QRCode");
            entity.Property(e => e.RCode)
                .HasColumnType("text")
                .HasColumnName("R_Code");
            entity.Property(e => e.SalesDefaultProductUnitId).HasColumnName("SalesDefaultProductUnitID");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");

            entity.HasOne(d => d.Branch).WithMany(p => p.Products)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Branch_BranchId");

            

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ProductCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_Product_Employee_CreatedBy");


            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.ProductUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK_Product_Employee_UpdatedBy");
        });

 

        modelBuilder.Entity<Productvarint>(entity =>
        {
            entity.HasKey(e => e.ProductVarintId).HasName("PRIMARY");

            entity
                .ToTable("productvarint")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.BranchId, "IX_ProductVarint_BranchId");

            entity.HasIndex(e => e.CreatedBy, "IX_ProductVarint_CreatedBy");

            entity.HasIndex(e => e.ProductId, "IX_ProductVarint_ProductId");

            entity.HasIndex(e => e.UpdatedBy, "IX_ProductVarint_UpdatedBy");

            entity.Property(e => e.Barcode).HasColumnType("text");
            entity.Property(e => e.CaloriesValue).HasColumnName("Calories_Value");
            entity.Property(e => e.Code).HasColumnType("text");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DefaultSecStock).HasColumnType("text");
            entity.Property(e => e.DefaultStock).HasColumnType("text");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.ImagePath).HasColumnType("text");
            entity.Property(e => e.IntBarcode)
                .HasColumnType("text")
                .HasColumnName("Int_Barcode");
            entity.Property(e => e.IsOrder).HasColumnName("Is_Order");
            entity.Property(e => e.IsPreOrder).HasColumnName("Is_Pre_Order");
            entity.Property(e => e.Name).HasColumnType("text");
            entity.Property(e => e.NewPurchaseDate).HasColumnType("datetime");
            entity.Property(e => e.NewPurchaseTurnOffNote).HasColumnType("text");
            entity.Property(e => e.Photo).HasColumnType("text");
            entity.Property(e => e.PortionPersons).HasColumnName("Portion_Persons");
            entity.Property(e => e.RCode)
                .HasColumnType("text")
                .HasColumnName("R_Code");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");

            entity.HasOne(d => d.Branch).WithMany(p => p.Productvarints)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK_ProductVarint_Branch_BranchId");

           
            entity.HasOne(d => d.Product).WithMany(p => p.Productvarints)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ProductVarint_Product_ProductId");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.ProductvarintUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK_ProductVarint_Employee_UpdatedBy");

            entity.HasMany(d => d.Buddies).WithMany(p => p.ProductVarints)
                .UsingEntity<Dictionary<string, object>>(
                    "Supplierproductvarint",
                    r => r.HasOne<Buddy>().WithMany()
                        .HasForeignKey("BuddiesId")
                        .HasConstraintName("FK_SupplierProductVarint_Buddies_BuddiesId"),
                    l => l.HasOne<Productvarint>().WithMany()
                        .HasForeignKey("ProductVarintId")
                        .HasConstraintName("FK_SupplierProductVarint_ProductVarint_ProductVarintId"),
                    j =>
                    {
                        j.HasKey("ProductVarintId", "BuddiesId")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("supplierproductvarint")
                            .HasCharSet("latin1")
                            .UseCollation("latin1_swedish_ci");
                        j.HasIndex(new[] { "BuddiesId" }, "IX_SupplierProductVarint_BuddiesId");
                    });
        });

      


       
       
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
