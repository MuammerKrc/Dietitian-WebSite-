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
using Newtonsoft.Json;

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
        private IGeneralMsjService generalMsjService;
        private IProductService productService;
        private IMyCartService myCartService;
        private IPilatesWeekService PilatesWeekService;
        private IDateRequestService dateRequestService;
        private IPilatesService pilatesService;

        public AdminController(IPilatesService _pilatesService,IDateRequestService _dateRequestService, IPilatesWeekService _pilatesWeekService, IMyCartService _myCartService, IProductService _productService, IGeneralMsjService _generalMsjService, ICalendarService _calendarService, IPackageRequestService _packageService, UserManager<User> _userManager, ICustomerService _customerService, IDietWekklyService _dietWekklyService, IEmailSender _emailSender, IRecipeService _recipeService, IDietMenüService _dietMenüService, IDietService _dietService, RoleManager<IdentityRole> _roleManager)
        {
            pilatesService=_pilatesService;
            dateRequestService = _dateRequestService;
            PilatesWeekService = _pilatesWeekService;
            myCartService = _myCartService;
            productService = _productService;
            generalMsjService = _generalMsjService;
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
        //pages 
        #region Admin Page 

        public async Task<IActionResult> Home()
        {
            try
            {
                //Get all Customer
                var result = await customerService.GetCustomerForHome();
                //Get General Mesaj
                var resultGeneralMesaj = await generalMsjService.GetAll();
                //All Recipe
                var resultRecipe = await recipeService.GetAll();
                //All Package Request
                var ResultPackageRequest = await packageService.GetAll();
                //All Date Request
                var RusultDateRequest = await dateRequestService.GetAll();

                if (ResultPackageRequest.oprationResult == OprationResult.ok)
                {
                    if (ResultPackageRequest.values.Count > 0)
                    {
                        ViewBag.AllPackageRequest = ResultPackageRequest.values;
                    }
                }
                else
                {
                    //hata raporu
                }
                if (resultRecipe.oprationResult == OprationResult.ok)
                {
                    ViewBag.Recipe = resultRecipe.values;
                }
                else
                {
                    //hata Raporu Yazılacak
                }
                if (resultGeneralMesaj.oprationResult == OprationResult.ok)
                {
                    ViewBag.General = resultGeneralMesaj.values;
                }
                else
                {
                    //Hata Raporları oluşturulacak
                }
                if (RusultDateRequest.oprationResult == OprationResult.ok)
                {
                    if (RusultDateRequest.values.Count > 0)
                    {
                        ViewBag.AllDateRequest = RusultDateRequest.values;
                    }
                }
                if (result.oprationResult == OprationResult.ok)
                {
                    return View(result.values);
                }
                else
                {
                    //Hata Raporları oluşturulacak
                    return View(new List<Customer>());
                }
            }
            catch (System.Exception)
            {
                return View(new List<Customer>());
            }
        }
        public async Task<IActionResult> CustomerHome(int id)
        {
            try
            {
                // var ReducePackage = await customerService.ReduceDietPackage(id);

                //get Customer
                var result = await customerService.GetCustomerForCustomerHome(id);
                //get Category
                var resultProduct = await productService.GetAll();
                if (resultProduct.oprationResult == OprationResult.ok)
                {
                    ViewBag.Diet = resultProduct.values.Where(i => i.CategoryId == 1).ToList();
                    ViewBag.Pilates = resultProduct.values.Where(i => i.CategoryId == 2).ToList();
                }
                else
                {
                    //hata yazılacak
                }

                if (result.oprationResult == OprationResult.ok)
                {
                    return View(result.value);
                }
                //Hata Yazılacak
                return View(new Customer());

            }
            catch (System.Exception)
            {
                return View(new Customer());
            }

        }
        public async Task<IActionResult> CustomerDiet(int customerId)
        {
            try
            {
                var result = await customerService.GetCustomerForCustomerHome(customerId);
                if (result.oprationResult == OprationResult.ok)
                {
                    if (result.value != null)
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
                        var TakeRecipe = await recipeService.GetAll();
                        if (TakeRecipe.oprationResult == OprationResult.ok)
                        {
                            ViewBag.AllRecipe = TakeRecipe.values;
                        }
                    }
                    return View(result.value);
                }

                return View(new Customer());
            }
            catch (System.Exception)
            {
                return View(new Customer());
            }
        }
        public async Task<IActionResult> CustomerPilates(int customerId)
        {
            try
            {
                var result = await customerService.GetCustomerForCustomerHome(customerId);
                if (result.oprationResult == OprationResult.ok)
                {
                    return View(result.value);
                }
                return View(new Customer());
            }
            catch (System.Exception)
            {
                return View(new Customer());
            }
        }
        public async Task<IActionResult> CustomerWeek(int id)
        {
            try
            {
                var result = await dietWekklyService.GetByIDWithDietMenü(id);
                return View(result.value);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public async Task<IActionResult> CustomerPilatesWeek(int id)
        {
            try
            {
                var result = await PilatesWeekService.GetWithIncludeOthers(id);
                return View(result.value);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        #endregion


        #region  PackageDefine
        [HttpPost]
        public async Task<IActionResult> UpdateMyCart(MyCart myCart)
        {
            try
            {
                var result = await myCartService.UpdateAsync(myCart);
                if (result != OprationResult.ok)
                {
                    //hata yazılacak
                }
                return Redirect("~/admin/CustomerHome/" + myCart.CustomerId);
            }
            catch (System.Exception)
            {
                return Redirect("~/admin/CustomerHome/" + myCart.CustomerId);

            }
        }

        [HttpPost]
        public async Task<IActionResult> SellDiet(MyCart myCart, string deneme)
        {

            try
            {
                //mycart Create
                if (deneme != null)
                {
                    myCart.IsPaid = true;
                }
                myCart.Time = DateTime.Now;
                var resultCart = await myCartService.CreateAsync(myCart);

                //CreateDiet Weekly
                if (resultCart == OprationResult.ok)
                {

                    DietWekkly D;
                    var result = await customerService.GetCustomerByIdWithDiet(myCart.CustomerId);
                    if (result.oprationResult != OprationResult.ok)
                    {
                        //hata yazılacak
                    }
                    if (result.value.Diet != null)
                    {
                        for (var y = 0; y < 4; y++)
                        {
                            D = new DietWekkly()
                            {
                                Name = $"{result.value.Diet.DietWekklies.Count + y + 1}. Hafta",
                                Active = false,
                                DietId = result.value.Diet.Id
                            };
                            var resultDietWeekly = await dietWekklyService.CreateAsync(D);
                            if (resultDietWeekly != OprationResult.ok)
                            {
                                //Hata Yazılacak
                            }
                        }
                    }
                }
                return Redirect("/Admin/CustomerHome/" + myCart.CustomerId);
            }
            catch (System.Exception)
            {

                throw;
            }

        }
        [HttpPost]
        public async Task<IActionResult> SellPilates(MyCart myCart, string deneme)
        {

            try
            {
                //mycart Create
                if (deneme != null)
                {
                    myCart.IsPaid = true;
                }
                myCart.Time = DateTime.Now;
                var resultCart = await myCartService.CreateAsync(myCart);

                //CreateDiet Weekly
                if (resultCart == OprationResult.ok)
                {

                    PilatesWeek P;
                    var result = await customerService.GetCustomerByIdWithDiet(myCart.CustomerId);
                    if (result.oprationResult != OprationResult.ok)
                    {
                        //hata yazılacak
                    }
                    if (result.value.Pilates != null)
                    {
                        for (var y = 0; y < 8; y++)
                        {
                            P = new PilatesWeek()
                            {
                                Name = $"{result.value.Pilates.PilatesWeeks.Count + y + 1}. Ders",
                                PilatesId = result.value.Pilates.Id
                            };
                            var resultCreateWeek = await PilatesWeekService.CreateAsync(P);
                            if (resultCreateWeek != OprationResult.ok)
                            {
                                //Hata Yazılacak
                            }
                        }
                    }
                }
                return Redirect("/Admin/CustomerHome/" + myCart.CustomerId);
            }
            catch (System.Exception)
            {

                throw;
            }

        }


        [HttpPost]

        public async Task<IActionResult> RegisterDiet(int CustomerId)
        {
            try
            {
                var result = await customerService.InitilazeDiet(CustomerId);
                if (result != OprationResult.ok)
                {
                    // hata yazılacak
                }
                return Redirect("~/Admin/CustomerHome/" + CustomerId);
            }
            catch (System.Exception)
            {
                return NotFound();
            }
        }
        [HttpPost]
        public async Task<IActionResult> RegisterPilates(int CustomerId)
        {
            try
            {
                var result = await customerService.InitilazePilates(CustomerId);
                if (result != OprationResult.ok)
                {
                    // hata yazılacak
                }
                return Redirect("~/Admin/CustomerHome/" + CustomerId);
            }
            catch (System.Exception)
            {
                return NotFound();
            }
        }


        #endregion
        #region UpdateCustomer
        public async Task<IActionResult> UpdateCustomer(Customer c, string btnradio)
        {
            try
            {
                if (btnradio != null)
                {
                    if (btnradio == "1")
                    {
                        c.Gender = true;
                    }
                    else
                    {
                        c.Gender = false;
                    }
                }
                var result = await customerService.UpdateAsync(c);
                if (result != OprationResult.ok)
                {
                    //Hata Yazılacak
                }
                return Redirect("~/Admin/CustomerHome/" + c.Id);
            }
            catch (System.Exception)
            {
                return Redirect("~/Admin/CustomerHome/" + c.Id);
            }
        }
        public async Task<IActionResult> UpdateDietActive(int Id, int DietId, string ForCheckedDiet)
        {
            try
            {
                var dietResult = await dietService.GetByIdAsync(DietId);
                if (dietResult.oprationResult != OprationResult.ok)
                {
                    //hata
                    return Redirect("~/Admin/CustomerHome/" + Id);
                }
                if (dietResult.value != null)
                {
                    if (ForCheckedDiet != null)
                    {
                        dietResult.value.Active = true;
                    }
                    else
                    {
                        dietResult.value.Active = false;
                    }
                    var SaveResult = await dietService.UpdateAsync(dietResult.value);
                    if (SaveResult != OprationResult.ok)
                    {
                        //hata
                    }
                }
                return Redirect("~/Admin/CustomerHome/" +Id);
            }
            catch (System.Exception)
            {
                 return Redirect("~/Admin/CustomerHome/" + Id);
            }
        }
        public async Task<IActionResult> UpdatePilatesActive(int Id, int PilatesId, string ForCheckedPilates)
        {
            try
            {
                var pilatesResult = await pilatesService.GetByIdAsync(PilatesId);
                if (pilatesResult.oprationResult != OprationResult.ok)
                {
                    //hata
                    return Redirect("~/Admin/CustomerHome/" + Id);
                }
                if (pilatesResult.value != null)
                {
                    if (ForCheckedPilates != null)
                    {
                        pilatesResult.value.Active = true;
                    }
                    else
                    {
                        pilatesResult.value.Active = false;
                    }
                    var SaveResult = await pilatesService.UpdateAsync(pilatesResult.value);
                    if (SaveResult != OprationResult.ok)
                    {
                        //hata
                    }
                }
                return Redirect("~/Admin/CustomerHome/" +Id);
            }
            catch (System.Exception)
            {
                 return Redirect("~/Admin/CustomerHome/" + Id);
            }
        }
        #endregion

        #region Recipe And General Mesaj Request
        public async Task<IActionResult> DeletePackageRequest(int id)
        {
            try
            {
                var result = await packageService.GetByIdAsync(id);
                if (result.value != null)
                {
                    var resultDelete = await packageService.DeleteAsync(result.value);
                }
                //hata yazılacak
                return RedirectToAction("Home");
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        [HttpPost]
        public async Task<IActionResult> GeneralMesaj(GeneralMesaj mesaj, int TypeOfAlert, string deneme)
        {
            try
            {
                List<string> Alert = new List<string>()
                {
                    "alert-primary",
                    "alert-secondary",
                    "alert-success",
                    "alert-danger",
                    "alert-warning",
                    "alert-info",
                    "alert-light",
                    "alert-dark"
                };
                mesaj.AlertType = Alert[TypeOfAlert];
                if (deneme != null)
                {
                    mesaj.href = true;
                }
                else
                {
                    mesaj.href = false;
                }
                mesaj.Time = DateTime.Now.ToShortDateString();
                var result = await generalMsjService.CreateAsync(mesaj);
                if (result != OprationResult.ok)
                {
                    //hata yazılacak
                }
                return RedirectToAction("home");
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<IActionResult> RemoveGeneralMesaj(int id)
        {
            try
            {
                GeneralMesaj m = new GeneralMesaj()
                {
                    Id = id
                };
                var result = await generalMsjService.DeleteAsync(m);
                if (result == OprationResult.ok)
                {
                    // buraya mesaj girilecek
                }
                return RedirectToAction("Home");
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<IActionResult> CreateRecipe(Recipe recipe)
        {
            try
            {
                var result = await recipeService.CreateAsync(recipe);
                if (result == OprationResult.ok)
                {
                    // buraya mesaj girilecek
                }
                return RedirectToAction("Home");
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        #endregion



        [HttpPost]
        public IActionResult AddPackage(MyCart m)
        {
            return Redirect("~/admin/CustomerHome/" + m.CustomerId);
        }

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
            if (result.oprationResult != OprationResult.ok)
            {
                //hata yazılacak
            }
            if (result.value.Diet != null)
            {
                for (var y = 0; y < 4; y++)
                {
                    D = new DietWekkly()
                    {
                        Name = $"{result.value.Diet.DietWekklies.Count + y + 1} Hafta",
                        Active = false,
                        DietId = result.value.Diet.Id
                    };
                    await dietWekklyService.CreateAsync(D);
                }
            }
            return Redirect("/Admin/CustomerHome/" + id);
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

        #region  DietSendAndChangeDelete

        [HttpGet]
        public async Task<IActionResult> DietSendAndChange(int? id)
        {
            try
            {
                var result = await dietWekklyService.GetByIDWithDietMenü((int)id);
                var allRecipe = await recipeService.GetAll();
                ViewBag.Recipe = allRecipe.values;

                return View(result.value);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> DietSendAndChange(DietWekkly model, int[] recipeIds, IFormFile file, int meal, int btnradio = 1)
        {
            try
            {
                if (recipeIds == null)
                {
                    var resultsa = await dietWekklyService.GetByIDWithDietMenü((int)model.DietId);
                    var allRecipe = await recipeService.GetAll();
                    ViewBag.Recipe = allRecipe.values;

                    return View(resultsa.value);
                }



                var d = new DietMenü();
                string name = file.FileName.Replace(" ", "-");
                string randomName = string.Format($"{DateTime.Now.ToShortDateString().Replace("/", "-")}.{name}");
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
                        Path = randomName,
                        DietWekklyId = model.Id,
                        TwoMeals = meal == 1 ? true : false,
                        FullName = model.DietMenü.FullName,
                        Weight = model.DietMenü.Weight,
                        Content = model.DietMenü.Content
                    };
                    //create Diet Menü
                    var resultInıtial = await dietMenüService.InitilazeDietMenü(d, recipeIds);
                    //Week Make Active
                    var weekResult = await dietWekklyService.MakeActive(model.Id);
                    //UpdateRemaningPackage
                    // var ReducePackage = await customerService.ReduceDietPackage(model.Diet.CustomerId);

                }
                else
                {
                    d = new DietMenü()
                    {
                        Id = model.DietMenü.Id,
                        Gender = btnradio == 1 ? true : false,
                        Path = randomName,
                        DietWekklyId = model.Id,
                        TwoMeals = meal == 1 ? true : false,
                        FullName = model.DietMenü.FullName,
                        Weight = model.DietMenü.Weight,
                        Content = model.DietMenü.Content
                    };
                    //update Diet Menü
                    var reeult = await dietMenüService.UpdateDietmenü(d, recipeIds);
                    //Week Make Active
                    var weekResult = await dietWekklyService.MakeActive(model.Id);
                    //UpdateRemaningPackage
                    // var ReducePackage = await customerService.ReduceDietPackage(model.Diet.CustomerId);
                }
                // update combine diet and recipe
                var results = await dietService.UpdateJustRecipe(model.Diet.Id, recipeIds);

                await emailSender.SendEmailAsync($"{model.Diet.Customer.Mail}", "Haftalık Diyetiniz", $"{model.DietMenü.Content}", attachment);
                return Redirect("/Admin/CustomerWeek/" + model.Id);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        #endregion
        public IActionResult Deneme()
        {
            return View();
        }
        public IActionResult Denemeiki()
        {
            return View();
        }
        public IActionResult Denemeüc()
        {
            return View();
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

        #region  MakeDate
        [HttpPost]
        public async Task<IActionResult> MakeDate(int dietWeekId, int durations, int customerId, DateTime TimeofDates, string firstname, string lastname)
        {
            try
            {
                int startingHour = (TimeofDates.Hour * 60) + TimeofDates.Minute;

                int finishedHour = startingHour + durations;
                int day = TimeofDates.Day;
                int month = TimeofDates.Month;
                int year = TimeofDates.Year;
                string Hour = TimeofDates.TimeOfDay.ToString();
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
                    Traning = TraningType.Diet,
                    LastName = lastname
                };
                var result = await calendarService.MakeDate(c);
                if (result == OprationResult.ok)
                {
                    //week ıs done
                    var resultMakeIsDone = await dietWekklyService.makeIsDone(dietWeekId);
                    //week Reduce Remaning Package 
                    var reducePaket = await customerService.ReduceRemaningPackage(customerId);
                }

                return Redirect("~/Admin/CustomerWeek/" + dietWeekId);
            }
            catch (System.Exception)
            {

                throw;
            }

        }
        public async Task<IActionResult> MakePilatesDate(int pilatesWeekId, int customerId, int durations, DateTime TimeofDates, string firstname, string lastname)
        {
            try
            {
                int startingHour = (TimeofDates.Hour * 60) + TimeofDates.Minute;

                int finishedHour = startingHour + durations;
                int day = TimeofDates.Day;
                int month = TimeofDates.Month;
                int year = TimeofDates.Year;
                string Hour = TimeofDates.TimeOfDay.ToString();

                Calendar c = new Calendar()
                {
                    StartingHour = startingHour,
                    FinishedHour = finishedHour,
                    CurrentDay = day,
                    CurrentMounth = month,
                    CurrentYear = year,
                    Active = true,
                    CurrentHour = Hour,
                    PilatesWeekId = pilatesWeekId,
                    FirstName = firstname,
                    Traning = TraningType.Pilates,
                    LastName = lastname
                };
                var result = await calendarService.MakeDate(c);
                if (result == OprationResult.ok)
                {
                    //week ıs done
                    var resultMakeIsDone = await PilatesWeekService.makeIsDone(pilatesWeekId);
                    //week Reduce Remaning Package 
                    var reducePaket = await customerService.ReduceRemaningPackage(customerId);
                }
                return Redirect("~/Admin/CustomerPilatesWeek/" + pilatesWeekId);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public async Task<IActionResult> RemoveDatePilates(int customerId, int pilatesWeekId, int DateId)
        {
            try
            {
                var DateResult = await calendarService.GetByIdAsync(DateId);
                if (DateResult.value != null)
                {
                    var result = await calendarService.DeleteAsync(DateResult.value);
                    if (result == OprationResult.ok)
                    {
                        //week ıs done
                        var resultNotDone = await PilatesWeekService.makeNotDone(pilatesWeekId);
                        //week Reduce Remaning Package 
                        var reducePaket = await customerService.ReduceRemaningPackage(customerId);
                    }

                }
                return Redirect("~/Admin/CustomerPilatesWeek/" + pilatesWeekId);

            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public async Task<IActionResult> RemoveDateDiet(int customerId, int dietWeekId, int DateId)
        {
            try
            {
                var DateResult = await calendarService.GetByIdAsync(DateId);
                if (DateResult.value != null)
                {
                    var result = await calendarService.DeleteAsync(DateResult.value);
                    if (result == OprationResult.ok)
                    {
                        //week ıs done
                        var resultNotDone = await dietWekklyService.makeNotDone(dietWeekId);
                        //week Reduce Remaning Package 
                        var reducePaket = await customerService.ReduceRemaningPackage(customerId);
                    }
                }
                return Redirect("~/Admin/CustomerWeek/" + dietWeekId);

            }
            catch (System.Exception)
            {
                throw;
            }
        }


        [HttpPost]
        public async Task<IActionResult> UpdateDate(int customerId, int dietWeekId, int DateId, int durations, DateTime TimeofDates, string firstname, string lastname)
        {
            try
            {
                int startingHour = (TimeofDates.Hour * 60) + TimeofDates.Minute;

                int finishedHour = startingHour + durations;
                int day = TimeofDates.Day;
                int month = TimeofDates.Month;
                int year = TimeofDates.Year;
                string Hour = TimeofDates.TimeOfDay.ToString();

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
                    Traning = TraningType.Diet,
                    LastName = lastname
                };
                var result = await calendarService.UpdateAsync(c);
                if (result == OprationResult.ok)
                {
                    //week ıs done
                    var resultMakeIsDone = await dietWekklyService.makeIsDone(dietWeekId);
                    //week Reduce Remaning Package 
                    var reducePaket = await customerService.ReduceRemaningPackage(customerId);
                }
                return Redirect("~/Admin/CustomerWeek/" + dietWeekId);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public async Task<IActionResult> UpdatePilatesDate(int customerId, int pilatesWeekId, int DateId, int durations, DateTime TimeofDates, string firstname, string lastname)
        {
            try
            {
                int startingHour = (TimeofDates.Hour * 60) + TimeofDates.Minute;

                int finishedHour = startingHour + durations;
                int day = TimeofDates.Day;
                int month = TimeofDates.Month;
                int year = TimeofDates.Year;
                string Hour = TimeofDates.TimeOfDay.ToString();

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
                    PilatesWeekId = pilatesWeekId,
                    FirstName = firstname,
                    Traning = TraningType.Pilates,
                    LastName = lastname
                };
                var result = await calendarService.UpdateAsync(c);
                if (result == OprationResult.ok)
                {
                    //week ıs done
                    var resultMakeIsDone = await PilatesWeekService.makeIsDone(pilatesWeekId);
                    //week Reduce Remaning Package 
                    var reducePaket = await customerService.ReduceRemaningPackage(customerId);
                }
                return Redirect("~/Admin/CustomerPilatesWeek/" + pilatesWeekId);
            }
            catch (System.Exception)
            {

                throw;
            }
        }


        public async Task<IActionResult> RemoveDateRequest(int id)
        {
            try
            {
                DateRequest date = new DateRequest
                {
                    Id = id
                };
                var reuslt = await dateRequestService.DeleteAsync(date);
                return RedirectToAction("Home");
            }
            catch (System.Exception)
            {
                return RedirectToAction("Home");
            }
        }
        #endregion
    }
}