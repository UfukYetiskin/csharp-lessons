using efcoreApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace efcoreApp.Controllers
{
    public class OgretmenController : Controller
    {
        private readonly DataContext _context;
        public OgretmenController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(){
            var ogretmenler = await _context.Ogretmenler.ToListAsync();
            return View(ogretmenler);
        }

        [HttpGet]
        public async  Task<IActionResult> Create(){
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Ogretmen ogretmen){
                _context.Ogretmenler.Add(ogretmen);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Ogretmen");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id){
            var ogretmen = await _context
                                .Ogretmenler
                                // .Include(item => item.KursKayitlari)
                                // .ThenInclude(item => item.Kurs)
                                .FirstOrDefaultAsync(item => item.OgretmenId == id); // İlk eşleşen kaydı al // id'ye göre ilk kaydı alıyoruz
            if (ogretmen == null)
            {
                return NotFound(); // Eğer öğrenci bulunamazsa 404 döndür
            }
            return View(ogretmen); // Öğrenciyi View'e gönder
        }

                [HttpPost]
        [HttpPut]  // PUT metodunu gizli alan ile işleyebilmek için
        public async Task<IActionResult> Edit(int id, Ogretmen ogretmen)
        {
            var ogr = await _context.Ogretmenler.FindAsync(id);
            if (ogr != null)
            {
                ogr.Ad = ogretmen.Ad;
                ogr.Soyad = ogretmen.Soyad;
                ogr.Eposta = ogretmen.Eposta;
                ogr.Telefon = ogretmen.Telefon;
                ogr.BaslamaTarihi = ogretmen.BaslamaTarihi;

                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Ogretmen");
            }
            return View(ogr);
        }

        [HttpPost]
        [HttpDelete]
        public async Task<IActionResult> DeleteOgretmen(int id){
            var ogr = await _context.Ogretmenler.FindAsync(id);
            if(ogr != null){
                _context.Ogretmenler.Remove(ogr);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Ogretmen");
            }
            return RedirectToAction("Index", "Ogretmen");

        }
    }
}