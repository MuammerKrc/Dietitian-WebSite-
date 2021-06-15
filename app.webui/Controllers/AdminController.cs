using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
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
using Microsoft.Extensions.FileProviders;

namespace app.webui.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private RoleManager<IdentityRole> roleManager;
        private UserManager<User> userManager;
        public ICustomerService customerService;
        public IDietWekklyService dietWekklyService;
        private IEmailSender emailSender;
        private IRecipeService recipeService;
        private IDietMenüService dietMenüService;
        private IDietService dietService;
        private IPackageRequestService packageService;
        private ICalendarService calendarService;

        public AdminController(ICalendarService _calendarService, IPackageRequestService _packageService, UserManager<User> _userManager, ICustomerService _customerService, IDietWekklyService _dietWekklyService, IEmailSender _emailSender, IRecipeService _recipeService, IDietMenüService _dietMenüService, IDietService _dietService, RoleManager<IdentityRole> _roleManager)
        {
            calendarService = _calendarService;
            packageService = _packageService;
            userManager = _userManager;
            dietMenüService = _dietMenüService;
            customerService = _customerService;
            dietWekklyService = _dietWekklyService;
            emailSender = _emailSender;
            recipeService = _recipeService;
            dietService = _dietService;
            roleManager = _roleManager;
        }
        //home
        public async Task<IActionResult> Home()
        {
            try
            {
                var result = await packageService.GetAll();
                if (result.values.Count() > 0)
                {
                    ViewBag.Package = "Yeni Paket İstekleri Bulunmaktadır";
                    ViewBag.Request = result.values;
                }
                return View();
            }
            catch (System.Exception)
            {
                return View();
            }
        }

        public async Task<IActionResult> AllCustomer()
        {
            var returned = await customerService.GetAll();
            return View(returned.values);
        }
        // Index
        public async Task<IActionResult> Index()
        {
            var returned = await customerService.GetAll();
            return View(returned.values);
        }
        public IActionResult Deneme3()
        {

            return View();
        }
        public IActionResult Deneme(DateTime time)
        {
            return View();
        }
        [HttpGet]
        // public async Task<IActionResult> Denemeiki()
        // {

        //     var result = await mounthService.GetDateInOneMounth(DateTime.Now.Month);
        //     CalendarModel c = new CalendarModel(new DateTime(), result.value);

        //     return View(c);

        // }
        // [HttpPost]
        // public async Task<IActionResult> Denemeiki(DateTime m)
        // {
        //     var result = await mounthService.GetDateInOneMounth(m.Month);

        //     CalendarModel c = new CalendarModel(m, result.value);

        //     if (result.value != null)
        //     {
        //         System.Console.WriteLine("girdi");
        //     }

        //     return View(c);

        // }
        [HttpGet]
        public async Task<IActionResult> DietWekklys(int id)
        {
            var result = await dietWekklyService.GetByIdAsync(id);
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
        public async Task<IActionResult> DietOneMonth(int id)
        {

            DietWekkly D;
            var result = await customerService.GetCustomerByIdWithDiet(id);
            for (var y = 0; y < 4; y++)
            {
                D = new DietWekkly()
                {
                    Name = $"{result.value.Diet.DietWekklies.Count + y + 1} Hafta",
                    DietId = result.value.Diet.Id
                };
                await dietWekklyService.CreateAsync(D);
            }
            return Redirect("/Diet/Index/" + id);
        }

        public async Task<IActionResult> DietOneWeek(int id)
        {
            DietWekkly D;

            var result = await customerService.GetCustomerByIdWithDiet(id);

            D = new DietWekkly()
            {
                Name = $"{result.value.Diet.DietWekklies.Count + 1} Hafta",

                DietId = result.value.Diet.Id
            };
            await dietWekklyService.CreateAsync(D);

            return Redirect("/admin/diet/" + id);
        }

        [HttpGet]
        public async Task<IActionResult> DietSendAndChange(int? id)
        {
            var result = await dietWekklyService.GetByIDWithDietMenü((int)id);
            var allRecipe = await recipeService.GetAll();
            ViewBag.Recipe = allRecipe.values;

            return View(result.value);
        }

        [HttpPost]
        public async Task<IActionResult> DietSendAndChange(DietWekkly model, int[] recipeIds, IFormFile file, String content, int meal, int btnradio = 1)
        {
            try
            {
                if (recipeIds == null)
                {
                    var resultsa = await dietWekklyService.GetByIDWithDietMenü(model.DietId);
                    var allRecipe = await recipeService.GetAll();
                    ViewBag.Recipe = allRecipe.values;

                    return View(resultsa.value);
                }



                var d = new DietMenü();
                string name = file.FileName;
                string randomName = string.Format($"{Guid.NewGuid()}.{name}");
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\diet", randomName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                System.Console.WriteLine(path + "   " + "yol");
                Attachment attachment = new Attachment($"{path}");



                if (model.DietMenü.Id == 0)
                {
                    d = new DietMenü()
                    {
                        Gender = btnradio == 1 ? true : false,
                        Path = path,
                        DietWekklyId = model.Id,
                        TwoMeals = meal == 1 ? true : false,
                        FullName = model.DietMenü.FullName,
                        Weight = model.DietMenü.Weight,
                        Content = content
                    };
                    //create Diet Menü
                    var resultInıtial = await dietMenüService.InitilazeDietMenü(d, recipeIds);
                    //Week Make Active
                    var weekResult = await dietWekklyService.MakeActive(model.Id);
                    //UpdateRemaningPackage
                    var ReducePackage = await customerService.ReduceDietPackage(model.Diet.CustomerId);

                }
                else
                {
                    d = new DietMenü()
                    {
                        Id = model.DietMenü.Id,
                        Gender = btnradio == 1 ? true : false,
                        Path = path,
                        DietWekklyId = model.Id,
                        TwoMeals = meal == 1 ? true : false,
                        FullName = model.DietMenü.FullName,
                        Weight = model.DietMenü.Weight,
                        Content = content
                    };
                    //update Diet Menü
                    var reeult = await dietMenüService.UpdateDietmenü(d, recipeIds);
                    //Week Make Active
                    var weekResult = await dietWekklyService.MakeActive(model.Id);
                    //UpdateRemaningPackage
                    var ReducePackage = await customerService.ReduceDietPackage(model.Diet.CustomerId);
                }
                // update combine diet and recipe
                var results = await dietService.UpdateJustRecipe(model.Diet.Id, recipeIds);

                // await emailSender.SendEmailAsync("muammer03karaca@gmail.com", "Haftalık Diyetiniz", $"{content}", attachment);
                return Redirect("/Diet/DietWekklys/" + model.Id);
            }
            catch (System.Exception)
            {

                throw;
            }

        }

        [HttpGet]
        public async Task<IActionResult> DietMenüList()
        {
            var allrecipe = await recipeService.GetAll();
            ViewBag.recipes = allrecipe.values;
            var result = await dietMenüService.GetAllWithRecpe();
            return View(result.values);
        }
        [HttpPost]
        public async Task<IActionResult> DietMenüList(string Adı, int? MinWeight, int? MaxWeight, int Cinsiyet, int Meal, int[] recipeIds)
        {
            var allrecipe = await recipeService.GetAll();
            ViewBag.recipes = allrecipe.values;
            if (MaxWeight == null)
            {
                MaxWeight = 0;
            }
            if (MinWeight == null)
            {
                MinWeight = 0;
            }
            System.Console.WriteLine(MaxWeight + " " + MinWeight + " " + Adı);
            var result = await dietMenüService.GEtAllWithOption(Adı, (int)MinWeight, (int)MaxWeight, Cinsiyet, Meal, recipeIds);

            if (result.values == null)
            {
                return View(new List<DietMenü>());

            }

            return View(result.values);
        }
        [HttpPost]
        // public async Task<IActionResult> MakeCalendar(int dietWekklyId, int duration, DateTime timeOfDates)
        // {
        //     int startingHour = (timeOfDates.Hour * 100) + timeOfDates.Minute;
        //     int finishedHour = startingHour + duration;
        //     int day = timeOfDates.Day;
        //     int mounth = timeOfDates.Month;
        //     string CurrentHour = timeOfDates.ToShortTimeString();

        //     Console.WriteLine(startingHour);
        //     Console.WriteLine(finishedHour);
        //     Console.WriteLine(day);
        //     Console.WriteLine(mounth);

        //     var result = await mounthService.MakeDate(mounth, day, startingHour, finishedHour, dietWekklyId, CurrentHour);
        //     if (result.oprationResult == OprationResult.Saved)
        //     {
        //         var resultOfDietWekkly = await dietWekklyService.UpdateJustDate(dietWekklyId, result.value.CurrentHour);
        //     }
        //     return Redirect("/diet/DietWekklys/" + dietWekklyId);
        // }


        [HttpPost]
        public async Task<IActionResult> RegisterDiet(int CustomerId)
        {
            try
            {
                var result = await customerService.InitilazeDiet(CustomerId);
                return Redirect("~/Diet/Index/" + CustomerId);
            }
            catch (System.Exception)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> MakeDate(int dietWeekId, int durations, DateTime TimeofDates, string firstname, string lastname)
        {
            try
            {
                int startingHour = (TimeofDates.Hour * 60) + TimeofDates.Minute;

                int finishedHour = startingHour + durations;
                int day = TimeofDates.Day;
                int month = TimeofDates.Month;
                int year = TimeofDates.Year;
                string Hour = $"{TimeofDates.Hour}:{TimeofDates.Minute}";

                Calendar c = new Calendar()
                {
                    StartingHour = startingHour,
                    FinishedHour = finishedHour,
                    CurrentDay = day,
                    CurrentMounth = month,
                    CurrentYear = year,
                    Active = true,
                    CurrentHour = Hour,
                    DietWekklyId = dietWeekId,
                    FirstName = firstname,
                    Traning = "diet",
                    LastName = lastname
                };
                var result = await calendarService.MakeDate(c);
                return Redirect("~/Diet/DietWekklys/" + dietWeekId);
            }
            catch (System.Exception)
            {

                throw;
            }

        }

        [HttpPost]
        public async Task<IActionResult> RemoveDate(int dietWeekId, int DateId)
        {
            try
            {
                Calendar c = new Calendar()
                {
                    Id = DateId
                };
                var result = await calendarService.DeleteAsync(c);


                return Redirect("~/Diet/DietWekklys/" + dietWeekId);
            }
            catch (System.Exception)
            {

                throw;
            }

        }

        [HttpPost]
        public async Task<IActionResult> UpdateDate(int dietWeekId, int DateId, int durations, DateTime TimeofDates, string firstname, string lastname)
        {
            try
            {
                int startingHour = (TimeofDates.Hour * 60) + TimeofDates.Minute;

                int finishedHour = startingHour + durations;
                int day = TimeofDates.Day;
                int month = TimeofDates.Month;
                int year = TimeofDates.Year;
                string Hour = $"{TimeofDates.Hour}:{TimeofDates.Minute}";

                Calendar c = new Calendar()
                {
                    Id = DateId,
                    StartingHour = startingHour,
                    FinishedHour = finishedHour,
                    CurrentDay = day,
                    CurrentMounth = month,
                    CurrentYear = year,
                    Active = true,
                    CurrentHour = Hour,
                    DietWekklyId = dietWeekId,
                    FirstName = firstname,
                    Traning = "diet",
                    LastName = lastname
                };
                var result = await calendarService.UpdateAsync(c);
                return Redirect("~/Diet/DietWekklys/" + dietWeekId);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}