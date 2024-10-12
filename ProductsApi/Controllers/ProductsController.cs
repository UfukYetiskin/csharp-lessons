using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsApi.Models;


namespace ProductsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {

        private readonly ProductsContext _context;

        public ProductsController(ProductsContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _context.Products.ToListAsync();
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        [HttpGet("{id}")]
        //or
        //[HttpGet("api/[controller]/id)]
        public async Task<ActionResult<Product>> GetProduct(int? id)
        {
            if (id == null)
            {
                // 404 Not Found hatası döner
                return NotFound();
            }

            var p = await _context.Products.FirstOrDefaultAsync(item => item.ProductId == id);

            if (p == null)
            {
                return NotFound();
            }

            return Ok(p);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product){
            if(product != null){
                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                //return StatusCode(201, "Created Successfully!");
                //or
                return CreatedAtAction(nameof(GetProduct), new {id = product.ProductId}, product);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Product product){
            var entity = await _context.Products.FirstOrDefaultAsync(item => item.ProductId == id);
            if(entity == null || id == null){
                return NotFound();
            }
            entity.ProductName = product.ProductName;
            entity.Price = product.Price;
            entity.IsActive = product.IsActive;

            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProduct), new{id = product.ProductId}, product );
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id){
            var product = await _context.Products.FindAsync(id);
            

            if(product == null || id == null){return NotFound();}

            _context.Products.Remove(product);
            await  _context.SaveChangesAsync();
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }
    }
}