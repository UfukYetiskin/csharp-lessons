using Microsoft.AspNetCore.Mvc; // ASP.NET Core MVC çerçevesine ait sınıflar ve özellikleri sağlar.
using System.Collections.Generic; // Generic koleksiyon tiplerini kullanabilmemiz için gerekli olan kütüphane.

namespace WebAPIProject{
    // Bu sınıfın bir API controller olduğunu belirtir.
    [ApiController]
    // Controller'ın kök rotasını belirler, örneğin '/auth'.
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost()]
        public ResponseModel Login(LoginModel loginModel){
            if(loginModel.Username != "admin" || loginModel.Password != "123"){
                return new ResponseModel{
                    IsSuccess = false,
                    Message = "Invalid username or password"
                };
            }else{
                return new ResponseModel{
                    IsSuccess = true,
                    Token = "123asdasnkl",
                    Message = "Login successful"
                };
            }
        }
    }
}

public class LoginModel{
    public string Username { get; set; }
    public string Password { get; set; }
}

public class ResponseModel{
    public string Token { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}