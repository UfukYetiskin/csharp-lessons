using Microsoft.AspNetCore.Mvc;
using ProductsApi.Models;

namespace ProductsApi.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase {

        private static List<Product> _products = null!;

        public ProductsController() {
            _products = new List<Product>();
            _products.Add(new Product{ProductId = 1, ProductName = "IPhone 12", Price = 12000, IsActive = true });
            _products.Add(new Product{ProductId = 2, ProductName = "IPhone 13", Price = 13000, IsActive = true });
            _products.Add(new Product{ProductId = 3, ProductName = "IPhone 14", Price = 14000, IsActive = false });
            _products.Add(new Product{ProductId = 4, ProductName = "IPhone 15", Price = 15000, IsActive = true });
        }
        [HttpGet]
        public List<Product> GetProducts(){
            return _products ?? new List<Product>();
        }

        [HttpGet("{id}")]
        //or
        //[HttpGet("api/[controller]/id)]
        public Product? GetProduct(int id){
            return _products.FirstOrDefault(item => item.ProductId == id);
        }
    }
}