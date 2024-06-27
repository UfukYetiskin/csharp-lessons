// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Atama ve İşlemli Atama Operatörleri
int x = 3;
int y = 3;
y = y + 2;
y += 2;

//Mantıksal Öperatörler
// ||, &&, !

//İlişkisel Operatörler
// <, >, <=, >=, ==, !=
int a = 3;
int b = 4;
bool sonuc = a < b;

//Aritmetik Operatörler
// +, -, *, /, %
int sayi1 = 10;
int sayi2 = 5;
int toplam = sayi1 + sayi2;
int fark = sayi1 - sayi2;

// % mod alır
int sonuc1 = 20 % 3;

//Arttırma ve Azaltma Operatörleri
// ++, --

int sayi3 = 10;
sayi3 = sayi3 + 1;

//Atama ve Karşılaştırma Operatörleri
// =, ==, ===, !=, !==

int sayi4 = 10;
int sayi5 = 5;
bool sonuc2 = sayi4 == sayi5;

//3. Kısım
//If Else
int time = DateTime.Now.Hour;
if (time >= 6 && time < 11)
{
    Console.WriteLine("Günaydın");
}
else if (time <= 18)
{
    Console.WriteLine("İyi Günler");
}
else
{
    Console.WriteLine("İyi Geceler");
}

//Switch Case
int number = 5;
switch (number)
{
    case 1:
        Console.WriteLine("Sayı 1");
        break;
    case 2:
        Console.WriteLine("Sayı 2");
        break;
    case 3:
        Console.WriteLine("Sayı 3");
        break;
    default:
        Console.WriteLine("Sayı 4");
        break;
}

//Döngüler
//For
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

//While
int number1 = 1;
while (number1 <= 10)
{
    Console.WriteLine(number1);
    number1++;
}

//Do While
int number2 = 1;
do
{
    Console.WriteLine(number2);
    number2++;
} while (number2 <= 10);

//Foreach
string[] students = { "Engin", "Derin", "Salih" };
foreach (var student in students)
{
    Console.WriteLine(student);
}



//Metotlar
static void Add()
{
    Console.WriteLine("Added!");
}

Add();

//Parametreli Metotlar
static void Add2(int number1, int number2)
{
    int result = number1 + number2;
    Console.WriteLine("Result: " + result);
}

Add2(3, 5);


//Metotlar
static int Add3(int number1, int number2)
{
    return number1 + number2;
}

int result = Add3(20, 30);
Console.WriteLine(result);

//Ref ve Out Keyword
static void Add4(ref int number)
{
    number = number + 3;
}

int number11 = 20;
Add4(ref number11);
Console.WriteLine(number11);

static void Add5(out int number1, int number2)
{
    number1 = 30;
    number1 = number1 + number2;
}

int numberOut;
Add5(out numberOut, 40);
Console.WriteLine(numberOut);


//Try-Catch
try
{
    //Hata oluşabilecek kodlar
    Console.WriteLine("Bir sayı giriniz: ");
    int number12 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Girdiğiniz sayı: " + number12);
}
catch (Exception ex)
{
    //Hata durumunda çalışacak kodlar
    //ex, hata ile ilgili detaylı bilgi verir
    Console.WriteLine("Hata: " + ex.Message);
}
finally
{
    //Hata olsa da olmasa da çalışacak kodlar
    Console.WriteLine("İşlem Tamamlandı");
}