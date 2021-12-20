using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UITS_IMS.Repository.Models
{
    [Table("Employee")]
    public partial class Employee
    {
        public Employee()
        {
            PhoneNumbers = new HashSet<PhoneNumber>();
            ProductOrdereds = new HashSet<ProductOrdered>();
            Requistions = new HashSet<Requistion>();
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

        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty("Employees")]
        public virtual Department Department { get; set; }
        [InverseProperty(nameof(PhoneNumber.Employee))]
        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
        [InverseProperty(nameof(ProductOrdered.Employee))]
        public virtual ICollection<ProductOrdered> ProductOrdereds { get; set; }
        [InverseProperty(nameof(Requistion.Employee))]
        public virtual ICollection<Requistion> Requistions { get; set; }
    }
}
