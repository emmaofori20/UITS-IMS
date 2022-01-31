using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UITS_IMS.Models;
using UITS_IMS.Models.ViewModels;

namespace UITS_IMS.Services.Interface
{
   public interface IRequestService
    {
        public RequestViewModel GetAllProducts(int id);
        public Request Makerequest(MakeRequest Request);
        public void AddProducts(RequestViewModel productRequest);
    }
}
