using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using basics.Models;

namespace basics.Controllers;

public class HomeController : Controller
{
    // /home ya da /home/index
    public IActionResult Index()
    {
        return View();
    }

    // /home/privacy
    public IActionResult Contact()
    {
        //return View("ContactView") ile de döner. Eğer farklı isimle .cshtml sayfası oluşturursak
        return View("Privacy");
    }
}
