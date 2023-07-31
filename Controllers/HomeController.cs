
using HRApplication.Models;
using Microsoft.AspNetCore.Mvc;


namespace HRApplication.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Employee()
        {
            return View();
                
        }
        [HttpPost]
        public ViewResult Employee(Employee emp)
        {
            if (ModelState.IsValid)
            {
                Repostory.Addemb(emp);
                return View("comfirmation", emp);

            }
            else
                return View();
        }
        public ViewResult AllEmployees()
        {
            return View(Repostory.GetEmployee());
        }


    }
}