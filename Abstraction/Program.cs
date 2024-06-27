//Abstraction (Soyutlama)
//Bir sınıf için nesne üretmek mantıksız gelirse o sınıf soyutlanabilir. Soyutlanan sınıfların nesne üretilemez.
//Soyutlanan sınıfların içerisinde soyut metotlar bulunabilir. Soyut metotlar sınıfın alt sınıflarında implemente edilmek zorundadır.
//Soyut sınıflar abstract anahtar kelimesi ile tanımlanır.

using System;
namespace Abstraction;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        //Academian academian = new Academian(); //Hata verir
        //Employee employee = new Employee(); //Hata verir
        Teacher teacher = new Teacher();
        teacher.GetSalary();
    }
}


class Employee
{
    private string name;
    private string surname;
    private string phone;
    private string email;
}

//abstract class Academian inherits from Employee
abstract class Academian : Employee
{
    private string department;
    private string title;
    public void GetSalary()
    {
        Console.WriteLine("Salary");
    }

    public string yemekhane()
    {
        return "Yemekhane";
    }
}

class Teacher : Academian
{
    public void GetSalary()
    {
        Console.WriteLine("Salary");
    }
}