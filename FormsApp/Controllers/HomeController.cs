using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using FormsApp.Models;

namespace FormsApp.Controllers;

public class HomeController : Controller
{
    public HomeController()
    {
    }

    [HttpGet]
    public IActionResult Index(string searchString, string category)
    {
        var products = Repository.Products;
        if (!String.IsNullOrEmpty(searchString))
        {
            ViewBag.SearchString = searchString;
            products = products.Where(p => p.Name.ToLower().Contains(searchString)).ToList();
        }
        if (!String.IsNullOrEmpty(category))
        {
            if (int.Parse(category) != 0)
            {
                products = products.Where(p => p.CategoryId == int.Parse(category)).ToList();
            }

        }
        ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name", category);
        return View(products);
    }

    [HttpPost]
    public IActionResult Index(Product product){
        var products = Repository.Products;
        if(ModelState.IsValid){
            Repository.CreateProduct(product);
            Console.WriteLine(product);
            return RedirectToAction("Index");
        }else{
            return View(products);
        }

    }
    public IActionResult Privacy()
    {
        return View();
    }
}
