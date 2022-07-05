using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MyLineBot.Data.common
{
    public partial class CommonDataContext : DbContext
    {
        public CommonDataContext()
        {
        }

        public CommonDataContext(DbContextOptions<CommonDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<LineRegister> LineRegisters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=27.254.207.172;Database=SIMAT-COMMON;user id=sa;password=skyfr0gDEV;Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
