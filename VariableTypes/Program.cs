using System;

namespace VariableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //ismi integerValue olan bir değişken tanımlayalım ve değer atayalım
            int integerValue = 10;
            Console.WriteLine("intergerValue Değişkeninin Type'i: " + integerValue.GetType().ToString() + " ve Değeri: " + integerValue.ToString() + "\n");

            //ismi doubleValue olan bir değişken tanımlayalım ve değer atayalım
            double doubleValue = 10.5;
            Console.WriteLine("doubleValue Değişkeninin Type'i: " + doubleValue.GetType().ToString() + " ve Değeri: " + doubleValue.ToString() + "\n");


            //ismi stringValue olan bir değişken tanımlayalım ve değer atayalım
            string stringValue = "Hello World!";
            Console.WriteLine("stringValue Değişkeninin Type'i: " + stringValue.GetType().ToString() + " ve Değeri: " + stringValue + "\n");

            //ismi boolValue olan bir değişken tanımlayalım ve değer atayalım
            bool boolValue = true;
            Console.WriteLine("boolValue Değişkeninin Type'i: " + boolValue.GetType().ToString() + " ve Değeri: " + boolValue.ToString() + "\n");

            //ismi charValue olan bir değişken tanımlayalım ve değer atayalım
            char charValue = 'A';
            Console.WriteLine("charValue Değişkeninin Type'i: " + charValue.GetType().ToString() + " ve Değeri: " + charValue.ToString() + "\n");

            //DateTimes sınıfından bir değişken tanımlayalım ve değer atayalım
            DateTime dateTimeValue = DateTime.Now;
            Console.WriteLine("dateTimeValue Değişkeninin Type'i: " + dateTimeValue.GetType().ToString() + " ve Değeri: " + dateTimeValue.ToString() + "\n");

            Console.WriteLine("Hello World!");
        }
    }
}
