using System.Collections.Generic;
using System.Web.Http;
using Acme.Web.Models;

namespace Acme.Web.Controllers
{
    public class ProductsController : ApiController
    {

        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return new[]
            {
                new Product
                {
                    Id = 1,
                    Name = "Giant Rubber-Band",
                    Description = "Perfect for tripping Road Runners",
                    Price = 0.99m
                },
                new Product
                {
                    Id = 2,
                    Name = "Earthquake Pills",
                    Description = "Why wait? Make your own earthquakes - loads of fun!",
                    Price = 10.00m
                }
            };
        }
    }
}
