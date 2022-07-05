using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MyLineBot.Data
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LineMsgLog> LineMsgLogs { get; set; }
        public virtual DbSet<Mhhd> Mhhds { get; set; }
        public virtual DbSet<Mmilestone> Mmilestones { get; set; }
        public virtual DbSet<Mreason> Mreasons { get; set; }
        public virtual DbSet<Msconf> Msconfs { get; set; }
        public virtual DbSet<Tjob> Tjobs { get; set; }
        public virtual DbSet<Tjobreject> Tjobrejects { get; set; }
        public virtual DbSet<Tmilestone> Tmilestones { get; set; }
        public virtual DbSet<Tpoi> Tpois { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Connection String");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Thai_CI_AS");

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
