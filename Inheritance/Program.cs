using System;

namespace Inheritance_Lesson;

class Program
{
    static void Main(string[] args)
    {
        //Signle Inheritance Example
        Student student = new Student();
        student.Name = "Ali";
        student.Surname = "Veli";
        student.Age = 20;
        student.Department = "Computer Engineering";
        student.Number = 123;
        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("Surname: " + student.Surname);
        Console.WriteLine("Age: " + student.Age);
        Console.WriteLine("Department: " + student.Department);
        Console.WriteLine("Number: " + student.Number);

        //Multiple Inheritance Example
        // Kedi kedi = new Kedi();
        // kedi.Tur = "Kedi";
        // kedi.Beslenme = "Et";
        // kedi.Cinsi = "Van";
        // kedi.Renk = "White";
        // kedi.Ad = "Mavis";
        // kedi.Yas = 2;
        // Console.WriteLine("Tur: " + kedi.Tur);
        // Console.WriteLine("Beslenme: " + kedi.Beslenme);
        // Console.WriteLine("Cinsi: " + kedi.Cinsi);
        // Console.WriteLine("Renk: " + kedi.Renk);
        // Console.WriteLine("Ad: " + kedi.Ad);
        // Console.WriteLine("Yas: " + kedi.Yas);


        //University Management Example
        Teacher teacher = new Teacher();
        teacher.Name = "Ali";
        teacher.Surname = "Veli";
        teacher.Age = 40;
        teacher.Department = "Computer Engineering";
        teacher.Branch = "Software";

        Assistant assistant = new Assistant();
        assistant.Name = "Ayşe";
        assistant.Surname = "Fatma";
        assistant.Age = 30;
        assistant.Department = "Computer Engineering";
        assistant.Branch = "Software";

        LabAssistant labAssistant = new LabAssistant();
        labAssistant.Name = "Mehmet";
        labAssistant.Surname = "Ahmet";
        labAssistant.Age = 25;
        labAssistant.Department = "Computer Engineering";
        labAssistant.Branch = "Software";

        ITDepartment itDepartment = new ITDepartment();
        itDepartment.Name = "Hasan";
        itDepartment.Surname = "Hüseyin";
        itDepartment.Age = 35;
        itDepartment.Department = "Computer Engineering";
        itDepartment.Branch = "Software";

        Security security = new Security();
        security.Name = "Zeynep";
        security.Surname = "Gizem";
        security.Age = 45;
        security.Department = "Computer Engineering";
        security.Branch = "Software";

        Console.WriteLine("Teacher Name: " + teacher.Name);
        Console.WriteLine("Teacher Surname: " + teacher.Surname);
        Console.WriteLine("Teacher Age: " + teacher.Age);
        Console.WriteLine("Teacher Department: " + teacher.Department);
        Console.WriteLine("Teacher Branch: " + teacher.Branch);

        Console.WriteLine("---------------------------------");
        Console.WriteLine("Assistant Name: " + assistant.Name);
        Console.WriteLine("Assistant Surname: " + assistant.Surname);
        Console.WriteLine("Assistant Age: " + assistant.Age);
        Console.WriteLine("Assistant Department: " + assistant.Department);
        Console.WriteLine("Assistant Branch: " + assistant.Branch);

        Console.WriteLine("---------------------------------");
        Console.WriteLine("Lab Assistant Name: " + labAssistant.Name);
        Console.WriteLine("Lab Assistant Surname: " + labAssistant.Surname);
        Console.WriteLine("Lab Assistant Age: " + labAssistant.Age);
        Console.WriteLine("Lab Assistant Department: " + labAssistant.Department);
        Console.WriteLine("Lab Assistant Branch: " + labAssistant.Branch);

        Console.WriteLine("---------------------------------");
        Console.WriteLine("IT Department Name: " + itDepartment.Name);
        Console.WriteLine("IT Department Surname: " + itDepartment.Surname);
        Console.WriteLine("IT Department Age: " + itDepartment.Age);
        Console.WriteLine("IT Department Department: " + itDepartment.Department);
        Console.WriteLine("IT Department Branch: " + itDepartment.Branch);

        Console.WriteLine("---------------------------------");
        Console.WriteLine("Security Name: " + security.Name);
        Console.WriteLine("Security Surname: " + security.Surname);
        Console.WriteLine("Security Age: " + security.Age);
        Console.WriteLine("Security Department: " + security.Department);
        Console.WriteLine("Security Branch: " + security.Branch);

        Console.WriteLine("---------------------------------");

    }
}

//Inheritance (Kalıtım)
//Kalıtım, bir sınıfın farklı bir sınıfın niteliklerini ve davranışlarını kendisine alması demektir.
//Kalıtım yapan sınıfa alt sınıf deriz. KAlıtım yapılan sınıfa ise ata sınıf deriz. Ata sınıfta tanımlı olan her şey alt sınıf için de tanımlıdır.


//Tek Yönlü Kalıtım(Single Inheritance)
//Bir sınıfın sadece bir sınıftan kalıtım yapmasına tek yönlü kalıtım denir.
class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
}

class Student : Person
{
    public string Department { get; set; }
    public int Number { get; set; }
}


//Çoklu Kalıtım(Multiple Inheritance)
//Bir sınıfın birden fazla sınıftan kalıtım yapmasına çoklu kalıtım denir.
//C# dilinde çoklu kalıtım desteklenmez. Ancak çoklu kalıtım yapısını kullanmak için bir sınıfın birden fazla sınıftan kalıtım yapmasını sağlayan bir yapı vardır. Bu yapıda sınıfların hepsi interface olmalıdır.

class MemeliHayvan
{
    public string Tur { get; set; }
    public string Beslenme { get; set; }
}

class EvcilHayvan
{
    public string Cinsi { get; set; }
    public string Renk { get; set; }
}

// class Kedi : MemeliHayvan, EvcilHayvan
// {
//     public string Ad { get; set; }
//     public int Yas { get; set; }
// }

//Üniversite Yönetim Örneği
class Employee
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
}

class Teacher : Employee
{
    public string Department { get; set; }
    public string Branch { get; set; }
}

class Assistant : Employee
{
    public string Department { get; set; }
    public string Branch { get; set; }
}

class LabAssistant : Employee
{
    public string Department { get; set; }
    public string Branch { get; set; }
}

class ITDepartment : Employee
{
    public string Department { get; set; }
    public string Branch { get; set; }
}

class Security : Employee
{
    public string Department { get; set; }
    public string Branch { get; set; }
}