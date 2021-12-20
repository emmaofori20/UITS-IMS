using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UITS_IMS.Models;
using UITS_IMS.Repository;

namespace UITS_IMS.Services
{
    public class EmployeeRequestService : IEmployeeRequestService
    {
        //private readonly IMSDbContext _context;

        public EmployeeRequestService(IMSDbContext context)
        {
           //_context = context;
        }

        public string CreateEmployeeRequest(EmployeeRequestModel model)
        {
            //_context.Employees.Add(model.Employee);
            return "";
        }
    }
}
