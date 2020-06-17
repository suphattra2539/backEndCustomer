using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    //public partial class CustomerSaleProductController
    //{
        

    //}

    public class CustomerViewModel1
    {
        public CustomerViewModel1() { 
        
        }

        public CustomerViewModel1(int id) {
            customerID = id;
        }

        public int customerID { get; set; }
        public OrderViewModel1 Order { get; set; }


        public void Run() { 
        
        }

        public void Run(int shoed)
        {

        }

    }
    public class OrderViewModel1
    {
        public string OrderID { get; set; }
        public List<OrderDetailViewModel1> ItemProduct { get; set; }

    }
    public class OrderDetailViewModel1
    {
        public int ProductID { get; set; }
        public int Quantity { get; set; }
    }
    public class DataInputNumber
    {
        public int id { get; set; }
    }
}
