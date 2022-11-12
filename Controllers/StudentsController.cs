using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

namespace MyWebApp.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(Student std)
        {
            if (ModelState.IsValid)
            {
                return View("Details", std);
            }
            else
            {
                return View(std);
            }
        }
    }
}
