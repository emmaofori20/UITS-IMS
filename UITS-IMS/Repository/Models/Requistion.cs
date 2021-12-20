using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UITS_IMS.Repository.Models
{
    [Table("Requistion")]
    public partial class Requistion
    {
        public Requistion()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        [Column("RequistionID")]
        public int RequistionId { get; set; }
        [Required]
        [StringLength(18)]
        public string Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedTime { get; set; }
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime IssueDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ReturnDate { get; set; }
        [Column("EmployeeID")]
        public int EmployeeId { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("Requistions")]
        public virtual Employee Employee { get; set; }
        [InverseProperty(nameof(Order.Requistion))]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
