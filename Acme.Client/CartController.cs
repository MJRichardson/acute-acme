using System.Linq;

namespace Acme.Client
{
    public class CartController : Acute.Controller
    {
        private readonly CartService _cartService;

        public CartController(CartService cartService)
        {
            _cartService = cartService;
        }

        public override void Control(dynamic scope)
        {
            scope.CartIsEmpty = !_cartService.ProductsInCart.Any(); 

            scope.ProductQuantities = _cartService.ProductsInCart
                .Select(x => new {Name = x.Key, Quantity = x.Value})
                .ToList();

        }

    }
}
