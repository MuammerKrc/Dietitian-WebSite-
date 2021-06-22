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
using static app.entity.PackageRequest;

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
        public OnlineController(IDateRequestService _dateRequestService, ICalendarService _calendarService, UserManager<User> _userManager, ICustomerService _customerService, IRecipeService _recipeService, IDietWekklyService _dietWekklyService, IEmailSender _emailSender, IAnamnezFormService _anamnezFormService, IDietService _dietService, IPackageRequestService _packageService)
        {
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
                                    if(item.WeekId==id&&item.typeOfRequest==DateType.Diet)
                                    {
                                        ViewBag.control=true;
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
                    item.AllDateInDay = result.values;
                }
            }
            return View(Week);
        }

        [HttpPost]
        public IActionResult Callendar(int i)
        {
            return View();
        }
        
        #region  DateRequest
        public async Task<IActionResult> dateRequestDiet(DateRequest date)
        {
            try
            {
                date.RequestTİme=DateTime.Now;
                date.typeOfRequest=DateType.Diet;
                var resultCreate=await dateRequestService.CreateAsync(date);
                if(resultCreate!=OprationResult.ok)
                {

                }
                return Redirect("~/Online/DietWekklys/"+date.WeekId);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        } 

        #endregion
    }

}