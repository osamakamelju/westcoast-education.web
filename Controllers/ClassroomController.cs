using Microsoft.AspNetCore.Mvc;
using westcoast_education.web.Models;

namespace westcoast_education.web.Controllers
{
    [Route("[classroom]")]
    public class ClassroomController : Controller
    {
        public IActionResult Index()
        {
         
          var classroom = new List<Classroom>
          {
            new Classroom{Name = "Introduction to programming", Content = "Python", Title = "P1",},
            new Classroom{Name = "Fronted developing", Content = "HTML CSS & JS", Title = "P2",},
            new Classroom{Name = "Backend developing", Content = "php", Title = "P3",},
            new Classroom{Name = "Mobile Apps", Content = "Basics of Mobile application programming", Title = "M1",},
          };
           return View("Index", classroom);
        }
        // https://localhost:7000/classroom/details/101
        [Route("details/{school}")]
        public IActionResult Details(Guid courseId)
        {
            
            var foundClassroom =  new Classroom
            {
              Name = "Mobile Apps", 
              Content = "Basics of Mobile application programming", 
              Title = "M1",
            };
            return View();
        }
    }
}