using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UITS_IMS.Models
{
    [Table("ProductRequest")]
    public partial class ProductRequest
    {
        [Key]
        public int RequestId { get; set; }
        public int Quantity { get; set; }
        [Column("OrderProductID")]
        public int OrderProductId { get; set; }
        [Column("ProductID")]
        public int ProductId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; }
        [StringLength(255)]
        public string CreatedBy { get; set; }
        [StringLength(255)]
        public string UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Updated { get; set; }

        [ForeignKey(nameof(OrderProductId))]
        [InverseProperty(nameof(Request.ProductRequests))]
        public virtual Request OrderProduct { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty("ProductRequests")]
        public virtual Product Product { get; set; }
    }
}
