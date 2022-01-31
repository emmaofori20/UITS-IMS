using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UITS_IMS.Models;
using UITS_IMS.Models.ViewModels;
using UITS_IMS.Repository;
using UITS_IMS.Services.Interface;

namespace UITS_IMS.Services
{
    public class AuthService : IAuthService
    {
        private readonly IMSDbContext _context;

        public AuthService(IMSDbContext context)
        {
            _context = context;
        }
        public RegisterNewUserModel GetDepartments()
        {
            var x = new RegisterNewUserModel()
            {
                Departments = new SelectList(_context.Departments.Select(s => new { Id = s.DepartmentId, Text = $"{s.DepartmentName}" }), "Id", "Text"),
            };
            return x;
        }

        public staff RegisterNewStaff()
        {
            throw new NotImplementedException();
        }
    }
}
