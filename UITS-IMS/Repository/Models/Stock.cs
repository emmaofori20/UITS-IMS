using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UITS_IMS.Repository.Models
{
    [Table("Stock")]
    public partial class Stock
    {
        public Stock()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        [Column("StockID")]
        public int StockId { get; set; }
        [Required]
        [StringLength(255)]
        public string InvoiceNumber { get; set; }
        [Required]
        [StringLength(255)]
        public string InvoiceUpload { get; set; }
        [Column("SupplierID")]
        public int SupplierId { get; set; }

        [ForeignKey(nameof(SupplierId))]
        [InverseProperty("Stocks")]
        public virtual Supplier Supplier { get; set; }
        [InverseProperty(nameof(Product.Stock))]
        public virtual ICollection<Product> Products { get; set; }
    }
}
