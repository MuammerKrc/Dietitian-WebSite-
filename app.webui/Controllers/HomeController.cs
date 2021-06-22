using System;
using System.Threading.Tasks;
using app.business.Abstract;
using app.webui.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace app.webui.Controllers
{
    //Todo:navbar indexi css yüklenecek
    //? DatabaseGüncellemesini unutma daha sonradan takvim yapıalcak
    public class HomeController:Controller
    {
        UserManager<User> userManager;
        ICustomerService customerService;

        public HomeController(ICustomerService _customerService,UserManager<User> _userManager)
        {
            userManager=_userManager;
            customerService=_customerService;
        }
         public IActionResult Index()
        {
            System.Console.WriteLine(DateTime.Now.ToShortDateString());
            return View();
        }
        public async  Task<IActionResult> Package()
        {
            if(User.Identity.IsAuthenticated)
            {
                var user =await userManager.FindByNameAsync(User.Identity.Name);
                if(User!=null)
                {
                    var customerResult =await customerService.GetCustomerByUserId(user.Id);
                    if(customerResult.oprationResult==OprationResult.ok)
                    {
                        return View(customerResult.value);
                    }
                }
            }
            return View();
        }
    }
}