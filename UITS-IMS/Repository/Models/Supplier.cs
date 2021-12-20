using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UITS_IMS.Repository.Models
{
    [Table("Supplier")]
    public partial class Supplier
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
            Stocks = new HashSet<Stock>();
        }

        [Key]
        [Column("SupplierID")]
        public int SupplierId { get; set; }
        [Required]
        [StringLength(255)]
        public string SupplierName { get; set; }
        [Required]
        [StringLength(255)]
        public string Contact { get; set; }

        [InverseProperty(nameof(Product.Supplier))]
        public virtual ICollection<Product> Products { get; set; }
        [InverseProperty(nameof(Stock.Supplier))]
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
