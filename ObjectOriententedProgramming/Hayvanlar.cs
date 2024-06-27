namespace InheritanceLesson;
using System;

public class Hayvanlar : Canlilar
{
    public void Adaptasyon()
    {
        Console.WriteLine("Hayvanlar adaptasyon yapar.");
    }
    public void Ureme()
    {
        Console.WriteLine("Hayvanlar ürer.");
    }

    //override anahtar kelimesi ile üst sınıftan gelen metotlar ezilebilir.
    //Canlilar sınıfından gelen UyaranlaraTepki metodu ezildi.
    public override void UyaranlaraTepki()
    {
        base.UyaranlaraTepki();
        Console.WriteLine("Canlilar sınıfından kalıtım alan Hayvanlar sınıfı UyaranlaraTepki metodu override edildi.");
    }
}

//: işareti ile kalıtım yapılır.
//Hayvanlar sınıfı üst sınıf, Surungenler sınıfı alt sınıftır.
//Surungenler sınıfı, Hayvanlar sınıfının özelliklerini ve metotlarını alır.
public class Surungenler : Hayvanlar
{
    public void SurunerekHareketEtme()
    {
        Console.WriteLine("Sürüngenler sürünerek hareket eder.");
    }
}

public class Kuslar : Hayvanlar
{
    public void Ucmak()
    {
        Console.WriteLine("Kuşlar uçar.");
    }
}


