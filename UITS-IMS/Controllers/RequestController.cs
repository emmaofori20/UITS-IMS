using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UITS_IMS.Models;
using UITS_IMS.Models.ViewModels;
using UITS_IMS.Services.Interface;

namespace UITS_IMS.Controllers
{
    public class RequestController : Controller
    {

        private readonly IRequestService _requestService;
        public RequestController(IRequestService requestService)
        {
            _requestService = requestService;
        }

        public ActionResult Index()
        {
            return View();
        }
        
        //User makes request to the server before selecting item
        [HttpPost]
        public ActionResult Index(MakeRequest model)
        {
            if (ModelState.IsValid)
            {
                Request newRequest = _requestService.Makerequest(model);
                return RedirectToAction("SelectProduct", new { id = newRequest.OrderProductId});

            }
            
            return View();
        }

        //User Select Item
        [HttpGet]
        public ActionResult SelectProduct(int id)
        {
            var results = _requestService.GetAllProducts(id);
            return View( results);
        }

        //USer sends item to the server
        [HttpPost]
        public ActionResult SelectProduct (RequestViewModel model)
        {
            _requestService.AddProducts(model);
            return RedirectToAction("SelectProduct");
        }



        // GET: RequestController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RequestController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
