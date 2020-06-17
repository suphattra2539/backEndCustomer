using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.ViewModel
{
    public class Orders_TestViewModel
    {
        public int ID_Order { get; set; }
        public int Quanyiyt_O { get; set; }
        public List<Product_TestViewModel> ID_Product { get; set; }
    }
}