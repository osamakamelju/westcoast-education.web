using Microsoft.AspNetCore.Mvc;

namespace westcoast_education.web.Controllers
{
    [Route("[classroom]")]
    public class ClassroomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("details/{courseId}")]
        public IActionResult Details(int courseId)
        {
            return View();
        }
    }
}