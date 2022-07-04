using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MyLineBot.Models
{
    public partial class _00008Context : DbContext
    {
        public _00008Context()
        {
        }

        public _00008Context(DbContextOptions<_00008Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AccessTypeJob> AccessTypeJobs { get; set; }
        public virtual DbSet<AlertSm> AlertSms { get; set; }
        public virtual DbSet<Atran> Atrans { get; set; }
        public virtual DbSet<Auditlog> Auditlogs { get; set; }
        public virtual DbSet<Btran> Btrans { get; set; }
        public virtual DbSet<Cmileage> Cmileages { get; set; }
        public virtual DbSet<CodeItem> CodeItems { get; set; }
        public virtual DbSet<Ctran> Ctrans { get; set; }
        public virtual DbSet<DeviceType> DeviceTypes { get; set; }
        public virtual DbSet<DriverSkillMaster> DriverSkillMasters { get; set; }
        public virtual DbSet<ExportLog> ExportLogs { get; set; }
        public virtual DbSet<ExportPdfqueue> ExportPdfqueues { get; set; }
        public virtual DbSet<HookStatusLog> HookStatusLogs { get; set; }
        public virtual DbSet<ImportLog> ImportLogs { get; set; }
        public virtual DbSet<LineMsgLog> LineMsgLogs { get; set; }
        public virtual DbSet<LogsFile> LogsFiles { get; set; }
        public virtual DbSet<Maction> Mactions { get; set; }
        public virtual DbSet<MailLog> MailLogs { get; set; }
        public virtual DbSet<Maintenance> Maintenances { get; set; }
        public virtual DbSet<Mapp> Mapps { get; set; }
        public virtual DbSet<MauditType> MauditTypes { get; set; }
        public virtual DbSet<Mbpd> Mbpds { get; set; }
        public virtual DbSet<Mcontact> Mcontacts { get; set; }
        public virtual DbSet<Mcstatus> Mcstatuses { get; set; }
        public virtual DbSet<Mcust> Mcusts { get; set; }
        public virtual DbSet<Mdocrun> Mdocruns { get; set; }
        public virtual DbSet<Mexpense> Mexpenses { get; set; }
        public virtual DbSet<Mgstatus> Mgstatuses { get; set; }
        public virtual DbSet<Mhhd> Mhhds { get; set; }
        public virtual DbSet<Mhhstatus> Mhhstatuses { get; set; }
        public virtual DbSet<Mholiday> Mholidays { get; set; }
        public virtual DbSet<Mmaintenance> Mmaintenances { get; set; }
        public virtual DbSet<Mmilestone> Mmilestones { get; set; }
        public virtual DbSet<Mpolygon> Mpolygons { get; set; }
        public virtual DbSet<Mreason> Mreasons { get; set; }
        public virtual DbSet<Msconf> Msconfs { get; set; }
        public virtual DbSet<Mspeedlimit> Mspeedlimits { get; set; }
        public virtual DbSet<Msqa> Msqas { get; set; }
        public virtual DbSet<Mstype> Mstypes { get; set; }
        public virtual DbSet<Mtoken> Mtokens { get; set; }
        public virtual DbSet<Mtran> Mtrans { get; set; }
        public virtual DbSet<Multicontact> Multicontacts { get; set; }
        public virtual DbSet<Multilanguage> Multilanguages { get; set; }
        public virtual DbSet<Muser> Musers { get; set; }
        public virtual DbSet<MuserLog> MuserLogs { get; set; }
        public virtual DbSet<Mzone> Mzones { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PlaningConfig> PlaningConfigs { get; set; }
        public virtual DbSet<Planning> Plannings { get; set; }
        public virtual DbSet<PointApproval> PointApprovals { get; set; }
        public virtual DbSet<RePassLog> RePassLogs { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<Satisfaction> Satisfactions { get; set; }
        public virtual DbSet<SkillMaster> SkillMasters { get; set; }
        public virtual DbSet<TbZone> TbZones { get; set; }
        public virtual DbSet<TbmAction> TbmActions { get; set; }
        public virtual DbSet<TbmAlarm> TbmAlarms { get; set; }
        public virtual DbSet<TbmCustomertype> TbmCustomertypes { get; set; }
        public virtual DbSet<TbmGroup> TbmGroups { get; set; }
        public virtual DbSet<TbmMenu> TbmMenus { get; set; }
        public virtual DbSet<TbmModule> TbmModules { get; set; }
        public virtual DbSet<TbmProvince> TbmProvinces { get; set; }
        public virtual DbSet<TbmQueuestatus> TbmQueuestatuses { get; set; }
        public virtual DbSet<TbrGaccess> TbrGaccesses { get; set; }
        public virtual DbSet<TbsAction> TbsActions { get; set; }
        public virtual DbSet<TbsAlarm> TbsAlarms { get; set; }
        public virtual DbSet<TbsAlert> TbsAlerts { get; set; }
        public virtual DbSet<TbsRoleDetail> TbsRoleDetails { get; set; }
        public virtual DbSet<TbsRoleHeader> TbsRoleHeaders { get; set; }
        public virtual DbSet<TbtShipment> TbtShipments { get; set; }
        public virtual DbSet<TitemType> TitemTypes { get; set; }
        public virtual DbSet<Tjitem> Tjitems { get; set; }
        public virtual DbSet<Tjob> Tjobs { get; set; }
        public virtual DbSet<TjobExp> TjobExps { get; set; }
        public virtual DbSet<Tjobimage> Tjobimages { get; set; }
        public virtual DbSet<Tjobreject> Tjobrejects { get; set; }
        public virtual DbSet<Tjobtimeslot> Tjobtimeslots { get; set; }
        public virtual DbSet<Tmad> Tmads { get; set; }
        public virtual DbSet<Tmilestone> Tmilestones { get; set; }
        public virtual DbSet<Tphoto> Tphotos { get; set; }
        public virtual DbSet<Tpoi> Tpois { get; set; }
        public virtual DbSet<Tpoiprove> Tpoiproves { get; set; }
        public virtual DbSet<Tqaitem> Tqaitems { get; set; }
        public virtual DbSet<Tqueue> Tqueues { get; set; }
        public virtual DbSet<Tsale> Tsales { get; set; }
        public virtual DbSet<VehicleHistory> VehicleHistorys { get; set; }
        public virtual DbSet<VehicleHistoryDetail> VehicleHistoryDetails { get; set; }
        public virtual DbSet<VehiclePlanning> VehiclePlannings { get; set; }
        public virtual DbSet<VehiclePlanningRoute> VehiclePlanningRoutes { get; set; }
        public virtual DbSet<VehiclePlanningRoutesDetail> VehiclePlanningRoutesDetails { get; set; }
        public virtual DbSet<VehiclePlanningUnAssign> VehiclePlanningUnAssigns { get; set; }
        public virtual DbSet<Vision> Visions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=27.254.207.172;Database=00008;User=sa;Password=skyfr0gDEV");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Thai_CI_AS");

            modelBuilder.Entity<AccessTypeJob>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.Property(e => e.CreateBy).HasMaxLength(20);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.JobTypeId).HasColumnName("JobTypeID");

                entity.Property(e => e.UpdaeBy).HasMaxLength(20);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<AlertSm>(entity =>
            {
                entity.HasKey(e => e.JobNo);

                entity.ToTable("AlertSMS");

                entity.Property(e => e.JobNo).HasMaxLength(50);

                entity.Property(e => e.IsSmsopen).HasColumnName("IsSMSOpen");

                entity.Property(e => e.IsSmsreceive).HasColumnName("IsSMSReceive");

                entity.Property(e => e.IsSmsreject).HasColumnName("IsSMSReject");

                entity.Property(e => e.IsSmssent).HasColumnName("IsSMSSent");

                entity.Property(e => e.SmsalertNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SMSAlertNumber");

                entity.Property(e => e.SmssenderName)
                    .HasMaxLength(50)
                    .HasColumnName("SMSSenderName");
            });

            modelBuilder.Entity<Atran>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("ATrans");

                entity.Property(e => e.ActionApp)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.Hhid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("HHID");

                entity.Property(e => e.Lati).HasColumnType("decimal(11, 8)");

                entity.Property(e => e.Long).HasColumnType("decimal(11, 8)");

                entity.Property(e => e.Nimage)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NImage");
            });

            modelBuilder.Entity<Auditlog>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("PK__Auditlog__3214D4A8ECA9FE65");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeleteFlag).HasColumnName("deleteFlag");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TypeID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("userName");
            });

            modelBuilder.Entity<Btran>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("BTrans");

                entity.Property(e => e.ActionApp)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Bpcode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("BPCode");

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.Gstatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GStatus")
                    .IsFixedLength(true);

                entity.Property(e => e.Hhid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("HHID");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.Lati).HasColumnType("decimal(11, 8)");

                entity.Property(e => e.Long).HasColumnType("decimal(11, 8)");
            });

            modelBuilder.Entity<Cmileage>(entity =>
            {
                entity.HasKey(e => new { e.No, e.Hhid });

                entity.ToTable("CMileage");

                entity.Property(e => e.No).ValueGeneratedOnAdd();

                entity.Property(e => e.Hhid)
                    .HasMaxLength(20)
                    .HasColumnName("HHID");

                entity.Property(e => e.Cmileage1).HasColumnName("CMileage");

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.Lat).HasColumnType("decimal(11, 8)");

                entity.Property(e => e.Long).HasColumnType("decimal(11, 8)");

                entity.Property(e => e.Mmileage).HasColumnName("MMileage");
            });

            modelBuilder.Entity<CodeItem>(entity =>
            {
                entity.HasKey(e => e.CodeItem1)
                    .HasName("PK__CodeItem__1EA3C946BC75D717");

                entity.Property(e => e.CodeItem1)
                    .HasMaxLength(100)
                    .HasColumnName("CodeItem");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ItemTypeCode).HasMaxLength(255);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Ctran>(entity =>
            {
                entity.HasKey(e => new { e.No, e.Hhid });

                entity.ToTable("CTrans");

                entity.Property(e => e.No).ValueGeneratedOnAdd();

                entity.Property(e => e.Hhid)
                    .HasMaxLength(20)
                    .HasColumnName("HHID");

                entity.Property(e => e.ActionApp)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ActualTime).HasColumnType("datetime");

                entity.Property(e => e.Bpcode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("BPCode");

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.Cstatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CStatus")
                    .IsFixedLength(true)
                    .HasComment("\"1\" = Car On, \"2\" = Car Off");

                entity.Property(e => e.Dcstatus)
                    .HasColumnType("datetime")
                    .HasColumnName("DCStatus");

                entity.Property(e => e.Gstatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GStatus")
                    .IsFixedLength(true);

                entity.Property(e => e.Hhstatus)
                    .HasMaxLength(50)
                    .HasColumnName("hhstatus");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.Jobno)
                    .HasMaxLength(20)
                    .HasColumnName("jobno");

                entity.Property(e => e.Lati).HasColumnType("decimal(11, 8)");

                entity.Property(e => e.Long).HasColumnType("decimal(11, 8)");
            });

            modelBuilder.Entity<DeviceType>(entity =>
            {
                entity.HasKey(e => e.DriverTypeId);

                entity.ToTable("DeviceType");

                entity.Property(e => e.DriverTypeId).HasColumnName("DriverTypeID");

                entity.Property(e => e.Class).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<DriverSkillMaster>(entity =>
            {
                entity.HasKey(e => e.DriverMasterCode);

                entity.ToTable("DriverSkillMaster");

                entity.Property(e => e.DriverMasterCode).HasColumnName("driver_master_code");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.Hhids)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SkillMaster)
                    .HasMaxLength(50)
                    .HasColumnName("skill_master");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("update_date");
            });

            modelBuilder.Entity<ExportLog>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("PK__ExportLo__3214D4A806CD04F7");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ExportBy).HasMaxLength(20);

                entity.Property(e => e.ExportDate).HasColumnType("datetime");

                entity.Property(e => e.ExportType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.JobNo).HasMaxLength(50);

                entity.Property(e => e.JobStatus).HasMaxLength(20);

                entity.Property(e => e.ReportId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ReportID");
            });

            modelBuilder.Entity<ExportPdfqueue>(entity =>
            {
                entity.HasKey(e => e.Jobno);

                entity.ToTable("ExportPDFQueue");

                entity.Property(e => e.Jobno)
                    .HasMaxLength(50)
                    .HasColumnName("jobno");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<HookStatusLog>(entity =>
            {
                entity.HasKey(e => e.Jobno);

                entity.ToTable("HookStatusLog");

                entity.Property(e => e.Jobno)
                    .HasMaxLength(50)
                    .HasColumnName("jobno");

                entity.Property(e => e.NotFound).HasColumnName("notFound");

                entity.Property(e => e.StatusA).HasColumnName("statusA");

                entity.Property(e => e.StatusB).HasColumnName("statusB");

                entity.Property(e => e.StatusC).HasColumnName("statusC");

                entity.Property(e => e.StatusE).HasColumnName("statusE");

                entity.Property(e => e.StatusP).HasColumnName("statusP");

                entity.Property(e => e.StatusR).HasColumnName("statusR");

                entity.Property(e => e.StatusS).HasColumnName("statusS");
            });

            modelBuilder.Entity<ImportLog>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("PK__ImportLo__3214D4A80A9D95DB");

                entity.HasIndex(e => new { e.ImportStatus, e.CreateDate, e.Hhid }, "HHID_ImportStatus_CreateDate");

                entity.Property(e => e.CreateBy).HasMaxLength(20);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Hhid)
                    .HasMaxLength(20)
                    .HasColumnName("HHID");

                entity.Property(e => e.JobNo).HasMaxLength(50);
            });

            modelBuilder.Entity<LineMsgLog>(entity =>
            {
                entity.Property(e => e.PostedData)
                    .HasColumnType("text")
                    .HasColumnName("postedData");

                entity.Property(e => e.ReplyToken)
                    .IsUnicode(false)
                    .HasColumnName("replyToken");

                entity.Property(e => e.SentTime)
                    .HasColumnType("datetime")
                    .HasColumnName("sentTime");

                entity.Property(e => e.ToUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("toUser");
            });

            modelBuilder.Entity<LogsFile>(entity =>
            {
                entity.ToTable("LogsFile");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apiname)
                    .HasMaxLength(100)
                    .HasColumnName("apiname");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .HasColumnName("createby");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.Descriptions).HasColumnName("descriptions");

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.Refcode)
                    .HasMaxLength(50)
                    .HasColumnName("refcode");

                entity.Property(e => e.Resmessage)
                    .HasMaxLength(255)
                    .HasColumnName("resmessage");

                entity.Property(e => e.Statuscode).HasColumnName("statuscode");
            });

            modelBuilder.Entity<Maction>(entity =>
            {
                entity.HasKey(e => e.ActionId)
                    .HasName("PK__Maction__FFE3F4B926488B2D");

                entity.ToTable("Maction");

                entity.Property(e => e.ActionId)
                    .ValueGeneratedNever()
                    .HasColumnName("ActionID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.TypeId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TypeID");
            });

            modelBuilder.Entity<MailLog>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("PK__MailLogs__3214D4A80E6E26BF");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.JobNo).HasMaxLength(50);

                entity.Property(e => e.JobStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.SendFrom).HasMaxLength(100);
            });

            modelBuilder.Entity<Maintenance>(entity =>
            {
                entity.HasKey(e => e.MaId);

                entity.ToTable("Maintenance");

                entity.Property(e => e.Actiondate)
                    .HasColumnType("datetime")
                    .HasColumnName("actiondate");

                entity.Property(e => e.Actionmile).HasColumnName("actionmile");

                entity.Property(e => e.Bookdate)
                    .HasColumnType("datetime")
                    .HasColumnName("bookdate");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Currentmile).HasColumnName("currentmile");

                entity.Property(e => e.Estdate)
                    .HasColumnType("datetime")
                    .HasColumnName("estdate");

                entity.Property(e => e.Expireddate)
                    .HasColumnType("datetime")
                    .HasColumnName("expireddate");

                entity.Property(e => e.Hhid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("hhid")
                    .IsFixedLength(true);

                entity.Property(e => e.Lastupdate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastupdate");

                entity.Property(e => e.Plandate)
                    .HasColumnType("datetime")
                    .HasColumnName("plandate");

                entity.Property(e => e.Planmile).HasColumnName("planmile");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(300)
                    .HasColumnName("remarks");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Mapp>(entity =>
            {
                entity.HasKey(e => e.Appid);

                entity.ToTable("mapp");

                entity.Property(e => e.Appid)
                    .HasMaxLength(50)
                    .HasColumnName("appid");

                entity.Property(e => e.Appicon)
                    .HasMaxLength(100)
                    .HasColumnName("appicon");

                entity.Property(e => e.Appname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("appname");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Updatedt)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedt");
            });

            modelBuilder.Entity<MauditType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__MauditTy__516F0395871EDDDA");

                entity.ToTable("MauditType");

                entity.Property(e => e.TypeId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TypeID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Mbpd>(entity =>
            {
                entity.HasKey(e => e.Bpcode);

                entity.ToTable("mbpd");

                entity.Property(e => e.Bpcode)
                    .HasMaxLength(20)
                    .HasColumnName("bpcode");

                entity.Property(e => e.Bpname)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("bpname");

                entity.Property(e => e.Bpref1)
                    .HasMaxLength(100)
                    .HasColumnName("bpref1");

                entity.Property(e => e.Bpref2)
                    .HasMaxLength(100)
                    .HasColumnName("bpref2");

                entity.Property(e => e.Bpref3)
                    .HasMaxLength(100)
                    .HasColumnName("bpref3");

                entity.Property(e => e.Bpref4)
                    .HasMaxLength(100)
                    .HasColumnName("bpref4");

                entity.Property(e => e.Bptype)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("bptype")
                    .IsFixedLength(true);

                entity.Property(e => e.Createby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("createby");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.Cusimg)
                    .HasMaxLength(50)
                    .HasColumnName("cusimg");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .HasColumnName("fax");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Lineimg)
                    .HasMaxLength(50)
                    .HasColumnName("lineimg");

                entity.Property(e => e.Loginpwd)
                    .HasMaxLength(50)
                    .HasColumnName("loginpwd");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .HasColumnName("mobile");

                entity.Property(e => e.No)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("no");

                entity.Property(e => e.Sendmailaccount).HasColumnName("sendmailaccount");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tel");
            });

            modelBuilder.Entity<Mcontact>(entity =>
            {
                entity.ToTable("mcontact");

                entity.HasComment("Contact Person");

                entity.HasIndex(e => new { e.Bpcode, e.IsNotifyReceived }, "IX_mcontact_bpcode_IsNotifyReceived");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("Running Number");

                entity.Property(e => e.Bpcode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("bpcode")
                    .HasComment("BP Code (FK from mbpd)");

                entity.Property(e => e.Createby)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("createby")
                    .HasComment("Create By");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate")
                    .HasComment("Create Date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email")
                    .HasComment("Email");

                entity.Property(e => e.ExprieDate).HasColumnType("datetime");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .HasColumnName("fax")
                    .HasComment("Fax");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("fullname");

                entity.Property(e => e.IsSendSms).HasColumnName("IsSendSMS");

                entity.Property(e => e.Isdefault)
                    .HasColumnName("isdefault")
                    .HasComment("Dafault (true-default, false - No default)");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .HasColumnName("mobile")
                    .HasComment("Mobile");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name")
                    .HasComment("Contact Person Name");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Position)
                    .HasMaxLength(100)
                    .HasColumnName("position")
                    .HasComment("Position");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tel")
                    .HasComment("Tel.");
            });

            modelBuilder.Entity<Mcstatus>(entity =>
            {
                entity.HasKey(e => e.Statusid);

                entity.ToTable("mcstatus");

                entity.Property(e => e.Statusid)
                    .ValueGeneratedNever()
                    .HasColumnName("statusid");

                entity.Property(e => e.Statusname)
                    .HasMaxLength(100)
                    .HasColumnName("statusname");
            });

            modelBuilder.Entity<Mcust>(entity =>
            {
                entity.HasKey(e => e.Bpcode);

                entity.ToTable("MCust");

                entity.Property(e => e.Bpcode)
                    .HasMaxLength(20)
                    .HasColumnName("BPCode");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.Bpname)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("BPName");

                entity.Property(e => e.Lati).HasColumnType("decimal(11, 8)");

                entity.Property(e => e.Long).HasColumnType("decimal(11, 8)");
            });

            modelBuilder.Entity<Mdocrun>(entity =>
            {
                entity.HasKey(e => new { e.Docid, e.Type, e.Docname });

                entity.ToTable("mdocrun");

                entity.HasComment("Docment Running Table");

                entity.Property(e => e.Docid)
                    .HasColumnName("docid")
                    .HasComment("Document ID");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("type")
                    .HasComment("Type of Running Number");

                entity.Property(e => e.Docname)
                    .HasMaxLength(50)
                    .HasColumnName("docname")
                    .HasComment("Document Name (Ex Job)");

                entity.Property(e => e.Currentrun)
                    .HasMaxLength(50)
                    .HasColumnName("currentrun")
                    .HasComment("Current Running Number");

                entity.Property(e => e.Customtext)
                    .HasMaxLength(100)
                    .HasColumnName("customtext");

                entity.Property(e => e.Docformat)
                    .HasMaxLength(50)
                    .HasColumnName("docformat");

                entity.Property(e => e.Docno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("docno");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Isdefault).HasColumnName("isdefault");

                entity.Property(e => e.Ishidden).HasColumnName("ishidden");

                entity.Property(e => e.Lastcreate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastcreate");

                entity.Property(e => e.Loadtime).HasColumnName("loadtime");

                entity.Property(e => e.Maxloadtime).HasColumnName("maxloadtime");

                entity.Property(e => e.Maxunloadtime).HasColumnName("maxunloadtime");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(10)
                    .HasColumnName("prefix")
                    .HasComment("Prefix of Running Number");

                entity.Property(e => e.Startrun)
                    .HasMaxLength(50)
                    .HasColumnName("startrun")
                    .HasComment("Start Running Number");

                entity.Property(e => e.Subtype).HasColumnName("subtype");

                entity.Property(e => e.Unloadtime).HasColumnName("unloadtime");
            });

            modelBuilder.Entity<Mexpense>(entity =>
            {
                entity.HasKey(e => e.Itemno)
                    .HasName("PK_MExpItem");

                entity.ToTable("MExpense");

                entity.Property(e => e.Itemno).HasColumnName("itemno");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Itemname)
                    .HasMaxLength(100)
                    .HasColumnName("itemname");
            });

            modelBuilder.Entity<Mgstatus>(entity =>
            {
                entity.HasKey(e => e.Statusid);

                entity.ToTable("mgstatus");

                entity.Property(e => e.Statusid)
                    .ValueGeneratedNever()
                    .HasColumnName("statusid");

                entity.Property(e => e.Statusname)
                    .HasMaxLength(100)
                    .HasColumnName("statusname");
            });

            modelBuilder.Entity<Mhhd>(entity =>
            {
                entity.HasKey(e => new { e.No, e.Hhid })
                    .HasName("PK_MHHD");

                entity.ToTable("mhhd");

                entity.Property(e => e.No)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("no");

                entity.Property(e => e.Hhid)
                    .HasMaxLength(20)
                    .HasColumnName("hhid");

                entity.Property(e => e.Activatedate).HasColumnType("datetime");

                entity.Property(e => e.Btname)
                    .HasMaxLength(50)
                    .HasColumnName("btname");

                entity.Property(e => e.Compid)
                    .HasMaxLength(20)
                    .HasColumnName("compid");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .HasColumnName("createby");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.DriverTypeId).HasColumnName("DriverTypeID");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Endpoint)
                    .HasMaxLength(20)
                    .HasColumnName("endpoint");

                entity.Property(e => e.Endtime)
                    .HasMaxLength(50)
                    .HasColumnName("endtime");

                entity.Property(e => e.Fixedcost).HasColumnName("fixedcost");

                entity.Property(e => e.Fuelcost).HasColumnName("fuelcost");

                entity.Property(e => e.Gps)
                    .HasMaxLength(10)
                    .HasColumnName("gps")
                    .IsFixedLength(true);

                entity.Property(e => e.Groupid)
                    .HasMaxLength(20)
                    .HasColumnName("groupid");

                entity.Property(e => e.Hhenextspk)
                    .HasColumnName("hhenextspk")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Hhimg)
                    .HasMaxLength(50)
                    .HasColumnName("hhimg")
                    .HasComment("Handheld Icon Image");

                entity.Property(e => e.Lineimg)
                    .HasMaxLength(50)
                    .HasColumnName("lineimg");

                entity.Property(e => e.Mastart).HasColumnName("mastart");

                entity.Property(e => e.Maxdistance).HasColumnName("maxdistance");

                entity.Property(e => e.Mile).HasColumnName("mile");

                entity.Property(e => e.Nextma).HasColumnName("nextma");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .HasColumnName("phone");

                entity.Property(e => e.Phoneno)
                    .HasMaxLength(15)
                    .HasColumnName("phoneno");

                entity.Property(e => e.Pincode)
                    .HasMaxLength(50)
                    .HasColumnName("pincode");

                entity.Property(e => e.Pod)
                    .HasMaxLength(10)
                    .HasColumnName("pod")
                    .IsFixedLength(true);

                entity.Property(e => e.PolygonId).HasColumnName("polygon_id");

                entity.Property(e => e.Sendmailaccount).HasColumnName("sendmailaccount");

                entity.Property(e => e.Shortname)
                    .HasMaxLength(50)
                    .HasColumnName("shortname")
                    .HasComment("Handheld short name");

                entity.Property(e => e.Skill)
                    .HasMaxLength(50)
                    .HasColumnName("skill");

                entity.Property(e => e.Speedlimit)
                    .HasMaxLength(20)
                    .HasColumnName("speedlimit");

                entity.Property(e => e.Starttime)
                    .HasMaxLength(50)
                    .HasColumnName("starttime");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Tag)
                    .HasMaxLength(30)
                    .HasColumnName("tag");

                entity.Property(e => e.Timecost).HasColumnName("timecost");

                entity.Property(e => e.Userid)
                    .HasMaxLength(20)
                    .HasColumnName("userid");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.Property(e => e.Uuid)
                    .HasMaxLength(50)
                    .HasColumnName("UUID");

                entity.Property(e => e.Version)
                    .HasMaxLength(10)
                    .HasColumnName("version");
            });

            modelBuilder.Entity<Mhhstatus>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_mcarstatus");

                entity.ToTable("mhhstatus");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasColumnName("code");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("statusName");
            });

            modelBuilder.Entity<Mholiday>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("Mholiday");

                entity.Property(e => e.No).HasColumnName("no");

                entity.Property(e => e.Bpcode)
                    .HasMaxLength(20)
                    .HasColumnName("bpcode");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(20);

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Holiday)
                    .HasColumnType("date")
                    .HasColumnName("holiday");

                entity.Property(e => e.HolidayDow)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("holidayDOW")
                    .IsFixedLength(true);

                entity.Property(e => e.Poidelivery)
                    .HasMaxLength(20)
                    .HasColumnName("poidelivery");

                entity.Property(e => e.Poideliverytype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("poideliverytype")
                    .IsFixedLength(true);

                entity.Property(e => e.Poireceive)
                    .HasMaxLength(20)
                    .HasColumnName("poireceive");

                entity.Property(e => e.RegularFlag)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("regularFlag")
                    .IsFixedLength(true);

                entity.Property(e => e.Remark).HasColumnName("remark");

                entity.Property(e => e.TimeFrom)
                    .HasMaxLength(10)
                    .HasColumnName("Time_From");

                entity.Property(e => e.TimeTo)
                    .HasMaxLength(10)
                    .HasColumnName("Time_To");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(20);
            });

            modelBuilder.Entity<Mmaintenance>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("PK_Mmaintenance");

                entity.ToTable("MMaintenance");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.VehicleType)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Mmilestone>(entity =>
            {
                entity.HasKey(e => e.MilestoneId)
                    .HasName("PK_M_Milestone");

                entity.ToTable("mmilestone");

                entity.Property(e => e.MilestoneId)
                    .HasMaxLength(20)
                    .HasColumnName("MilestoneID");

                entity.Property(e => e.JobType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Mpolygon>(entity =>
            {
                entity.HasKey(e => e.PolygonId)
                    .HasName("PK_mpolyn");

                entity.ToTable("mpolygon");

                entity.Property(e => e.PolygonId).HasColumnName("polygon_id");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(20)
                    .HasColumnName("create_by");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.PolygonCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("polygon_code");

                entity.Property(e => e.PolygonName)
                    .HasMaxLength(250)
                    .HasColumnName("polygon_name");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(20)
                    .HasColumnName("update_by");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("update_date");
            });

            modelBuilder.Entity<Mreason>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_MReason_1");

                entity.ToTable("MReason");

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .HasColumnName("code");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("description");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Rtype)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("rtype")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Msconf>(entity =>
            {
                entity.HasKey(e => new { e.Appid, e.Keyname })
                    .HasName("PK_msys_1");

                entity.ToTable("msconf");

                entity.Property(e => e.Appid)
                    .HasMaxLength(50)
                    .HasColumnName("appid");

                entity.Property(e => e.Keyname)
                    .HasMaxLength(50)
                    .HasColumnName("keyname");

                entity.Property(e => e.Appidref)
                    .HasMaxLength(50)
                    .HasColumnName("appidref");

                entity.Property(e => e.Keylabel)
                    .HasMaxLength(100)
                    .HasColumnName("keylabel");

                entity.Property(e => e.Keyorder).HasColumnName("keyorder");

                entity.Property(e => e.Keyvalue)
                    .HasMaxLength(255)
                    .HasColumnName("keyvalue");

                entity.Property(e => e.Updatedt)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedt");

                entity.Property(e => e.Xstore).HasColumnName("xstore");

                entity.Property(e => e.Xtype)
                    .HasMaxLength(50)
                    .HasColumnName("xtype");
            });

            modelBuilder.Entity<Mspeedlimit>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("MSpeedlimit");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .HasColumnName("code");

                entity.Property(e => e.Alarmfeq).HasColumnName("alarmfeq");

                entity.Property(e => e.Avgday).HasColumnName("avgday");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("description");

                entity.Property(e => e.Fixedcost).HasColumnName("fixedcost");

                entity.Property(e => e.Fuelcost).HasColumnName("fuelcost");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Speedlimit).HasColumnName("speedlimit");

                entity.Property(e => e.Timecost).HasColumnName("timecost");

                entity.Property(e => e.Volume).HasColumnName("volume");

                entity.Property(e => e.Weights).HasColumnName("weights");
            });

            modelBuilder.Entity<Msqa>(entity =>
            {
                entity.HasKey(e => e.Qaid);

                entity.ToTable("msqa");

                entity.Property(e => e.Qaid).HasColumnName("qaid");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Qaname)
                    .HasMaxLength(150)
                    .HasColumnName("qaname");
            });

            modelBuilder.Entity<Mstype>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("mstype");

                entity.Property(e => e.No).HasColumnName("no");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Subtypeid)
                    .HasMaxLength(20)
                    .HasColumnName("subtypeid");

                entity.Property(e => e.Subtypename)
                    .HasMaxLength(50)
                    .HasColumnName("subtypename");
            });

            modelBuilder.Entity<Mtoken>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("mtoken");

                entity.Property(e => e.Hhid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("hhid");

                entity.Property(e => e.Token).IsRequired();
            });

            modelBuilder.Entity<Mtran>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("PK_MTrans_1");

                entity.ToTable("MTrans");

                entity.HasIndex(e => e.CreateOn, "CreateOn-20180409-131432");

                entity.HasIndex(e => e.Hhid, "HHID-20180409-131334");

                entity.HasIndex(e => new { e.Hhid, e.Lati, e.Long, e.CreateOn }, "IX_MTrans_HHID_Lati_Long_CreateOn");

                entity.Property(e => e.ActionApp)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Bpcode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("BPCode");

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.Cstatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CStatus")
                    .IsFixedLength(true)
                    .HasComment("\"1\" = Car On, \"2\" = Car Off");

                entity.Property(e => e.Dcstatus)
                    .HasColumnType("datetime")
                    .HasColumnName("DCStatus");

                entity.Property(e => e.Gstatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GStatus")
                    .IsFixedLength(true);

                entity.Property(e => e.Hhid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("HHID");

                entity.Property(e => e.Hhstatus)
                    .HasMaxLength(50)
                    .HasColumnName("hhstatus");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.Jobno)
                    .HasMaxLength(50)
                    .HasColumnName("jobno");

                entity.Property(e => e.Lati).HasColumnType("decimal(11, 8)");

                entity.Property(e => e.Long).HasColumnType("decimal(11, 8)");

                entity.Property(e => e.ServerDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Multicontact>(entity =>
            {
                entity.HasKey(e => e.Jobno)
                    .HasName("PK_Multiplecontact");

                entity.ToTable("Multicontact");

                entity.Property(e => e.Jobno)
                    .HasMaxLength(50)
                    .HasColumnName("jobno");

                entity.Property(e => e.ContactD)
                    .HasMaxLength(20)
                    .HasColumnName("contactD");

                entity.Property(e => e.ContactR)
                    .HasMaxLength(20)
                    .HasColumnName("contactR");

                entity.Property(e => e.Deliveryupdate)
                    .HasColumnType("datetime")
                    .HasColumnName("deliveryupdate");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Receiveupdate)
                    .HasColumnType("datetime")
                    .HasColumnName("receiveupdate");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .HasColumnName("updateby");
            });

            modelBuilder.Entity<Multilanguage>(entity =>
            {
                entity.HasKey(e => e.DisplayId);

                entity.ToTable("multilanguage");

                entity.Property(e => e.DisplayId)
                    .HasMaxLength(4)
                    .HasColumnName("displayID");

                entity.Property(e => e.DisplayEn)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("displayEN");

                entity.Property(e => e.DisplayMy)
                    .HasMaxLength(150)
                    .HasColumnName("displayMY");

                entity.Property(e => e.DisplayTh)
                    .HasMaxLength(150)
                    .HasColumnName("displayTH");

                entity.Property(e => e.DisplayVn)
                    .HasMaxLength(150)
                    .HasColumnName("displayVN");

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("formID");

                entity.Property(e => e.No).ValueGeneratedOnAdd();

                entity.Property(e => e.ValueId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("valueID");
            });

            modelBuilder.Entity<Muser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("MUser");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .HasColumnName("userID");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Lineimg)
                    .HasMaxLength(50)
                    .HasColumnName("lineimg");

                entity.Property(e => e.No).ValueGeneratedOnAdd();

                entity.Property(e => e.Sendmailaccount).HasColumnName("sendmailaccount");

                entity.Property(e => e.UActive).HasColumnName("uActive");

                entity.Property(e => e.UBpcode)
                    .HasMaxLength(20)
                    .HasColumnName("uBPCode");

                entity.Property(e => e.UCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("uCreate");

                entity.Property(e => e.UFname)
                    .HasMaxLength(50)
                    .HasColumnName("uFName")
                    .HasComment("First Name");

                entity.Property(e => e.ULname)
                    .HasMaxLength(50)
                    .HasColumnName("uLName")
                    .HasComment("Last Name");

                entity.Property(e => e.UPhone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("uPhone");

                entity.Property(e => e.UPositionId)
                    .HasMaxLength(10)
                    .HasColumnName("uPositionID")
                    .IsFixedLength(true);

                entity.Property(e => e.URoleId).HasColumnName("uRoleID");

                entity.Property(e => e.UType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uType")
                    .IsFixedLength(true);

                entity.Property(e => e.UUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("uUpdate");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("userName");

                entity.Property(e => e.UserPass)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("userPass");

                entity.Property(e => e.Userimg)
                    .HasMaxLength(50)
                    .HasColumnName("userimg");
            });

            modelBuilder.Entity<MuserLog>(entity =>
            {
                entity.HasKey(e => new { e.No, e.UserId });

                entity.ToTable("MUserLog");

                entity.Property(e => e.No).ValueGeneratedOnAdd();

                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Createby)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mzone>(entity =>
            {
                entity.HasKey(e => e.Zoneid);

                entity.ToTable("MZone");

                entity.Property(e => e.Zoneid)
                    .HasMaxLength(20)
                    .HasColumnName("zoneid");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasColumnName("description");

                entity.Property(e => e.No)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("no");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedate");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("PK__Payments__3214D4A8123EB7A3");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.JobNo).HasMaxLength(50);

                entity.Property(e => e.NetAmount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentEndDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentStatus).HasComment("0= No payment, 1= Paid");

                entity.Property(e => e.PaymentType).HasComment("0 = Cash, 1 = Credit Card");

                entity.Property(e => e.RecordBy).HasMaxLength(20);

                entity.Property(e => e.RefCode).HasMaxLength(50);

                entity.Property(e => e.Refer1).HasMaxLength(100);

                entity.Property(e => e.Refer2).HasMaxLength(100);

                entity.Property(e => e.Refer3).HasMaxLength(100);

                entity.Property(e => e.Refer4).HasMaxLength(100);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.Property(e => e.Vat).HasColumnType("numeric(18, 6)");
            });

            modelBuilder.Entity<PlaningConfig>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("PlaningConfig");

                entity.Property(e => e.No).HasColumnName("no");

                entity.Property(e => e.Assignmode).HasColumnName("assignmode");

                entity.Property(e => e.Deliverymode).HasColumnName("deliverymode");

                entity.Property(e => e.DepartureTime)
                    .HasMaxLength(50)
                    .HasColumnName("departureTime");

                entity.Property(e => e.Depots)
                    .HasMaxLength(50)
                    .HasColumnName("depots");

                entity.Property(e => e.Endtime)
                    .HasMaxLength(50)
                    .HasColumnName("endtime");

                entity.Property(e => e.Groupid)
                    .HasMaxLength(20)
                    .HasColumnName("groupid");

                entity.Property(e => e.Groupmode).HasColumnName("groupmode");

                entity.Property(e => e.Maxdrop)
                    .HasMaxLength(50)
                    .HasColumnName("maxdrop");

                entity.Property(e => e.Modes).HasColumnName("modes");

                entity.Property(e => e.Motorways).HasColumnName("motorways");

                entity.Property(e => e.Packmode).HasColumnName("packmode");

                entity.Property(e => e.Returnmode).HasColumnName("returnmode");

                entity.Property(e => e.Routingtype).HasColumnName("routingtype");

                entity.Property(e => e.Starttime)
                    .HasMaxLength(50)
                    .HasColumnName("starttime");

                entity.Property(e => e.Tollroads).HasColumnName("tollroads");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");

                entity.Property(e => e.UpdatebBy)
                    .HasMaxLength(50)
                    .HasColumnName("updatebBy");

                entity.Property(e => e.Vehiclemode).HasColumnName("vehiclemode");
            });

            modelBuilder.Entity<Planning>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("Planning");

                entity.Property(e => e.No).HasColumnName("no");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.DatasetName)
                    .HasMaxLength(100)
                    .HasColumnName("datasetName");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Jobno)
                    .HasMaxLength(50)
                    .HasColumnName("jobno");

                entity.Property(e => e.Jobtype).HasColumnName("jobtype");

                entity.Property(e => e.Lat)
                    .HasColumnType("decimal(11, 8)")
                    .HasColumnName("lat");

                entity.Property(e => e.Lng)
                    .HasColumnType("decimal(11, 8)")
                    .HasColumnName("lng");

                entity.Property(e => e.Poiid)
                    .HasMaxLength(20)
                    .HasColumnName("poiid");

                entity.Property(e => e.Refjob)
                    .HasMaxLength(100)
                    .HasColumnName("refjob");

                entity.Property(e => e.Volumn).HasColumnName("volumn");

                entity.Property(e => e.Weight).HasColumnName("weight");
            });

            modelBuilder.Entity<PointApproval>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.PointId, e.ContactId })
                    .HasName("PK__PointApp__1AF895E5160F4887");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.PointId)
                    .HasMaxLength(20)
                    .HasColumnName("PointID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.No).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RePassLog>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("RePassLog");

                entity.Property(e => e.No).HasColumnName("no");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.Expiredmail)
                    .HasColumnType("datetime")
                    .HasColumnName("expiredmail");

                entity.Property(e => e.Mailcount).HasColumnName("mailcount");

                entity.Property(e => e.Receivedmail)
                    .HasMaxLength(100)
                    .HasColumnName("receivedmail");

                entity.Property(e => e.Token)
                    .HasMaxLength(100)
                    .HasColumnName("token");

                entity.Property(e => e.Userid)
                    .HasMaxLength(20)
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<Receipt>(entity =>
            {
                entity.HasKey(e => new { e.ReceiptNo, e.TerminalId, e.MerchantId });

                entity.HasIndex(e => e.InvoiceNo, "InvoiceNo_Index")
                    .IsUnique();

                entity.Property(e => e.ReceiptNo).HasMaxLength(20);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(20)
                    .HasColumnName("TerminalID");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(20)
                    .HasColumnName("MerchantID");

                entity.Property(e => e.ApprovalCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.BatchId)
                    .HasMaxLength(20)
                    .HasColumnName("BatchID");

                entity.Property(e => e.InvoiceNo).HasMaxLength(20);

                entity.Property(e => e.ReferenceNo).HasMaxLength(20);

                entity.Property(e => e.SystemTrace).HasMaxLength(20);
            });

            modelBuilder.Entity<Satisfaction>(entity =>
            {
                entity.HasKey(e => new { e.JobNo, e.JobStatus })
                    .HasName("PK_Satisfactions_1");

                entity.HasIndex(e => new { e.Rate, e.CreateDate }, "IX_Satisfactions_Rate_CreateDate");

                entity.Property(e => e.JobNo)
                    .HasMaxLength(50)
                    .HasComment("Job No.");

                entity.Property(e => e.JobStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .HasComment("job status (B-Blank, R-Receive, S-Send, C-Complete)");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Rate).HasComment("satisfaction rate (1-very bad, 2-bad, 3-Fair, 4-good,5-excellent)");

                entity.Property(e => e.ReasonCode).HasMaxLength(30);

                entity.Property(e => e.Remark).HasMaxLength(255);

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SkillMaster>(entity =>
            {
                entity.HasKey(e => e.SkillCode);

                entity.ToTable("SkillMaster");

                entity.Property(e => e.SkillCode)
                    .HasMaxLength(50)
                    .HasColumnName("skill_code");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.Defaults).HasColumnName("defaults");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.SkillDescription)
                    .HasMaxLength(100)
                    .HasColumnName("skill_description");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("update_date");
            });

            modelBuilder.Entity<TbZone>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("tb_Zone");

                entity.Property(e => e.No).HasColumnName("no");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.Group)
                    .HasMaxLength(20)
                    .HasColumnName("group");

                entity.Property(e => e.Mainzone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("mainzone");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Subzone)
                    .HasMaxLength(50)
                    .HasColumnName("subzone");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedate");

                entity.Property(e => e.Zone)
                    .HasMaxLength(50)
                    .HasColumnName("zone");
            });

            modelBuilder.Entity<TbmAction>(entity =>
            {
                entity.HasKey(e => e.ActionId)
                    .HasName("PK_tbm_act");

                entity.ToTable("tbm_action");

                entity.Property(e => e.ActionId)
                    .HasMaxLength(20)
                    .HasColumnName("actionId");

                entity.Property(e => e.ActionActive).HasColumnName("actionActive");

                entity.Property(e => e.ActionCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("actionCreate");

                entity.Property(e => e.ActionName)
                    .HasMaxLength(100)
                    .HasColumnName("actionName");

                entity.Property(e => e.ActionUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("actionUpdate");
            });

            modelBuilder.Entity<TbmAlarm>(entity =>
            {
                entity.HasKey(e => e.AlarmId)
                    .HasName("PK_tbm_arm");

                entity.ToTable("tbm_alarm");

                entity.HasComment("Table Alarms ");

                entity.Property(e => e.AlarmId)
                    .HasMaxLength(20)
                    .HasColumnName("alarmId");

                entity.Property(e => e.AlarmActive).HasColumnName("alarmActive");

                entity.Property(e => e.AlarmCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("alarmCreate");

                entity.Property(e => e.AlarmName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("alarmName");

                entity.Property(e => e.AlarmUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("alarmUpdate");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(20)
                    .HasColumnName("module_id");
            });

            modelBuilder.Entity<TbmCustomertype>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("tbm_customertype");

                entity.Property(e => e.TypeId)
                    .HasMaxLength(20)
                    .HasColumnName("type_id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(100)
                    .HasColumnName("type_name");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("update_date");
            });

            modelBuilder.Entity<TbmGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("tbm_group");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(20)
                    .HasColumnName("group_id");

                entity.Property(e => e.GroupActive).HasColumnName("group_active");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(255)
                    .HasColumnName("group_name");

                entity.Property(e => e.Lat)
                    .HasColumnType("decimal(11, 8)")
                    .HasColumnName("lat");

                entity.Property(e => e.Lng)
                    .HasColumnType("decimal(11, 8)")
                    .HasColumnName("lng");

                entity.Property(e => e.Radius).HasColumnName("radius");
            });

            modelBuilder.Entity<TbmMenu>(entity =>
            {
                entity.HasKey(e => e.MenuId)
                    .HasName("PK_tbm_menu_1");

                entity.ToTable("tbm_menu");

                entity.Property(e => e.MenuId)
                    .HasMaxLength(20)
                    .HasColumnName("menu_id");

                entity.Property(e => e.MenuActive).HasColumnName("menu_active");

                entity.Property(e => e.MenuCssname)
                    .HasMaxLength(50)
                    .HasColumnName("menu_cssname");

                entity.Property(e => e.MenuDescription)
                    .HasMaxLength(255)
                    .HasColumnName("menu_description");

                entity.Property(e => e.MenuLayout)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("menu_layout")
                    .IsFixedLength(true)
                    .HasComment("T=Top, C=Center");

                entity.Property(e => e.MenuModuleid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("menu_moduleid");

                entity.Property(e => e.MenuName)
                    .HasMaxLength(255)
                    .HasColumnName("menu_name");

                entity.Property(e => e.MenuType)
                    .HasMaxLength(50)
                    .HasColumnName("menu_type");
            });

            modelBuilder.Entity<TbmModule>(entity =>
            {
                entity.HasKey(e => e.ModuleId)
                    .HasName("PK_tbm_mod");

                entity.ToTable("tbm_module");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(20)
                    .HasColumnName("module_id");

                entity.Property(e => e.ModuleActive).HasColumnName("module_active");

                entity.Property(e => e.ModuleDescription)
                    .HasMaxLength(255)
                    .HasColumnName("module_description");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("module_name");
            });

            modelBuilder.Entity<TbmProvince>(entity =>
            {
                entity.HasKey(e => new { e.ProvCountryId, e.ProvProvinceId });

                entity.ToTable("tbm_province");

                entity.Property(e => e.ProvCountryId).HasColumnName("prov_countryID");

                entity.Property(e => e.ProvProvinceId).HasColumnName("prov_provinceID");

                entity.Property(e => e.ProvEnglishName)
                    .HasMaxLength(100)
                    .HasColumnName("prov_englishName");

                entity.Property(e => e.ProvLocalName)
                    .HasMaxLength(100)
                    .HasColumnName("prov_localName");
            });

            modelBuilder.Entity<TbmQueuestatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK_tbm_StatusQueues");

                entity.ToTable("tbm_queuestatus");

                entity.Property(e => e.StatusId)
                    .HasMaxLength(20)
                    .HasColumnName("status_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.StatusActive).HasColumnName("status_active");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(100)
                    .HasColumnName("status_name");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("update_date");
            });

            modelBuilder.Entity<TbrGaccess>(entity =>
            {
                entity.HasKey(e => new { e.GaGroupId, e.GaUserId })
                    .HasName("PK_tbl_gaccess_1");

                entity.ToTable("tbr_gaccess");

                entity.Property(e => e.GaGroupId)
                    .HasMaxLength(20)
                    .HasColumnName("ga_GroupID");

                entity.Property(e => e.GaUserId)
                    .HasMaxLength(20)
                    .HasColumnName("ga_UserID");

                entity.Property(e => e.GaActive).HasColumnName("ga_Active");

                entity.Property(e => e.GaCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("ga_Create");

                entity.Property(e => e.GaNo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ga_No");
            });

            modelBuilder.Entity<TbsAction>(entity =>
            {
                entity.HasKey(e => new { e.AccCopid, e.AccModid, e.AccActionid })
                    .HasName("PK_tbs_acc_1");

                entity.ToTable("tbs_action");

                entity.Property(e => e.AccCopid)
                    .HasMaxLength(50)
                    .HasColumnName("acc_copid");

                entity.Property(e => e.AccModid)
                    .HasMaxLength(50)
                    .HasColumnName("acc_modid");

                entity.Property(e => e.AccActionid)
                    .HasMaxLength(50)
                    .HasColumnName("acc_actionid");

                entity.Property(e => e.AccCdate)
                    .HasColumnType("datetime")
                    .HasColumnName("acc_cdate");

                entity.Property(e => e.AccImages)
                    .HasMaxLength(255)
                    .HasColumnName("acc_images");

                entity.Property(e => e.AccIsactive).HasColumnName("acc_isactive");

                entity.Property(e => e.AccNo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("acc_no");

                entity.Property(e => e.AccUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("acc_udate");
            });

            modelBuilder.Entity<TbsAlarm>(entity =>
            {
                entity.HasKey(e => new { e.ArcUserid, e.ArcModuleid, e.ArcAlarmid });

                entity.ToTable("tbs_alarm");

                entity.Property(e => e.ArcUserid)
                    .HasMaxLength(20)
                    .HasColumnName("arc_userid");

                entity.Property(e => e.ArcModuleid)
                    .HasMaxLength(20)
                    .HasColumnName("arc_moduleid");

                entity.Property(e => e.ArcAlarmid)
                    .HasMaxLength(20)
                    .HasColumnName("arc_alarmid");

                entity.Property(e => e.ArcCdate)
                    .HasColumnType("datetime")
                    .HasColumnName("arc_cdate");

                entity.Property(e => e.ArcIsactive).HasColumnName("arc_isactive");

                entity.Property(e => e.ArcOperator)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("arc_operator")
                    .IsFixedLength(true);

                entity.Property(e => e.ArcUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("arc_udate");

                entity.Property(e => e.ArcValue).HasColumnName("arc_value");
            });

            modelBuilder.Entity<TbsAlert>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("tbs_alert");

                entity.HasIndex(e => new { e.Hhid, e.Alarmid, e.Alarmdate }, "IX_tbs_alert_hhid_alarmid_alarmdate");

                entity.HasIndex(e => e.Alarmdate, "alarmdate-20170911-104943");

                entity.HasIndex(e => e.Alarmid, "alarmid-20170911-104928");

                entity.HasIndex(e => e.Hhid, "hhid-20170911-104914");

                entity.Property(e => e.No).HasColumnName("no");

                entity.Property(e => e.Actionid)
                    .HasMaxLength(20)
                    .HasColumnName("actionid");

                entity.Property(e => e.Alarmdate)
                    .HasColumnType("datetime")
                    .HasColumnName("alarmdate");

                entity.Property(e => e.Alarmid)
                    .HasMaxLength(20)
                    .HasColumnName("alarmid");

                entity.Property(e => e.Detail)
                    .HasMaxLength(255)
                    .HasColumnName("detail");

                entity.Property(e => e.Hhid)
                    .HasMaxLength(20)
                    .HasColumnName("hhid");

                entity.Property(e => e.Lat)
                    .HasColumnType("decimal(11, 8)")
                    .HasColumnName("lat");

                entity.Property(e => e.Lng)
                    .HasColumnType("decimal(11, 8)")
                    .HasColumnName("lng");

                entity.Property(e => e.Userid)
                    .HasMaxLength(20)
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<TbsRoleDetail>(entity =>
            {
                entity.HasKey(e => new { e.RoledRolehId, e.RoledMenuId });

                entity.ToTable("tbs_roleDetail");

                entity.Property(e => e.RoledRolehId).HasColumnName("roled_rolehId");

                entity.Property(e => e.RoledMenuId)
                    .HasMaxLength(20)
                    .HasColumnName("roled_menuId");

                entity.Property(e => e.RoledCdate)
                    .HasColumnType("datetime")
                    .HasColumnName("roled_cdate");

                entity.Property(e => e.RoledType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("roled_type")
                    .IsFixedLength(true)
                    .HasComment("{R=Read only, F=Full, V=Various, N=No}");
            });

            modelBuilder.Entity<TbsRoleHeader>(entity =>
            {
                entity.HasKey(e => e.RolehId);

                entity.ToTable("tbs_roleHeader");

                entity.Property(e => e.RolehId)
                    .ValueGeneratedNever()
                    .HasColumnName("roleh_id");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .HasColumnName("createby");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.RoledActive)
                    .HasColumnName("roled_active")
                    .HasComment("{0=Visible, 1=Enable}");

                entity.Property(e => e.RolehName)
                    .HasMaxLength(255)
                    .HasColumnName("roleh_name");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .HasColumnName("updateby");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedate");
            });

            modelBuilder.Entity<TbtShipment>(entity =>
            {
                entity.HasKey(e => e.LoadId)
                    .HasName("PK_tb_shipments");

                entity.ToTable("tbt_shipments");

                entity.Property(e => e.LoadId).HasMaxLength(20);

                entity.Property(e => e.AdeliverDistance).HasColumnName("ADeliverDistance");

                entity.Property(e => e.AdeliverTime).HasColumnName("ADeliverTime");

                entity.Property(e => e.AtotalDistance).HasColumnName("ATotalDistance");

                entity.Property(e => e.AtotalTime).HasColumnName("ATotalTime");

                entity.Property(e => e.Attachfile).HasMaxLength(100);

                entity.Property(e => e.Attachname).HasMaxLength(100);

                entity.Property(e => e.Carrier).HasMaxLength(20);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(20);

                entity.Property(e => e.Eta)
                    .HasColumnType("datetime")
                    .HasColumnName("ETA");

                entity.Property(e => e.Flag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.GroupId).HasMaxLength(20);

                entity.Property(e => e.Hhid).HasMaxLength(20);

                entity.Property(e => e.InterfaceDate).HasColumnType("datetime");

                entity.Property(e => e.LoadIdref).HasMaxLength(20);

                entity.Property(e => e.PdeliverDistance).HasColumnName("PDeliverDistance");

                entity.Property(e => e.PdeliverTime).HasColumnName("PDeliverTime");

                entity.Property(e => e.PtotalDistance).HasColumnName("PTotalDistance");

                entity.Property(e => e.PtotalTime).HasColumnName("PTotalTime");

                entity.Property(e => e.Ref1).HasMaxLength(100);

                entity.Property(e => e.Ref10).HasMaxLength(100);

                entity.Property(e => e.Ref11).HasMaxLength(100);

                entity.Property(e => e.Ref12).HasMaxLength(100);

                entity.Property(e => e.Ref2).HasMaxLength(100);

                entity.Property(e => e.Ref3).HasMaxLength(100);

                entity.Property(e => e.Ref4).HasMaxLength(100);

                entity.Property(e => e.Ref5).HasMaxLength(100);

                entity.Property(e => e.Ref6).HasMaxLength(100);

                entity.Property(e => e.Ref7).HasMaxLength(100);

                entity.Property(e => e.Ref8).HasMaxLength(100);

                entity.Property(e => e.Ref9).HasMaxLength(100);

                entity.Property(e => e.Remark).HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.TruckType).HasMaxLength(20);

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(20);
            });

            modelBuilder.Entity<TitemType>(entity =>
            {
                entity.HasKey(e => e.ItemTypeId);

                entity.ToTable("titemType");

                entity.Property(e => e.ItemTypeId)
                    .HasMaxLength(50)
                    .HasColumnName("ItemType_id");

                entity.Property(e => e.ItemTypeCdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ItemType_cdate");

                entity.Property(e => e.ItemTypeName)
                    .HasMaxLength(255)
                    .HasColumnName("ItemType_name");

                entity.Property(e => e.ItemTypeStatus).HasColumnName("ItemType_status");

                entity.Property(e => e.ItemTypeUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ItemType_udate");
            });

            modelBuilder.Entity<Tjitem>(entity =>
            {
                entity.HasKey(e => new { e.Itemno, e.Jobno });

                entity.ToTable("tjitem");

                entity.HasComment("Job Item Transaction");

                entity.HasIndex(e => e.Jobno, "IX_tjitem_jobno");

                entity.Property(e => e.Itemno)
                    .HasColumnName("itemno")
                    .HasComment("Item No.");

                entity.Property(e => e.Jobno)
                    .HasMaxLength(50)
                    .HasColumnName("jobno")
                    .HasComment("Job No.");

                entity.Property(e => e.Cdate)
                    .HasColumnType("datetime")
                    .HasColumnName("cdate")
                    .HasComment("Create Date");

                entity.Property(e => e.Containerno)
                    .HasMaxLength(50)
                    .HasColumnName("containerno")
                    .HasComment("Container No.");

                entity.Property(e => e.Cover)
                    .HasColumnName("cover")
                    .HasComment("Is Cover (True-Cover, False-No Cover)");

                entity.Property(e => e.Crack)
                    .HasColumnName("crack")
                    .HasComment("Is Crack (True-Crack, False-No Crack)");

                entity.Property(e => e.Dent)
                    .HasColumnName("dent")
                    .HasComment("Is Dent (True-Dent, False-No Dent)");

                entity.Property(e => e.Dimg)
                    .HasMaxLength(50)
                    .HasColumnName("dimg");

                entity.Property(e => e.Dqty).HasColumnName("dqty");

                entity.Property(e => e.Dreason)
                    .HasMaxLength(30)
                    .HasColumnName("dreason");

                entity.Property(e => e.Dstatus)
                    .HasMaxLength(20)
                    .HasColumnName("DStatus");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasComment("Item height");

                entity.Property(e => e.Hoop)
                    .HasColumnName("hoop")
                    .HasComment("Is Hoop (True-Hoop, False-No Hoop)");

                entity.Property(e => e.Isqa)
                    .HasColumnName("isqa")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Is QA (QA-True, No QA-False)");

                entity.Property(e => e.ItemType)
                    .HasMaxLength(50)
                    .HasColumnName("itemType");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("itemname")
                    .HasComment("Item Name");

                entity.Property(e => e.Lenght)
                    .HasColumnName("lenght")
                    .HasComment("Item Lenght");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasComment("Item Quntity");

                entity.Property(e => e.Ref)
                    .HasMaxLength(100)
                    .HasColumnName("ref")
                    .HasComment("Reference Number (Coil Number)");

                entity.Property(e => e.Rimg)
                    .HasMaxLength(50)
                    .HasColumnName("rimg");

                entity.Property(e => e.Rmin)
                    .HasColumnName("rmin")
                    .HasComment("Is RM In (True-RM In, False-No RM In)");

                entity.Property(e => e.Rmout)
                    .HasColumnName("rmout")
                    .HasComment("Is RM Out (True-RM Out, False-No RM Out)");

                entity.Property(e => e.Rqty).HasColumnName("rqty");

                entity.Property(e => e.Rreason)
                    .HasMaxLength(30)
                    .HasColumnName("rreason");

                entity.Property(e => e.Rstatus)
                    .HasMaxLength(20)
                    .HasColumnName("RStatus");

                entity.Property(e => e.Rusty)
                    .HasColumnName("rusty")
                    .HasComment("Is Rusty (True-Rusty, False-No Rusty)");

                entity.Property(e => e.Sealno)
                    .HasMaxLength(50)
                    .HasColumnName("sealno");

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasComment("Item weight");

                entity.Property(e => e.Wet)
                    .HasColumnName("wet")
                    .HasComment("Is Wet (True-Wet, False-No Wet)");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasComment("Width");
            });

            modelBuilder.Entity<Tjob>(entity =>
            {
                entity.HasKey(e => e.Jobno)
                    .HasName("PK_tjob_1");

                entity.ToTable("tjob");

                entity.HasComment("Job Transaction");

                entity.HasIndex(e => e.Bpcode, "IX_tjob_bpcode");

                entity.HasIndex(e => e.Cdate, "IX_tjob_cdate");

                entity.HasIndex(e => new { e.Ddate, e.Hhid, e.Jobstatus, e.Dduedate }, "IX_tjob_ddate_hhid_jobstatus_dduedate");

                entity.HasIndex(e => e.Dduedate, "IX_tjob_dduedate");

                entity.HasIndex(e => new { e.Groupid, e.Hhid, e.Jobstatus }, "IX_tjob_groupid_hhid_jobstatus");

                entity.HasIndex(e => e.Hhid, "IX_tjob_hhid");

                entity.HasIndex(e => new { e.Hhid, e.Jobstatus }, "IX_tjob_hhid_jobstatus");

                entity.HasIndex(e => new { e.Jobstatus, e.Cdate }, "IX_tjob_jobstatus_cdate");

                entity.HasIndex(e => new { e.Jobstatus, e.Dduedate }, "IX_tjob_jobstatus_dduedate");

                entity.HasIndex(e => new { e.Jobtype, e.Rdate, e.Groupid, e.Hhid, e.Jobstatus, e.Rduedate }, "IX_tjob_jobtype_rdate_groupid_hhid_jobstatus_rduedate");

                entity.HasIndex(e => new { e.Rdate, e.Hhid, e.Rduedate }, "IX_tjob_rdate_hhid_rduedate");

                entity.Property(e => e.Jobno)
                    .HasMaxLength(50)
                    .HasColumnName("jobno")
                    .HasComment("Job No.");

                entity.Property(e => e.Ackdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ackdate");

                entity.Property(e => e.Ackduedate)
                    .HasColumnType("datetime")
                    .HasColumnName("ackduedate");

                entity.Property(e => e.Ackstatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ackstatus")
                    .IsFixedLength(true);

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.Approveby)
                    .HasMaxLength(50)
                    .HasColumnName("approveby");

                entity.Property(e => e.Approvedate)
                    .HasColumnType("datetime")
                    .HasColumnName("approvedate");

                entity.Property(e => e.Attachfile)
                    .HasMaxLength(100)
                    .HasColumnName("attachfile")
                    .HasComment("Attach File");

                entity.Property(e => e.Attachname)
                    .HasMaxLength(100)
                    .HasColumnName("attachname")
                    .HasComment("Attach Name");

                entity.Property(e => e.Bpcode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("bpcode")
                    .HasComment("Customer Code");

                entity.Property(e => e.Cby)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("cby")
                    .HasComment("Create by");

                entity.Property(e => e.Cdate)
                    .HasColumnType("datetime")
                    .HasColumnName("cdate")
                    .HasComment("Create date");

                entity.Property(e => e.Contactd)
                    .HasColumnName("contactd")
                    .HasComment("Contact Person - Delivery (FK mcontact.id)");

                entity.Property(e => e.Contactr)
                    .HasColumnName("contactr")
                    .HasComment("Contact Person - Receive (FK mcontact.id)");

                entity.Property(e => e.Dchkindate)
                    .HasColumnType("datetime")
                    .HasColumnName("dchkindate");

                entity.Property(e => e.Dchkinlatlng)
                    .HasMaxLength(50)
                    .HasColumnName("dchkinlatlng");

                entity.Property(e => e.Dchkoutdate)
                    .HasColumnType("datetime")
                    .HasColumnName("dchkoutdate");

                entity.Property(e => e.Dchkoutlatlng)
                    .HasMaxLength(50)
                    .HasColumnName("dchkoutlatlng");

                entity.Property(e => e.Ddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ddate")
                    .HasComment("Delivery Date");

                entity.Property(e => e.Ddistance).HasColumnName("DDistance");

                entity.Property(e => e.Dduedate)
                    .HasColumnType("datetime")
                    .HasColumnName("dduedate");

                entity.Property(e => e.DeliveryUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Dlat)
                    .HasColumnType("decimal(11, 8)")
                    .HasColumnName("dlat");

                entity.Property(e => e.Dlng)
                    .HasColumnType("decimal(11, 8)")
                    .HasColumnName("dlng");

                entity.Property(e => e.Dmanimg)
                    .HasMaxLength(50)
                    .HasColumnName("dmanimg")
                    .HasComment("Man Delivery Image");

                entity.Property(e => e.Dqr).HasColumnName("dqr");

                entity.Property(e => e.Dsignimg)
                    .HasMaxLength(50)
                    .HasColumnName("dsignimg")
                    .HasComment("Delivery Signature Image");

                entity.Property(e => e.Epdate)
                    .HasColumnType("datetime")
                    .HasColumnName("epdate");

                entity.Property(e => e.Eta)
                    .HasColumnType("datetime")
                    .HasColumnName("eta");

                entity.Property(e => e.Groupid)
                    .HasMaxLength(20)
                    .HasColumnName("groupid")
                    .HasDefaultValueSql("((1000))")
                    .HasComment("Group ID");

                entity.Property(e => e.Hhid)
                    .HasMaxLength(20)
                    .HasColumnName("hhid")
                    .HasComment("Handheld");

                entity.Property(e => e.IsApprove).HasColumnName("isApprove");

                entity.Property(e => e.Ispriority)
                    .HasColumnName("ispriority")
                    .HasComment("Priority of job (1-High, 0-Low, NULL- no)");

                entity.Property(e => e.JobSkill)
                    .HasMaxLength(50)
                    .HasColumnName("jobSkill");

                entity.Property(e => e.Jobstatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("jobstatus")
                    .IsFixedLength(true)
                    .HasComment("job status (B-Blank, R-Receive, S-Send, C-Complete)");

                entity.Property(e => e.Jobtype)
                    .HasColumnName("jobtype")
                    .HasComment("Job Type (D-Delivery, R-Return Container)");

                entity.Property(e => e.LoadId)
                    .HasMaxLength(100)
                    .HasColumnName("LoadID");

                entity.Property(e => e.Payamount).HasColumnName("payamount");

                entity.Property(e => e.Paydate)
                    .HasColumnType("datetime")
                    .HasColumnName("paydate");

                entity.Property(e => e.Payref)
                    .HasMaxLength(100)
                    .HasColumnName("payref");

                entity.Property(e => e.Poidelivery)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("poidelivery")
                    .HasComment("Poi Delivery (poiid FK tpoi Table)");

                entity.Property(e => e.Poireceive)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("poireceive")
                    .HasComment("Poi Receive (poiid FK tpoi Table)");

                entity.Property(e => e.Printdate)
                    .HasColumnType("datetime")
                    .HasColumnName("printdate");

                entity.Property(e => e.Rchkindate)
                    .HasColumnType("datetime")
                    .HasColumnName("rchkindate");

                entity.Property(e => e.Rchkinlatlng)
                    .HasMaxLength(50)
                    .HasColumnName("rchkinlatlng");

                entity.Property(e => e.Rchkoutdate)
                    .HasColumnType("datetime")
                    .HasColumnName("rchkoutdate");

                entity.Property(e => e.Rchkoutlatlng)
                    .HasMaxLength(50)
                    .HasColumnName("rchkoutlatlng");

                entity.Property(e => e.Rdate)
                    .HasColumnType("datetime")
                    .HasColumnName("rdate")
                    .HasComment("Receive Date");

                entity.Property(e => e.Rdistance).HasColumnName("RDistance");

                entity.Property(e => e.Rduedate)
                    .HasColumnType("datetime")
                    .HasColumnName("rduedate");

                entity.Property(e => e.ReceiveUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.RecognizeDate).HasColumnType("datetime");

                entity.Property(e => e.Ref1)
                    .HasMaxLength(100)
                    .HasColumnName("ref1")
                    .HasComment("Ref1 (Container Number)");

                entity.Property(e => e.Ref10)
                    .HasMaxLength(100)
                    .HasColumnName("ref10");

                entity.Property(e => e.Ref11)
                    .HasMaxLength(100)
                    .HasColumnName("ref11");

                entity.Property(e => e.Ref12)
                    .HasMaxLength(100)
                    .HasColumnName("ref12");

                entity.Property(e => e.Ref2)
                    .HasMaxLength(100)
                    .HasColumnName("ref2")
                    .HasComment("Ref2 (Trailer Number)");

                entity.Property(e => e.Ref3)
                    .HasMaxLength(100)
                    .HasColumnName("ref3")
                    .HasComment("Ref3 (Return Place)");

                entity.Property(e => e.Ref4)
                    .HasMaxLength(100)
                    .HasColumnName("ref4")
                    .HasComment("Ref4 (Chassis Number)");

                entity.Property(e => e.Ref5)
                    .HasMaxLength(100)
                    .HasColumnName("ref5");

                entity.Property(e => e.Ref6)
                    .HasMaxLength(100)
                    .HasColumnName("ref6");

                entity.Property(e => e.Ref7)
                    .HasMaxLength(100)
                    .HasColumnName("ref7");

                entity.Property(e => e.Ref8)
                    .HasMaxLength(100)
                    .HasColumnName("ref8");

                entity.Property(e => e.Ref9)
                    .HasMaxLength(100)
                    .HasColumnName("ref9");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("remark")
                    .HasComment("Remark");

                entity.Property(e => e.Rlat)
                    .HasColumnType("decimal(11, 8)")
                    .HasColumnName("rlat");

                entity.Property(e => e.Rlng)
                    .HasColumnType("decimal(11, 8)")
                    .HasColumnName("rlng");

                entity.Property(e => e.Rmanimg)
                    .HasMaxLength(50)
                    .HasColumnName("rmanimg")
                    .HasComment("Man Receive Image");

                entity.Property(e => e.Rqr).HasColumnName("rqr");

                entity.Property(e => e.Rsignimg)
                    .HasMaxLength(50)
                    .HasColumnName("rsignimg")
                    .HasComment("Receive Signature Image");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Tdistance).HasColumnName("tdistance");

                entity.Property(e => e.Ttime).HasColumnName("ttime");

                entity.Property(e => e.UpdateBy).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Zone)
                    .HasMaxLength(50)
                    .HasColumnName("zone");
            });

            modelBuilder.Entity<TjobExp>(entity =>
            {
                entity.HasKey(e => new { e.Jobno, e.Itemid, e.Itemno });

                entity.ToTable("tjobExp");

                entity.Property(e => e.Jobno)
                    .HasMaxLength(50)
                    .HasColumnName("jobno");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemno).HasColumnName("itemno");

                entity.Property(e => e.Amountapr).HasColumnName("amountapr");

                entity.Property(e => e.Amountpay).HasColumnName("amountpay");

                entity.Property(e => e.Amountreq).HasColumnName("amountreq");

                entity.Property(e => e.Createby)
                    .HasMaxLength(100)
                    .HasColumnName("createby");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.Photo)
                    .HasMaxLength(100)
                    .HasColumnName("photo");
            });

            modelBuilder.Entity<Tjobimage>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("tjobimages");

                entity.Property(e => e.No).HasColumnName("no");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.Filename)
                    .HasMaxLength(100)
                    .HasColumnName("filename");

                entity.Property(e => e.Hhid)
                    .HasMaxLength(20)
                    .HasColumnName("hhid");

                entity.Property(e => e.Jobno)
                    .HasMaxLength(50)
                    .HasColumnName("jobno");
            });

            modelBuilder.Entity<Tjobreject>(entity =>
            {
                entity.ToTable("tjobreject");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cdate)
                    .HasColumnType("datetime")
                    .HasColumnName("cdate");

                entity.Property(e => e.Checkindate)
                    .HasColumnType("datetime")
                    .HasColumnName("checkindate");

                entity.Property(e => e.Checkinlatlng)
                    .HasMaxLength(50)
                    .HasColumnName("checkinlatlng");

                entity.Property(e => e.Dduedate)
                    .HasColumnType("datetime")
                    .HasColumnName("dduedate");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("fullname");

                entity.Property(e => e.Hhid)
                    .HasMaxLength(20)
                    .HasColumnName("hhid");

                entity.Property(e => e.Jobno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("jobno");

                entity.Property(e => e.Reasoncode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("reasoncode");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("remark");

                entity.Property(e => e.Shortname)
                    .HasMaxLength(50)
                    .HasColumnName("shortname");
            });

            modelBuilder.Entity<Tjobtimeslot>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("PK_tjob_timeslot");

                entity.ToTable("tjobtimeslot");

                entity.Property(e => e.DropSeq).HasMaxLength(50);

                entity.Property(e => e.Jobno).HasMaxLength(50);

                entity.Property(e => e.TimeDeliveryFromSlot1)
                    .HasMaxLength(10)
                    .HasColumnName("Time_Delivery_From_Slot1");

                entity.Property(e => e.TimeDeliveryFromSlot2)
                    .HasMaxLength(10)
                    .HasColumnName("Time_Delivery_From_Slot2");

                entity.Property(e => e.TimeDeliveryToSlot1)
                    .HasMaxLength(10)
                    .HasColumnName("Time_Delivery_To_Slot1");

                entity.Property(e => e.TimeDeliveryToSlot2)
                    .HasMaxLength(10)
                    .HasColumnName("Time_Delivery_To_Slot2");

                entity.Property(e => e.TimeReceiveFromSlot1)
                    .HasMaxLength(10)
                    .HasColumnName("Time_Receive_From_Slot1");

                entity.Property(e => e.TimeReceiveFromSlot2)
                    .HasMaxLength(10)
                    .HasColumnName("Time_Receive_From_Slot2");

                entity.Property(e => e.TimeReceiveToSlot1)
                    .HasMaxLength(10)
                    .HasColumnName("Time_Receive_To_Slot1");

                entity.Property(e => e.TimeReceiveToSlot2)
                    .HasMaxLength(10)
                    .HasColumnName("Time_Receive_To_Slot2");
            });

            modelBuilder.Entity<Tmad>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("PK_mmad_1");

                entity.ToTable("tmad");

                entity.HasComment("Maintenance Data");

                entity.Property(e => e.No)
                    .HasColumnName("no")
                    .HasComment("Running Number");

                entity.Property(e => e.Checkin)
                    .HasColumnType("datetime")
                    .HasColumnName("checkin")
                    .HasComment("Check in Date");

                entity.Property(e => e.Checkout)
                    .HasColumnType("datetime")
                    .HasColumnName("checkout")
                    .HasComment("Check out date");

                entity.Property(e => e.Expense)
                    .HasColumnName("expense")
                    .HasComment("Service Expense ");

                entity.Property(e => e.Garage)
                    .HasMaxLength(100)
                    .HasColumnName("garage")
                    .HasComment("Garage (POI Type = 'G' and Subtype = 'Garage')");

                entity.Property(e => e.Hhid)
                    .HasMaxLength(20)
                    .HasColumnName("hhid")
                    .HasComment("HHID");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("id")
                    .HasComment("ID");

                entity.Property(e => e.Mile)
                    .HasColumnName("mile")
                    .HasComment("Mileage");

                entity.Property(e => e.Service)
                    .HasMaxLength(255)
                    .HasColumnName("service")
                    .HasComment("Service");
            });

            modelBuilder.Entity<Tmilestone>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("PK_tmilestone_1");

                entity.ToTable("tmilestone");

                entity.HasIndex(e => new { e.JobNo, e.MilestoneId }, "IX_tmilestone_JobNo_MilestoneID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Hhid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("HHID");

                entity.Property(e => e.JobNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Lat).HasColumnType("decimal(11, 8)");

                entity.Property(e => e.Lng).HasColumnType("decimal(11, 8)");

                entity.Property(e => e.MilestoneId)
                    .HasMaxLength(20)
                    .HasColumnName("MilestoneID");

                entity.Property(e => e.RefCode).HasMaxLength(50);
            });

            modelBuilder.Entity<Tphoto>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("tphoto");

                entity.Property(e => e.No).HasColumnName("no");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Hhid)
                    .HasMaxLength(20)
                    .HasColumnName("hhid");

                entity.Property(e => e.Isprofile).HasColumnName("isprofile");

                entity.Property(e => e.Lat)
                    .HasColumnType("decimal(11, 8)")
                    .HasColumnName("lat");

                entity.Property(e => e.Lng)
                    .HasColumnType("decimal(11, 8)")
                    .HasColumnName("lng");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.RefCode).HasMaxLength(50);
            });

            modelBuilder.Entity<Tpoi>(entity =>
            {
                entity.HasKey(e => e.Poiid);

                entity.ToTable("tpoi");

                entity.HasComment("POI transaction");

                entity.HasIndex(e => e.Name, "IX_tpoi_name");

                entity.HasIndex(e => new { e.Name, e.Bpcode }, "IX_tpoi_name_bpcode");

                entity.HasIndex(e => new { e.Type, e.Bpcode }, "IX_tpoi_type_bpcode");

                entity.HasIndex(e => new { e.District, e.Province }, "Idx_district_province");

                entity.HasIndex(e => e.Poiid, "Idx_pooid");

                entity.Property(e => e.Poiid)
                    .HasMaxLength(20)
                    .HasColumnName("poiid")
                    .HasComment("Running Number");

                entity.Property(e => e.Activestate).HasColumnName("activestate");

                entity.Property(e => e.Addrno)
                    .HasColumnName("addrno")
                    .HasComment("Address Number");

                entity.Property(e => e.Bpcode)
                    .HasMaxLength(20)
                    .HasColumnName("bpcode")
                    .HasComment("BP Code");

                entity.Property(e => e.Branchcode)
                    .HasMaxLength(20)
                    .HasColumnName("branchcode")
                    .HasComment("Branch Code");

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .HasColumnName("country")
                    .HasComment("Country");

                entity.Property(e => e.Createby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("createby")
                    .HasComment("Create By");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate")
                    .HasComment("Create Date");

                entity.Property(e => e.District)
                    .HasMaxLength(100)
                    .HasColumnName("district")
                    .HasComment("district");

                entity.Property(e => e.IsException).HasColumnName("isException");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Isapprove)
                    .HasColumnName("isapprove")
                    .HasComment("1-Approve, 0-No Approve");

                entity.Property(e => e.Isdefault)
                    .HasColumnName("isdefault")
                    .HasComment("Default (0-No Default, 1-Default)");

                entity.Property(e => e.Isfind).HasColumnName("isfind");

                entity.Property(e => e.Lat)
                    .HasColumnType("decimal(11, 8)")
                    .HasColumnName("lat")
                    .HasComment("Latitude");

                entity.Property(e => e.Lng)
                    .HasColumnType("decimal(11, 8)")
                    .HasColumnName("lng")
                    .HasComment("Longitude");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name")
                    .HasComment("POI Name");

                entity.Property(e => e.Province)
                    .HasMaxLength(100)
                    .HasColumnName("province")
                    .HasComment("province");

                entity.Property(e => e.Radius)
                    .HasColumnName("radius")
                    .HasComment("Error Radius");

                entity.Property(e => e.Servicetime)
                    .HasMaxLength(10)
                    .HasColumnName("servicetime");

                entity.Property(e => e.Skillpoi)
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Street)
                    .HasMaxLength(100)
                    .HasColumnName("street")
                    .HasComment("Street");

                entity.Property(e => e.Subdistrict)
                    .HasMaxLength(100)
                    .HasColumnName("subdistrict")
                    .HasComment("Subdistrict");

                entity.Property(e => e.Subtype)
                    .HasMaxLength(20)
                    .HasColumnName("subtype")
                    .HasComment("Sub Type");

                entity.Property(e => e.Truckavailable).HasColumnName("truckavailable");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("type")
                    .IsFixedLength(true)
                    .HasComment("G-General, B-BP, R-Branch");

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(10)
                    .HasColumnName("zipcode")
                    .HasComment("Zipcode");
            });

            modelBuilder.Entity<Tpoiprove>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("PK_tapprove");

                entity.ToTable("tpoiprove");

                entity.HasComment("Approve POI");

                entity.HasIndex(e => e.Poiid, "IX_tpoiprove_poiid");

                entity.Property(e => e.No)
                    .HasColumnName("no")
                    .HasComment("Running Number");

                entity.Property(e => e.Createby)
                    .HasMaxLength(20)
                    .HasColumnName("createby")
                    .HasComment("Create by (User id)");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate")
                    .HasComment("Create Date");

                entity.Property(e => e.Isapprove)
                    .HasColumnName("isapprove")
                    .HasComment("Approve (True-Approve, False-No Approve)");

                entity.Property(e => e.Jobno)
                    .HasMaxLength(50)
                    .HasColumnName("jobno");

                entity.Property(e => e.Lat)
                    .HasColumnType("decimal(11, 8)")
                    .HasColumnName("lat")
                    .HasComment("Latitude");

                entity.Property(e => e.Lng)
                    .HasColumnType("decimal(11, 8)")
                    .HasColumnName("lng")
                    .HasComment("Longitude");

                entity.Property(e => e.Poiid)
                    .HasMaxLength(20)
                    .HasColumnName("poiid")
                    .HasComment("POI ID");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(20)
                    .HasColumnName("updateby")
                    .HasComment("Update by (User id)");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedate")
                    .HasComment("update date");
            });

            modelBuilder.Entity<Tqaitem>(entity =>
            {
                entity.HasKey(e => new { e.Qaid, e.Jobno, e.Itemno });

                entity.ToTable("tqaitem");

                entity.Property(e => e.Qaid).HasColumnName("qaid");

                entity.Property(e => e.Jobno)
                    .HasMaxLength(50)
                    .HasColumnName("jobno");

                entity.Property(e => e.Itemno).HasColumnName("itemno");

                entity.Property(e => e.Isok).HasColumnName("isok");

                entity.Property(e => e.Qadate)
                    .HasColumnType("datetime")
                    .HasColumnName("qadate");
            });

            modelBuilder.Entity<Tqueue>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("PK_TQueue");

                entity.ToTable("tqueue");

                entity.Property(e => e.AssignBy).HasMaxLength(50);

                entity.Property(e => e.FinishLoading).HasColumnType("datetime");

                entity.Property(e => e.Hhid)
                    .HasMaxLength(20)
                    .HasColumnName("HHID");

                entity.Property(e => e.Lane).HasMaxLength(20);

                entity.Property(e => e.LoadId)
                    .HasMaxLength(100)
                    .HasColumnName("LoadID");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.StartLoading).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.Truckout).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(50);

                entity.Property(e => e.WaitingListDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tsale>(entity =>
            {
                entity.HasKey(e => new { e.No, e.Hhid });

                entity.ToTable("tsale");

                entity.Property(e => e.No).HasColumnName("no");

                entity.Property(e => e.Hhid)
                    .HasMaxLength(20)
                    .HasColumnName("hhid");

                entity.Property(e => e.Actionapp)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("actionapp")
                    .IsFixedLength(true);

                entity.Property(e => e.Appby)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("appby");

                entity.Property(e => e.Appdate)
                    .HasColumnType("datetime")
                    .HasColumnName("appdate");

                entity.Property(e => e.Battery).HasColumnName("battery");

                entity.Property(e => e.Bpcode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("bpcode");

                entity.Property(e => e.Cardimg)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("cardimg");

                entity.Property(e => e.Cflatlng).HasColumnName("cflatlng");

                entity.Property(e => e.Compid)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.Isapprove).HasColumnName("isapprove");

                entity.Property(e => e.Lat)
                    .HasColumnType("decimal(11, 8)")
                    .HasColumnName("lat");

                entity.Property(e => e.Lng)
                    .HasColumnType("decimal(11, 8)")
                    .HasColumnName("lng");

                entity.Property(e => e.StatusBp)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("statusBP")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VehicleHistory>(entity =>
            {
                entity.Property(e => e.VehicleHistoryId)
                    .HasMaxLength(20)
                    .HasColumnName("VehicleHistoryID");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Hhid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("HHID");

                entity.Property(e => e.Latitude).HasColumnType("decimal(11, 8)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(11, 8)");

                entity.Property(e => e.No).ValueGeneratedOnAdd();

                entity.Property(e => e.RowType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("UUID");
            });

            modelBuilder.Entity<VehicleHistoryDetail>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.Property(e => e.KeyType).HasMaxLength(50);

                entity.Property(e => e.RowType).HasMaxLength(20);

                entity.Property(e => e.Value).HasColumnType("decimal(11, 8)");

                entity.Property(e => e.VehicleHistoryId)
                    .HasMaxLength(20)
                    .HasColumnName("VehicleHistoryID");

                entity.HasOne(d => d.VehicleHistory)
                    .WithMany(p => p.VehicleHistoryDetails)
                    .HasForeignKey(d => d.VehicleHistoryId)
                    .HasConstraintName("FK_VehicleHistoryDetails_VehicleHistorys1");
            });

            modelBuilder.Entity<VehiclePlanning>(entity =>
            {
                entity.ToTable("VehiclePlanning");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(50)
                    .HasColumnName("createBy");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.DatasetName)
                    .HasMaxLength(100)
                    .HasColumnName("datasetName");

                entity.Property(e => e.DepartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("departTime");

                entity.Property(e => e.Motorways).HasColumnName("motorways");

                entity.Property(e => e.Refconfig)
                    .HasMaxLength(400)
                    .HasColumnName("refconfig");

                entity.Property(e => e.Refdate)
                    .HasMaxLength(100)
                    .HasColumnName("refdate");

                entity.Property(e => e.Refplan)
                    .HasMaxLength(5)
                    .HasColumnName("refplan");

                entity.Property(e => e.RoutingTypes).HasColumnName("routingTypes");

                entity.Property(e => e.SearchRange).HasColumnName("searchRange");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Tollroads).HasColumnName("tollroads");

                entity.Property(e => e.TotalCost).HasColumnName("totalCost");

                entity.Property(e => e.TotalCostSolver).HasColumnName("totalCostSolver");

                entity.Property(e => e.TotalDistance).HasColumnName("totalDistance");

                entity.Property(e => e.TotalDuration).HasColumnName("totalDuration");

                entity.Property(e => e.TotalNumberOfVehiclesUsed).HasColumnName("totalNumberOfVehiclesUsed");

                entity.Property(e => e.TotalServiceTime).HasColumnName("totalServiceTime");

                entity.Property(e => e.TotalTransportTime).HasColumnName("totalTransportTime");

                entity.Property(e => e.TotalWaitingTime).HasColumnName("totalWaitingTime");

                entity.Property(e => e.Transportmodes).HasColumnName("transportmodes");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .HasColumnName("updateBy");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");
            });

            modelBuilder.Entity<VehiclePlanningRoute>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssignBy)
                    .HasMaxLength(50)
                    .HasColumnName("assignBy");

                entity.Property(e => e.AssignDate)
                    .HasColumnType("datetime")
                    .HasColumnName("assignDate");

                entity.Property(e => e.DatasetName)
                    .HasMaxLength(100)
                    .HasColumnName("datasetName");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("endTime");

                entity.Property(e => e.Isassign).HasColumnName("isassign");

                entity.Property(e => e.Loadid)
                    .HasMaxLength(10)
                    .HasColumnName("loadid");

                entity.Property(e => e.MaxcapacityVolume).HasColumnName("maxcapacityVolume");

                entity.Property(e => e.MaxcapacityWeight).HasColumnName("maxcapacityWeight");

                entity.Property(e => e.Modify).HasColumnName("modify");

                entity.Property(e => e.Recalculate).HasColumnName("recalculate");

                entity.Property(e => e.Route).HasColumnName("route");

                entity.Property(e => e.Sendapi).HasColumnName("sendapi");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("startTime");

                entity.Property(e => e.TotalDistance).HasColumnName("totalDistance");

                entity.Property(e => e.TotalDuration).HasColumnName("totalDuration");

                entity.Property(e => e.TotalServicetime).HasColumnName("totalServicetime");

                entity.Property(e => e.TotalTransporttime).HasColumnName("totalTransporttime");

                entity.Property(e => e.TotalWaitingtime).HasColumnName("totalWaitingtime");

                entity.Property(e => e.VehicleId)
                    .HasMaxLength(20)
                    .HasColumnName("vehicleID");
            });

            modelBuilder.Entity<VehiclePlanningRoutesDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activity)
                    .HasMaxLength(50)
                    .HasColumnName("activity");

                entity.Property(e => e.ArrivalTime)
                    .HasColumnType("datetime")
                    .HasColumnName("arrivalTime");

                entity.Property(e => e.DatasetName)
                    .HasMaxLength(100)
                    .HasColumnName("datasetName");

                entity.Property(e => e.DepartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("departTime");

                entity.Property(e => e.Distance).HasColumnName("distance");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .HasColumnName("orderID");

                entity.Property(e => e.SequenceId).HasColumnName("sequenceID");

                entity.Property(e => e.VehicleId)
                    .HasMaxLength(20)
                    .HasColumnName("vehicleID");
            });

            modelBuilder.Entity<VehiclePlanningUnAssign>(entity =>
            {
                entity.ToTable("VehiclePlanningUnAssign");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DatasetName)
                    .HasMaxLength(100)
                    .HasColumnName("datasetName");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .HasColumnName("orderID");
            });

            modelBuilder.Entity<Vision>(entity =>
            {
                entity.ToTable("vision");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("createdAt");

                entity.Property(e => e.Hhid)
                    .HasMaxLength(20)
                    .HasColumnName("hhid");

                entity.Property(e => e.Jobno)
                    .HasMaxLength(50)
                    .HasColumnName("jobno");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Probability).HasColumnName("probability");

                entity.Property(e => e.Tag)
                    .HasMaxLength(255)
                    .HasColumnName("tag");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
