using Acute;

namespace Acme.Client
{
    public class AcmeApp : Acute.App
    {
        protected override void ConfigureRoutes(RouteProvider routeProvider)
        {
            routeProvider.When("/cart", new RouteConfig {TemplateUrl = "cart.html"});
            routeProvider.Otherwise(new RouteConfig<ProductsController> {TemplateUrl = "products.html"});
        }
    }
}
		
