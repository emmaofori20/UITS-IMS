using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UITS_IMS.Repository.Models;

namespace UITS_IMS.Models
{
    public class EmployeeRequestModel
    {
        public Employee Employee { get; set; }
        public ProductOrdered ProductOrder { get; set; }
        public PhoneNumber Phone { get; set; }
        public Requistion Request { get; set; }

    }
}
