using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using UITS_IMS.Repository.Models;

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
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductOrdered> ProductOrdereds { get; set; }
        public virtual DbSet<Requistion> Requistions { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=IMSdb;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK29")
                    .IsClustered(false);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .HasName("PK34")
                    .IsClustered(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK31")
                    .IsClustered(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RefDepartment21");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK27")
                    .IsClustered(false);

                entity.HasOne(d => d.Requistion)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.RequistionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RefRequistion30");
            });

            modelBuilder.Entity<PhoneNumber>(entity =>
            {
                entity.HasKey(e => new { e.PhoneNumberId, e.EmployeeId })
                    .HasName("PK38")
                    .IsClustered(false);

                entity.Property(e => e.PhoneNumberId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PhoneNumbers)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RefEmployee34");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK26")
                    .IsClustered(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RefCategory23");

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.StockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RefStock25");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RefSupplier24");
            });

            modelBuilder.Entity<ProductOrdered>(entity =>
            {
                entity.HasKey(e => e.OrderProductId)
                    .HasName("PK37")
                    .IsClustered(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ProductOrdereds)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RefEmployee33");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.ProductOrdereds)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RefOrders31");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductOrdereds)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RefProduct32");
            });

            modelBuilder.Entity<Requistion>(entity =>
            {
                entity.HasKey(e => e.RequistionId)
                    .HasName("PK32")
                    .IsClustered(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Requistions)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RefEmployee29");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.HasKey(e => e.StockId)
                    .HasName("PK35")
                    .IsClustered(false);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Stocks)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RefSupplier26");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasKey(e => e.SupplierId)
                    .HasName("PK28")
                    .IsClustered(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
