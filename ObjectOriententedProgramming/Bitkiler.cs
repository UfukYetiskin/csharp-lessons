namespace InheritanceLesson;
using System;

//Protected erişim belirleyicisi ile Bitkiler sınıfına sadece Bitkiler sınıfından kalıtım almış sınıflar erişebilir.
public class Bitkiler : Canlilar
{
    protected void Fotosentez()
    {
        Console.WriteLine("Bitkiler fotosentez yapar.");
    }
}

public class TohumluBitkiler : Bitkiler
{
    public TohumluBitkiler()
    {
        //base anahtar kelimesi ile üst sınıfın metotlarına erişim sağlanır. Protected olan üst sınıfın metoduna erişim sağlanabilir.
        base.Fotosentez();
    }
    public void TohumlaCogalma()
    {
        Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
    }
}

public class TohumsuzBitkiler : Bitkiler
{
    public TohumsuzBitkiler()
    {
        base.Fotosentez();
    }
    public void SporlaCogalma()
    {
        Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
    }
}