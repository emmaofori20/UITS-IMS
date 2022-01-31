using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UITS_IMS.Models
{
    [Table("Staff")]
    public partial class staff
    {
        public staff()
        {
            PhoneNumbers = new HashSet<PhoneNumber>();
            Requests = new HashSet<Request>();
        }

        [Key]
        [Column("EmployeeID")]
        public int EmployeeId { get; set; }
        [Required]
        [StringLength(255)]
        public string Position { get; set; }
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(255)]
        public string LastName { get; set; }
        [Required]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("DepartmentID")]
        public int DepartmentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; }
        [StringLength(255)]
        public string CreatedBy { get; set; }
        [StringLength(255)]
        public string UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Updated { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty("staff")]
        public virtual Department Department { get; set; }
        [InverseProperty(nameof(PhoneNumber.Employee))]
        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
        [InverseProperty(nameof(Request.Employee))]
        public virtual ICollection<Request> Requests { get; set; }
    }
}
