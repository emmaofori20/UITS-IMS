using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UITS_IMS.Models;
using UITS_IMS.Models.ViewModels;
using UITS_IMS.Repository;
using UITS_IMS.Services.Interface;

namespace UITS_IMS.Services
{
    public class RequestService : IRequestService
    {
        private readonly IMSDbContext _context;

        public RequestService(IMSDbContext context)
        {
            _context = context;
        }

        public void AddProducts( RequestViewModel productRequest)
        {
            var data = new ProductRequest()
            {
                OrderProductId = productRequest.RequestId,
                Quantity = productRequest.Quantity,
                ProductId = productRequest.ProductId,
                Created = DateTime.Now,
                CreatedBy = "Stew"
            };
            _context.ProductRequests.Add(data);
            _context.SaveChanges();
           
        }

        public RequestViewModel GetAllProducts(int id)
        {
            //(var result = _context.Products.ToList();
            var x = new RequestViewModel() {
                Products = new SelectList(_context.Products.Select(s => new { Id = s.ProductId, Text = $"{s.ProductName}" }), "Id", "Text"),
                RequestId = id
            };
            return x;
        }

        public Request Makerequest(MakeRequest request)
        {
            var makerequest = new Request()
            {
                Description = request.Description,
                Created = DateTime.Now,
                CreatedBy = "Stew",
                EmployeeId = 404
            };
            _context.Requests.Add(makerequest);
            _context.SaveChanges();
            return makerequest;
        }
    }
}
