using System.Threading.Tasks;
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
        private SignInManager<User> signInManager;
        private IEmailSender emailSender;
        public AccountController(UserManager<User> _userManager, SignInManager<User> _signInManager, IEmailSender _emailSender)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            emailSender = _emailSender;
        }

        [HttpGet]
        public IActionResult Login(string ReturnUrl = null)
        {

            return View(new LoginModel()
            {
                ReturnUrl = ReturnUrl
            });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Girilen Kullanıcı Adı ve Parola İle Eşleşen Bir Kullanıcı Bulunamadı");
                model.Password = "";
                return View(model);
            }
            var user = await userManager.FindByNameAsync(model.Username);
            if (user == null)
            {
                ModelState.AddModelError("", "Girilen Kullanıcı Adı ve Parola İle Eşleşen Bir Kullanıcı Bulunamadı");
                model.Password = "";
                return View(model);
            }
            var result = await signInManager.PasswordSignInAsync(model.Username, model.Password,true,true);
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Password = "";
                model.RePassword = "";
                return View(model);
            }
            var user = new User
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email
            };
            var result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var code = await userManager.GenerateEmailConfirmationTokenAsync(user);
                var url = Url.Action("ConfirmEmail", "Account", new
                {
                    userId = user.Id,
                    token = code
                });
                //Email
                await emailSender.SendEmailAsync(model.Email, "Hesabınızı onaylayınız.", $"lütfen email hesabınızı onaylamak için linke <a href='http://localhost:5000{url}'>tıklayınız.</a>");
                return RedirectToAction("Login", "Account");
            }
            ModelState.AddModelError("", "Bilinmeyen bir nden oldu lütfen tekrar deneyiniz");
            return View(model);
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