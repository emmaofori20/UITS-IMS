using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UITS_IMS.Controllers
{
    public class LoginController : Controller
    {
        //constructor
        public LoginController()
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
    }

    
}
