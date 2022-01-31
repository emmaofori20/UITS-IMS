using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UITS_IMS.Models
{
    [Table("Product")]
    public partial class Product
    {
        public Product()
        {
            ProductRequests = new HashSet<ProductRequest>();
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
        [Column("StockID")]
        public int? StockId { get; set; }
        [Column("CategoryID")]
        public int? CategoryId { get; set; }
        [StringLength(255)]
        public string UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Updated { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; }
        [StringLength(255)]
        public string CreatedBy { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty("Products")]
        public virtual Category Category { get; set; }
        [ForeignKey(nameof(StockId))]
        [InverseProperty("Products")]
        public virtual Stock Stock { get; set; }
        [InverseProperty(nameof(ProductRequest.Product))]
        public virtual ICollection<ProductRequest> ProductRequests { get; set; }
    }
}
