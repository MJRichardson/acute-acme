using Acute;

namespace Acme.Client
{
    public class AcmeApp : Acute.App
    {
        public AcmeApp()
        {
           Service<CartService>(); 
        }

        protected override void ConfigureRoutes(RouteProvider routeProvider)
        {
            routeProvider.When("/cart", new RouteConfig<CartController> {TemplateUrl = "cart.html"});
            routeProvider.Otherwise(new RouteConfig<ProductsController> {TemplateUrl = "products.html"});
        }
    }
}
	
