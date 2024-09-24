using Microsoft.AspNetCore.Mvc; // ASP.NET Core MVC framework'ünü kullanmak için gerekli kütüphane.
using efcoreApp.Data; // Projenizdeki veri erişim katmanını kullanmak için gerekli namespace.
using Microsoft.EntityFrameworkCore; // Bu ekleme asenkron metodları kullanabilmeniz için gereklidir.

namespace efcoreApp.Controllers{
    public class OgrenciController : Controller {
        private readonly DataContext _context; // Veri tabanı ile etkileşim kurmak için DataContext sınıfını kullanıyoruz.

        // Constructor ile DataContext sınıfını dependency injection ile alıyoruz.
        public OgrenciController(DataContext context){
            _context = context; // DataContext örneği bu sınıfa atanıyor.
        }

        // Asenkron bir şekilde tüm öğrencileri listelemek için Index metodu.
        public async Task<IActionResult> Index(){
            var ogrenciler = await _context.Ogrenciler.ToListAsync(); // Veritabanındaki tüm öğrencileri çekiyoruz.
            return View(ogrenciler); // Verileri View'e (görünüme) gönderiyoruz.
        }

        // Yeni bir öğrenci eklemek için Create sayfasını döndüren metot.
        public IActionResult Create(){
            return View(); // Boş bir form döndürülüyor.
        }

        // Öğrenci oluşturma formunu gönderdiğimizde bu metot çalışır.
        [HttpPost] // Bu metot, sadece POST istekleri için çalışır.
        public async Task<IActionResult> Create(Ogrenci ogrenci){
            if (ModelState.IsValid) { // Model doğrulaması geçerli mi diye kontrol ediyoruz.
                _context.Ogrenciler.Add(ogrenci); // Veritabanına yeni öğrenci ekleniyor.
                await _context.SaveChangesAsync(); // Veritabanına asenkron olarak kaydediliyor.
                return RedirectToAction("Index", "Ogrenci"); // İşlem tamamlanınca Index sayfasına yönlendiriliyor.
            }
            return View(ogrenci); // Eğer model geçersizse form tekrar gösteriliyor.
        }
    }
}
