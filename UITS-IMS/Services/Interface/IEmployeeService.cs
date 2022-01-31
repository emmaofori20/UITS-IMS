using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UITS_IMS.Models;

namespace UITS_IMS.Services.Interface
{
   public interface IEmployeeService
    {
        public List<staff> GetAllStaff();
    }
}
