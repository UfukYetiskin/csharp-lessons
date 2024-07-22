// WebApplicationBuilder nesnesi oluşturuluyor ve komut satırı bağımsız değişkenleri alınıyor
var builder = WebApplication.CreateBuilder(args);

// Hizmetlerin konteynere eklenmesi
// API uç noktalarını tarayarak ilgili meta verileri otomatik olarak ekler
builder.Services.AddEndpointsApiExplorer();
// Swagger/OpenAPI belgelerini üretmek için gereken hizmetleri ekler
builder.Services.AddSwaggerGen();

// Uygulamayı inşa ediyor
var app = builder.Build();

// HTTP istek hattının yapılandırılması
// Geliştirme ortamındaysa Swagger ve Swagger UI ara yazılımlarını kullanır
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Tüm HTTP isteklerini HTTPS'ye yönlendirir
app.UseHttpsRedirection();

// Hava durumu açıklamalarının yer aldığı bir dizi
var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

// GET isteği geldiğinde çalışacak olan bir uç nokta tanımlanıyor
app.MapGet("/weatherforecast", () =>
{
    // Rastgele hava durumu tahminleri içeren bir dizi döndürülüyor
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast") // Uç noktaya kolayca başvurmak için bir isim veriliyor
.WithOpenApi(); // Bu uç noktanın OpenAPI dokümantasyonunda görünmesini sağlar

// Uygulama çalışma zamanında HTTP isteklerini dinlemeye başlıyor
app.Run();

// Hava durumu tahminlerini temsil eden record tipi
record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    // Sıcaklığın Fahrenheit cinsinden hesaplanmasını sağlar
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
