using Microsoft.AspNetCore.Mvc;

namespace app.webui.Controllers
{
    //Todo:navbar indexi css yüklenecek
    //? DatabaseGüncellemesini unutma daha sonradan takvim yapıalcak
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}