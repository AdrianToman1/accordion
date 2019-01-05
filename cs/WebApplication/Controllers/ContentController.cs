using Common;
using HTMLInterpreter;
using HTMLRepo;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class ContentController : Controller
    {
        public IActionResult Index(string id)
        {
            IHTMLInterpreter htmlInterpreter = new HTMLInterpreter.HTMLInterpreter();
            IHTMLRepo htmlRepo = new FileSystemRepo();

            var html = htmlRepo.GetHTMLPage(id + ".html");

            if (string.IsNullOrWhiteSpace(html)) return NotFound();

            return Content(htmlInterpreter.ApplyPermissions(html), "text/html");
        }
    }
}