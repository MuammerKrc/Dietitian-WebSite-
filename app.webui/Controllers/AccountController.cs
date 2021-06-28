using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using app.business.Abstract;
using app.entity;
using app.webui.EmailService;
using app.webui.Identity;
using app.webui.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace app.webui.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> userManager;
        private RoleManager<IdentityRole> roleManager;
        private SignInManager<User> signInManager;
        private IEmailSender emailSender;
        private ICustomerService customerService;
        public AccountController(ICustomerService _customerService, UserManager<User> _userManager, SignInManager<User> _signInManager, IEmailSender _emailSender, RoleManager<IdentityRole> _roleManager)
        {
            customerService = _customerService;
            userManager = _userManager;
            signInManager = _signInManager;
            emailSender = _emailSender;
            roleManager = _roleManager;
        }
        [HttpGet]
        public IActionResult Login(string ReturnUrl = null)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Girilen Kullanıcı Adı ve Parola İle Eşleşen Bir Kullanıcı Bulunamadı");
                model.Password = "";
                return View(model);
            }
            var user = await userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Girilen Kullanıcı Adı ve Parola İle Eşleşen Bir Kullanıcı Bulunamadı");
                model.Password = "";
                return View(model);
            }

            var result = await signInManager.PasswordSignInAsync(user, model.Password, true, true);
            if (result.Succeeded)
            {
                return Redirect(model.ReturnUrl ?? "~/");
            }
            ModelState.AddModelError("", "Girilen Kullanıcı Adı ve Parola İle Eşleşen Bir Kullanıcı Bulunamadı");
            model.Password = "";
            return View(model);
        }
        [HttpGet]
        public IActionResult ForgotPassword()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string Email)
        {
            if (string.IsNullOrEmpty(Email))
            {
                return View();
            }
            var user = await userManager.FindByEmailAsync(Email);
            if (user != null)
            {
                //generate tooken
                var code = await userManager.GeneratePasswordResetTokenAsync(user);
                var url = Url.Action("ResetPassword", "Account", new
                {
                    userId = user.Id,
                    token = code
                });
                //Email
                await emailSender.SendEmailAsync(Email, "ResetPassword", $"Parolanızı yenilemek için linke <a href='http://localhost:5000{url}'>tıklayınız.</a>");
            }

            return View();
        }
        public IActionResult ResetPassword(string userId, string token)
        {
            if (userId == null || token == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var model = new ResetPasswordModel() { Token = token };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var user = await userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var result = await userManager.ResetPasswordAsync(user, model.Token, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Login", "Account");
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        public static string ToTitleCase(string value)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model, string btnradio)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    model.Password = "";
                    return RedirectToAction("login", "account", model);
                }
                var user = new User();
                var IsThere = await userManager.FindByEmailAsync(model.Email);
                if (IsThere != null)
                {
                    //var yazılacak
                    return RedirectToAction("login", "account", model);
                }
                user.FirstName = ToTitleCase(model.FirstName.ToLower().Trim());
                user.LastName = ToTitleCase(model.LastName.ToLower().Trim());
                user.Gender = btnradio == "1" ? true : false;
                user.Email=model.Email;
                bool flag = true;
                int y=0;
                while (flag)
                {
                    var modelUserName=user.FirstName+$"{y}";
                    var UserNameTry=await userManager.FindByNameAsync(modelUserName);
                    if(UserNameTry==null)
                    {
                        user.UserName=modelUserName;
                        flag=true;
                        break;
                    }
                    else
                    {
                        y++;
                    }
                }
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    //Add in Customer Role
                    var resultRoleAdd = await userManager.AddToRoleAsync(user, "Customer");
                    //make Customer
                    Customer customer = new Customer()
                    {
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Mail = user.Email,
                        UserId = user.Id,
                        Gender=user.Gender
                    };
                    var resultCustomer = await customerService.InitilazeCustomer(customer);


                    //Email
                    // var code = await userManager.GenerateEmailConfirmationTokenAsync(user);
                    // var url = Url.Action("ConfirmEmail", "Account", new
                    // {
                    //     userId = user.Id,
                    //     token = code
                    // });
                    // await emailSender.SendEmailAsync(model.Email, "Hesabınızı onaylayınız.", $"lütfen email hesabınızı onaylamak için linke <a href='http://localhost:5000{url}'>tıklayınız.</a>");
                    return RedirectToAction("Login", "Account");
                }
                ModelState.AddModelError("", "Bilinmeyen bir nden oldu lütfen tekrar deneyiniz");
                return View(model);
            }
            catch (System.Exception)
            {
                ModelState.AddModelError("", "Bilinmeyen bir nden oldu lütfen tekrar deneyiniz");
                return View(model);
            }
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                return View();
            }
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return View();
            }
            var result = await userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                return View();
            }
            return View();
        }
    }
}