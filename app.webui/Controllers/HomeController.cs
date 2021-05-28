using Microsoft.AspNetCore.Mvc;

namespace app.webui.Controllers
{
    //Todo:navbar indexi css yüklenecek
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}