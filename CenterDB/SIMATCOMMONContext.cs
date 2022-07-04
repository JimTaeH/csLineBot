using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class SIMATCOMMONContext : DbContext
    {
        public SIMATCOMMONContext()
        {
        }

        public SIMATCOMMONContext(DbContextOptions<SIMATCOMMONContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Access> Accesses { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<BlackListApp> BlackListApps { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Content> Contents { get; set; }
        public virtual DbSet<ContentPermission> ContentPermissions { get; set; }
        public virtual DbSet<ContractPeriod> ContractPeriods { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Documentation> Documentations { get; set; }
        public virtual DbSet<EmailCount> EmailCounts { get; set; }
        public virtual DbSet<HookLog> HookLogs { get; set; }
        public virtual DbSet<License> Licenses { get; set; }
        public virtual DbSet<LineRegister> LineRegisters { get; set; }
        public virtual DbSet<MailConfig> MailConfigs { get; set; }
        public virtual DbSet<Maintenance> Maintenances { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MenuAction> MenuActions { get; set; }
        public virtual DbSet<Mexpense> Mexpenses { get; set; }
        public virtual DbSet<Mmodule> Mmodules { get; set; }
        public virtual DbSet<ObjectList> ObjectLists { get; set; }
        public virtual DbSet<Ocomp> Ocomps { get; set; }
        public virtual DbSet<Office> Offices { get; set; }
        public virtual DbSet<Ohhsm> Ohhsms { get; set; }
        public virtual DbSet<OrderType> OrderTypes { get; set; }
        public virtual DbSet<Ouser> Ousers { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<Period> Periods { get; set; }
        public virtual DbSet<PreOrder> PreOrders { get; set; }
        public virtual DbSet<RequestReport> RequestReports { get; set; }
        public virtual DbSet<RoleAccess> RoleAccesses { get; set; }
        public virtual DbSet<ServiceUrl> ServiceUrls { get; set; }
        public virtual DbSet<Sqlmapoutput> Sqlmapoutputs { get; set; }
        public virtual DbSet<TicketDetail> TicketDetails { get; set; }
        public virtual DbSet<TicketMessage> TicketMessages { get; set; }
        public virtual DbSet<TicketUpload> TicketUploads { get; set; }
        public virtual DbSet<Timgcancel> Timgcancels { get; set; }
        public virtual DbSet<Tpckdetail> Tpckdetails { get; set; }
        public virtual DbSet<Tpckheader> Tpckheaders { get; set; }
        public virtual DbSet<Training> Trainings { get; set; }
        public virtual DbSet<UsageOnDisk> UsageOnDisks { get; set; }
        public virtual DbSet<View1> View1s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=27.254.207.172;Database=SIMAT-COMMON;User=sa;Password=skyfr0gDEV");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Access>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.Property(e => e.ActionId)
                    .HasMaxLength(10)
                    .HasColumnName("ActionID")
                    .IsFixedLength(true);

                entity.Property(e => e.MenuId)
                    .HasMaxLength(10)
                    .HasColumnName("MenuID")
                    .IsFixedLength(true);

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("RoleID")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.Accesses)
                    .HasForeignKey(d => d.ActionId)
                    .HasConstraintName("FK_Accesses_Actions");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.Accesses)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_Accesses_Menus");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accesses)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Accesses_Roles");
            });

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .HasColumnName("UserID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.No).ValueGeneratedOnAdd();

                entity.Property(e => e.OfficeId)
                    .HasMaxLength(10)
                    .HasColumnName("OfficeID")
                    .IsFixedLength(true);

                entity.Property(e => e.Password).HasMaxLength(20);

                entity.Property(e => e.Prefix)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.RoleId)
                    .HasMaxLength(10)
                    .HasColumnName("RoleID")
                    .IsFixedLength(true);

                entity.Property(e => e.Telephone).HasMaxLength(20);

                entity.Property(e => e.UserName).HasMaxLength(20);

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("FK_Accounts_Offices");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Accounts_Roles");
            });

            modelBuilder.Entity<BlackListApp>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("BlackListApp");

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => new { e.No, e.CustomerId })
                    .HasName("PK__Contacts__A85E32E31BC821DD");

                entity.Property(e => e.No).ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.MobileNumber).HasMaxLength(20);

                entity.Property(e => e.OfficeTel).HasMaxLength(20);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contacts_Customers");
            });

            modelBuilder.Entity<Content>(entity =>
            {
                entity.ToTable("Content");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.PublishDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ContentPermission>(entity =>
            {
                entity.HasKey(e => new { e.ContentId, e.CustomerId });

                entity.ToTable("ContentPermission");

                entity.Property(e => e.CustomerId).HasMaxLength(20);
            });

            modelBuilder.Entity<ContractPeriod>(entity =>
            {
                entity.HasKey(e => e.PeriodId);

                entity.Property(e => e.PeriodId)
                    .HasMaxLength(10)
                    .HasColumnName("PeriodID");

                entity.Property(e => e.No).ValueGeneratedOnAdd();

                entity.Property(e => e.PeriodName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.CleanDate).HasColumnType("datetime");

                entity.Property(e => e.CompanyGroup).HasMaxLength(100);

                entity.Property(e => e.ContactName).HasMaxLength(100);

                entity.Property(e => e.ContractId)
                    .HasMaxLength(10)
                    .HasColumnName("ContractID");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerAccountNo).HasMaxLength(50);

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EncryptKey).HasMaxLength(50);

                entity.Property(e => e.Gps)
                    .HasMaxLength(100)
                    .HasColumnName("GPS");

                entity.Property(e => e.No).ValueGeneratedOnAdd();

                entity.Property(e => e.Tel).HasMaxLength(20);

                entity.Property(e => e.TrackTraceName).HasMaxLength(50);

                entity.Property(e => e.UpdateBy).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Vrpadvance).HasColumnName("VRPAdvance");
            });

            modelBuilder.Entity<Documentation>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Cdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CDate");

                entity.Property(e => e.CurrentRun).HasMaxLength(10);

                entity.Property(e => e.Format).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.No).ValueGeneratedOnAdd();

                entity.Property(e => e.Prefix).HasMaxLength(4);

                entity.Property(e => e.StartRun).HasMaxLength(10);
            });

            modelBuilder.Entity<EmailCount>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("PK__EmailCou__3214D4A82EDAF651");

                entity.ToTable("EmailCount");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmailType).HasComment("1 = Email service; 2 = Email R");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HookLog>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("HookLog");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.Jobno)
                    .HasMaxLength(50)
                    .HasColumnName("jobno");

                entity.Property(e => e.Jobstatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("jobstatus")
                    .IsFixedLength(true);

                entity.Property(e => e.Jsonbody)
                    .HasColumnType("text")
                    .HasColumnName("JSONBody");

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.RequestUri)
                    .HasColumnType("text")
                    .HasColumnName("RequestURI");

                entity.Property(e => e.Response).HasColumnType("text");

                entity.Property(e => e.ResponseDate).HasColumnType("datetime");

                entity.Property(e => e.ResponseStatus).HasColumnType("text");
            });

            modelBuilder.Entity<License>(entity =>
            {
                entity.HasKey(e => new { e.LicenseId, e.OrderId });

                entity.HasIndex(e => e.DeviceId, "DeviceID-20170818-091542");

                entity.HasIndex(e => e.ExpireDate, "ExpireDate-20170818-091602");

                entity.HasIndex(e => e.ExpireDate, "IX_Licenses_ExpireDate");

                entity.HasIndex(e => e.IsActive, "IX_Licenses_IsActive");

                entity.HasIndex(e => new { e.IsActive, e.DeviceId }, "IX_Licenses_IsActive_DeviceID");

                entity.HasIndex(e => e.IsActive, "IsActive-20170818-091622");

                entity.HasIndex(e => e.LicenseId, "LicenseID-20170818-091401");

                entity.HasIndex(e => e.OrderId, "OrderID-20170818-091520");

                entity.Property(e => e.LicenseId)
                    .HasMaxLength(50)
                    .HasColumnName("LicenseID");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(20)
                    .HasColumnName("OrderID");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(20)
                    .HasColumnName("DeviceID");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.No).ValueGeneratedOnAdd();

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Licenses)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Licenses_PreOrders1");
            });

            modelBuilder.Entity<LineRegister>(entity =>
            {
                entity.ToTable("LineRegister");

                entity.Property(e => e.Bpcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bpcode");

                entity.Property(e => e.ContactId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contactId");

                entity.Property(e => e.Dbcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DBcode");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("displayName");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.LastMsgSent)
                    .HasColumnType("datetime")
                    .HasColumnName("lastMsgSent");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registerDate");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId");
            });

            modelBuilder.Entity<MailConfig>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__MailConf__1788CCAC2A164134");

                entity.ToTable("MailConfig");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .HasColumnName("UserID");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.No).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Maintenance>(entity =>
            {
                entity.Property(e => e.MaintenanceId)
                    .HasMaxLength(20)
                    .HasColumnName("MaintenanceID");

                entity.Property(e => e.BackupDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.MenuId)
                    .HasMaxLength(10)
                    .HasColumnName("MenuID")
                    .IsFixedLength(true);

                entity.Property(e => e.Action).HasMaxLength(50);

                entity.Property(e => e.Controller).HasMaxLength(50);

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.MenuName).HasMaxLength(20);

                entity.Property(e => e.No).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MenuAction>(entity =>
            {
                entity.HasKey(e => e.ActionId)
                    .HasName("PK_Action");

                entity.Property(e => e.ActionId)
                    .HasMaxLength(10)
                    .HasColumnName("ActionID")
                    .IsFixedLength(true);

                entity.Property(e => e.ActionName).HasMaxLength(20);

                entity.Property(e => e.No).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Mexpense>(entity =>
            {
                entity.HasKey(e => e.Itemno)
                    .HasName("PK__MExpense__56A3EBA03493CFA7");

                entity.ToTable("MExpense");

                entity.Property(e => e.Itemno).HasColumnName("itemno");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Itemname)
                    .HasMaxLength(100)
                    .HasColumnName("itemname");
            });

            modelBuilder.Entity<Mmodule>(entity =>
            {
                entity.ToTable("mmodule");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ObjectList>(entity =>
            {
                entity.HasKey(e => new { e.GroupCode, e.Code });

                entity.ToTable("ObjectList");

                entity.Property(e => e.GroupCode).HasMaxLength(50);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(150);
            });

            modelBuilder.Entity<Ocomp>(entity =>
            {
                entity.HasKey(e => new { e.No, e.CompId });

                entity.ToTable("OCOMP");

                entity.HasIndex(e => e.CompId, "NonClusteredIndex-20170509-161219");

                entity.Property(e => e.No)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("no");

                entity.Property(e => e.CompId)
                    .HasMaxLength(12)
                    .HasColumnName("compID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("address");

                entity.Property(e => e.AmountHh).HasColumnName("amountHH");

                entity.Property(e => e.AmountUser).HasColumnName("amountUser");

                entity.Property(e => e.Bakdate)
                    .HasColumnType("datetime")
                    .HasColumnName("bakdate");

                entity.Property(e => e.Bakterms).HasColumnName("bakterms");

                entity.Property(e => e.CompName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("compName");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("createBy");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.Dbtype)
                    .HasMaxLength(50)
                    .HasColumnName("dbtype");

                entity.Property(e => e.ExpireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("expireDate");

                entity.Property(e => e.Lat)
                    .HasColumnType("decimal(11, 8)")
                    .HasColumnName("lat");

                entity.Property(e => e.Lng)
                    .HasColumnType("decimal(11, 8)")
                    .HasColumnName("lng");

                entity.Property(e => e.Packcode)
                    .HasMaxLength(50)
                    .HasColumnName("packcode");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.PackcodeNavigation)
                    .WithMany(p => p.Ocomps)
                    .HasForeignKey(d => d.Packcode)
                    .HasConstraintName("FK_OCOMP_tpckheader");
            });

            modelBuilder.Entity<Office>(entity =>
            {
                entity.Property(e => e.OfficeId)
                    .HasMaxLength(10)
                    .HasColumnName("OfficeID")
                    .IsFixedLength(true);

                entity.Property(e => e.No).ValueGeneratedOnAdd();

                entity.Property(e => e.OfficeName).HasMaxLength(100);
            });

            modelBuilder.Entity<Ohhsm>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("PK_OCOMHH");

                entity.ToTable("OHHSM");

                entity.HasIndex(e => e.Hhid, "NonClusteredIndex-20170509-161105");

                entity.HasIndex(e => e.CompId, "NonClusteredIndex-20170509-161117");

                entity.Property(e => e.No).HasColumnName("no");

                entity.Property(e => e.CompId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("compID");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("createBy");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.ExpireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("expireDate");

                entity.Property(e => e.Hhid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("hhid");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<OrderType>(entity =>
            {
                entity.Property(e => e.OrderTypeId)
                    .HasMaxLength(10)
                    .HasColumnName("OrderTypeID");

                entity.Property(e => e.No).ValueGeneratedOnAdd();

                entity.Property(e => e.OrderTypeName).HasMaxLength(20);
            });

            modelBuilder.Entity<Ouser>(entity =>
            {
                entity.HasKey(e => new { e.No, e.UserId });

                entity.ToTable("OUSER");

                entity.Property(e => e.No)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("no");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .HasColumnName("userID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("userName");

                entity.Property(e => e.UserPass)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("userPass");
            });

            modelBuilder.Entity<Package>(entity =>
            {
                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.CreateBy).HasMaxLength(20);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.PackageTypeId).HasColumnName("PackageTypeID");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Period>(entity =>
            {
                entity.Property(e => e.PeriodId)
                    .HasMaxLength(10)
                    .HasColumnName("PeriodID");

                entity.Property(e => e.No).ValueGeneratedOnAdd();

                entity.Property(e => e.PeriodForm).HasMaxLength(50);

                entity.Property(e => e.PeriodName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PeriodType).HasMaxLength(50);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<PreOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.HasIndex(e => e.CustomerId, "CustomerID-20180110-173008");

                entity.HasIndex(e => e.CreateDate, "IX_PreOrders_CreateDate");

                entity.HasIndex(e => new { e.IsApprove, e.OrderTypeId }, "IX_PreOrders_IsApprove_OrderTypeID");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(20)
                    .HasColumnName("OrderID");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AfterSaleId)
                    .HasMaxLength(20)
                    .HasColumnName("AfterSaleID");

                entity.Property(e => e.ApproveBy).HasMaxLength(50);

                entity.Property(e => e.ApproveDate).HasColumnType("datetime");

                entity.Property(e => e.AttachFileName).HasMaxLength(50);

                entity.Property(e => e.BillingPeriod)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ChargingNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreditTerm)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.LicenseStartDate).HasColumnType("datetime");

                entity.Property(e => e.No).ValueGeneratedOnAdd();

                entity.Property(e => e.OrderTypeId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("OrderTypeID");

                entity.Property(e => e.PackageChannelId).HasColumnName("PackageChannelID");

                entity.Property(e => e.PackageClassId).HasColumnName("PackageClassID");

                entity.Property(e => e.PackageSimId).HasColumnName("PackageSimID");

                entity.Property(e => e.PeriodId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("PeriodID");

                entity.Property(e => e.RecSaleId)
                    .HasMaxLength(20)
                    .HasColumnName("RecSaleID");

                entity.Property(e => e.ReferenceCode).HasMaxLength(20);

                entity.Property(e => e.SaleId)
                    .HasMaxLength(20)
                    .HasColumnName("SaleID");

                entity.Property(e => e.State)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.TermStorage).HasMaxLength(50);

                entity.Property(e => e.UpdateBy).HasMaxLength(20);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.PreOrders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_PreOrders_Customers");

                entity.HasOne(d => d.OrderType)
                    .WithMany(p => p.PreOrders)
                    .HasForeignKey(d => d.OrderTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PreOrders_OrderTypes");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.PreOrders)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PreOrders_ContractPeriods");

                entity.HasOne(d => d.PeriodNavigation)
                    .WithMany(p => p.PreOrders)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PreOrders_Periods");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PreOrders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_PreOrders_Accounts");
            });

            modelBuilder.Entity<RequestReport>(entity =>
            {
                entity.ToTable("RequestReport");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompId)
                    .HasMaxLength(50)
                    .HasColumnName("compID");

                entity.Property(e => e.ReportName)
                    .HasMaxLength(50)
                    .HasColumnName("reportName");

                entity.Property(e => e.RequestDateend)
                    .HasColumnType("datetime")
                    .HasColumnName("requestDateend");

                entity.Property(e => e.RequestDatestart)
                    .HasColumnType("datetime")
                    .HasColumnName("requestDatestart");

                entity.Property(e => e.RequestQuery).HasColumnName("requestQuery");
            });

            modelBuilder.Entity<RoleAccess>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK_Roles");

                entity.Property(e => e.RoleId)
                    .HasMaxLength(10)
                    .HasColumnName("RoleID")
                    .IsFixedLength(true);

                entity.Property(e => e.No).ValueGeneratedOnAdd();

                entity.Property(e => e.Rolename).HasMaxLength(20);
            });

            modelBuilder.Entity<ServiceUrl>(entity =>
            {
                entity.HasKey(e => e.CompanyCode);

                entity.ToTable("ServiceUrl");

                entity.Property(e => e.CompanyCode).HasMaxLength(50);

                entity.Property(e => e.Base)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Interface)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Node)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.NodeApi)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Soap)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Socket)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Sqlmapoutput>(entity =>
            {
                entity.ToTable("sqlmapoutput");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasMaxLength(4000)
                    .HasColumnName("data");
            });

            modelBuilder.Entity<TicketDetail>(entity =>
            {
                entity.Property(e => e.AgentRoleId).HasColumnName("AgentRoleID");

                entity.Property(e => e.TicketId).HasColumnName("TicketID");
            });

            modelBuilder.Entity<TicketMessage>(entity =>
            {
                entity.HasIndex(e => e.ForId, "IX_TicketMessages_ForID");

                entity.Property(e => e.ForId).HasColumnName("ForID");

                entity.Property(e => e.TicketId).HasColumnName("TicketID");

                entity.HasOne(d => d.For)
                    .WithMany(p => p.TicketMessages)
                    .HasForeignKey(d => d.ForId);
            });

            modelBuilder.Entity<TicketUpload>(entity =>
            {
                entity.HasIndex(e => e.ForId, "IX_TicketUploads_ForID");

                entity.Property(e => e.ForId).HasColumnName("ForID");

                entity.Property(e => e.TicketId).HasColumnName("TicketID");

                entity.HasOne(d => d.For)
                    .WithMany(p => p.TicketUploads)
                    .HasForeignKey(d => d.ForId);
            });

            modelBuilder.Entity<Timgcancel>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("timgcancel");

                entity.Property(e => e.No).HasColumnName("no");

                entity.Property(e => e.Compid)
                    .HasMaxLength(50)
                    .HasColumnName("compid");

                entity.Property(e => e.Imagename)
                    .HasMaxLength(255)
                    .HasColumnName("imagename");

                entity.Property(e => e.Path)
                    .HasMaxLength(50)
                    .HasColumnName("path");
            });

            modelBuilder.Entity<Tpckdetail>(entity =>
            {
                entity.HasKey(e => new { e.Packcode, e.Moduleid })
                    .HasName("PK_tpackdetail_1");

                entity.ToTable("tpckdetail");

                entity.Property(e => e.Packcode)
                    .HasMaxLength(50)
                    .HasColumnName("packcode");

                entity.Property(e => e.Moduleid).HasColumnName("moduleid");

                entity.Property(e => e.No)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("no");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.Tpckdetails)
                    .HasForeignKey(d => d.Moduleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tpackdetail_mmodule");

                entity.HasOne(d => d.PackcodeNavigation)
                    .WithMany(p => p.Tpckdetails)
                    .HasForeignKey(d => d.Packcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tpackdetail_tpackheader");
            });

            modelBuilder.Entity<Tpckheader>(entity =>
            {
                entity.HasKey(e => e.Packcode)
                    .HasName("PK_tpackheader");

                entity.ToTable("tpckheader");

                entity.Property(e => e.Packcode)
                    .HasMaxLength(50)
                    .HasColumnName("packcode");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Packname)
                    .HasMaxLength(100)
                    .HasColumnName("packname");

                entity.Property(e => e.Price)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("price");
            });

            modelBuilder.Entity<Training>(entity =>
            {
                entity.HasKey(e => e.TraningId);

                entity.Property(e => e.TraningId)
                    .HasMaxLength(10)
                    .HasColumnName("TraningID");

                entity.Property(e => e.ClassName).HasMaxLength(100);

                entity.Property(e => e.CreateBy).HasMaxLength(20);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.No).ValueGeneratedOnAdd();

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdateBy).HasMaxLength(20);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UsageOnDisk>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__UsageOnD__A4AE64B817F790F9");

                entity.ToTable("UsageOnDisk");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(10)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MaxSize).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.No).ValueGeneratedOnAdd();

                entity.Property(e => e.Usage).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_1");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.CustomerName).HasMaxLength(100);

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(20)
                    .HasColumnName("DeviceID");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.LicenseId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("LicenseID");

                entity.Property(e => e.PeriodName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
