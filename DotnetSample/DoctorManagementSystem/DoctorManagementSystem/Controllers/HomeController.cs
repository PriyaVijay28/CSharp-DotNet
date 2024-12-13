using System.Diagnostics;
using DoctorManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoctorManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SubmitData(string name,string desig,string spec)
        {
            TempData["Name"]=name;
            TempData["Designation"]=desig;
            TempData["Speciality"]=spec;
                return RedirectToAction("Create", "DMS");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
