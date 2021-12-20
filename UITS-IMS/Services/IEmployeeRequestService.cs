using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UITS_IMS.Models;

namespace UITS_IMS.Services
{
    public interface IEmployeeRequestService
    {
        public string CreateEmployeeRequest(EmployeeRequestModel model);
     }
}
