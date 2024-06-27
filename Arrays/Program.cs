using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //colors ismine sahip bir dizi oluşturduk ve içine 3 tane string değer atadık.
            string[] colors = { "red", "green", "blue" };

            //animals ismine sahip bir dizi oluşturduk. İçerisine değer atamadan önce dizi boyutunu belirttik.
            string[] animasl = new string[3];
            animasl[0] = "cat";
            animasl[1] = "dog";
            animasl[2] = "bird";

            foreach (var animal in animasl)
            {
                Console.WriteLine(animal);
            }


            // Declare an array of integers
            int[] numbers = new int[5];

            // Initialize the array
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            // Access an element of the array
            Console.WriteLine(numbers[1]);

            // Declare and initialize an array in one line
            int[] numbers2 = new int[] { 4, 8, 15, 16, 23 };

            // Declare and initialize an array in one line without specifying the size
            int[] numbers3 = { 4, 8, 15, 16, 23 };

            // Iterate over an array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // Iterate over an array using foreach
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            //Array Methods
            // IndexOf(), dizi içerisinde aranan elemanın indexini döndürür.
            int[] indexOfNumbers = { 4, 8, 15, 16, 23 };
            Console.WriteLine(Array.IndexOf(indexOfNumbers, 15)); // 2

            // Clear(), dizi içerisindeki elemanları temizler.
            int[] clearNumbers = { 4, 8, 15, 16, 23 };
            Array.Clear(clearNumbers, 0, 2);
            Console.WriteLine("Effect of Clear()");

            foreach (int number in clearNumbers)
            {
                Console.WriteLine("Cleaned Numbers: ", number);
            }

            // Copy(), dizi içerisindeki elemanları başka bir diziye kopyalar.
            int[] copyNumbers = { 4, 8, 15, 16, 23 };
            int[] copyNumbers2 = new int[3];
            Array.Copy(copyNumbers, copyNumbers2, 3);
            Console.WriteLine("Effect of Copy()");
            foreach (int number in copyNumbers2)
            {
                Console.WriteLine("Copied Numbers", number);
            }

            // Sort(), dizi içerisindeki elemanları sıralar.
            int[] sortNumbers = { 4, 8, 15, 16, 23 };
            Array.Sort(sortNumbers);
            Console.WriteLine("Effect of Sort()");
            foreach (int number in sortNumbers)
            {
                Console.WriteLine(number);
            }

            // Reverse(), dizi içerisindeki elemanları ters çevirir.
            int[] reverseNumbers = { 4, 8, 15, 16, 23 };
            Array.Reverse(reverseNumbers);
            Console.WriteLine("Effect of Reverse()");
            foreach (int number in reverseNumbers)
            {
                Console.WriteLine(number);
            }

            // Resize(), dizi boyutunu değiştirir.
            int[] resizeNumbers = { 4, 8, 15, 16, 23 };
            Array.Resize(ref resizeNumbers, 10);
            Console.WriteLine("Effect of Resize()");
            foreach (int number in resizeNumbers)
            {
                Console.WriteLine(number);
            }

            // Find(), dizi içerisinde belirtilen koşula uyan ilk elemanı döndürür.
            int[] findNumbers = { 4, 8, 15, 16, 23 };
            Console.WriteLine(Array.Find(findNumbers, element => element > 10)); // 15

            // FindAll(), dizi içerisinde belirtilen koşula uyan tüm elemanları döndürür.
            int[] findAllNumbers = { 4, 8, 15, 16, 23 };
            Array.FindAll(findAllNumbers, element => element > 10); // 15, 16, 23

            // Exists(), dizi içerisinde belirtilen koşula uyan eleman var mı yok mu kontrol eder.
            int[] existsNumbers = { 4, 8, 15, 16, 23 };
            Console.WriteLine(Array.Exists(existsNumbers, element => element > 10)); // True

            // TrueForAll(), dizi içerisinde belirtilen koşula uyan tüm elemanlar var mı yok mu kontrol eder.
            int[] trueForAllNumbers = { 4, 8, 15, 16, 23 };
            Console.WriteLine(Array.TrueForAll(trueForAllNumbers, element => element > 10)); // False

            // ForEach(), dizi içerisindeki elemanlar üzerinde işlem yapar.
            int[] forEachNumbers = { 4, 8, 15, 16, 23 };
            Array.ForEach(forEachNumbers, element => Console.WriteLine(element));

            // ConvertAll(), dizi içerisindeki elemanları dönüştürür.
            string[] convertAllNumbers = { "4", "8", "15", "16", "23" };
            int[] convertedNumbers = Array.ConvertAll(convertAllNumbers, element => int.Parse(element));
            foreach (int number in convertedNumbers)
            {
                Console.WriteLine(number);
            }

            // AsReadOnly(), dizi içerisindeki elemanları okunabilir bir koleksiyona dönüştürür.
            int[] asReadOnlyNumbers = { 4, 8, 15, 16, 23 };
            var readOnlyNumbers = Array.AsReadOnly(asReadOnlyNumbers);
            foreach (int number in readOnlyNumbers)
            {
                Console.WriteLine(number);
            }

            // BinarySearch(), dizi içerisinde belirtilen elemanı arar ve indexini döndürür.
            int[] binarySearchNumbers = { 4, 8, 15, 16, 23 };
            Console.WriteLine(Array.BinarySearch(binarySearchNumbers, 15)); // 2

            // FindIndex(), dizi içerisinde belirtilen koşula uyan ilk elemanın indexini döndürür.
            int[] findIndexNumbers = { 4, 8, 15, 16, 23 };
            Console.WriteLine(Array.FindIndex(findIndexNumbers, element => element > 10)); // 2

            // FindLastIndex(), dizi içerisinde belirtilen koşula uyan son elemanın indexini döndürür.
            int[] findLastIndexNumbers = { 4, 8, 15, 16, 23 };
            Console.WriteLine(Array.FindLastIndex(findLastIndexNumbers, element => element > 10)); // 4



        }
    }
}