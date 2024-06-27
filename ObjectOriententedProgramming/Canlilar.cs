namespace InheritanceLesson;
public class Canlilar
{
    public void Beslenme()
    {
        System.Console.WriteLine("Canlilar beslenir.");
    }

    public void Solunum()
    {
        System.Console.WriteLine("Canlilar Solunum yapar.");
    }
    public void Bosaltim()
    {
        System.Console.WriteLine("Canlilar bosaltim yapar.");
    }


    //Virtual metotlar, kalıtım alan sınıflar tarafından ezilebilir.
    //Virtual metotlar, kalıtım alan sınıflar tarafından değiştirilebilir.
    public virtual void UyaranlaraTepki()
    {
        System.Console.WriteLine("Canlilar Sınıfı Virtual anahtar kelimesi ile tanımlanan metot.");
    }

}