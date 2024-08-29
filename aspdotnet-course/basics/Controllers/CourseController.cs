using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

//Course
public class CourseController : Controller{
     
     //Action methods

     // /course/ ya da  /course/index
     public IActionResult Index(){
         var kurs = new Course();

         kurs.Id = 1;
         kurs.Title = "ASP NET KURSU";
         kurs.Image = "first-image.jpg";
         kurs.Description  ="Açıklama";
        return View(kurs);
     }

      public IActionResult Details(int? id){
         if(id == null){
            return Redirect("/course/list");
         }
         var kurs = Repository.GetById(id);
        return View(kurs);
     }

    // /course/list
     public IActionResult List(){
      
      return View(Repository.Courses);
     }
}