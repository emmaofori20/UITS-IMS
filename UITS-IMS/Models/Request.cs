using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UITS_IMS.Models
{
    [Table("Request")]
    public partial class Request
    {
        public Request()
        {
            ProductRequestStatuses = new HashSet<ProductRequestStatus>();
            ProductRequests = new HashSet<ProductRequest>();
        }

        [Key]
        [Column("OrderProductID")]
        public int OrderProductId { get; set; }
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; }
        [StringLength(255)]
        public string CreatedBy { get; set; }
        [StringLength(255)]
        public string UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Updated { get; set; }
        [Column("EmployeeID")]
        public int? EmployeeId { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty(nameof(staff.Requests))]
        public virtual staff Employee { get; set; }
        [InverseProperty(nameof(ProductRequestStatus.OrderProduct))]
        public virtual ICollection<ProductRequestStatus> ProductRequestStatuses { get; set; }
        [InverseProperty(nameof(ProductRequest.OrderProduct))]
        public virtual ICollection<ProductRequest> ProductRequests { get; set; }
    }
}
