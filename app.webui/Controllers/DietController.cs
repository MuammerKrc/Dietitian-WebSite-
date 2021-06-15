using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using app.business.Abstract;
using app.entity;
using app.webui.EmailService;
using app.webui.Identity;
using app.webui.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace app.webui.Controllers
{
    [Authorize]
    public class DietController : Controller
    {
        IAnamnezFormService anamnezFormService;
        IDietService dietService;
        ICustomerService customerService;
        IRecipeService recipeService;
        IDietWekklyService dietWekklyService;
        IEmailSender emailSender;
        UserManager<User> usermanager;
        ICalendarService calendarService;
        IPackageRequestService packageService;
        public DietController(ICalendarService _calendarService, UserManager<User> _userManager, ICustomerService _customerService, IRecipeService _recipeService, IDietWekklyService _dietWekklyService, IEmailSender _emailSender, IAnamnezFormService _anamnezFormService, IDietService _dietService, IPackageRequestService _packageService)
        {
            calendarService = _calendarService;
            packageService = _packageService;
            usermanager = _userManager;
            anamnezFormService = _anamnezFormService;
            dietWekklyService = _dietWekklyService;
            customerService = _customerService;
            recipeService = _recipeService;
            emailSender = _emailSender;
            dietService = _dietService;
        }

        public async Task<IActionResult> Home()
        {
            try
            {
                var user = await usermanager.FindByNameAsync(User.Identity.Name);
                if (user != null)
                {
                    var result = await customerService.GetCustomerByUserId(user.Id);
                    if (result.oprationResult == OprationResult.ok)
                    {
                        return View(result.value);
                    }
                }
                return NotFound();
            }
            catch (System.Exception)
            {
                return NotFound();
            }
        }
        public async Task<IActionResult> Index(int? id)
        {
            try
            {
                if (id == null)
                {
                    var user = await usermanager.FindByNameAsync(User.Identity.Name);
                    if (user != null)
                    {
                        var result2 = await customerService.GetCustomerByUserId(user.Id);
                        if (result2.value.Diet != null)
                        {
                            result2.value.Diet.CombineDietRecipes = result2.value.Diet.CombineDietRecipes ?? new List<entity.CombineDietRecipe>();
                            result2.value.Diet.AnamnezForm = result2.value.Diet.AnamnezForm ?? new AnamnezForm();
                        }
                        var allRecipe = await recipeService.GetAll();
                        if (!(allRecipe.oprationResult == OprationResult.canceled))
                        {
                            ViewBag.Recipe = allRecipe.values;
                            return View(result2.value);
                        }
                    }
                    return NotFound();
                }

                var result = await customerService.GetCustomerByIdWithDiet((int)id);
                if (!(result.oprationResult == OprationResult.canceled))
                {
                    if (result.value.Diet != null)
                    {
                        result.value.Diet.CombineDietRecipes = result.value.Diet.CombineDietRecipes ?? new List<entity.CombineDietRecipe>();
                        result.value.Diet.AnamnezForm = result.value.Diet.AnamnezForm ?? new AnamnezForm();
                        if (result.value.Diet.CombineDietRecipes == null)
                        {
                            Console.WriteLine("girdi");
                        }
                        else
                        {
                            Console.Write("girmese daha iyi");
                        }
                    }
                    var allRecipe = await recipeService.GetAll();
                    allRecipe.values.ForEach(i => Console.WriteLine(i));

                    if (!(allRecipe.oprationResult == OprationResult.canceled))
                    {

                        ViewBag.Recipe = allRecipe.values;
                        return View(result.value);
                    }
                }
                return NotFound();
            }
            catch (System.Exception)
            {
                return NotFound();
            }
        }

        [HttpGet]
        public async Task<IActionResult> DietWekklys(int? id)
        {
            var result = await dietWekklyService.GetByIDWithDietMenü(id);
            return View(result.value);
        }
        [HttpPost]
        public async Task<IActionResult> DietWekklys(DietWekkly model, IFormFile file)
        {
            string name = file.FileName;
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\diet", name);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            System.Console.WriteLine(path + "   " + "yol");
            // var returned = await dietWekklyService.GetByIdAsync(model.Id);
            // returned.value.Menü = name;
            // returned.value.Active = true;
            // await dietWekklyService.UpdateAsync(returned.value);


            await emailSender.SendEmailAsync("sinem.karaca.93@gmail.com", "Haftalık Diyetiniz", $"Bu hafta Diyetiniz <a href='http://localhost:5000/diet/{name}'>tıklayınız.</a>");
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> AnamnezForm(int Id)
        {
            try
            {
                var anamnezRegister = await customerService.InitilazeAnamnezForm(Id);
                var anamnezForm = await customerService.GetCustomerByIdWithDiet(Id);
                if (anamnezForm.oprationResult == OprationResult.ok)
                {
                    if (anamnezForm.value.Diet.AnamnezForm != null)
                    {
                        ViewBag.CustomerId = anamnezForm.value.Id;
                        return View(anamnezForm.value.Diet.AnamnezForm);
                    }
                }
                return NotFound();
            }
            catch (System.Exception)
            {
                return NotFound();
            }

        }
        [HttpPost]
        public async Task<IActionResult> AnamnezForm(AnamnezForm model, int otherId)
        {
            var result = await anamnezFormService.UpdateAsync(model);
            return Redirect("/Diet/Index/" + otherId);
        }

        [HttpPost]
        public async Task<IActionResult> DietPackage(string name, int customer)
        {
            try
            {
                PackageRequest p = new PackageRequest()
                {
                    PackageName = "Diet",
                    CustomerId = customer,
                    FullName = name,
                    RequestTime = DateTime.Now
                };
                var result = await packageService.CreateAsync(p);
                return RedirectToAction("Home", "Diet");
            }
            catch (System.Exception)
            {
                return RedirectToAction("Home", "Diet");
            }
        }
        public IActionResult PilatesPackage(int CustomerId)
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Callendar()
        {
            CallendarModel m = new CallendarModel(DateTime.Now);
            List<Week> Week = m.Weeks;

            foreach (var item in Week)
            {
                var result = await calendarService.GetDates(item.Time);
                if (result.oprationResult == OprationResult.ok)
                {
                    item.AllDateInDay=result.values;
                }
            }
            return View(Week);
        }

        [HttpPost]
        public IActionResult Callendar(int i)
        {
            return View();
        }

    }
}