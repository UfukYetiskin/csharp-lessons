// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");

//Collections (Koleksiyonlar)
//Koleksiyonlar, birçok veriyi tek bir değişken adı altında saklamamızı sağlar.
//Koleksiyonların arraylerden farkı, arraylerin sabit boyutlu olmasıdır. Koleksiyonlar ise dinamik boyutludur.
//Koleksiyonlar, arrayin aksine tek bir veri tipi ile sınırlı değildir. Yani koleksiyonlar, farklı veri tiplerini aynı koleksiyon içerisinde tutabilir.
//Koleksiyonlar, System.Collections.Generic isim alanı altında bulunur.

//List<T> Koleksiyonu
//List<T> koleksiyonu, en çok kullanılan koleksiyonlardan biridir. List koleksiyonu, dinamik boyutlu bir koleksiyondur ve farklı veri tiplerini aynı koleksiyon içerisinde tutabilir.
//List koleksiyonu, System.Collections.Generic isim alanı altında bulunur.
//T, koleksiyon içerisinde tutulacak veri tipini temsil eder. T, generic bir tiptir ve koleksiyon içerisinde hangi veri tipinin tutulacağını belirtir. Object veri tipi yerine kullanılır.

List<int> countsList = new List<int>();

countsList.Add(1);
countsList.Add(2);
countsList.Add(3);
countsList.Add(4);
countsList.Add(5);

Console.WriteLine("CountList Count: " + countsList.Count);
foreach (var count in countsList)
{
    Console.WriteLine(count);
}

//ya da 
countsList.ForEach(count => Console.WriteLine(count));

List<string> colorList = new List<string>();

colorList.Add("Red");
colorList.Add("Green");
colorList.Add("Blue");
colorList.Add("Yellow");
colorList.Add("White");

Console.WriteLine("ColorList Count: " + colorList.Count);
foreach (var color in colorList)
{
    Console.WriteLine(color);
}


//Remove
//List içerisinden spesifik bir eleman çıkarmak için Remove metodu kullanılır.
//Remove metodu, koleksiyon içerisindeki ilk eşleşen elemanı siler.
countsList.Remove(3);
colorList.Remove("Green");
countsList.ForEach(count => Console.WriteLine(count));
colorList.ForEach(color => Console.WriteLine(color));


//Contains (İçeriyor mu?)
//Contains metodu, koleksiyon içerisinde belirtilen elemanın olup olmadığını kontrol eder.
bool hasColor = colorList.Contains("Red");
Console.WriteLine("Has Red :" + hasColor);

//IndexOf (Elemanın İndisi)
//IndexOf metodu, koleksiyon içerisinde belirtilen elemanın indexini döner.
int indexOfRed = colorList.IndexOf("Red");
Console.WriteLine("Index of Red: " + indexOfRed);

//BinarySearch (Binary Arama)
//BinarySearch metodu, koleksiyon içerisinde belirtilen elemanı arar ve bulursa indexini döner. Bulamazsa -1 döner.
int indexOfBlue = colorList.BinarySearch("Blue");
Console.WriteLine("Index of Blue: " + indexOfBlue);

//Sort (Sıralama)
//Sort metodu, koleksiyon içerisindeki elemanları küçükten büyüğe sıralar.
colorList.Sort();
colorList.ForEach(color => Console.WriteLine(color));

//Reverse (Ters Çevirme)
//Reverse metodu, koleksiyon içerisindeki elemanları ters çevirir.
colorList.Reverse();
colorList.ForEach(color => Console.WriteLine(color));

//Bir diziyi List'e çevirme
int[] numbers = { 1, 2, 3, 4, 5 };
List<int> numberList = new List<int>(numbers);
numberList.ForEach(number => Console.WriteLine(number));

//List'i Diziye Çevirme
int[] numberArray = numberList.ToArray();
foreach (var number in numberArray)
{
    Console.WriteLine(number);
}


//List içerisinde nesne tutma
//List koleksiyonu içerisinde nesne tutmak için, nesne tipinde bir List oluşturulur.
//Örneğin, Person tipinde bir List oluşturmak için List<Person> şeklinde bir tanımlama yapılır.
//List koleksiyonu içerisine nesne eklemek için, nesne tipinde bir nesne oluşturulur ve List koleksiyonuna Add metodu ile eklenir.

List<Kullanicilar> kullanicilar = new List<Kullanicilar>();
//Kullanıcılar class'ından nesne oluşturulur.
Kullanicilar firtKullanici = new Kullanicilar();
firtKullanici.Isim = "Fırat";
firtKullanici.Soyisim = "Özgül";
firtKullanici.Yas = 25;

Kullanicilar secondKullanici = new Kullanicilar();
secondKullanici.Isim = "Ali";
secondKullanici.Soyisim = "Veli";
secondKullanici.Yas = 30;

//Kullanıcılar listesine nesneler eklenir.
kullanicilar.Add(firtKullanici);
kullanicilar.Add(secondKullanici);

//Kullanıcılar listesi döngü ile yazdırılır.
foreach (var kullanici in kullanicilar)
{
    Console.WriteLine("İsim: " + kullanici.Isim + " Soyisim: " + kullanici.Soyisim + " Yaş: " + kullanici.Yas);
}

//Arabalar Class'ı ile yeni bir List'e oluturulur.
List<Cars> cars = new List<Cars>();
Cars firstCar = new Cars();
firstCar.Brand = "BMW";
firstCar.Model = "M3";
firstCar.Year = 2021;

Cars secondCar = new Cars();
secondCar.Brand = "Mercedes";
secondCar.Model = "C200";
secondCar.Year = 2020;

cars.Add(firstCar);
cars.Add(secondCar);
cars.Add(new Cars()
{
    Brand = "Audi",
    Model = "A3",
    Year = 2019
});

foreach (var car in cars)
{
    Console.WriteLine("Brand: " + car.Brand + " Model: " + car.Model + " Year: " + car.Year);
}


public class Kullanicilar
{
    //Nesne özellikleri
    //private erişim belirleyicisi ile erişilebilirlik sınırlanır.
    private string isim;
    private string soyisim;
    private int yas;

    //Nesne özelliklerine erişmek için property'ler kullanılır.
    //Property'ler, nesne özelliklerine erişmek ve değiştirmek için kullanılır.
    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }

}

public class Cars
{
    private string brand;
    private string model;
    private int year;

    public string Brand { get => brand; set => brand = value; }
    public string Model { get => model; set => model = value; }
    public int Year { get => year; set => year = value; }
}


//ArrayList
//ArrayList koleksiyonu, List koleksiyonuna benzer bir yapıya sahiptir. ArrayList koleksiyonu, System.Collections isim alanı altında bulunur.
//ArrayList koleksiyonu, List koleksiyonundan farklı olarak, farklı veri tiplerini aynı koleksiyon içerisinde tutabilir.
//ArrayList koleksiyonu, List koleksiyonundan daha eski bir koleksiyondur ve performans açısından List koleksiyonundan daha düşüktür.
ArrayList arrayList = new ArrayList();
arrayList.Add(1);
arrayList.Add("Fırat");
arrayList.Add(3.14);
arrayList.Add(true);
arrayList.Add(new Animals() { Name = "Hannick", Type = "Dog", Age = 2 });



//ArrayList koleksiyonu içerisindeki elemanlara erişmek için index numarası kullanılır.
Console.WriteLine(arrayList[0]);
Console.WriteLine(arrayList[1]);

//ArrayList koleksiyonu içerisindeki elemanları döngü ile yazdırmak için foreach döngüsü kullanılır.
foreach (var item in arrayList)
{
    Console.WriteLine(item);
}

//AddRange, Add metoduna benzer bir metoddur. AddRange metodu, koleksiyon içerisine birden fazla eleman eklemek için kullanılır.
string[] colors = { "Red", "Green", "Blue" };
arrayList.AddRange(colors);

List<int> numbers3 = new List<int>() { 1, 2, 3, 4, 5 };
arrayList.AddRange(numbers3);

public class Animals
{
    private string name;
    private string type;
    private int age;

    public string Name { get => name; set => name = value; }
    public string Type { get => type; set => type = value; }
    public int Age { get => age; set => age = value; }
}

//Dictionary
//Dictionary koleksiyonu, key-value (anahtar-değer) çiftlerini tutan bir koleksiyondur. Dictionary koleksiyonu, System.Collections.Generic isim alanı altında bulunur.
//Dictionary koleksiyonu, key-value çiftlerini tutar. Key, anahtar ve value ise değerdir.
//Dictionary koleksiyonu, key-value çiftlerini tutar ve key değerleri benzersiz olmalıdır. Yani aynı key değeri birden fazla kez kullanılamaz.

Dictionary<int, string> dictionary = new Dictionary<int, string>();
dictionary.Add(15, "Fırat");
dictionary.Add(22, "Ali");
dictionary.Add(3, "Veli");

//Dictionary koleksiyonu içerisindeki elemanlara erişmek için key değeri kullanılır.
Console.WriteLine(dictionary[15]); //Fırat
Console.WriteLine(dictionary[22]);  //Ali

//Value değerine erişmek için Values property'si kullanılır.
foreach (var item in dictionary.Values)
{
    Console.WriteLine(item);
}