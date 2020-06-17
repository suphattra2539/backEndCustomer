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

namespace WebApplication1.Controllers
{
    public class ProductsController : ApiController
    {
        private ExamsEntities db = new ExamsEntities();


        public IEnumerable<Product_TestViewModel> GetAllProduct()
        {
            var products = db.Products.Select(x => new Product_TestViewModel
            {
                ID_Product = x.ProductID,
                Name_P = x.Name,
                Price_P = x.Price,
            }).ToList();
            return products;
        }

        public IHttpActionResult GetProducts(int id)
        {
            var product = db.Products.Where(prod => prod.ProductID == id).Select(x => new Product_TestViewModel() 
            {

                ID_Product = x.ProductID,
                Name_P = x.Name,
                Price_P = x.Price,
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

        public IHttpActionResult updateProduct(int id, Product_TestViewModel productView)
        {
            var productUp = db.Products.Where(x => x.ProductID == id).FirstOrDefault();

            if (productUp != null)
            {
                productUp.Name = productView.Name_P;
                productUp.Price = productView.Price_P;
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
