using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Data.Entity;
using WebApplication1.Models;
using System.Security.Cryptography.X509Certificates;
using System.Web.UI.WebControls;
using System.Security.AccessControl;
using WebApplication1.Models.ViewModel;
using System.Data.Entity.Migrations;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Data;

namespace WebApplication1.Controllers
{
   [RoutePrefix("api/Customer")]
    public class CustomersController : ApiController
    {
        private ExamsEntities db = new ExamsEntities();

         public IEnumerable<CustomerViewModel> GetAllCustomer()
         {
             var customers = db.Customers.Select(x => new CustomerViewModel()
             {
                 Id = x.CustomerID,
                 Name = x.Name,
             }).ToList();
             return customers;
         }
        public IHttpActionResult GetCustomer(int id )
        {

            CustomerViewModel1 kon = new CustomerViewModel1(999);
            kon.Run();
            var customer = db.Customers.Where(prod => prod.CustomerID == id).Select(x => new CustomerViewModel()
            {
                Id = x.CustomerID,
                Name = x.Name,
                Orders = x.Orders.Select(o => new OrderViewModel()
                {
                    OrderId = o.OrderID,
                    OrderDate = o.OrderDate,

                }).ToList()
            }).FirstOrDefault();
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpGet]
        [Route("CustomerOrder")]
        public IHttpActionResult GetCustomer2(int customerId, string orderId)
        {
            var customer = db.Customers.Where(prod => prod.CustomerID == customerId).Select(x => new CustomerViewModel()
            {
                Id = x.CustomerID,
                Name = x.Name,
                Orders = x.Orders.Where(c => c.OrderID == orderId).Select(o => new OrderViewModel()
                {
                    OrderId = o.OrderID,
                  //  OrderDate = o.OrderDate,
                }).ToList()
            }).FirstOrDefault();
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }


        public IHttpActionResult CreateCustomer(CreateCustomerViewModel customer)
        {
            var record = db.Customers.Select(p => p.CustomerID == db.Customers.Max(r => r.CustomerID)).ToList();

            int CustomerIDMAX = db.Customers.Max(u => u.CustomerID);
            var create = db.Customers.Add(new Customer()
            {
                CustomerID = CustomerIDMAX + 1,
                Name = customer.Name,
                Age = customer.Age,
            });

            db.SaveChanges();

            return Ok(new CustomerViewModel()
            {
                Id = CustomerIDMAX,
                Name = customer.Name,
            });
        }

        //public IHttpActionResult CreateCustometGetId(customerGatId customerGatId)
        //{
        //    var DataCreate = new CustomersGetId();
        //    DataCreate.ID = customerGatId.ID;
        //    DataCreate.FullName = customerGatId.FullName;   // DataCreate.FullName = customerGatId.FullName;

        //    var CreateCustomerGetId = db.CustomersGetIds.Add(DataCreate);

        //    db.SaveChanges();
        //    return Ok(DataCreate);
        //}

        public IHttpActionResult UpdateCustomer(int Id, CreateCustomerViewModel customer)
        {
            var Update = db.Customers.Where(x => x.CustomerID == Id).FirstOrDefault();
            if (Update != null)
            {
                Update.Name = customer.Name;
                Update.Age = customer.Age;
            }
            db.SaveChanges();
            return Ok(Update);

        }
       /*  public IHttpActionResult deleteCustomer(int id)
         {
             var delete = db.Customers.Where(x => x.CustomerID == id).FirstOrDefault();
             if(delete != null)
             {
                 //db.Customers.Remove(delete);
                 db.Entry(delete).State = System.Data.Entity.EntityState.Deleted;
             };

             db.SaveChanges();
             return Ok(delete);
         }*/
        public IHttpActionResult deleteCustomertest(int id)
        {
            var delete = db.CustomersDeletes.Where(x => x.ID == id).FirstOrDefault();
            if (delete != null)
            {
                db.CustomersDeletes.Remove(delete);
               // db.Entry(delete).State = System.Data.Entity.EntityState.Deleted;
            };

            db.SaveChanges();
            return Ok(delete + "OK");
        }
        /* public IHttpActionResult UpdateData(int id, string name, string category, int price  )
         {
             // UPDATE dbo.Person SET is_default = 0 WHERE person_id = 5

             var customer = db.Customers.Where(prod => prod.CustomerID == id)
                            .FirstOrDefault();
             if (customer == null)
             {
                 return NotFound();
             }else
             {

                     var customer1 = db.Customers.Where(prod => prod.CustomerID == id)
                            .FirstOrDefault();
             }
             return Ok(customer);
         }*/
        /*  public IHttpActionResult PostCustomer(int Id, string Name, int Age)
          {
              var f = db.Customers.Where(x => x.CustomerID == Id)
                                  .FirstOrDefault();

              f.Name = Name;
              f.Age = Age;
              db.SaveChanges();
          }*/

        /* public IHttpActionResult Edit(int Id)
         {
             var std = db.Customers.Where(s => s.CustomerID == Id).FirstOrDefault();

             return View(std);
         }*/

    }
}

/*
  using (var ctx = new SchoolDBEntities())
                {
                    f.Customer.Add(new Customer()
                    {
                        CustomerID = Customer.Id,
                        Name = Customer.Name,
                        Age = Customer.Age
                    });
                    f.SaveChanges();
                }
                return Ok();*/

/*
 /* public IEnumerable<CustomerViewModel> GetAllCustomer()
         {
             var customers = db.Customers.Select(x => new CustomerViewModel()
             {
                 CustomerId = x.CustomerID,
                 FullName = x.Name,
                 OrdersBy = x.Orders.OrderByDescending(o=>o.OrderDate).Select(o => new OrderViewModel()
                 {
                     OrderId = o.OrderID,
                     Time = o.OrderDate
                 }).FirstOrDefault()
             });
             return customers;
 */
