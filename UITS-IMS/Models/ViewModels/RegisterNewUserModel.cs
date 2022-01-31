using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UITS_IMS.Models.ViewModels
{
    public class RegisterNewUserModel
    {
        public int DepartmentID{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public SelectList Departments { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public int Phone { get; set; }
    }
}
