using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UITS_IMS.Models.ViewModels
{
    public class RequestViewModel
    {
        public int RequestId { get; set; }
        public int ProductId { get; set; }
        public SelectList Products { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }

    
}
