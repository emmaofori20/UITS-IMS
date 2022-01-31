using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UITS_IMS.Models
{
    [Table("PhoneNumber")]
    public partial class PhoneNumber
    {
        [Key]
        [Column("PhoneNumberID")]
        public int PhoneNumberId { get; set; }
        public int ContactNumber { get; set; }
        [Column("isActive")]
        public bool IsActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; }
        [StringLength(255)]
        public string CreatedBy { get; set; }
        [StringLength(255)]
        public string UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Updated { get; set; }
        [Key]
        [Column("EmployeeID")]
        public int EmployeeId { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty(nameof(staff.PhoneNumbers))]
        public virtual staff Employee { get; set; }
    }
}
