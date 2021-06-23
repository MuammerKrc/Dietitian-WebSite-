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
    public class HomeController : Controller
    {
        UserManager<User> userManager;
        ICustomerService customerService;
        IPackageRequestService packageRequestService;

        public HomeController(IPackageRequestService _packageRequestService, ICustomerService _customerService, UserManager<User> _userManager)
        {
            packageRequestService = _packageRequestService;
            userManager = _userManager;
            customerService = _customerService;
        }
        public IActionResult Index()
        {
            System.Console.WriteLine(DateTime.Now.ToShortDateString());
            return View();
        }
        public async Task<IActionResult> Package()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = await userManager.FindByNameAsync(User.Identity.Name);
                if (User != null)
                {
                    var customerResult = await customerService.GetCustomerByUserId(user.Id);
                    if (customerResult.oprationResult == OprationResult.ok)
                    {
                        if (customerResult.value != null)
                        {
                            var resultRequest = await packageRequestService.GetByCustomerId(customerResult.value.Id);
                            if(resultRequest.oprationResult==OprationResult.ok)
                            {
                                ViewBag.AllRequest =resultRequest.values;
                            }
                        }
                        return View(customerResult.value);
                    }
                }
            }
            return View();
        }
    }
}