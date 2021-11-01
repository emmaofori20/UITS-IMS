using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UITS_IMS.Controllers
{
    public class DashboardController : Controller
    {
        public DashboardController()
        {

        }
        public ViewResult Index()
        {
            return View();
        }
    }
}
