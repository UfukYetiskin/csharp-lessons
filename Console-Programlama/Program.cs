
//Yeni bir konsol uygulaması oluşturulduğunda, aşağıdaki kodlar otomatik olarak oluşturulur.
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Eski konsol yapılarında ise aşağıdaki kodlar otomatik olarak oluşturulur. Aynı çıktıyı verir.
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        //Main method default olarak public olur. Ancak private olarak da tanımlanabilir.
        //Static olması, Main methodunun isetnildiği yerden yeni bir instance oluşturulmadan çağrılabilmesini sağlar.
        //Void olması, Main methodunun herhangi bir değer döndürmeyeceğini belirtir. 
        //string[] args, Main methodunun parametrelerini belirtir. Bu parametreler, programın çalıştırıldığı komut satırından alınan parametrelerdir. Komut satırı argümanlarını içeri almak için kullanılıyor. 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //System class'ını import etmediğimiz için System.Console.WriteLine şeklinde yazmamız gerekiyor. Aksi takdirde Console is not defined hatası alırız.
            System.Console.WriteLine("Hello World!");
        }
    }
}