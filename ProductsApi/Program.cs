// Gerekli kütüphanelerin dahil edilmesi. Bu kütüphaneler, veritabanı bağlantısı, kimlik doğrulama, 
// JWT işlemleri ve API yapılandırması gibi işlevler için gereklidir.
using ProductsApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using Microsoft.OpenApi.Models;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Uygulama için yapılandırma nesnesi oluşturuluyor.
var builder = WebApplication.CreateBuilder(args);

//CORS, verilmiş endpoint'ten gelen isteklere yanıt dönecektir. Buraya birden fazla endpoint eklenebilir. herhangi bir method ya da header kabul edilir.
builder.Services.AddCors(options => {
    options.AddPolicy(MyAllowSpecificOrigins, policy => {
        policy.WithOrigins("http://localhost:5283")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

// Veritabanı bağlantısı yapılandırılıyor.
// Burada SQLite kullanılıyor ve "products.db" adlı bir veritabanı dosyası belirleniyor.
builder.Services.AddDbContext<ProductsContext>(options => 
    options.UseSqlite("Data Source=products.db"));

// Identity sistemi ekleniyor. 
// Kullanıcı yönetimi (AppUser) ve rol yönetimi (AppRole) ile EntityFramework üzerinden Identity işlemleri yapılabiliyor.
builder.Services.AddIdentity<AppUser, AppRole>()
    // Identity için veritabanı olarak ProductsContext kullanılıyor.
    .AddEntityFrameworkStores<ProductsContext>();

// Identity için çeşitli seçenekler yapılandırılıyor. 
// Şifre gereksinimleri, kilitleme mekanizması gibi ayarlar bu kısımda belirleniyor.
builder.Services.Configure<IdentityOptions>(options => {
    // Şifrenin minimum uzunluğunu 6 karakter olarak ayarlıyoruz.
    options.Password.RequiredLength = 6;
    
    // Şifrede özel karakter gerekmiyor.
    options.Password.RequireNonAlphanumeric = false;
    
    // Şifrede küçük harf kullanımı zorunlu değil.
    options.Password.RequireLowercase = false;
    
    // Şifrede büyük harf kullanımı zorunlu değil.
    options.Password.RequireUppercase = false;
    
    // Şifrede sayı kullanımı zorunlu değil.
    options.Password.RequireDigit = false;

    // Kullanıcıların benzersiz e-posta adresine sahip olmasını zorunlu hale getiriyoruz.
    options.User.RequireUniqueEmail = true;

    // Hatalı giriş denemelerinin maksimum sayısı 5 olarak ayarlanıyor.
    options.Lockout.MaxFailedAccessAttempts = 5;

    // Hatalı giriş denemelerinden sonra kullanıcının hesabının 5 dakika boyunca kilitlenmesini sağlıyoruz.
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
});

// JWT ile kimlik doğrulama sistemi ekleniyor.
builder.Services.AddAuthentication(item => {
    // Varsayılan kimlik doğrulama şeması olarak JWT Bearer kullanılıyor.
    item.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;

    // Kimlik doğrulama başarısız olduğunda yine JWT Bearer kullanılıyor.
    item.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
// JWT Bearer token doğrulama işlemleri burada yapılandırılıyor.
.AddJwtBearer(item => {
    // HTTPS zorunlu olmadan token kabul edilmesini sağlar. 
    // Geliştirme ortamında false olarak ayarlanır, ancak üretim ortamında true olmalıdır.
    item.RequireHttpsMetadata = false;

    // Token doğrulama için kullanılan parametreler.
    item.TokenValidationParameters = new TokenValidationParameters{
        // Token'ın issuer (oluşturan taraf) bilgisinin doğrulanıp doğrulanmayacağını belirtir. 
        // Burada false olduğundan doğrulama yapılmayacak.
        ValidateIssuer = false,

        // Token’ın geçerli issuer değeridir. 
        // Ancak ValidateIssuer false olduğu için bu değer doğrulanmayacaktır.
        ValidIssuer = "sadikturan.com",

        // Token’ın hedef kitlesinin doğrulanıp doğrulanmayacağını belirler.
        // Burada false olduğundan audience doğrulaması yapılmayacak.
        ValidateAudience = false,

        // Hedef kitle (audience) değerini boş bıraktık.
        ValidAudience = "",

        // Token birden fazla hedef kitle için geçerli olabilir.
        // Ancak ValidateAudience false olduğu için bu değerler kontrol edilmeyecek.
        ValidAudiences = new string[] {"a", "b"},

        // Token’ın imzasının doğrulanması gerektiğini belirtir. Bu, güvenlik açısından önemlidir.
        ValidateIssuerSigningKey = true,

        // Token'ın imzasını doğrulamak için kullanılan simetrik anahtar.
        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.ASCII.GetBytes(
                // Gizli anahtar, AppSettings bölümünden alınıyor.
                builder.Configuration.GetSection("AppSettings:Secret").Value ?? ""
            )
        ),

        // Token’ın süresinin dolup dolmadığını kontrol eder.
        ValidateLifetime = true
    };
});

// Controller sınıflarını hizmet olarak ekler.
// Bu sayede API istekleri route'lar üzerinden yönlendirilecektir.
builder.Services.AddControllers();

// Swagger, API belgeleri oluşturmak için kullanılır.
// EndpointsApiExplorer, API uç noktalarının keşfedilmesini sağlar.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(setup =>
{
    // Include 'SecurityScheme' to use JWT Authentication
    var jwtSecurityScheme = new OpenApiSecurityScheme
    {
        BearerFormat = "JWT",
        Name = "JWT Authentication",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = JwtBearerDefaults.AuthenticationScheme,
        Description = "Put **_ONLY_** your JWT Bearer token on textbox below!",

        Reference = new OpenApiReference
        {
            Id = JwtBearerDefaults.AuthenticationScheme,
            Type = ReferenceType.SecurityScheme
        }
    };

    setup.AddSecurityDefinition(jwtSecurityScheme.Reference.Id, jwtSecurityScheme);

    setup.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        { jwtSecurityScheme, Array.Empty<string>() }
    });

});

// Uygulamanın yapılandırma ve çalışma aşamasına geçiliyor.
var app = builder.Build();

// Geliştirme ortamındaysak, Swagger UI aracılığıyla API belgelerini görüntüleme aktif hale gelir.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// HTTP üzerinden yapılan talepler HTTPS'e yönlendirilir. Güvenli bağlantı için kullanılır.
app.UseHttpsRedirection();

// Kimlik doğrulama işlemlerini etkinleştirir.
// Bu adım, belirlenen JWT ayarlarına göre kullanıcının doğrulanmasını sağlar.
app.UseAuthentication();

app.UseRouting();

//Corse İçin Gerekli eklemeler, static dosyalardan önce eklenemeli
app.UseCors(MyAllowSpecificOrigins);

// Kullanıcı yetkilendirme işlemlerini devreye sokar.
// Yetkili olup olmadığını kontrol eder.
app.UseAuthorization();

// API route'ları kullanıma açılır ve controller'lar aracılığıyla API talepleri işlenir.
app.MapControllers();

// Uygulama başlatılır ve talepleri kabul etmeye başlar.
app.Run();
