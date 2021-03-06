using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UITS_IMS.Repository.Models
{
    [Table("Product")]
    public partial class Product
    {
        public Product()
        {
            ProductOrdereds = new HashSet<ProductOrdered>();
        }

        [Key]
        [Column("ProductID")]
        public int ProductId { get; set; }
        [Required]
        [StringLength(255)]
        public string ProductName { get; set; }
        [Required]
        [StringLength(255)]
        public string SerialNumber { get; set; }
        public bool StatusType { get; set; }
        public int Quantity { get; set; }
        [Column("CategoryID")]
        public int CategoryId { get; set; }
        [Column("SupplierID")]
        public int SupplierId { get; set; }
        [Column("StockID")]
        public int StockId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty("Products")]
        public virtual Category Category { get; set; }
        [ForeignKey(nameof(StockId))]
        [InverseProperty("Products")]
        public virtual Stock Stock { get; set; }
        [ForeignKey(nameof(SupplierId))]
        [InverseProperty("Products")]
        public virtual Supplier Supplier { get; set; }
        [InverseProperty(nameof(ProductOrdered.Product))]
        public virtual ICollection<ProductOrdered> ProductOrdereds { get; set; }
    }
}
