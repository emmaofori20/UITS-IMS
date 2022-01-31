using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UITS_IMS.Models
{
    [Table("ProductRequestStatus")]
    public partial class ProductRequestStatus
    {
        [Key]
        public int RequestStatusId { get; set; }
        public int StatusId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; }
        [StringLength(255)]
        public string CreatedBy { get; set; }
        [StringLength(255)]
        public string UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Updated { get; set; }
        [Column("OrderProductID")]
        public int OrderProductId { get; set; }

        [ForeignKey(nameof(OrderProductId))]
        [InverseProperty(nameof(Request.ProductRequestStatuses))]
        public virtual Request OrderProduct { get; set; }
        [ForeignKey(nameof(StatusId))]
        [InverseProperty("ProductRequestStatuses")]
        public virtual Status Status { get; set; }
    }
}
