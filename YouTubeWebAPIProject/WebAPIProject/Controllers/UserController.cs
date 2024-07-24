using Microsoft.AspNetCore.Mvc; // ASP.NET Core MVC çerçevesine ait sınıflar ve özellikleri sağlar.
using System.Collections.Generic; // Generic koleksiyon tiplerini kullanabilmemiz için gerekli olan kütüphane.

namespace WebAPIProject.Controllers
{
    // Bu sınıfın bir API controller olduğunu belirtir.
    [ApiController]
    // Controller'ın kök rotasını belirler, örneğin '/user'.
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        // Kullanıcı bilgilerini temsil eden bir model sınıfı oluşturuyoruz.
        public class User
        {
            public int Id { get; set; } // Kullanıcı ID
            public string FirstName { get; set; } // Kullanıcı adı
            public string LastName { get; set; } // Kullanıcı soyadı
            public int Age { get; set; } // Kullanıcı yaşı
        }

        // Bu metodun HTTP GET isteği ile çalışacağını belirtir.
        // Ek olarak '/getUsers' rotası ile erişilebilir.
        [HttpGet("getUsers")]
        public IEnumerable<User> Get()
        {
            // Kullanıcıların bilgilerini içeren bir liste döndürür.
            return new List<User>
            {
                new User { Id = 1, FirstName = "John", LastName = "Doe", Age = 30 },
                new User { Id = 2, FirstName = "Jane", LastName = "Smith", Age = 25 },
                new User { Id = 3, FirstName = "Michael", LastName = "Johnson", Age = 40 },
                new User { Id = 4, FirstName = "Emily", LastName = "Davis", Age = 35 }
            };
        }

        [HttpGet("getUserById/{id}")]
        public User GetById(int id)
        {
            // Kullanıcı ID'sine göre kullanıcı bilgilerini döndürür.
            switch (id)
            {
                case 1:
                    return new User { Id = 1, FirstName = "John", LastName = "Doe", Age = 30 };
                case 2:
                    return new User { Id = 2, FirstName = "Jane", LastName = "Smith", Age = 25 };
                case 3:
                    return new User { Id = 3, FirstName = "Michael", LastName = "Johnson", Age = 40 };
                case 4:
                    return new User { Id = 4, FirstName = "Emily", LastName = "Davis", Age = 35 };
                default:
                    return null;
            }
        }

        [HttpGet("myName")]
        public string GetName()
        {
            // Ad ve soyadı döndürür.
            return "John Doe";
        }
    }
}
