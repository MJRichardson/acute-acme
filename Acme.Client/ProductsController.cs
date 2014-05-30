using Acute;

namespace Acme.Client
{
    public class ProductsController : Controller
    {
        public override void Control(dynamic scope)
        {
	    scope.Products = new Product[]
		{
		   new Product{
		       Id =1, 
		       Name="Giant Rubber-Band", 
		       Description = "Perfect for tripping Road Runners", 
		       Price = 9.99m},  

		   new Product{
		       Id =2, 
		       Name="Earthquake Pills", 
		       Description = "Why wait? Make your own earthquakes - loads of fun!", 
		       Price = 11.00m },  

		   new Product{
		       Id =3, 
		       Name="Explosive Tennis Balls", 
		       Description = "Tickle your friends! Surprise your opponent!", 
		       Price = 25.40m }  
		};
        }
    }
}
