// See https://aka.ms/new-console-template for more information
using System;

namespace InheritanceLesson;

class Program
{
    static void Main(string[] args)
    {


        //Object Orientented Programming, OOP
        //OOP, bir programlama paradigmalarından biridir. OOP, programlamada nesne odaklı düşünmeyi ve programlamayı sağlar.
        //OOP, programlamada nesnelerin birbirleriyle etkileşimde bulunarak çalıştığı bir yapıdır.

        //Inheritance, kalıtım
        //Inheritance, bir sınıfın başka bir sınıftan özelliklerini ve metotlarını almasıdır.
        //Inheritance, sınıflar arasında bir ilişki kurar ve kod tekrarını önler.
        Console.WriteLine("Inheritance Lesson");
        Console.WriteLine("-----------------");
        Console.WriteLine("Bitkiler sınıfından kalıtım almış Tohumlu Bitkiler sınıfından nesne oluşturuldu.");
        //Bitkiler sınıfından nesne oluşturuldu.
        TohumluBitkiler tohumluBitki = new TohumluBitkiler();
        //Canlilar sınıfından gelen metotlar
        tohumluBitki.Beslenme();
        tohumluBitki.Solunum();
        tohumluBitki.Bosaltim();

        //Bitkiler sınıfından gelen metotlar, eğer Bitkiler sınıfı private olsaydı bu metotlara erişim sağlanamazdı. Protected erişim belirleyicisi ile Bitkiler sınıfına sadece Bitkiler sınıfından kalıtım almış sınıflar erişebilir.
        // tohumluBitki.Fotosentez();


        Console.WriteLine("-----------------");
        Console.WriteLine("Hayvanlar sınıfından kalıtım almış Kuslar sınıfından nesne oluşturuldu.");
        //Hayvanlar sınıfından nesne oluşturuldu.
        Kuslar serce = new Kuslar();
        //Canlilar sınıfından gelen metotlar
        serce.Beslenme();
        serce.Solunum();
        serce.Bosaltim();
        //Hayvanlar sınıfından gelen metotlar
        serce.Adaptasyon();
        serce.Ureme();
        //Kuslar sınıfından gelen metotlar
        serce.Ucmak();

        //Polymorphism, çok biçimlilik
        //Polymorphism, bir nesnenin farklı durumlarda farklı davranışlar sergilemesidir.
        //Polymorphism, kalıtım ve sanal metotlar ile sağlanır.
        Console.WriteLine("-----------------");
        //Canlilar sınıfında virtual anahtar kelimesi ile tanımlanan metotlar, kalıtım alan sınıflar tarafından ezilebilir.
        //Hayvanlar sınıfı Canlilar sınıfından kalitim aldı ve UyaranlaraTepki metodu override anahtar kelimesi ile ezildi.
        serce.UyaranlaraTepki();


        //Interface, Arayüz
        //Interface, bir sınıfın içerisinde tanımlanan metotların imzasını içerir.
        //Interface, yapısı gereği diğer sınıflara yol gösterici, rehberlik yapmak için oluşturulan, kendisinden implement edilen bir sınıfa doldurulması zorunlu olan bazı özelliklerin aktarılmasını sağlayan bir kavramdır.
        Console.WriteLine("-----------------");
        Console.WriteLine("Interface Class Lesson");
        Console.WriteLine("-----------------");
        //ILogger interface'inden kalıtım alan FileLogger, SmsLogger ve DatabaseLogger sınıflarından nesne oluşturuldu.
        FileLogger fileLogger = new FileLogger();
        SmsLogger smsLogger = new SmsLogger();
        DatabaseLogger databaseLogger = new DatabaseLogger();

        //ILogger interface'inden kalıtım alan FileLogger, SmsLogger ve DatabaseLogger sınıflarının WriteLog metotları çağrıldı.
        fileLogger.WriteLog();
        smsLogger.WriteLog();
        databaseLogger.WriteLog();

        //LogManager, ILogger interface'inden kalıtım alan sınıfların WriteLog metotlarını çağıran bir metot içerir.
        LogManager logManager = new LogManager(new FileLogger());
        logManager.WriteLog();

        //Abstract Class, Soyut Sınıf
        //Abstract Class, bir sınıfın içerisinde en az bir tane soyut metot bulunduran sınıftır.
        //Abstract Class, new anahtar kelimesi ile nesne oluşturulamaz.
        //Abstract Class, kalıtım alan sınıflar tarafından implemente edilmesi gereken metotlar içerir.
        Console.WriteLine("-----------------");
        Console.WriteLine("Abstract Class Lesson");
        Console.WriteLine("-----------------");

    }
}



