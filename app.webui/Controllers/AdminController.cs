using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using app.business.Abstract;
using app.entity;
using app.webui.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace app.webui.Controllers
{
    public class AdminController : Controller
    {
        public ICustomerService customerService;
        public IDietWekklyService dietWekklyService;
        public AdminController(ICustomerService _customerService, IDietWekklyService _dietWekklyService)
        {
            customerService = _customerService;
            dietWekklyService = _dietWekklyService;
        }

        public IActionResult Deneme()
        {
            return View();
        }

        public async Task<IActionResult> Index()
        {
            var returned = await customerService.GetAll();

            return View(returned.values);
        }

        public async Task<IActionResult> Diet(int id)
        {
            System.Console.WriteLine(id + "Controller");
            var result = await customerService.GetCustomerByIdWithDiet(id);

            List<MenüModel> MenüList = new List<MenüModel>();
            ModelHelper.MenüCreate(result.value.Menü, MenüList);
            ViewBag.Menü = MenüList;
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
            var returned = await dietWekklyService.GetByIdAsync(model.Id);

            returned.value.Menü = name;
            returned.value.Active = true;
            await dietWekklyService.UpdateAsync(returned.value);
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
                    Name = $"{result.value.Diet.DietWekklies.Count + 1} Hafta",
                    DietId = result.value.Diet.Id
                };
                await dietWekklyService.CreateAsync(D);
            }
            return Redirect("/admin/diet/" + id);
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
    }
}