using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data{
    public class Ogrenci{

        // sql tablosunda Primary Key'in bu sutün oldugunu belirtmek için Id ya da classIsmıId yazarsak default olarak anlayacaktır.
        //Eğer özel bir isim koymak istersek OgrenciNoId gibi [Key] değerini eklememiz gerek.
        //[Key]
        public int OgrenciId { get; set; }
        public string? OgrenciAd { get; set; }
        public string? OgrenciSoyad { get; set; }
        public string? Eposta { get; set; }
        public string? Telefon { get; set; }
    }
}