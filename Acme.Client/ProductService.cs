using System.Collections.Generic;
using System.Threading.Tasks;
using Acute.Services;

namespace Acme.Client
{
    public class ProductService
    {
        private readonly IHttp _http;

        public ProductService(IHttp http)
        {
            _http = http;
        }

        public Task<IEnumerable<Product>> GetAllProducts()
        {
            return _http.GetAsync("/api/products")
                .ContinueWith(result => result.Result.DataAs<IEnumerable<Product>>());
        }
    }
}
