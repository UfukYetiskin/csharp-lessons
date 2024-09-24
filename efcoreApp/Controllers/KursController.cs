using Microsoft.AspNetCore.Mvc; // ASP.NET Core MVC framework'ünü kullanmak için gerekli kütüphane.
using efcoreApp.Data; // Projenizdeki veri erişim katmanını kullanmak için gerekli namespace.
using Microsoft.EntityFrameworkCore; // Bu ekleme asenkron metodları kullanabilmeniz için gereklidir.

namespace efcoreApp.Controllers{
    public class KursController : Controller{
        private readonly DataContext _context;
        public KursController(DataContext context){
            _context = context;
        }

        public async Task<IActionResult> Index(){
            var kurslar = await _context.Kurslar.ToListAsync();
            return View(kurslar);
        }

        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Kurs kurs){
            if(ModelState.IsValid){
                _context.Kurslar.Add(kurs);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Kurs");
            }
            return View(kurs);
        }
    }
}