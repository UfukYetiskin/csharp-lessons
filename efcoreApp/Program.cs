using efcoreApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// 'builder.Services' ile servis koleksiyonuna bir servis ekleniyor.
// Bu, ASP.NET Core uygulamasının Dependency Injection (bağımlılık enjeksiyonu) sistemine 
// 'DataContext' sınıfını eklemek için kullanılır.
builder.Services.AddDbContext<DataContext>(options => {

    // 'builder.Configuration' ile uygulamanın yapılandırma ayarlarına erişiliyor.
    // Bu yapılandırma genellikle 'appsettings.json' gibi dosyalardan veya çevresel değişkenlerden alınır.
    var config = builder.Configuration;

    // 'GetConnectionString("database")' ile 'appsettings.development.json' dosyasındaki
    // "ConnectionStrings" bölümünden 'database' adlı bağlantı cümlesi alınıyor.
    var connectionString = config.GetConnectionString("database");

    // 'options.UseSqlite(connectionString)' ile veritabanı sağlayıcısı olarak SQLite kullanılıyor.
    // 'connectionString' burada SQLite veritabanına bağlanmak için gerekli olan bağlantı cümlesini içeriyor.
    options.UseSqlite(connectionString);
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
