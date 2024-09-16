var builder = WebApplication.CreateBuilder(args);

//MVC şablonu ile çalışmak istediğimizi belirttik.
builder.Services.AddControllersWithViews();
var app = builder.Build();

//Rest API
//Razor PAges

//Static olarak route için bir çıktı verir.
// app.MapGet("/", () => "Hello World!");
// app.MapGet("/blog", () => "Blog Page!");

//Route yapısını controller'a bırakmak için.
// app.MapDefaultControllerRoute();
//ya da 
app.MapControllerRoute(
    name : "default",
    pattern : "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
