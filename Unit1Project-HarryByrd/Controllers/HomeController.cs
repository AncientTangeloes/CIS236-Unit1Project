using Microsoft.AspNetCore.Mvc;
using Unit1Project_HarryByrd.Models;

namespace Unit1Project_HarryByrd.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.U1P = "";
            return View();
        }

        [HttpPost]
        public IActionResult Index(Unit1ProjectModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.U1P = model.GenerateMemeName();
            }
            else
            {
                ViewBag.U1P = "";
            }
            return View(model);
        }
    }
}
