using DemoWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

using System.Web.Http;

namespace DemoWebApi.Controllers
{
    public class ProductsController : ApiController
    {
        List<Product> products = new List<Product>();
        //public ProductsController() { }

        public ProductsController(List<Product> products)
        {
            this.products = products;
        }

        static List<Product> products_sample = new List<Product>
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M },
            new Product { Id = 4, Name = "Ketchup", Category = "Groceries", Price = 16M }
        };
        
        
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        public IHttpActionResult PostProduct([FromBody]Product p)
        {
            products.Add(p);
            return Ok(p);
        }

        public IHttpActionResult PutProduct([FromBody]Product p)
        {
            products[products.FindIndex(ind => ind.Id == p.Id)] = p;
            return Ok(p);
        }

        public IHttpActionResult DeleteProduct(int i)
        {
            products.RemoveAt(i);
            return Ok();
        }



        }
}
