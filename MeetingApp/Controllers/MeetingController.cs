using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;
namespace MeetingApp.Controllers
{

    public class MeetingController : Controller
    {

        //Default olarak HTTP GET isteği olarak verilir.
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(Meeting meeting)
        {
            if (ModelState.IsValid)
            {
                //Formdan gelen veriyi listeye kaydediyoruz
                Repository.CreateUser(meeting);
                // Başarı mesajını TempData'ya ekle
                TempData["SuccessMessage"] = "Başarıyla kaydedildi!";
                return RedirectToAction("List");
            }else{
                return View(meeting);
            }

        }

        [HttpGet]
        public IActionResult List()
        {
            return View(Repository.Meetings);
        }

        //meeting/details/2
        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }
    }
}