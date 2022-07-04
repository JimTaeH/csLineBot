using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MyLineBot.Models
{
    public partial class LineUserDBContext : DbContext
    {
        public LineUserDBContext()
        {
        }

        public LineUserDBContext(DbContextOptions<LineUserDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LineLogin> LineLogins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=LineUserDB;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<LineLogin>(entity =>
            {
                entity.ToTable("lineLogins");

                entity.Property(e => e.DisplayName).HasColumnName("displayName");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.Value1).HasColumnName("value1");

                entity.Property(e => e.Value2).HasColumnName("value2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
