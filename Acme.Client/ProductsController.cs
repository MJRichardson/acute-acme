using System;

namespace Acme.Client
{
    public class ProductsController : Acute.Controller
    {
        private readonly CartService _cartService;

        public ProductsController(CartService cartService)
        {
            _cartService = cartService;
        }

        public override void Control(dynamic scope)
        {
            scope.Products = new Product[]
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

            scope.AddToCart = (Action<string>)(productName => _cartService.AddToCart(productName));

        }
    }
}
