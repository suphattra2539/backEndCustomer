using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.ViewModel
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<OrderViewModel> Orders { get; set; }
        //  public int MyProperty { get; set; }

    }

}