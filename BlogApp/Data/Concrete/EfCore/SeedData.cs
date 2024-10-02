using Microsoft.EntityFrameworkCore; // Entity Framework Core paketini kullanıyoruz, bu sayede veritabanı işlemlerini yapabiliyoruz.
using BlogApp.Entity;

namespace BlogApp.Data.Concrete.EfCore{
    // Veritabanını başlangıçta test verileriyle doldurmak için kullanılan bir sınıf tanımlıyoruz.
    public static class SeedData{
        // Test verilerini veritabanına eklemek için bir metot tanımlıyoruz. IApplicationBuilder, uygulamayı başlatırken hizmetlere erişmemizi sağlar.
        public static void TestVerileriniDoldur(IApplicationBuilder app){

            // BlogContext'i kullanarak veritabanına erişim sağlıyoruz. Scope oluşturmak, dependency injection (bağımlılık enjeksiyonu) ile servisleri almak için kullanılır.
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContext>();

            // Eğer veritabanı context'i null değilse, yani context'i başarıyla aldıysak, aşağıdaki işlemleri yapacağız.
            if(context != null){

                // Eğer veritabanında bekleyen migrasyonlar (veritabanı güncellemeleri) varsa, bu migrasyonları uyguluyoruz.
                if(context.Database.GetPendingMigrations().Any()){
                    context.Database.Migrate(); // Bekleyen migrasyonları veritabanına uygular.
                }

                // Eğer veritabanında herhangi bir Tag (etiket) yoksa, örnek etiket verileri ekliyoruz.
                if(!context.Tags.Any()){
                    // Etiketlerimizi veritabanına eklemek için bir dizi yeni Tag nesnesi oluşturuyoruz.
                    context.Tags.AddRange(
                        new Entity.Tag {Text = "Web Programlama"},
                        new Entity.Tag {Text = "Backend"},
                        new Entity.Tag {Text = "Frontend"},
                        new Entity.Tag {Text = "Fullstack"}
                    );
                    // Yapılan değişiklikleri veritabanına kaydediyoruz.
                    context.SaveChanges();
                }

                // Eğer veritabanında herhangi bir User (kullanıcı) yoksa, örnek kullanıcı verileri ekliyoruz.
                if(!context.Users.Any()){
                    // Kullanıcıları veritabanına eklemek için yeni User nesneleri oluşturuyoruz.
                    context.Users.AddRange(
                        new User{UserName = "Ümmühan Gümüş"}, // Birinci kullanıcı
                        new User{UserName = "Abdurrahman Gümüş"} // İkinci kullanıcı
                    );
                    // Değişiklikleri veritabanına kaydediyoruz.
                    context.SaveChanges();
                }

                // Eğer veritabanında herhangi bir Post (gönderi) yoksa, örnek gönderi verileri ekliyoruz.
                if(!context.Posts.Any()){
                    // Gönderileri eklemek için yeni Post nesneleri oluşturuyoruz.
                    context.Posts.AddRange(
                        new Post{
                            Title = "Asp.Net Core",  // Gönderi başlığı
                            Content = "Asp.Net Core Dersleri",  // Gönderi içeriği
                            IsActive = true, // Gönderi aktif mi? (yayınlanmış mı?)
                            PublishedOn = DateTime.Now.AddDays(-10), // Gönderinin yayınlanma tarihi
                            Tags = context.Tags.Take(3).ToList(), // Bu gönderiye 3 adet tag ilişkilendiriyoruz.
                            UserId = 1, // Bu gönderiyi oluşturan kullanıcı ID'si
                            // User = context.Users.FirstOrDefault() // Kullanıcı bilgisi doğrudan veritabanından çekilebilir (yorum satırında)
                        },
                        new Post{
                            Title = "Php",  // Php dersleri hakkında bir gönderi
                            Content = "Php Dersleri",
                            IsActive = false, // Bu gönderi aktif değil (yayınlanmamış)
                            PublishedOn = DateTime.Now.AddDays(-20), // Yayınlanma tarihi 20 gün önce
                            Tags = context.Tags.Take(2).ToList(), // Bu gönderiye 2 adet tag ilişkilendiriyoruz.
                            UserId = 1, // Bu gönderiyi oluşturan kullanıcı ID'si
                        },
                        new Post{
                            Title = "Django",  // Django hakkında bir gönderi
                            Content = "Django Dersleri",
                            IsActive = true, // Gönderi aktif (yayınlanmış)
                            PublishedOn = DateTime.Now.AddDays(-5), // Yayınlanma tarihi 5 gün önce
                            Tags = context.Tags.Take(4).ToList(), // Bu gönderiye 4 adet tag ilişkilendiriyoruz.
                            UserId = 2, // Bu gönderiyi oluşturan kullanıcı ID'si
                        }
                    );
                    // Gönderileri veritabanına kaydediyoruz.
                    context.SaveChanges();
                }

            }
        }
    }
}
