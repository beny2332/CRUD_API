using CRUD_API.Models;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace CRUD_API.Services
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;
        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Product>> GetAllProductsAsync()
        {
            var response = await _httpClient.GetAsync("https://fakestoreapi.com/products");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Product>>(json);

        }
    }
}
