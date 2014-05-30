using System;

namespace Acme.Client
{
    public class ProductsController : Acute.Controller
    {
        private readonly CartService _cartService;
        private readonly ProductService _productService;

        public ProductsController(CartService cartService, ProductService productService)
        {
            _cartService = cartService;
            _productService = productService;
        }

        public override void Control(dynamic scope)
        {
            _productService.GetAllProducts()
                .ContinueWith(task => scope.Products = task.Result);

            scope.AddToCart = (Action<string>)(productName => _cartService.AddToCart(productName));

        }
    }
}
