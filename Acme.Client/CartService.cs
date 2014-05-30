using System.Collections.Generic;

namespace Acme.Client
{
    public class CartService
    {
        private readonly Dictionary<string, int> _productQuantities = new Dictionary<string, int>(); 

        public void AddToCart(string productName)
        {
            //if the dictionary does not contain the product
            if (!_productQuantities.ContainsKey(productName))
            {
                //then add with a quantity of 1
                _productQuantities.Add(productName, 1);
                return;
            }

            //otherwise increment the quantity
            _productQuantities[productName] = _productQuantities[productName] + 1;

        }

        public IDictionary<string, int> ProductsInCart { get { return _productQuantities; }} 
    }
}
