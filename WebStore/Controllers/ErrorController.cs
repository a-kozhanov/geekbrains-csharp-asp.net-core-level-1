using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Извините, запрашиваемый вами ресурс не найден";
                    return View("Error404");
                default:
                    ViewBag.ErrorMessage = "Упс, что-то пошло не так";
                    break;
            }

            return View("Error");
        }
    }
}