using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.ViewModel
{
    public class Orders_Test
    {
        public int ID_Order { get; set; }
        public List<Customer_CViewModel> ID_Customer { get; set; }
        public List<Product_TestViewModel> ID_Product { get; set; }
        public int Quantity_O { get; set; }

    }
}