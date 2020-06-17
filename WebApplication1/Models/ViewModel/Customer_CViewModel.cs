using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.ViewModel
{
    public class Customer_CViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<OrderViewModel> Orders { get; set; }
    }
}