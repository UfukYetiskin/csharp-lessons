// Gerekli Entity Framework Core kütüphanesini projeye dahil ediyor.
using Microsoft.EntityFrameworkCore;

namespace efcoreApp.Data
{
    // 'DataContext' sınıfı Entity Framework Core'un DbContext sınıfından türetilmiştir.
    // Bu sınıf, veritabanı ile etkileşimi sağlayacak olan temel sınıftır.
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        // 'Kurslar' adında bir DbSet tanımlanmıştır.
        // Bu, 'Kurs' modelinin veritabanındaki 'Kurslar' tablosu ile ilişkili olduğunu belirtir.
        // 'Set<Kurs>()' metodu, Entity Framework'teki 'Kurs' modelini veritabanındaki 'Kurslar' tablosuna bağlar.
        public DbSet<Kurs> Kurslar => Set<Kurs>();

        // 'Ogrenciler' adında bir DbSet tanımlanmıştır.
        // 'Ogrenci' modeli veritabanında 'Ogrenciler' tablosu ile ilişkilendirilir.
        // DbSet, sorgulama ve veritabanı işlemleri yapmak için kullanılır.
        public DbSet<Ogrenci> Ogrenciler => Set<Ogrenci>();

        // 'KursKayitlari' adında bir DbSet tanımlanmıştır.
        // Bu, 'KursKayit' modelinin veritabanındaki 'KursKayitlari' tablosu ile ilişkili olduğunu belirtir.
        public DbSet<KursKayit> KursKayitlari => Set<KursKayit>();
         public DbSet<Ogretmen> Ogretmenler => Set<Ogretmen>();
    }

    // Yorum olarak belirtilen, veri tabanı yaklaşımlarına dair iki önemli kavram:
    // Code-first => Veritabanı, yazılan C# modellerine (entity) ve DbContext'e göre oluşturulur.
    // Database-first => Var olan bir SQL Server veritabanına göre C# modelleri oluşturulur.
}
