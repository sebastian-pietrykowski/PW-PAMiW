using Microsoft.AspNetCore.Mvc;

namespace P09ShopWebAPPMVC.Client.Controllers
{
    //localhost/calculator/
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(IFormCollection form) 
        {
            int number1 = int.Parse(form["number1"]);
            int number2 = int.Parse(form["number2"]);

            int result = number1 + number2;

            ViewBag.Number1 = number1;
            ViewBag.Number2 = number2;
            ViewBag.MyResult = result;

            return View("Index");
            //ViewBag - uzycie dynamicznej wlascwiosci (proste dane)
            //ViewData - uzycie slownika (proste dane)
            // przeslanie danych przez model (zlozone dane)
        }
    }
}
