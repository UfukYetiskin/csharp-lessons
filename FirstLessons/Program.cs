// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Path: Program.cs
//import System;

//dotnet new console --name <project-name> ile proje oluştururuz.
//dotnet build ile projeyi derleriz.
//dotnet run ile projeyi çalıştırırız.
//dotnet run --no-build ile projeyi derlemeden çalıştırırız.

//Eski sürümde bu şekilde gelebilir.
//System, Console, WriteLine gibi kütüphaneleri kullanabilmek için System kütüphanesini import etmemiz gerekiyor.
using System;


//namespace: Bir sınıfın, bir metotun, bir değişkenin, bir interface'in, bir struct'ın, bir enum'un, bir delegatenin, bir event'in, bir namespace'in adı çakışmaması için kullanılan bir isimleme alanıdır.
namespace FirstLessons
{
    //class: Bir sınıf tanımlamak için kullanılır.
    class Program
    {
        //Main: Programın başlangıç noktasıdır.
        //static, Main metotunun sınıfın bir örneği olmadan çağrılabilir olduğunu belirtir.
        //void, Main metotunun geriye bir değer döndürmediğini belirtir.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Ufuk!");
        }
    }
}