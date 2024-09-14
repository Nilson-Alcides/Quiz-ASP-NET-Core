using Microsoft.AspNetCore.Mvc;
using QuizAspNet.Models;
using System.Diagnostics;

namespace QuizAspNet.Controllers
{
    public class HomeController : Controller
    {
     

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Acervo()
        {
            return View();
        }


    }
}
