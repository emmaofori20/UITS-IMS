using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UITS_IMS.Controllers
{
    public class HomeController : Controller
    {
        //constructor
        public HomeController()
        {

        }

        //Login page controller
        public ViewResult Login()
        {

            return View();
        }

        //redirects the user to the dashboard
        public RedirectToActionResult OnLogin()

        {
            return RedirectToAction("Index", "Dashboardcontroller");
        }


        //SignIn page Controller
        public ViewResult SignUp()
        {
            return View();
        }
    }

    
}
