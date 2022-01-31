using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UITS_IMS.Models
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
        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; }
        [StringLength(255)]
        public string CreatedBy { get; set; }
        [StringLength(255)]
        public string UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Updated { get; set; }

        [InverseProperty(nameof(Product.Stock))]
        public virtual ICollection<Product> Products { get; set; }
    }
}
