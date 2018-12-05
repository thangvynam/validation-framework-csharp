using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;
using ValidationFramework;
using System.Reflection;
using ValidationFramework.Show;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        Validation validation = Validation.getInstance;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(Employee employee)
        {
            validation.IsNotNullOrEmpty(employee.GetNamePropertyName(),employee.Name);
            validation.SetShowBehaivor(new Alert());
            ModelResponse modelResponse = new ModelResponse(validation.GetErrors(),validation.IsValid(),validation.Show());

            return Json(modelResponse);
            //return Content(validation.IsValid().ToString(), "text/plain");

        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
