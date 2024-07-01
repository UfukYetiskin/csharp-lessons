using System;
namespace ZooHomeWork;

class Program
{
    static void Main()
    {
        Animals[] animals = new Animals[3];
        Horse horse = new Horse();
        horse.Name = "Horse";
        horse.Species = "Equus ferus caballus";
        horse.Age = 5;
        horse.Sound = "Neigh";
        horse.Color = "Brown";
        horse.getDosage();
        animals[0] = horse;

        Rodent rodent = new Rodent();
        rodent.Name = "Rodent";
        rodent.Species = "Rodentia";
        rodent.Age = 2;
        rodent.Sound = "Squeak";
        rodent.Color = "Gray";
        rodent.getDosage();
        animals[1] = rodent;

        Cat cat = new Cat();
        cat.Name = "Cat";
        cat.Species = "Felis catus";
        cat.Age = 3;
        cat.Sound = "Meow";
        cat.Color = "Black";
        cat.getDosage();
        animals[2] = cat;

        for (int i = 0; i < animals.Length; i++)
        {
            Console.WriteLine("Name: " + animals[i].Name);
            Console.WriteLine("Species: " + animals[i].Species);
            Console.WriteLine("Age: " + animals[i].Age);
            Console.WriteLine("Sound: " + animals[i].Sound);
            Console.WriteLine("Color: " + animals[i].Color);
            Console.WriteLine("Dosage: " + animals[i].getDosage());
            Console.WriteLine();
        }
    }
}


