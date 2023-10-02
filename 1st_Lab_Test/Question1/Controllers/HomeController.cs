using Microsoft.AspNetCore.Mvc;
using Question1.Models;

namespace Question1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegisterForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterForm(RegistrationInformation info)
        {
            return RedirectToAction("XuatThongTin",info);
        }

        public IActionResult XuatThongTin(RegistrationInformation info)
        {
            return View(info);
        }
    }
}

