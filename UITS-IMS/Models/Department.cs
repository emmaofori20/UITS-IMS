using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace UITS_IMS.Models
{
    [Table("Department")]
    public partial class Department
    {
        public Department()
        {
            staff = new HashSet<staff>();
        }

        [Key]
        [Column("DepartmentID")]
        public int DepartmentId { get; set; }
        [Required]
        [StringLength(255)]
        public string DepartmentName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; }
        [StringLength(255)]
        public string CreatedBy { get; set; }
        [StringLength(255)]
        public string UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Updated { get; set; }

        [InverseProperty("Department")]
        public virtual ICollection<staff> staff { get; set; }
    }
}
