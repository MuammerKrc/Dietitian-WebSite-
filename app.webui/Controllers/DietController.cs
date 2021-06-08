using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using app.business.Abstract;
using app.entity;
using app.webui.EmailService;
using app.webui.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
        public DietController(ICustomerService _customerService, IRecipeService _recipeService, IDietWekklyService _dietWekklyService, IEmailSender _emailSender, IAnamnezFormService _anamnezFormService, IDietService _dietService)
        {
            anamnezFormService = _anamnezFormService;
            dietWekklyService = _dietWekklyService;
            customerService = _customerService;
            recipeService = _recipeService;
            emailSender = _emailSender;
            dietService = _dietService;
        }
        public async Task<IActionResult> Index(int? id)
        {
            try
            {

                var result = await customerService.GetCustomerByIdWithDiet((int)id);
                if (!(result.oprationResult == OprationResult.canceled))
                {
                    result.value.Diet.CombineDietRecipes = result.value.Diet.CombineDietRecipes ?? new List<entity.CombineDietRecipe>();
                    result.value.Diet.AnamnezForm = result.value.Diet.AnamnezForm ?? new AnamnezForm();
                    var allRecipe = await recipeService.GetAll();
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

            var result = await dietService.UpdateOrCreateAnamnezForm(Id);
            ViewBag.otherId = result.value.Id;
            return View(result.value.AnamnezForm);

        }
        [HttpPost]
        public async Task<IActionResult> AnamnezForm(AnamnezForm model, int otherId)
        {
            var result = await anamnezFormService.UpdateAsync(model);
            return Redirect("/Diet/Index/" + otherId);
        }
    }
}