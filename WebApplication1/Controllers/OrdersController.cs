using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Data.Entity;
using WebApplication1.Models;
using WebApplication1.Models.ViewModel;
using System.Data.Odbc;

namespace WebApplication1.Controllers
{
    public class OrdersController : ApiController
    {
        ExamsEntities db = new ExamsEntities();
        public IEnumerable<OrderViewModel> GetAllOrders()
        {
            var DataOrders = db.Orders.Select(x => new OrderViewModel()
            {
                OrderId = x.OrderID,
                OrderDate = x.OrderDate,
            }).ToList();

            return DataOrders;
        }

        public IHttpActionResult GetOrders(string Id)
        {
            var order = db.Orders.Where(x => x.OrderID == Id).Select(o => new OrderViewModel()
            {
                OrderId = o.OrderID,
                OrderDate = o.OrderDate,
                Products = o.OrderDetails.Select(odt => new ProductViewModel()
                {
                    ProductID = odt.ProductID,
                    Name = odt.Product.Name,
                    Quantity = odt.Quantity,
                    Price = odt.Product.Price,

                    SumPrices = odt.Quantity * odt.Product.Price,
                }).ToList()
            }).FirstOrDefault();

            var getSumTotal = order.Products.Sum(x => x.SumPrices);
            order.SumTotal = getSumTotal;

            return Ok(order);
        }


    }
}
