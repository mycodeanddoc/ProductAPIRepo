using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Lemon Soup", Category = "Soup", Price = 9 },
            new Product { Id = 2, Name = "Diamond Ring", Category = "Jewelery", Price = 1500.75M },
            new Product { Id = 3, Name = "Acer Predator X", Category = "Computer", Price = 105.99M }
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

        public ProductsController()
        {
        }
        public ProductsController(Product[] products)
        {
            this.products = products;
        }

    }
}