using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CDC.Consumer.Demo.UI.Models.CDC_POC_DB
{
    public partial class CDC_POC_DBContext : DbContext
    {
        public CDC_POC_DBContext()
        {
        }

        public CDC_POC_DBContext(DbContextOptions<CDC_POC_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CdcprocessLog> CdcprocessLogs { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<CdcprocessLog>(entity =>
            {
                entity.HasKey(e => e.ProcessLogId)
                    .HasName("PK__CDCProce__A80C9D3E045DEEAC");

                entity.ToTable("CDCProcessLogs");

                entity.Property(e => e.Lsn)
                    .HasMaxLength(10)
                    .HasColumnName("LSN")
                    .IsFixedLength(true);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(sysutcdatetime())");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.Email)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalEmployeeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
