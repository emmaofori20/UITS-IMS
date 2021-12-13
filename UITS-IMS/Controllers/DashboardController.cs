using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UITS_IMS.Controllers
{
    public class DashboardController : Controller
    {
        ///CONSTRUCTOR
        public DashboardController()
        {

        }
        public ViewResult Dashboard()
        {
            return View();
        }
    }
}
