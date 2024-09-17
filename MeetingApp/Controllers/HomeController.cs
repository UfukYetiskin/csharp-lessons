using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;

namespace MeetingApp.Controllers{

    public class HomeController : Controller {

        //localhost:3000/
        //localhost:3000/home
        //localhost:3000/home/index
        public IActionResult Index(){
            int saat = DateTime.Now.Hour;
            ViewBag.Selamlama = saat > 12 ? "İyi Günler!" : "Günaydın!";
            ViewBag.UserName = "Ümmüş";
            ViewData["Surname"] = "Gümüş Yetişkin";
            var userCount = Repository.Meetings.Where(info => info.WillAttend == true).Count();
            var meetingInfo = new MeetingInfo()
            {
                Id = 1, 
                Location = "İstanbul, Maslak",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = userCount
            };
            return View(meetingInfo);
        }
    }
}