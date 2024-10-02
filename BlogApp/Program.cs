using BlogApp.Data.Abstract;
using BlogApp.Data.Concrete;
using BlogApp.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Controller'ın projede okunması için
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BlogContext>(options => {
    var config = builder.Configuration;
    var connectionString  = config.GetConnectionString("sql_connection");
    options.UseSqlite(connectionString);
});

builder.Services.AddScoped<IPostRepository, EfPostRepository>();

var app = builder.Build();
SeedData.TestVerileriniDoldur(app);

//Default route yapısının /Home/Action/id kullanılması
app.MapDefaultControllerRoute();



app.Run();
