using Microsoft.AspNetCore.Mvc;

namespace westcoast_education.web.Controllers;

public class HomeController : Controller
{
    //Action method...
    public IActionResult Index()
    {
        ViewBag.Message = "Vi har Kurser för att plugga!";
        //Returnerar ett ViewResult...
        return View("Start");
    }
}
