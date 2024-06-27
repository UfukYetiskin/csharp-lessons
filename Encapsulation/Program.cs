// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

//Encapsulation (Kapsülleme)
//Kapsülleme, bir sınıfın verilerini ve işlevlerini bir arada tutarak, dışarıdan erişime kapalı tutma işlemidir.
//Bir sınıfa ait niteliklerin ancak o sınıfa ait methodlar aracılığıyla değiştirilmesine olanak sağlar.


//Erişim Belirleyiciler
//Private, yazıldığı öğenin sadece ait olduğu sınıftan doğruadan erişilebilir olduğunu belirtir. Dışarıdan erişim engellenir.
//Protected, yazıldığı öğenin sadece ait olduğu sınıftan ve bu sınıftan türetilen sınıflardan erişilebilir olduğunu belirtir. Kendisi ile aynı paket içerisindeki sınıflardan erişmeye izin verir.
//Internal, yazıldığı öğenin sadece ait olduğu projeden erişilebilir olduğunu belirtir.
//Public, yazıldığı öğenin her yerden erişilebilir olduğunu belirtir.

//Constructor (Yapıcı Metot) ile kullanımda
Book notrDamn = new Book("Notr Dam", "Victor Hugo", 1488);
Console.WriteLine(notrDamn.getKitapAdi());
Console.WriteLine(notrDamn.getYazar());
Console.WriteLine(notrDamn.getSayfaSayisi());

//Encapsulation (Kapsülleme) Örneği
Book sucVeCeza = new Book();
sucVeCeza.setKitapAdi("Suç ve Ceza");
sucVeCeza.setYazar("Dostoyevski");
sucVeCeza.setSayfaSayisi(672);
Console.WriteLine(sucVeCeza.getKitapAdi());
Console.WriteLine(sucVeCeza.getYazar());
Console.WriteLine(sucVeCeza.getSayfaSayisi());

//Örnek
//Book adında bir sınıfımız var ve 3 niteliği var.
class Book
{
    private string kitapAdi;
    private string yazar;
    private int sayfaSayisi;

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