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
using ValidationFramework.Decorator;

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
            validation.SetShowBehaivor(new Alert());
            validation.IsNotNullOrEmpty(employee.GetNamePropertyName(), employee.Name);

            ValidationString validationString = new ValidationString(validation);
            validationString.HaveAnyUpperCharacter(employee.GetNamePropertyName(), employee.Name);
            ValidationRegularExpression validationRegularExpression = new ValidationRegularExpression(validation);
            validationRegularExpression.IsEmail(employee.GetNamePropertyName(), employee.Name);
            ModelResponse modelResponse = new ModelResponse(validation.GetErrors(validationString, validationRegularExpression),validation.Show());

            validation.ReadProperties(employee);

            return Json(modelResponse);
          

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
