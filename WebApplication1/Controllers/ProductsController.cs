using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Data.Entity;
using WebApplication1.Models;
using System.Web.UI.WebControls;
using WebApplication1.Models.ViewModel;
using System.Reflection.Emit;

namespace WebApplication1.Controllers
{
    public class ProductsController : ApiController
    {
        private ExamsEntities db = new ExamsEntities();


        public IEnumerable<Product_TestViewModel> GetAllProduct()
        {
            var products = db.Products.Select(x => new Product_TestViewModel
            {
                ProductID = x.ProductID,
                Name = x.Name,
                Price = x.Price,
            }).ToList();
            return products;
        }

        public IHttpActionResult GetProducts(int id)
        {
            if (id == 0)
            {
                return Ok(new Product_TestViewModel());
            }
            var product = db.Products.Where(prod => prod.ProductID == id).Select(x => new Product_TestViewModel() 
            {

                ProductID = x.ProductID,
                Name = x.Name,
                Price = x.Price,
            }).FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(product);
            }
            
        }

        public IHttpActionResult updateProduct(int id, ProductEditViesModel productView)
        {
            var productUp = db.Products.Where(x => x.ProductID == id).FirstOrDefault();

            if (productUp != null)
            {
                productUp.Name = productView.Name;
                productUp.Price = productView.Price;
                db.SaveChanges();
            }
            else
            {
                return BadRequest("error");
            }
            return Ok(productUp);
        }

        public IHttpActionResult createProduct(CreateProductVM createProduct)
        {
            var customerIdMax = db.Products.Select(x => x.ProductID == db.Products.Max(m => m.ProductID)).ToList();


            return Ok(customerIdMax);
        }
    }
}
