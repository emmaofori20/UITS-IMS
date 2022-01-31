using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UITS_IMS.Models;
using UITS_IMS.Models.ViewModels;

namespace UITS_IMS.Services.Interface
{
    public interface IAuthService
    {
        public staff RegisterNewStaff();

        public RegisterNewUserModel GetDepartments();
    }
}
