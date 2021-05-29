using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using app.business.Abstract;
using app.entity;
using app.webui.EmailService;
using app.webui.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace app.webui.Controllers
{
    public class DietController : Controller
    {
        ICustomerService customerService;
        IRecipeService recipeService;
        IDietWekklyService dietWekklyService;
        IEmailSender emailSender;
        public DietController(ICustomerService _customerService, IRecipeService _recipeService,IDietWekklyService _dietWekklyService)
        {
            dietWekklyService=_dietWekklyService;
            customerService = _customerService;
            recipeService = _recipeService;
        }
        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            System.Console.WriteLine(id + "Controller");

            var result = await customerService.GetCustomerByIdWithDiet((int)id);
            var allRecipe = await recipeService.GetAll();
            result.value.Diet.CombineDietRecipes = result.value.Diet.CombineDietRecipes ?? new List<entity.CombineDietRecipe>();
            System.Console.WriteLine(result.value.Diet.Id + " " + "Id bilgisi");
            System.Console.WriteLine(result.value.Diet.DietWekklies.Count + " " + "asd");
            System.Console.WriteLine(result.value.Diet.CombineDietRecipes.Count + " " + "asd");

            System.Console.WriteLine(allRecipe.values.Count);
            ViewBag.Recipe = allRecipe.values;
            return View(result.value);
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

    }
}