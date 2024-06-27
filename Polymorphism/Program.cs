using System;


//Polymorphism (Çok Biçimlilik)
//Nesneye Yönelik Programlamada programlama dilinin farklı tip verileri ve sınıfları farklı şekilde işleme yeteneğini belirten özelliğidir. Metotları ve türetilmiş sınıfları yeniden tanımlama yeteneğidir.
//Polimorfizm, alt sınıfların ata sınıflardaki metotları geçersiz kılması (method overriding) sayesinde çok biçimli olarak davranmasına deneir.

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Polymorphism
            Dog a = new Dog();
            a.Speak();
            Cat cat = new Cat();
            cat.Speak();
            Bird bird = new Bird();
            bird.Speak();
        }
    }
}


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