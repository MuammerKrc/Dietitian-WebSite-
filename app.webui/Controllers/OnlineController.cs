using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
using Newtonsoft.Json;
namespace app.webui.Controllers
{
    [Authorize]
    public class OnlineController : Controller
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
        IDateRequestService dateRequestService;
        IPilatesWeekService pilatesWeekService;
        IGeneralMsjService generalMsjService;
        public OnlineController(IGeneralMsjService _generalMsjService, IPilatesWeekService _pilatesWeekService, IDateRequestService _dateRequestService, ICalendarService _calendarService, UserManager<User> _userManager, ICustomerService _customerService, IRecipeService _recipeService, IDietWekklyService _dietWekklyService, IEmailSender _emailSender, IAnamnezFormService _anamnezFormService, IDietService _dietService, IPackageRequestService _packageService)
        {
            generalMsjService = _generalMsjService;
            pilatesWeekService = _pilatesWeekService;
            dateRequestService = _dateRequestService;
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

                        var resultGeneralMesaj = await generalMsjService.GetAll();
                        if (resultGeneralMesaj.oprationResult == OprationResult.ok)
                        {
                            if (resultGeneralMesaj.values != null)
                            {
                                if (resultGeneralMesaj.values.Count() > 0)
                                {
                                    ViewBag.GeneralMsj = resultGeneralMesaj.values.OrderByDescending(i => i.Id).ToList();
                                }
                            }
                        }
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
        public async Task<IActionResult> DietIndex()
        {
            try
            {
                var user = await usermanager.FindByNameAsync(User.Identity.Name);
                if (user != null)
                {
                    var result = await customerService.GetCustomerByUserId(user.Id);
                    if (result.oprationResult == OprationResult.ok)
                    {
                        if (result.value.Diet.AnamnezForm != null)
                        {
                            AnamnezForm a = result.value.Diet.AnamnezForm;
                            List<TableInfo> table = new List<TableInfo>();
                            table.AddRange(result.value.Diet.DietWekklies.Where(i => i.Active).OrderBy(i => i.Id).Select(i => new TableInfo()
                            {
                                Name = i.Name,
                                Adım = i.ortalamaAdim,
                                Diet = i.Dietuyumluluk,
                                Su = i.ortSu,
                                Kilo = i.GüncelKilo,
                                BasenÖlcüsü = i.GüncelKalca,
                                GögüsÖlcüsü = i.GüncelGögüs,
                                BelÖlcüsü = i.GüncelBel
                            }));
                            foreach (var item in table)
                            {
                                if ((item.Adım + item.Diet + item.Su) != 0)
                                {
                                    float t = item.Adım + item.Diet + item.Su;
                                    float k = t / 3;
                                    float y = MathF.Round(k, 1);
                                    item.WeekOrt = y;
                                }
                                if (a.Boy != null)
                                {
                                    if (a.Boy > 0 && item.Kilo > 0)
                                    {
                                        float kilos = item.Kilo * 10000;
                                        float boy = (float)a.Boy * (float)a.Boy;
                                        float bksaa = kilos / boy;
                                        item.Bki = MathF.Round(bksaa, 2);
                                    }
                                    if (a.Kilo != null)
                                    {
                                        if (a.Kilo > 0)
                                        {
                                            float kilos = (float)a.Kilo * 10000;
                                            float boy = (float)a.Boy * (float)a.Boy;
                                            float bksaa = kilos / boy;
                                            item.baslangicBki = MathF.Round(bksaa, 2);
                                        }
                                    }
                                }
                                if (a.Kilo != null)
                                {
                                    if (a.Kilo > 0 && item.Kilo > 0)
                                    {
                                        item.KiloDegisim = MathF.Round((float)a.Kilo - item.Kilo, 2);
                                    }
                                }
                                if (a.BelÖlcüsü != null)
                                {
                                    if (a.BelÖlcüsü > 0 && item.BelÖlcüsü > 0)
                                    {
                                        item.belDegisim = MathF.Round((float)a.BelÖlcüsü - item.BelÖlcüsü, 2);
                                    }
                                }
                                if (a.GögüsÖlcüsü != null)
                                {
                                    if (a.GögüsÖlcüsü > 0 && item.GögüsÖlcüsü > 0)
                                    {
                                        item.gögüsDegisim = MathF.Round((float)a.GögüsÖlcüsü - item.GögüsÖlcüsü, 2);
                                    }
                                }
                                if (a.BasenÖlcüsü != null)
                                {
                                    if (a.BasenÖlcüsü > 0 && item.BasenÖlcüsü > 0)
                                    {
                                        item.basenDegisim = MathF.Round((float)a.BasenÖlcüsü - item.BasenÖlcüsü, 2);
                                    }
                                }
                                if (item.baslangicBki > 0 && item.Bki > 0)
                                {
                                    item.bkiDegisim = MathF.Round((float)item.baslangicBki - item.Bki, 2);
                                }

                            }
                            ViewBag.Week = table;
                            ViewBag.table = JsonConvert.SerializeObject(table);
                        }

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

        public async Task<IActionResult> PilatesIndex()
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
        [HttpGet]
        public async Task<IActionResult> DietWekklys(int id)
        {
            try
            {
                var user = await usermanager.FindByNameAsync(User.Identity.Name);
                if (user != null)
                {
                    //control his own this dietweek
                    var ownWeek = await customerService.ownWeekControlWithByUserId(user.Id, id);
                    if (ownWeek == OprationResult.ok)
                    {
                        //take this week
                        var resultWeek = await dietWekklyService.GetByIDWithDietMenü(id);
                        if (resultWeek.oprationResult == OprationResult.ok)
                        {
                            //take all date request
                            var resultDateRequest = await dateRequestService.GetAll();
                            if (resultDateRequest.oprationResult == OprationResult.ok)
                            {
                                foreach (var item in resultDateRequest.values)
                                {
                                    if (item.WeekId == id && item.typeOfRequest == DateType.Diet)
                                    {
                                        ViewBag.control = true;
                                    }
                                }
                            }
                            return View(resultWeek.value);
                        }
                    }
                }
                return NotFound();
            }
            catch (System.Exception)
            {
                throw;
            }

        }
        public async Task<IActionResult> PilatesWeek(int id)
        {
            try
            {
                var user = await usermanager.FindByNameAsync(User.Identity.Name);
                if (user != null)
                {
                    //control his own this dietweek
                    var ownWeek = await customerService.onPiatesControlWithByUserId(user.Id, id);
                    if (ownWeek == OprationResult.ok)
                    {
                        //take this week
                        var resultWeek = await pilatesWeekService.GetWithIncludeOthers(id);
                        if (resultWeek.oprationResult == OprationResult.ok)
                        {
                            //take all date request
                            var resultDateRequest = await dateRequestService.GetAll();
                            if (resultDateRequest.oprationResult == OprationResult.ok)
                            {
                                foreach (var item in resultDateRequest.values)
                                {
                                    if (item.WeekId == id && item.typeOfRequest == DateType.Pilates)
                                    {
                                        ViewBag.control = true;
                                    }
                                }
                            }
                            return View(resultWeek.value);
                        }
                    }
                }
                return NotFound();
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult DietWekklys(DietWekkly model, IFormFile file)
        {
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> AnamnezForm()
        {
            try
            {
                var user = await usermanager.FindByNameAsync(User.Identity.Name);
                if (user != null)
                {
                    var anamnezForm = await customerService.GetCustomerByUserId(user.Id);
                    if (anamnezForm.oprationResult == OprationResult.ok)
                    {
                        if (anamnezForm.value.Diet.AnamnezForm != null)
                        {
                            return View(anamnezForm.value.Diet.AnamnezForm);
                        }
                        else
                        {
                            return View(new AnamnezForm()
                            {
                                DietId = anamnezForm.value.Diet.Id
                            });
                        }
                    }
                }
                //hata kodu
                return RedirectToAction("Home");
            }
            catch (System.Exception)
            {
                return NotFound();
            }
        }
        [HttpPost]
        public async Task<IActionResult> AnamnezForm(AnamnezForm model)
        {
            try
            {

                if (model.Id == 0)
                {
                    var resultCreate = await anamnezFormService.CreateAsync(model);
                }
                else
                {
                    var resultUpdate = await anamnezFormService.UpdateAsync(model);
                }
                return RedirectToAction("Home");
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> DietPackage(PackageRequest p)
        {
            try
            {
                var result = await packageService.CreateAsync(p);
                return RedirectToAction("Package", "Home");
            }
            catch (System.Exception)
            {
                return RedirectToAction("Package", "Home");
            }
        }
        public IActionResult PilatesPackage(int CustomerId)
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Calendar()
        {
            CallendarModel m = new CallendarModel(DateTime.Now);

            ViewBag.times = DateTime.Now;

            List<Week> Week = m.Weeks;
            foreach (var item in Week)
            {
                var result = await calendarService.GetDates(item.Time);
                if (result.oprationResult == OprationResult.ok)
                {
                    item.AllDateInDay = result.values;
                }
            }
            return View(Week);
        }

        [HttpPost]
        public async Task<IActionResult> Calendar(DateTime? time)
        {
            CallendarModel m = null;
            if (time == null)
            {
                m = new CallendarModel(DateTime.Now);
                ViewBag.times = DateTime.Now;
            }
            else
            {
                m = new CallendarModel((DateTime)time);
                ViewBag.times = (DateTime)time;
            }
            List<Week> Week = m.Weeks;
            foreach (var item in Week)
            {
                var result = await calendarService.GetDates(item.Time);
                if (result.oprationResult == OprationResult.ok)
                {
                    item.AllDateInDay = result.values.OrderBy(i=>i.StartingHour).ToList();
                }
            }
            return View(Week);
        }

        #region Diet Week Update
        [HttpPost]
        public async Task<IActionResult> UpdateDietWeekly(DietWekkly d, int aaa, int bbb)
        {
            try
            {
                d.IsUpdate = true;
                var result = await dietWekklyService.UpdateAsync(d);
                if (User.IsInRole("Admin"))
                {
                    return Redirect("~/Admin/CustomerWeek/" + d.Id);
                }
                else
                {
                    return Redirect("~/Online/DietWekklys/" + d.Id);
                }
            }
            catch (System.Exception)
            {
                return NotFound();
            }
        }


        #endregion

        #region  DateRequest
        public async Task<IActionResult> dateRequestDiet(DateRequest date)
        {
            try
            {
                date.RequestTİme = DateTime.Now;
                date.typeOfRequest = DateType.Diet;
                var resultCreate = await dateRequestService.CreateAsync(date);
                if (resultCreate != OprationResult.ok)
                {

                }
                return Redirect("~/Online/DietWekklys/" + date.WeekId);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public async Task<IActionResult> dateRequestPilates(DateRequest date)
        {
            try
            {
                date.RequestTİme = DateTime.Now;
                date.typeOfRequest = DateType.Pilates;
                var resultCreate = await dateRequestService.CreateAsync(date);
                if (resultCreate != OprationResult.ok)
                {

                }
                return Redirect("~/Online/PilatesWeek/" + date.WeekId);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        #endregion
    }
}