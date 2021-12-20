using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UITS_IMS.Repository.Models
{
    [Table("ProductOrdered")]
    public partial class ProductOrdered
    {
        [Key]
        [Column("OrderProductID")]
        public int OrderProductId { get; set; }
        public int Quantity { get; set; }
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Column("ProductID")]
        public int ProductId { get; set; }
        [Column("EmployeeID")]
        public int EmployeeId { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("ProductOrdereds")]
        public virtual Employee Employee { get; set; }
        [ForeignKey(nameof(OrderId))]
        [InverseProperty("ProductOrdereds")]
        public virtual Order Order { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty("ProductOrdereds")]
        public virtual Product Product { get; set; }
    }
}
