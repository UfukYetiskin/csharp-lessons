using Microsoft.AspNetCore.Mvc;
namespace MeetingApp.Controllers{

    public class HomeController : Controller {

        //localhost:3000/
        //localhost:3000/home
        //localhost:3000/home/index
        public IActionResult Index(){
            return View();
        }
    }
}