//Class (Sınıflar)
//Class, bir nesne oluşturmak için kullanılan bir şablondur. Class'lar, nesnelerin özelliklerini ve davranışlarını tanımlar.
//Class'lar, bir nesnenin durumunu ve davranışını tanımlar. Durum, nesnenin özelliklerini ve davranışı ise nesnenin işlevlerini tanımlar.
//Class'lar, nesnelerin özelliklerini ve davranışlarını tanımlar. Özellikler, nesnenin veri elemanlarını ve davranışlar ise nesnenin fonksiyonlarını tanımlar.

//Neden Class Kullanırız?
//Class'lar, nesnelerin özelliklerini ve davranışlarını tanımlar. Class'lar, nesnelerin durumunu ve davranışını tanımlar. Durum, nesnenin özelliklerini ve davranışı ise nesnenin işlevlerini tanımlar.

//Class Nasıl Tanımlanır?
//Class tanımlamak için class anahtar kelimesi kullanılır. Class tanımlanırken class anahtar kelimesinden sonra class adı yazılır ve süslü parantezler arasına class'ın özellikleri ve davranışları yazılır.

//Nesne Oluşturma
using System.Security.Cryptography.X509Certificates;

Araba carOfMyWife = new Araba();

//Özelliklere Erişim
carOfMyWife.Marka = "Renault";
Console.WriteLine("Araba Markası: " + carOfMyWife.Marka);
carOfMyWife.Model = "Clio";
Console.WriteLine("Araba Modeli: " + carOfMyWife.Model);
carOfMyWife.Yil = 2015;
Console.WriteLine("Araba Yılı: " + carOfMyWife.Yil);
carOfMyWife.Renk = "Beyaz";
Console.WriteLine("Araba Rengi: " + carOfMyWife.Renk);
carOfMyWife.BeygirGucu = 90;
Console.WriteLine("Araba Beygir Gücü: " + carOfMyWife.BeygirGucu);
carOfMyWife.Hiz = 100;
Console.WriteLine("Araba Hızı: " + carOfMyWife.Hiz);
carOfMyWife.Fiyat = 100000;
Console.WriteLine("Araba Fiyatı: " + carOfMyWife.Fiyat);
carOfMyWife.Hizlan();
carOfMyWife.Yavasla();
carOfMyWife.Dur();


Calisan firstEmployee = new Calisan("Ayşe", "Kara", 12345, "İnsan Kaynakları");
firstEmployee.Calis();
firstEmployee.Dinlen();
firstEmployee.BilgileriGoster();

//Overload Çalıştırma
Calisan secondEmployee = new Calisan("Fatma", "Kara");
secondEmployee.Calis();
secondEmployee.Dinlen();
secondEmployee.BilgileriGoster();

//Encapsulation (Kapsülleme) ve Property Kavramı
Human ummuhan = new Human("Ümmühan", "Gümüş", 25, "Kadın");
ummuhan.ShowInfos();

Human ufuk = new Human("Ufuk", "Gümüş", 30, "Erkek");
ufuk.ShowInfos();


//Static Class (Statik Sınıflar)
int result = Math.Sum(5, 10);
Console.WriteLine("Result: " + result);

Math math1 = new Math(2, 4);
Console.WriteLine("Pi: " + Math.Pi);

//Struct (Yapılar) ve Class Karışalştırması
Dikdortgen dikdortgen1 = new Dikdortgen();
dikdortgen1.KisaKenar = 3;
dikdortgen1.UzunKenar = 4;
Console.WriteLine("Dikdörtgen Alanı: " + dikdortgen1.AlanHesapla());

Dikdortgen_Struct dikdortgen2 = new Dikdortgen_Struct();
dikdortgen2.KisaKenar = 3;
dikdortgen2.UzunKenar = 4;
Console.WriteLine("Dikdörtgen Alanı: " + dikdortgen2.AlanHesapla());

//Enum (Numaralandırma)
Gun gun = Gun.Pazartesi;
Console.WriteLine("Bugün günlerden: " + gun);



class Araba
{
    //Erişim Belirleyiciler
    //Erişim belirleyiciler, bir nesnenin özelliklerine ve davranışlarına erişim düzeyini belirler. Erişim belirleyiciler, bir nesnenin özelliklerine ve davranışlarına erişim düzeyini belirler. Erişim belirleyiciler, bir nesnenin özelliklerine ve davranışlarına erişim düzeyini belirler.
    //private, sadece tanımlandığı sınıf içerisinde erişilebilir.
    //protected, tanımlandığı sınıf ve bu sınıftan türetilen sınıflar içerisinde erişilebilir.
    //internal, tanımlandığı proje içerisinde erişilebilir.
    //public, her yerden erişilebilir.
    public string Marka;
    public string Model;
    public int Yil;
    public string Renk;
    public int BeygirGucu;
    public int Hiz;
    public int Fiyat;



    //Davranışlar
    public void Hizlan()
    {
        Hiz += 10;
        Console.WriteLine("Arabanın hızı arttı: " + Hiz);
    }

    public void Yavasla()
    {
        Hiz -= 10;
        Console.WriteLine("Arabanın hızı azaldı: " + Hiz);
    }

    public void Dur()
    {
        Hiz = 0;
        Console.WriteLine("Araba durdu: " + Hiz);
    }
}



class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    //Kurucu || Yapıcı Metotlar, constructor
    //Constructor, bir sınıftan bir nesne örneği (instance) oluşturulduğunda çağrılan özel bir üye metottur. Bir constructor, sınıfın başlangıç durumunu ayarlamak ve örnek oluşturma sürecinde gerekli başlatma işlemlerini gerçekleştirmek için kullanılır.

    public Calisan(string ad, string soyad, int no, string departman)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }

    //Overload
    public Calisan(string ad, string soyad)
    {
        this.Ad = ad;
        this.Soyad = soyad;
    }

    public void Calis()
    {
        Console.WriteLine("Çalışan çalışıyor...");
    }

    public void Dinlen()
    {
        Console.WriteLine("Çalışan dinleniyor...");
    }

    public void BilgileriGoster()
    {
        Console.WriteLine("Çalışan Adı: " + Ad);
        Console.WriteLine("Çalışan Soyadı: " + Soyad);
        Console.WriteLine("Çalışan Numarası: " + No);
        Console.WriteLine("Çalışan Departmanı: " + Departman);
    }
}

//Encapsulation (Kapsülleme) ve Property Kavramı
//Encapsulation, herhangi bir nesnenin yöntemlerini, değişkenlerini ve özelliklerini diğer nesnelerden saklayarak, bunlara erişimini sınırlandırır.
//Koruma erişim belirleyiciler sayesinde sağlanır. 

//Property, bir nesnenin özelliklerine erişmek ve bu özellikleri değiştirmek için kullanılan bir yapıdır. Property, bir nesnenin özelliklerine erişmek ve bu özellikleri değiştirmek için kullanılan bir yapıdır. Property, bir nesnenin özelliklerine erişmek ve bu özellikleri değiştirmek için kullanılan bir yapıdır.

//Property Tanımlama
//Property tanımlamak için get ve set anahtar kelimeleri kullanılır. Property tanımlamak için get ve set anahtar kelimeleri kullanılır. Property tanımlamak için get ve set anahtar kelimeleri kullanılır.

class Human
{
    //Field
    private string name;
    private string surname;
    private int age;

    private string gender;

    //Property
    public string Name { get => name; set => name = value; }
    public string Surname { get => surname; set => surname = value; }
    public int Age
    {
        get => age;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Yaş değeri negatif olamaz.");
            }
            else
            {
                age = value;
            }
        }
    }

    public string Gender { get => gender; set => gender = value; }

    public Human(string name, string surname, int age, string gender)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
        this.Gender = gender;
    }

    public void ShowInfos()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Surname: " + Surname);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Gender: " + Gender);
    }
}


//Static Class (Statik Sınıflar)
//Statik Sınıflar, İçinde buluduğu sınıftan nesne oluşturulmadan veya hiç bir nesneye referans olmadan kullanılabilen üyeler static olarak nitelendirilir.
class Math
{
    private static int pi;

    public static int Pi { get => pi; }

    private int e;
    private int b;

    public Math(int e, int b)
    {
        this.e = e;
        this.b = b;
        pi++;
    }


    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }
}

//Struct (Yapılar)
//Struct, veri yapısıdır.
//Farklı veri türlerini bir araya getirmek için kullanılır. Örneğin, bir Point yapısında iki int değeri (x ve y koordinatları) tutabilirsiniz.
//Struct'lar, değer türüdür. Yani, struct'lar değer kopyaları üzerinden çalışır. Struct'lar, değer türüdür. Yani, struct'lar değer kopyaları üzerinden çalışır.
//Genellikle basit veri gruplarını temsil etmek için veya performans kritik kodlarda tercih edilir.

class Dikdortgen
{
    public int KisaKenar;
    public int UzunKenar;

    public int AlanHesapla()
    {
        return this.KisaKenar * this.UzunKenar;
    }

}

//Struct Tanımlama
struct Dikdortgen_Struct
{
    public int KisaKenar;
    public int UzunKenar;

    public int AlanHesapla()
    {
        return this.KisaKenar * this.UzunKenar;
    }
}


//Enum (Numaralandırma)
//Enumlar, belirli bir veri tipindeki sabit değerleri temsil etmek için kullanılır. 
//Bu sabit değerler, sembolik adlarla temsil edilir ve belirli bir sıraya sahiptirler. 
//Örneğin, bir günün haftanın hangi gününü temsil ettiğini düşünün. Bu sabit değerleri enum kullanarak tanımlayabilirsiniz.

public enum Gun
{
    Pazartesi = 1,
    Salı = 2,
    Çarşamba = 3,
    Perşembe = 4,
    Cuma = 5,
    Cumartesi = 6,
    Pazar = 7
}