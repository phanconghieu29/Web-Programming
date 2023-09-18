using Bai1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Bai1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowEmployee()
        {
            List<Employee> listEmployee = new List<Employee>();
            try
            {

                return View(listEmployee);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }
    }
}
