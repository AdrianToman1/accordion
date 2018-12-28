using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HTMLInterpreter;
using HTMLRepo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            IHTMLInterpreter htmlInterpreter = new HTMLInterpreter.HTMLInterpreter();
            IHTMLRepo htmlRepo = new HTMLRepo.HTMLRepo();
            
            return Content(htmlInterpreter.ApplyPermissions(htmlRepo.GetHTMLPage("test.html")), "text/html");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
