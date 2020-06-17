using System;
using System.Collections.Generic;

namespace WebApplication1.Models.ViewModel
{
    public class OrderViewModel
    {
        public string OrderId { get; internal set; }
        public DateTime? OrderDate { get; internal set; }
        public List<ProductViewModel> Products { get; set; }
        public int? SumTotal { get; internal set; }
    }

    public class ProductViewModel
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }

        public int? Price { get; set; }
        public int? SumPrices { get; internal set; }
    }

}