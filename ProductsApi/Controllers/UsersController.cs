using Microsoft.AspNetCore.Authentication.JwtBearer; // JWT kimlik doğrulama işlemleri için gereken kütüphane.
using Microsoft.Extensions.DependencyInjection; // Bağımlılık enjeksiyonu (DI) hizmetleri için gerekli kütüphane.
using Microsoft.IdentityModel.Tokens; // JWT'nin imzalama ve doğrulama işlemleri için kullanılan sınıfları sağlar.
using System.IdentityModel.Tokens.Jwt; // JWT token oluşturma ve yönetme işlemleri için gereken sınıfları içerir.
using System.Security.Claims; // Kullanıcıya ait kimlik bilgilerini ve haklarını belirten `Claim` sınıfını içerir.
using Microsoft.AspNetCore.Mvc; // ASP.NET Core'da MVC yapısını ve Controller tabanlı işlemleri gerçekleştirmek için gerekli kütüphane.
using Microsoft.AspNetCore.Identity; // Kullanıcı yönetimi ve kimlik doğrulama işlemleri için kullanılan kütüphane.
using System.Text; // String işlemlerini ve kodlamalarını sağlayan kütüphane.
using ProductsApi.Models; // Projedeki modelleri içeren ad alanı.
using ProductsApi.DTO; // Data Transfer Object'leri (DTO) içeren ad alanı, veriyi taşımak için kullanılır.

namespace ProductsApi.Controllers
{
    [ApiController] // Bu sınıfın bir API controller olduğunu belirtir.
    [Route("api/[controller]")] // Bu controller'ın "api/[controller]" yolunda erişileceğini belirtir. [controller] yerine controller adı gelir (Users).

    public class UsersController : ControllerBase // UsersController, API işlemlerini yönetir. ControllerBase, temel controller işlevlerini sağlar.
    {
        private readonly UserManager<AppUser> _userManager; // ASP.NET Identity ile kullanıcı yönetimi yapılmasını sağlar.
        private readonly SignInManager<AppUser> _signInManager; // Kullanıcı giriş ve çıkış işlemlerini yöneten sınıf.

        // Configuration ile appsettings.json dosyasındaki değerleri alabiliriz.
        private readonly IConfiguration _configuration; // Uygulama yapılandırmalarını okur, özellikle JWT için gizli anahtar gibi değerleri alır.

        public UsersController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IConfiguration configuration)
        {
            _userManager = userManager; // Kullanıcı yönetimi bağımlılığını enjekte eder.
            _signInManager = signInManager; // Giriş işlemleri yönetimini enjekte eder.
            _configuration = configuration; // Yapılandırma bağımlılığını enjekte eder.
        }

        [HttpPost("register")] // HTTP POST isteklerini "register" yoluna bağlar.
        public async Task<ActionResult> CreateUser(UserDTO model) // Kullanıcı kayıt işlemini gerçekleştirir.
        {

            if (!ModelState.IsValid) // Model geçerli değilse, hatalı durumu döner.
            {
                return BadRequest(ModelState); // Hatalı model verisi gönderilirse, 400 Bad Request yanıtı döner.
            }

            // Yeni bir AppUser nesnesi oluşturur, kullanıcıdan gelen verilerle doldurur.
            var user = new AppUser
            {
                FullName = model.FullName, // Kullanıcının tam adını ayarlar.
                UserName = model.UserName, // Kullanıcının kullanıcı adını ayarlar.
                Email = model.Email, // Kullanıcının e-posta adresini ayarlar.
                DateAdded = DateTime.Now // Kullanıcının eklenme tarihini şu anki tarih olarak ayarlar.
            };

            // Kullanıcıyı oluşturur ve belirlenen şifreyle kaydeder.
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded) // Kullanıcı başarıyla oluşturulduysa...
            {
                return StatusCode(201); // 201 Created yanıtı döner.
            }

            return BadRequest(result.Errors); // Oluşumda hata varsa, 400 Bad Request döner ve hataları iletir.

        }

        [HttpPost("login")] // HTTP POST isteklerini "login" yoluna bağlar.
        public async Task<IActionResult> Login(LoginDTO model)
        {
            // Kullanıcının e-posta adresine göre kullanıcıyı bulur.
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null) // Eğer kullanıcı bulunamazsa...
            {
                return BadRequest(new { message = "Email Hatalı!" }); // E-posta hatalı mesajı ile 400 Bad Request döner.
            }

            // Şifreyi kontrol eder ve kullanıcı doğrulamasını gerçekleştirir.
            var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);

            if (result.Succeeded) // Giriş işlemi başarılıysa...
            {
                return Ok(new { token = GenerateJWT(user) }); // Kullanıcıya JWT token döner.
            }

            return Unauthorized(); // Giriş başarısızsa, 401 Unauthorized döner.
        }

        // Kullanıcıya JWT token oluşturur.
        private object GenerateJWT(AppUser user)
        {
            var tokenHandler = new JwtSecurityTokenHandler(); // JWT token oluşturmak için handler sınıfı.
            var key = Encoding.ASCII.GetBytes(_configuration.GetSection("AppSettings:Secret").Value ?? ""); // Gizli anahtarı alır ve byte dizisine çevirir.
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                // JWT token'da kullanılacak claim'leri (hakları) ayarlar.
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()), // Kullanıcının Id'sini JWT'ye ekler.
                    new Claim(ClaimTypes.Name, user.UserName ?? ""), // Kullanıcının adını JWT'ye ekler.
                }),
                Expires = DateTime.UtcNow.AddDays(1), // Token'ın 1 gün sonra geçersiz olmasını sağlar.
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature) // Token'ı HMAC-SHA256 algoritmasıyla imzalar.
            };
            var token = tokenHandler.CreateToken(tokenDescriptor); // Token'ı oluşturur.
            return tokenHandler.WriteToken(token); // Oluşturulan token'ı string olarak döner.
        }
    }
}
