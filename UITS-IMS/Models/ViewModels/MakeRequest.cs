using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UITS_IMS.Models.ViewModels
{
    public class MakeRequest
    {
        public int staffId { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage ="Reason for request should not exceed 255 characters")]
        public string Description { get; set; }
    }
}
