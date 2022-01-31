using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UITS_IMS.Models;
using UITS_IMS.Repository;
using UITS_IMS.Services.Interface;

namespace UITS_IMS.Services
{
    public class EmployeeService: IEmployeeService
    {
        private readonly IMSDbContext _context;

        public EmployeeService(IMSDbContext context)
        {
            _context = context;
        }

        public List<staff> GetAllStaff()
        {
            var result = _context.staff.Include(x => x.Department).ToList();
            return result;
        }

        
    }
}
