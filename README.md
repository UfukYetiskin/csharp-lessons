# csharp-lessons

## Access Modifiers (Erişim Değiştiriciler)

- Public : Her yerden ulaşabilir. Ayrı dosyadan ilgili public classına ulaşabiliriz. DenemeCalısmaAlanı üzerinden Calısma Alanında oluşturduğumuz Ogrenci clasına ulaşalım. İlk olarak DenemeCalısmaAlanı referans alacağı projeyi (CalısmaAlanı) Add referencez üzerinden ekliyoruz.

- Protected : Sadece kendi bloğunda ve Inherited (miras alınmış) sınıflarda çalışır.

- Internal : Bağlı bulunduğu proje grubunda(Assembly-meclis) yani CalısmaAlanı içerinde oluşturulan her projede classlara ulaşabilir.

- Private : Sadece tanımlandığı blokta çalışır. Farklı classlardan ulaşılmaz.

## OOP (Object Orientented Programming)

Nesne (Object), fonksiyonları ve işlevleri tek bir varlıkta toplayan bir öğedir. Bir sınıfın (class) somutlaştırılmış versiyonlarıdır. Kendi metotlarını (methods) ve özelliklerini (properties) içerir.

Sınıf, nesne yönelimli programlama dilinde, belirli türdeki nesneleri tanımlamak için kullanılır. Bir sınıf, bir veri yapısının yanı sıra bu veriyi işlemek için metotları (functions) içeren bir şablondur.

Modelleme, genellikle bir veritabanı şemasını temsil etmek için kullanılan sınıflar veya nesnelerin oluşturulmasını ifade eder. Bu modeller, genellikle bir uygulamanın iş mantığını çevreleyen ve işlemek üzere veri taşıyan nesnelerdir.

### CLASS Nedir?
Classlar bizim yapmak isteğimiz işlemleri gruplara ayırmak, o grup üzerinden işlemlerimizi yapmak ve rahatlıkla bu gruba ulaşmak için kullanabilirz.
- Bir class’ı kullanabilmek için onun örneğini(referansını) oluşturmamız gerekmektedir.
- Bir class oluştururken kelimenin ilk harfi büyük oluşturulur. Ama örneği oluşturulduğunda ilk harfi küçük, sonraki kelimelerin ilk harfi büyük yazılır.


```
class Ogrenci
{
    public string Name {get; set;}
    public string SurName {get; set;}
    public int Age {get; set;}
}
```

### 1. Inheritance (Kalıtım)
Kalıtım, bir sınıfın farklı bir sınıfın niteliklerini ve davranışlarını kendisine alması demektir.
Kalıtım yapan sınıfa alt sınıf deriz. KAlıtım yapılan sınıfa ise ata sınıf deriz. Ata sınıfta tanımlı olan her şey alt sınıf için de tanımlıdır.

#### Interface (Arayüz)

Bir sınıfın belirli bir yetenek setini uygulamak zorunda olduğu, sadece imzaları tanımlanmış yöntemler topluluğudur.

Bir sınıf birden fazla arayüzü implement edebilir.

```
interface IFlyable
{
    void Fly();
}

interface ISwimmable
{
    void Swim();
}

class Duck : IFlyable, ISwimmable
{
    public void Fly()
    {
        Console.WriteLine("Flying...");
    }

    public void Swim()
    {
        Console.WriteLine("Swimming...");
    }
}
```
#### Interface ile Inheritance Arasındaki Fark
- Miras Alma Şekli; Inheritance, sınıflar arasında bir hiyerarşi oluşturur ve base class'ın tüm üyelerini devralır. Interface, bir sınıfa belirli yöntemlerin implement edilmesini zorunlu kılar, ancak uygulama detayı içermez.
- Çoklu Kalıtım; Inheritance, tekil kalıtım destekler. Bir sınıf sadece bir sınıftan türetilebilir. Interface, bir sınıf birden fazla arayüzü implement edebilir. Çok arayüz implementasyonu mümkündür.
- İçerik; Inheritance,hem işlevsel metodlar hem de değişkenler/alanlar içerebilir. Interface, sadece metod imzaları ve özellik tanımları içerir. Herhangi bir işlevsellik ya da değişken içermez.
- Kullanım Amacı; Inheritance, davranış ve veri paylaşımı için kullanılır. Interface, belirli bir yetenek veya davranışın zorunlu kılınması için kullanılır.

#### Tek Yönlü Kalıtım (Single Inheritance)
Bir sınıfın sadece bir sınıftan kalıtım yapmasına tek yönlü kalıtım denir.

```
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }
}
```

#### Çoklu Kalıtım(Multiple Inheritance)
Bir sınıfın birden fazla sınıftan kalıtım yapmasına çoklu kalıtım denir.
C# dilinde çoklu kalıtım desteklenmez. Ancak çoklu kalıtım yapısını kullanmak için bir sınıfın birden fazla sınıftan kalıtım yapmasını sağlayan bir yapı vardır. Bu yapıda sınıfların hepsi interface olmalıdır.

### 2. Encapsulation (Kapsülleme)

Davranış ve özellikler sınıfta soyutlanır ve saklanır. Kapsülleme ile hangi özellik ve davranışın dışarıdan kullanılacağını belirleyebiliriz.

```
class Book
{
    //Field
    private string kitapAdi;
    private string yazar;
    private int sayfaSayisi;

    //property
    public string yayinci;

    public Book()
    {
    }

    //Constructor (Yapıcı Metot), sınıfın nesnesi oluşturulduğunda çalışan metottur.
    public Book(string kitapAdi, string yazar, int sayfaSayisi)
    {
        this.kitapAdi = kitapAdi;
        this.yazar = yazar;
        this.sayfaSayisi = sayfaSayisi;
    }

    public string getKitapAdi()
    {
        return kitapAdi;
    }

    public void setKitapAdi(string kitapAdi)
    {
        this.kitapAdi = kitapAdi;
    }

    public string getYazar()
    {
        return yazar;
    }

    public void setYazar(string yazar)
    {
        this.yazar = yazar;
    }

    public int getSayfaSayisi()
    {
        return sayfaSayisi;
    }

    public void setSayfaSayisi(int sayfaSayisi)
    {
        this.sayfaSayisi = sayfaSayisi;
    }
}
```


### 3. ABSTRACT CLASS(SOYUTLAMA)
Bir sınıf için nesne üretmek mantıksız gelirse o sınıf soyutlanabilir. Soyutlanan sınıfların nesne üretilemez.
Soyutlanan sınıfların içerisinde soyut metotlar bulunabilir. Soyut metotlar sınıfın alt sınıflarında implemente edilmek zorundadır.
Soyut sınıflar abstract anahtar kelimesi ile tanımlanır.

```
public abstract class Shape
{
    // Soyut metod - türetilen sınıflar tarafından implement edilecek
    public abstract double CalculateArea();

    // Concrete metod - ortak özellikleri içerir
    public void Display()
    {
        Console.WriteLine($"The area is {CalculateArea()} square units.");
    }
}
```

### 4. Polymorphism (Çok Biçimlilik)
Miras alma işleminden sonra herhangi bir alanda bulunan değerleri miras alınan sınıftaki haliyle değil de bizim istediğimiz şekilde kullanılmasına denir.

#### VİRTUAL METODLAR

Inheritace alınacak classtan bir metod override(ezmek) edilecekse yani o metodun bir özelliği farklı bir isimle çağırılacaksa virtual kullanılır.

```
class Animals
{
    private string name;
    private int age;

    public void Speak()
    {
        Console.WriteLine("Hayvan konuşuyor");
    }
}

class Dog : Animals
{
    public void Speak()
    {
        Console.WriteLine("Köpek Havlıyor! Wow Wow!");
    }
}

class Cat : Animals
{
    public void Speak()
    {
        Console.WriteLine("Kedi miyavlıyor! Miyav!");
    }
}

class Bird : Animals
{
    public void Speak()
    {
        Console.WriteLine("Kuş ötüyor! Cik Cik!");
    }
}
```
Speak methodu kalıtım alınmış sınıf içerisinde ezilerek istenildiği gibi çıktı verilmesi sağlanıyor.


## Web API Yaratmak

Web Api projesi oluşturmak için  bu komut çalıştırılır;
```
dotnet new webapi -n <ProjeIsmı>
```

### Solution
Bir veya daha fazla projeyi içeren ve bu projeler arasındaki bağımlılıkları yöneterek büyük yazılım sistemlerini organize eden bir kapsayıcı yapıdır. Yazılımcılar, kodun modülerliğini, yeniden kullanılabilirliğini ve bakımını iyileştirmek amacıyla solution kullanırlar. Solution dosyası oluşturmak için kullanılması gereken komut; 
```
dotnet new sln -n HowCanCreateWebAPISln
```

Oluşturmuş olduğumuz webapi projesini solution'a eklemek için kullanacağımız komut;
```
dotnet sln add <WEBAPIPROJECTNAME>
```

Bu komuttan sonra üretmiş olduğumuz solution içerisinde;
```
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "WebApiProject", "WebApiProject\WebApiProject.csproj", "{BA59A31F-63C2-48D6-B402-4B1B3AA1B58B}"
```
satırını göreceğiz. Bu sayede bu solution'a oluşturmuş olduğumuz projenin eklenmiş olduğunu göreceğiz.

#### Dosya Tanımları

##### Startup.cs
.NET 5 ve öncesinde, Startup.cs dosyası uygulamanın başlangıç konfigürasyonunu ve hizmet bağımlılıklarını yapılandırmak için kullanılır. Bu dosya genellikle iki ana metot içerir:
- ConfigureServices : Uygulama için gerekli olan servisleri ekler.
- Configure : HTTP istek hattını (middleware pipeline) konfigüre eder.

```
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Servisleri buraya ekleyin
        services.AddControllers();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        
        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
```

.NET 6 ve sonrasında, Startup.cs yerine minimal API yaklaşımı kullanılmaktadır. Bu yeni stil, daha sade ve deklaratif bir yapı sunar. Aşağıda .NET 8'de bunun nasıl yapıldığına dair bir örnek bulabilirsiniz:

```
var builder = WebApplication.CreateBuilder(args);

// Servisleri eklemek için kullanılır
builder.Services.AddControllers();

var app = builder.Build();

// Middleware pipeline yapılandırması
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
```

##### appsettings.json ve appsettings.Developerment.json Dosyaları

Bu ortam dosyalarını uygulama içerisinde ihtiyaç duyduğumuz statik ifadeleri metinsel formatta tutmak için kullanırız. Dosya yapısı olarak json formatı kullanılır.

appsettings.json içerisinde tutulabilecek ifadelere örnek olarak veritabanı bağlantı bilgilerini verebiliriz. Uygulama içerisinde her yere bağlantı bilgisi yazdığımızı düşünelim. Gün geldiğinde veritabanı değiştiğinde bu bağlantı bilgisini uygulamanın her yerinde değiştirmek zorunda kalırız. Ama tek bir dosya içerisinden yönetirsek, sadece bir yerde değiştirdiğimizde tüm uygulama değişen veriye erişmiş olur.

Genel olarak aşağıdaki 3 ortam için appsettings dosyaları uygulama içerisinde bulunur.

- Development : Uygulama geliştirme aşamasında kullanılacak ayarlar için bu ortam kullanılır.
- Test (Staging): Geliştirilmesi tamamlanmış test edilme aşamasında kullanılacak ayarlar için bu ortam kullanılır.
- Production : Geliştirilmesi ve testi tamamlanmış gerçek ortamda kullanılacak ayarlar için bu ortam kullanılır.

#### Swagger ve SwaggerUI Nedir?

Swagger, API'lerinizi tanımlamanıza, oluşturmanıza, belgelemenize ve tüketmenize yardımcı olan bir araç setidir. .NET projelerinde kullanılan Swagger ve Swagger UI, geliştirdiğiniz API'lerin belgelenmesini ve test edilmesini kolaylaştırır.

Swagger UI'nin Faydaları;
- API endpointlerini görsel arayüzde listeler.
- API'leri doğrudan web tarayıcısından test etmenizi sağlar.
- API belgelerini otomatik olarak oluşturur.

##### .NET 8 ile Swagger UI Kullanımı
<b>Program.cs Dosyasındaki Swagger Ayarları</b>

Swagger'ın .NET 8 WebAPI projesinde kullanılması için genellikle Program.cs dosyasında aşağıdaki kod yer alır:

```
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
```

<b>Swagger UI'nin Çalıştığı Portu Doğrulama ve Kontrol Etme</b>

Projenizde Swagger UI'nin hangi portta çalıştığını kontrol etmek için aşağıdaki adımları izleyebilirsiniz:

- LaunchSettings.json Dosyasını Kontrol Et: Bu dosya, uygulamanızın çalıştırılacağı URL ve port bilgilerini içerir. Properties klasörü altındaki launchSettings.json dosyasını açın ve aşağıdaki gibi yapılandırılmış olmalıdır:

```
"profiles": {
    "http": {
        "commandName": "Project",
        "dotnetRunMessages": true,
        "launchBrowser": true,
        "applicationUrl": "http://localhost:5003",
        "environmentVariables": {
            "ASPNETCORE_ENVIRONMENT": "Development"
        }
    },
    "https": {
        "commandName": "Project",
        "dotnetRunMessages": true,
        "launchBrowser": true,
        "applicationUrl": "https://localhost:7003",
        "environmentVariables": {
            "ASPNETCORE_ENVIRONMENT": "Development"
        }
    }
}
```
- Tarayıcıdan Erişim: Uygulamanızı çalıştırdıktan sonra web tarayıcınızda http://localhost:5003/swagger URL'sini ziyaret ederek Swagger UI'ye erişim sağlayabilirsiniz.
- Terminal veya Output Penceresi: Projenizi çalıştırdığınızda terminal veya output penceresinde uygulamanın hangi portlarda dinlediğini belirten mesajlar olacaktır. Bu mesajlar da mevcut ayarları doğrulamak için kullanılabilir.

<b>Özelleştirmeler</b>

Swagger UI'yi daha fazla özelleştirmek isterseniz, UseSwaggerUI metodu içindeki çeşitli parametreler ile yapılandırmalar yapabilirsiniz:

```
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    options.RoutePrefix = string.Empty; // root URL'de Swagger UI gösterimi
});
```


## Entity Framework Nedir?

Entity Framework ORM(Object Relational Mapping) araçlarından biridir. ORM nedir dersek: İlişkisel veritabanı ile nesneye yönelik programlama(OOP) arasında bir köprü görevi gören araçtır. Bu köprü, ilişkisel veritabanındaki bilgilerimizi yönetmek için nesne modellerimizi kullandığımız bir yapıdır.

### Entity Framework Neden Kullanılır?
Bir projede EntityFramework kullanmanın çeşitli nedenleri vardır:

- <b> Veritabanı İşlemlerinin Kolaylaştırılması</b>

EntityFramework, veritabanı ile ilgili CRUD (Create, Read, Update, Delete) işlemlerini çok daha kolay ve hızlı bir şekilde gerçekleştirmenizi sağlar. SQL yazmadan LINQ sorguları ile veritabanı işlemleri yapabilirsiniz.

- <b>Otomatik Veritabanı Yönetimi</b>

EF, modele dayalı olarak veritabanı şemalarını otomatik olarak oluşturabilir ve güncelleyebilir. Bu, veritabanı yönetimini önemli ölçüde basitleştirir.

- <b>Bakım ve Genişletilebilirlik</b>

Kod tabanını veritabanından soyutladığı için kodun bakımı ve genişletilmesi daha kolay olur. Yeni özellikler eklemek veya mevcut olanları değiştirmek daha az zahmetlidir.


- <b>Zaman Tasarrufu</b>

Kod yazarak geçirilen zamanı azaltır ve veri erişim katmanlarını hızla geliştirmeyi mümkün kılar. Bu sayede projeler daha hızlı bir şekilde tamamlanabilir.


- <b>Performans ve Optimizasyon</b>

EF, performansı optimize etmek için çeşitli yöntemler sunar. Lazy Loading, Eager Loading ve Explicit Loading gibi özelliklerle verilerin ne zaman ve nasıl çekileceğini kontrol edebilirsiniz.

- <b>Test Edilebilirlik</b>

Mocking araçlarıyla birlikte kullanılabilen EntityFramework, birim test yazma süreçlerini kolaylaştırır.

- <b>Topluluk ve Destek</b>

Geniş bir kullanıcı topluluğuna ve sağlam dokümantasyona sahiptir. Sorunlarla karşılaştığınızda çevrimiçi destek bulmanız daha kolaydır.


<b>Örnek Kod</b>

Aşağıda, EF kullanarak basit bir Product sınıfının nasıl oluşturulup kullanılabileceğine dair bir örnek yer almaktadır:

```
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
}

// EF kullanarak veri ekleme
using (var context = new AppDbContext())
{
    var product = new Product
    {
        Name = "Laptop",
        Price = 999.99m
    };
    
    context.Products.Add(product);
    context.SaveChanges();
}
```

### Linq Metotlar

LINQ (Language-Integrated Query), .NET Framework'te veri sorgulama ve manipülasyon işlemlerini daha kolay ve verimli bir şekilde yapmamızı sağlayan güçlü bir araçtır. LINQ, koleksiyonlar üzerinde sorgulamalar yapmanızı sağlar ve SQL benzeri bir sorgulama diline sahiptir.

LINQ metotları genellikle iki kategoriye ayrılır:
- Sorgu Söz Dizimi (Query Syntax)
- Metot Söz Dizimi (Method Syntax)

<b>Temel LINQ Metotları</b>

<b>Where</b>

Belirtilen koşulu sağlayan elemanları filtreler

```
var filteredList = myList.Where(item => item.Age > 18)
```

<b>Select</b>

Koleksiyonda bulunan elementler kullanılarak yeni bir koleksiyon oluşturulur.
SelectMany – anahtar sözcüğü iki koleksiyonda bulunan ortak alanlara göre birleştirilmesi sonucunda yeni koleksiyon oluşturur. 
```
var names = myList.Select(item => item.Name)
```

<b>OrderBy ve OrderByDecending</b>

- OrderBy, Bir koleksiyon ögelerinin artan yada azalan sıraya göre listelenmesini sağlar. 
- OrderByDescending – Koleksiyonda bulunan verilerin belirtilen parametrelerine göre azalan olarak listelenmesini sağlar.

```
var sortedList = myList.OrderBy(item => item.Name);
var sortedListDesc = myList.OrderByDescending(item => item.Name);
```

<b>GroupBy</b>

Koleksiyondaki verilerin gruplanması için kullanılır.
```
var groupedByAge = myList.GroupBy(item => item.Age);
```

<b>Join</b>

En az iki koleksiyonun birbirleri ile matche edilmesi için kullanılır. Oluşan matche sonucunda yeni bir koleksiyon oluşur.
GroupJoin – İki koleksiyonda bulunan ortak alanlara göre eşleştirilerek birleştirir.
```
var joinedList = from item1 in list1
                 join item2 in list2 on item1.Id equals item2.ItemId
                 select new { item1.Name, item2.Description };
```

<b>Sum, Average, Min, Max</b>

Sum – Koleksiyondaki tam sayıların toplar.
Max – Koleksiyondaki en büyük sayısal elemanı bulur.
Min – Koleksiyondaki en küçük sayısal elemanı bulur.
Count – Koleksiyondaki eleman sayısını Int32 türünde verir.
LongCount – Koleksiyondaki eleman sayısını Int64 türünde verir.
Average – Koleksiyondaki sayısal değerlerin ortalamasını hesaplar.
Aggregate – Koleksiyonda bulunan sayısal değerlere belirtilen  işleme göre hesaplanmasını sağlar.

```
var totalAge = myList.Sum(item => item.Age);
var averageAge = myList.Average(item => item.Age);
var minAge = myList.Min(item => item.Age);
var maxAge = myList.Max(item => item.Age);
```

<b>First, FirstOrDefault, Single, SingleOrDefault</b>

First – FirstOrDefault Koleksiyonda bulunan ilk veri geriye döner.
ElementAt – ElementAtOrDefault Koleksiyonda bulunan verinin index değerine göre getirilmesini sağlar.
Last – LastOrDefault Koleksiyonda bulunan son elemanı alır. 
Single – SingleOrDefault Koleksiyonda bulunan bir ögeyi alır.

```
var firstItem = myList.First();
var firstOrDefaultItem = myList.FirstOrDefault();
var singleItem = myList.Single(item => item.Id == 1);
var singleOrDefaultItem = myList.SingleOrDefault(item => item.Id == 1);
```

<b>Any, Contains, All</b>

Any – Koleksiyonda bulunan verilerin olup olmadığını kontrol eder. Koşul ifadeleri yazılabilir.
Contains – Koleksiyonda bulunan verilerin, belirlenen koşula göre olup olmadığını kontrol eder.
All – Koleksiyonda bulunan tüm veriler içerisinde belirlenen koşullara göre kayıt olup olmadığını döner. 

<b>Range, Repeat, Empty, DefaultIfEmpty</b>

Range – Belirtilen iki değer arasındaki tam sayı değerlerinin koleksiyon halinde dönmesini sağlar.
Repeat – Yenilenen değerleri belirtilen adette bir koleksiyonda listelenmesini sağlar. Bu değerler tekrarlananacak olan kayıtlardır. Repeat() anahtar sözcüğünde birinci argüman tekrarlanacak olan kelime, ikinci argüman ise kaç defa tekrarlanacağı sayısını ifade eder.
Empty – Hiçbir öğe içermeyen bir koleksiyon oluşturur. Koleksiyonda herhangi bir öğe gönderilmesi istenmediği taktirde kullanılır.
DefaultIfEmpty – Belirtilen koleksiyon boş ise varsayılan koleksiyon türüyle geriye döner


<b>AsEnumerable, AsQueryable, Cast, ToArray, ToDictionary, ToList</b>

AsEnumerable – Koleksiyonu IEnumerable’a dönüştürür.
AsQueryable – Koleksiyonu IQueryable olarak döndürür ve IEnumerable özellikleri de barındırır.
Cast – Koleksiyonda bulunan veri türünü, yeni bir koleksiyonda, belirlenen veri türüne dönüştürür.
ToArray – Koleksiyonu diziye dönüştürür.
ToDictionary – Koleksiyon ögelerini Key, Value olacak şekilde Dictionary’e dönüştürür.
ToList – Koleksiyonu listeye dönüştürür.

<b>Take, TakeWhile, Skip, SkipWhile</b>

Take – Koleksiyon içerisinden listelenecek olan veri adedini be lirtir. Sql Sorgu cümleciğinde Top() anahtar sözcüğüne eş değerdir.
TakeWhile – Koleksiyon da bulunan verilerin, belirlenen koşul neticesinde listelenmesini sağlar
Skip – Koleksiyon içerisinde bulunan verilerin başlangıç index’ini belirler. Belirlenen index numarasından sonraki verileri getirir.
SkipWhile – Koleksiyonda bulunan verilerin, belirtilen koşul neticesinde başlangıç index’ine göre listelenmesini sağlar.


<b>Distinct, Union, Intersect, Except</b>

Distinct – Koleksiyon içerisinde bulunan tekrarlayan kayıtların gösterilmesini engeller.
Union – Koleksiyonda bulunan verilerin tekrarlayanları olmadan, koleksiyon verilerini geri döner.
Intersect – Koleksiyonda bulunan tekrarlayan kayıtların listelenmesini sağlar.
Except – Anahtar sözcüğü, iki koleksiyonda bulunan verilerin sadece ilk koleksiyonda olup ikinci koleksiyonda olmayan kayıtları listeler.




