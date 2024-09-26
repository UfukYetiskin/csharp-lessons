using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data{
    public class Ogrenci{

        // sql tablosunda Primary Key'in bu sutün oldugunu belirtmek için Id ya da classIsmıId yazarsak default olarak anlayacaktır.
        //Eğer özel bir isim koymak istersek OgrenciNoId gibi [Key] değerini eklememiz gerek.
        //[Key]
        [Display(Name = "Ogrenci ID")]
        public int OgrenciId { get; set; }
        [Display(Name = "Ogrenci Adı")]
        public string? OgrenciAd { get; set; }
        [Display(Name = "Ogrenci Soyadı")]

        public string AdSoyad { get { return this.OgrenciAd + " " + this.OgrenciSoyad;} }
        public string? OgrenciSoyad { get; set; }
        [Display(Name = "Eposta")]
        public string? Eposta { get; set; }
        [Display(Name = "Telefon")]
        public string? Telefon { get; set; }
        public ICollection<KursKayit> KursKayitlari {get; set;} = new List<KursKayit>();
    }
}