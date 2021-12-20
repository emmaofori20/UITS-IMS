using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UITS_IMS.Repository.Models
{
    [Table("PhoneNumber")]
    public partial class PhoneNumber
    {
        [Key]
        [Column("PhoneNumberID")]
        public int PhoneNumberId { get; set; }
        [Key]
        [Column("EmployeeID")]
        public int EmployeeId { get; set; }
        public int ContactNumber { get; set; }
        [Column("isActive")]
        public bool IsActive { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("PhoneNumbers")]
        public virtual Employee Employee { get; set; }
    }
}
