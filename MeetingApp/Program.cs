//builder, uygulamanın gereksinim duyduğu servislerin ve yapılandırmaların başlatma aşamasında eklenip düzenlenmesini sağlayan bir nesnedir.
var builder = WebApplication.CreateBuilder(args);

// MVC şablonu ile çalışmak istediğimizi belirttik.
// Bu, Controller'lar ve Razor View'lar ile çalışmak için gerekli servisleri ekler.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Statik dosyaların sunulmasını sağlar.
// Örneğin, wwwroot dizinindeki CSS, JS dosyaları veya libman ile eklenen kütüphaneler.
app.UseStaticFiles();

//ya da 
//İstediğimiz spesifik bir dosyayı da staticfiles olarak açmak istediğimiz takdirde
// app.UseStaticFiles(new StaticFileOptions
// {
//     FileProvider = new PhysicalFileProvider(
//            Path.Combine(builder.Environment.ContentRootPath, "MyStaticFiles")),
//     RequestPath = "/StaticFiles"
// });

// Uygulama için routing (yönlendirme) mekanizmasını etkinleştirir.
// Bu middleware, gelen isteklerin hangi rotaya yönlendirilmesi gerektiğini belirler.
app.UseRouting();

// REST API ve Razor Pages desteği eklenebilir. (Bu kodlarda mevcut değil)

// Route yapılandırması:
// "/controller/action/id" formatında bir URL yapısını kullanarak
// yönlendirmeleri Controller'lara bırakır.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

// Uygulamayı çalıştırır.
app.Run();
