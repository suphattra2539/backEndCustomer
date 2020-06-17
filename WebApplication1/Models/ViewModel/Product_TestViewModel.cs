using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Models.ViewModel
{
    public class Product_TestViewModel 
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }
    }
}
