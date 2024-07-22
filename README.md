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