using Microsoft.AspNetCore.Mvc; // MVC mimarisi ve Controller işlemleri için gerekli kütüphane.
using Microsoft.EntityFrameworkCore; // Entity Framework Core kütüphanesi, veritabanı işlemleri için kullanılır.
using ProductsApi.Models; // Projedeki modelleri içeren ad alanı.
using ProductsApi.DTO; // Data Transfer Object (DTO) sınıflarını içeren ad alanı.
using Microsoft.AspNetCore.Authorization; // Yetkilendirme işlemleri için kullanılan kütüphane (JWT gibi).

namespace ProductsApi.Controllers
{
    [ApiController] // Bu sınıfın bir API controller olduğunu belirtir.
    [Route("api/[controller]")] // Bu controller'a "api/[controller]" (controller adı Products olacaktır) yoluyla erişileceğini belirtir.
    public class ProductsController : ControllerBase // ProductsController, temel controller işlevlerine sahiptir.
    {
        private readonly ProductsContext _context; // Veritabanı işlemleri için kullanılan context.

        public ProductsController(ProductsContext context) // Constructor ile veritabanı context'ini enjekte eder.
        {
            _context = context;
        }

        [HttpGet] // HTTP GET isteği için bu methodu bağlar.
        public async Task<IActionResult> GetProducts() // Tüm ürünleri getirir.
        {
            // Veritabanından aktif ürünleri seçer ve DTO'ya dönüştürür.
            var products = await _context.Products
                .Where(item => item.IsActive == true) // Yalnızca aktif ürünleri getirir.
                .Select(item => new ProductDTO{
                    ProductId = item.ProductId, // Ürün ID'sini DTO'ya ekler.
                    ProductName = item.ProductName, // Ürün adını DTO'ya ekler.
                    Price = item.Price // Ürün fiyatını DTO'ya ekler.
                }).ToListAsync();

            if (products == null) // Eğer ürün bulunamazsa...
            {
                return NotFound(); // 404 Not Found döner.
            }
            return Ok(products); // Ürünler başarıyla bulunursa, 200 OK döner ve ürün listesini içerir.
        }

        [Authorize] // Bu method, yetkilendirilmiş (JWT ile doğrulanmış) kullanıcılar tarafından çağrılabilir.
        [HttpGet("{id}")] // HTTP GET isteği için bir ID parametresi alır.
        public async Task<ActionResult<Product>> GetProduct(int? id) // Belirtilen ID'ye sahip ürünü getirir.
        {
            if (id == null) // Eğer ID null ise...
            {
                return NotFound(); // 404 Not Found döner.
            }

            // Belirtilen ID'ye sahip ürünü veritabanından bulur ve DTO'ya dönüştürür.
            var p = await _context.Products
                .Where(item => item.ProductId == id)
                .Select(item => ProductToDTO(item)) // Ürünü DTO'ya çevirir.
                .FirstOrDefaultAsync();

            if (p == null) // Eğer ürün bulunamazsa...
            {
                return NotFound(); // 404 Not Found döner.
            }

            return Ok(p); // Ürün başarıyla bulunursa, 200 OK döner ve ürünü içerir.
        }

        [HttpPost] // HTTP POST isteği için bu methodu bağlar.
        public async Task<IActionResult> CreateProduct(Product product) // Yeni ürün oluşturur.
        {
            if (product != null) // Eğer ürün geçerli ise...
            {
                _context.Products.Add(product); // Ürünü veritabanına ekler.
                await _context.SaveChangesAsync(); // Veritabanındaki değişiklikleri kaydeder.
                
                // Yeni oluşturulan ürün için 201 Created yanıtı döner.
                return CreatedAtAction(nameof(GetProduct), new { id = product.ProductId }, product);
            }
            return NotFound(); // Ürün geçerli değilse, 404 Not Found döner.
        }

        [HttpPut("{id}")] // HTTP PUT isteği ile güncelleme işlemi için ID parametresi alır.
        public async Task<IActionResult> UpdateProduct(int id, Product product) // Var olan ürünü günceller.
        {
            var entity = await _context.Products.FirstOrDefaultAsync(item => item.ProductId == id); // Güncellenecek ürünü bulur.
            if (entity == null || id == null) // Eğer ürün bulunamazsa...
            {
                return NotFound(); // 404 Not Found döner.
            }

            // Ürünün bilgilerini günceller.
            entity.ProductName = product.ProductName;
            entity.Price = product.Price;
            entity.IsActive = product.IsActive;

            await _context.SaveChangesAsync(); // Veritabanındaki değişiklikleri kaydeder.
            // Güncellenen ürün için 201 Created yanıtı döner.
            return CreatedAtAction(nameof(GetProduct), new { id = product.ProductId }, product);
        }

        [HttpDelete("{id}")] // HTTP DELETE isteği ile ürün silme işlemi için ID parametresi alır.
        public async Task<IActionResult> DeleteProduct(int id) // Belirtilen ID'ye sahip ürünü siler.
        {
            var product = await _context.Products.FindAsync(id); // Silinecek ürünü bulur.
            
            if (product == null || id == null) // Eğer ürün bulunamazsa...
            {
                return NotFound(); // 404 Not Found döner.
            }

            _context.Products.Remove(product); // Ürünü veritabanından kaldırır.
            await _context.SaveChangesAsync(); // Değişiklikleri kaydeder.

            // Kalan tüm ürünleri getirir ve 200 OK döner.
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }

        // Product modelini ProductDTO'ya çevirir.
        private static ProductDTO ProductToDTO(Product product)
        {
            var entity = new ProductDTO();
            if (product != null) // Eğer ürün geçerli ise...
            {
                entity.ProductId = product.ProductId; // DTO'ya ürün ID'sini ekler.
                entity.ProductName = product.ProductName; // DTO'ya ürün adını ekler.
                entity.Price = product.Price; // DTO'ya ürün fiyatını ekler.
            }
            return entity; // DTO'yu döner.
        }
    }
}
