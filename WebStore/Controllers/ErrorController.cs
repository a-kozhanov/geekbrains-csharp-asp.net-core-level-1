using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return View("Error");
        }

        [Route("404")]
        public IActionResult PageNotFound()
        {
            return View("_404");
        }

        [Route("{code:int}")]
        public IActionResult Error(int code)
        {
            return View();
        }

        [Route("500")]
        public IActionResult Error500()
        {
            return View("Error");
        }
    }
}