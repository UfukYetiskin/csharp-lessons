using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintHelloWorld fonksiyonunu çağırıyoruz.
            PrintHelloWorld();
            Console.WriteLine("Sum of 5 and 6 is: " + Sum(5, 6));
            InstanceFunction instanceFunction = new InstanceFunction();
            instanceFunction.PrintHelloWorld();
            Console.WriteLine("Sum of 5 and 6 is: " + instanceFunction.Sum(5, 6));

            //out parametresi kullanımı
            //out parametresi, fonksiyonun içinde tanımlanmış bir değişkenin değerini dışarıya döndürmek için kullanılır.
            string stringsayi = "999";
            //int outSayi;
            bool sonuc = int.TryParse(stringsayi, out int outSayi);
            if (sonuc)
            {
                //outSayi değişkeni TryParse fonksiyonu içinde tanımlanmıştır. Bu değişkenin değeri fonksiyonun dışına çıkabilmektedir.
                Console.WriteLine("outSayi: " + outSayi);
            }
            else
            {
                Console.WriteLine("Dönüşüm başarısız.");
            }

            Console.WriteLine("OutIntegerFunction: " + OutIntegerFunction(out int outNumber));

            //Overloading
            //Overloading, aynı isimde birden fazla fonksiyon tanımlanmasıdır. Overloading, fonksiyonların parametrelerinin farklı olmasına dayanır.
            instanceFunction.OverloadingFunction("Hello World!");
            instanceFunction.OverloadingFunction(5);


            //Metot İmzası
            //Metot imzası, metot adı ve parametrelerin sayısı ve türlerinden oluşur. Metot imzası aynı olan metotlar tanımlanamaz.
            //Metot imzası aynı olan metotlar, parametrelerin sırası ve türleri farklı olmalıdır.
            instanceFunction.MetotImzasi(5, 6);


            //Rcursive Function (Öz Yinelemeli Fonksiyon)
            //Recursive fonksiyonlar, kendini çağıran fonksiyonlardır. Recursive fonksiyonlar, genellikle bir problemi küçük parçalara bölerek çözmek için kullanılır.
            //Örneğin, faktöriyel hesaplama, fibonacci serisi hesaplama gibi işlemler recursive fonksiyonlar ile yapılabilir.
            Console.WriteLine("RecursiveFunction: " + RecursiveFunction(5));
            static int RecursiveFunction(int number)
            {
                if (number == 0)
                {
                    return 1;
                }
                return number * RecursiveFunction(number - 1);
            }


            //Extension Method
            //Extension methodlar, var olan bir sınıfa yeni metotlar eklemek için kullanılır. Extension methodlar, static bir sınıf içinde tanımlanır.
            //Extension methodlar, genellikle var olan bir sınıfın metotlarını genişletmek için kullanılır.
            string text = "Hello World!";
            Console.WriteLine("Extension Method: " + text.ExtensionMethodPrint());





        }

        //PrintHelloWorld fonksiyonu static bir fonksiyondur. Çağrıldığında yeni bir instance oluşturulmaz. Void dönüş tipine sahiptir. Yani geriye bir değer döndürmez.
        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        //Sum Fonksiyonu iki parametre alır ve bu parametrelerin toplamını geriye döndürür. Geriye döndürdüğü değer int tipindedir.
        static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }



        //Overloading, aynı isimde birden fazla fonksiyon tanımlanmasıdır. Overloading, fonksiyonların parametrelerinin farklı olmasına dayanır.
        static int Sum(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }

        //Out Parametresi
        static int OutIntegerFunction(out int number)
        {
            number = 5;
            return number;
        }

    }

    //Static'e alternatif olarak instance fonksiyonlar da tanımlanabilir. Instance fonksiyonlar bir instance oluşturulduğunda çağrılabilir.
    class InstanceFunction
    {
        //PrintHelloWorld fonksiyonu instance bir fonksiyondur. Çağrıldığında yeni bir instance oluşturulur. Void dönüş tipine sahiptir. Yani geriye bir değer döndürmez.
        //Public erişim belirleyicisine sahiptir. Yani bu fonksiyon dışarıdan erişilebilir.
        public void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }


        //Overloading, aynı isimde birden fazla fonksiyon tanımlanmasıdır. Overloading, fonksiyonların parametrelerinin farklı olmasına dayanır.
        public void OverloadingFunction(string text)
        {
            Console.WriteLine("OverloadingFunction" + text);
        }

        public void OverloadingFunction(int number)
        {
            Console.WriteLine("OverloadingFunction: " + number);
        }

        //Metot İmzası
        public void MetotImzasi(int number1, int number2)
        {
            Console.WriteLine("MetotImzasi: " + (number1 + number2));
        }


    }

    //Extension Method
    public static class ExtensionMethods
    {
        public static bool ExtensionMethodPrint(this string text)
        {
            //Contains metodu, bir stringin içinde belirtilen metni arar ve metin içinde varsa true, yoksa false döner.
            return text.Contains("World");
        }
    }

}