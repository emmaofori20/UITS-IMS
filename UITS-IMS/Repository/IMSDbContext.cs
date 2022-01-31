using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using UITS_IMS.Models;

#nullable disable

namespace UITS_IMS.Repository
{
    public partial class IMSDbContext : DbContext
    {
        public IMSDbContext()
        {
        }

        public IMSDbContext(DbContextOptions<IMSDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductRequest> ProductRequests { get; set; }
        public virtual DbSet<ProductRequestStatus> ProductRequestStatuses { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<staff> staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=UITS-IMS;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .IsClustered(false);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .IsClustered(false);
            });

            modelBuilder.Entity<PhoneNumber>(entity =>
            {
                entity.HasKey(e => new { e.PhoneNumberId, e.EmployeeId })
                    .IsClustered(false);

                entity.Property(e => e.PhoneNumberId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PhoneNumbers)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffPhoneNumber");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .IsClustered(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_CategoryProduct");

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.StockId)
                    .HasConstraintName("FK_StockProduct");
            });

            modelBuilder.Entity<ProductRequest>(entity =>
            {
                entity.HasKey(e => e.RequestId)
                    .IsClustered(false);

                entity.HasOne(d => d.OrderProduct)
                    .WithMany(p => p.ProductRequests)
                    .HasForeignKey(d => d.OrderProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestProductRequest");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductRequests)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductProductRequest");
            });

            modelBuilder.Entity<ProductRequestStatus>(entity =>
            {
                entity.HasKey(e => e.RequestStatusId)
                    .IsClustered(false);

                entity.HasOne(d => d.OrderProduct)
                    .WithMany(p => p.ProductRequestStatuses)
                    .HasForeignKey(d => d.OrderProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestProductRequestStatus");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ProductRequestStatuses)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatusProductRequestStatus");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.HasKey(e => e.OrderProductId)
                    .IsClustered(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("RefStaff33");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .IsClustered(false);
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.HasKey(e => e.StockId)
                    .IsClustered(false);
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .IsClustered(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentStaff");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
