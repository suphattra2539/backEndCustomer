using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Data.Entity;
using WebApplication1.Models;
using WebApplication1.Models.ViewModel;
using System.Runtime.InteropServices;
using System.Web.Services.Description;

namespace WebApplication1.Controllers
{
    // [RoutePrefix("api/Test_Product")]
    public partial class CustomerSaleProductController : ApiController
    {
        ExamsEntities db = new ExamsEntities();

        public IHttpActionResult MyInput(int id)
        {
            var number = id;


            return Ok();
        }
        //public IHttpActionResult CreteOrder2(int id)
        //{
        //    var customer =  db.Customers.Where(x => x.CustomerID == id).FirstOrDefault();
        //    if (customer != null)
        //    {
        //        var DataOrder = new Order()
        //        {
        //            OrderID = "33422",
        //            CustomerID = id,
        //            OrderDate = DateTime.Now
        //        };
        //        var DataSetOrder = new OrderDetail()
        //        {
        //            OrderID = DataOrder.OrderID,
        //            ProductID = 1,
        //            Quantity = 3
        //        };
        //        var CheckProduct = db.Products.Where(x => x.ProductID == DataSetOrder.ProductID).FirstOrDefault();
        //        var CheckOrderId = db.Orders.Where(x => x.OrderID == DataOrder.OrderID).FirstOrDefault();
        //        if(CheckProduct != null  && CheckOrderId == null)
        //        {
        //            db.Orders.Add(DataOrder);
        //            db.OrderDetails.Add(DataSetOrder);
        //            db.SaveChanges();
        //        }
        //        else
        //        {
        //            return NotFound();
        //        }

        //    }else
        //    {
        //        return NotFound();
        //    }

        //    return Ok();
        //}
//        public IHttpActionResult CreteOrder(CustomerViewModel1 dataCostomer )
//        {

//        var customer = db.Customers.Where(x => x.CustomerID == dataCostomer.customerID).FirstOrDefault();
//            if (customer != null)
//            {
//                var getDataOrder = dataCostomer.Order.OrderID;//   .Select(o => new OrderViewModel1() { OrderID = o.OrderID }).ToList();

//                var DataOrder = new Order()
//                {
//            OrderID = dataCostomer.Order.OrderID,    //.Select(x => x.OrderID).FirstOrDefault(),
//            CustomerID = dataCostomer.customerID,
//            OrderDate = DateTime.Now
//        };

//        OrderDetailViewModel1 test = new OrderDetailViewModel1();
//        var DataSetOrder = new OrderDetail()
//        {
//            OrderID = DataOrder.OrderID,

//            ProductID = test.ProductID,
//            Quantity = test.Quantity,

//        };
//        var CheckProduct = db.Products.Where(x => x.ProductID == DataSetOrder.ProductID).FirstOrDefault();
//        var CheckOrderId = db.Orders.Where(x => x.OrderID == DataOrder.OrderID).FirstOrDefault();

//                if (CheckProduct != null && CheckOrderId == null)
//                {
//                    db.Orders.Add(DataOrder);
//                    db.OrderDetails.Add(DataSetOrder);
//                    db.SaveChanges();
//                }
//                else
//                {
//                    return NotFound();
//}

//            }
//            else
//            {
//                return NotFound();
//            }

//            return Ok();
//        }
       


        //public IHttpActionResult setcheckdataorderdetail(CustomerOrder dataCustomer , OrderDetailData dataorderdetail)
        //{
        //    var checkcustomer = db.Customers.Where(x => x.CustomerID == dataCustomer.CustomerID).First();
        //    if (checkcustomer != null)
        //    {
        //        var productidcheck = db.Products.Where(it => it.ProductID == dataorderdetail.ProductID).First();
        //        if (productidcheck != null)
        //        {
        //            var cretedataorderdetail = new OrderDetailData()
        //            {
        //                OrderID = dataorderdetail.OrderID,
        //                ProductID = dataorderdetail.ProductID,
        //                Quantity = dataorderdetail.Quantity,
        //            };
        //            db.OrderDetail.Add(cretedataorderdetail);
        //            db.SaveChanges();
        //        }
        //    }
        //    else
        //    {
        //       // return notfound();
        //    }
        //    return Ok();
        //}
        //public ihttpactionresult cretedaataorder(orderdetaildata dataorderdetail)
        //{
        //    using (var db = new examsentities())
        //    {
        //        db.orderdetail.add(new dataorderdetails()
        //        {
        //            orderid = dataorderdetail.orderid,
        //            //customerid = dataorderdetail.customerid,
        //            productid = dataorderdetail.productid,
        //            quantity = dataorderdetail.quantity,
        //        });

        //        db.savechanges();
        //    }
        //    return ok();
        //}


        /* public IHttpActionResult CustomerOrder(int Id = 1, string idorder = "23323", int productid = 3, int qty = 4)
         {

             var Customer = db.Customers.Select(x => x.CustomerID == Id).FirstOrDefault();
             var ProductSelect = db.Products.Select(x => x.ProductID == productid).FirstOrDefault();
             var Order = new Order()
             {
                 OrderID = idorder;
                 ID_Customer  = new List<CustomerOrder>()
                 {
                     Customer = 
                 };
              }

             db.Orders.Add(Order);

             var OrderDetails = new OrderDetail()
             {
                 OrderID = idorder,
                 ProductID = ProductSelect,
                 Quantity = qty

             };
             db.OrderDetail.Add(OrderDetails);

             return Ok();
         }*/

        /*   public static OrderDetailData1 setData()
           {
               return new OrderDetailData1()
               {
                   //CustomerID = 1,
                   OrderID = "11121",
                   ProductID = 2,
                   Quantity = 2
               };
           }*/
        //public static CustomerOrder setDataCustomer()
        //{
        //    return new CustomerOrder()
        //    {
        //        CustomerID =1,

        //    };
        //}


    }
}
