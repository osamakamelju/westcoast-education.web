using Microsoft.AspNetCore.Mvc;

namespace westcoast_education.web.Controllers;

public class HomeController : Controller
{
    //Action method...
    public IActionResult Index(int id)
    {
        ViewBag.Message = "We have courses to study!";
        //Returnerar ett ViewResult...
        return View("Index");
    }
}
