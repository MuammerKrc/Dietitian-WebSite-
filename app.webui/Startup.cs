using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using app.business.Abstract;
using app.business.Concret;
using app.data;
using app.data.Abstract;
using app.data.Concret;
using app.webui.EmailService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace app.webui
{
    public class Startup
    {
        public IConfiguration configuration;
        public Startup(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddDbContext<AppContext>(option=>option.UseSq)

            services.AddDbContext<AppContext>(options => options.UseSqlServer(configuration.GetConnectionString("MsSqlConnection")));

            //UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            //Customer
            services.AddScoped<ICustomerService, CustomerManager>();
            //Diet
            services.AddScoped<IDietService,DietManager>();
            //AnamnezForm
            services.AddScoped<IAnamnezFormService,AnamnezManager>();
            //DietWeekly
            services.AddScoped<IDietWekklyService,DietWekklyManager>();
            //DietMenü
            services.AddScoped<IDietMenüService,DietMenüManager>();
            //Recipe
            services.AddScoped<IRecipeService,RecipeManager>();
            //Pilates
            services.AddScoped<IPilatesService,PilatesManager>();
            //Mounth
            services.AddScoped<IMounthService,MounthManager>();
            //Day
            services.AddScoped<IDayService,DayManager>();
            //Hour
            services.AddScoped<IHourService,HourManager>();
          
            
            //email
             services.AddScoped<IEmailSender, SmtpEmailSender>(i =>
             new SmtpEmailSender(
                 configuration["EmailSender:Host"],
                 configuration.GetValue<int>("EmailSender:Port"),
                 configuration.GetValue<bool>("EmailSender:EnableSSL"),
                 configuration["EmailSender:UserName"],
                 configuration["EmailSender:Password"]
                 )
            );
            services.AddControllersWithViews();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), "node_modules/bootstrap/dist")),
                RequestPath = "/modules"
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //admin
                endpoints.MapControllerRoute(
                    name:"Diyet Listesi Görüntüle",
                    pattern:"/admin/diyet/{id}",
                    defaults:new{controller="Admin",action="Diet"}
                );
                //default
                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
