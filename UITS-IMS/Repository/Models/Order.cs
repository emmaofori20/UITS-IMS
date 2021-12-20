using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UITS_IMS.Repository.Models
{
    public partial class Order
    {
        public Order()
        {
            ProductOrdereds = new HashSet<ProductOrdered>();
        }

        [Key]
        [Column("OrderID")]
        public int OrderId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
        [Required]
        [StringLength(255)]
        public string Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateOrdered { get; set; }
        [Column("RequistionID")]
        public int RequistionId { get; set; }

        [ForeignKey(nameof(RequistionId))]
        [InverseProperty("Orders")]
        public virtual Requistion Requistion { get; set; }
        [InverseProperty(nameof(ProductOrdered.Order))]
        public virtual ICollection<ProductOrdered> ProductOrdereds { get; set; }
    }
}
