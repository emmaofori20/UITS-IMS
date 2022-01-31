using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UITS_IMS.Models
{
    [Table("Status")]
    public partial class Status
    {
        public Status()
        {
            ProductRequestStatuses = new HashSet<ProductRequestStatus>();
        }

        [Key]
        public int StatusId { get; set; }
        [Required]
        [StringLength(255)]
        public string StatusName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; }
        [StringLength(255)]
        public string CreatedBy { get; set; }
        [StringLength(255)]
        public string UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Updated { get; set; }

        [InverseProperty(nameof(ProductRequestStatus.Status))]
        public virtual ICollection<ProductRequestStatus> ProductRequestStatuses { get; set; }
    }
}
