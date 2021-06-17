using System;
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
using app.webui.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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

            //Identity
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(configuration.GetConnectionString("MsSqlConnection")));
            //
            services.AddDbContext<data.AppContext>(options => options.UseSqlServer(configuration.GetConnectionString("MsSqlConnection")));

            //RegisterSetting
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(options =>
            {
                //password
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
                //lockout
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = true;

                //User
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromDays(1);
                options.Cookie = new CookieBuilder()
                {
                    HttpOnly = true,
                    Name = "Diyet",
                    SameSite = SameSiteMode.Strict
                };
            });
            //UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            //Customer
            services.AddScoped<ICustomerService, CustomerManager>();
            //Diet
            services.AddScoped<IDietService, DietManager>();
            //AnamnezForm
            services.AddScoped<IAnamnezFormService, AnamnezManager>();
            //DietWeekly
            services.AddScoped<IDietWekklyService, DietWekklyManager>();
            //DietMenü
            services.AddScoped<IDietMenüService, DietMenüManager>();
            //Recipe
            services.AddScoped<IRecipeService, RecipeManager>();
            //Pilates
            services.AddScoped<IPilatesService, PilatesManager>();
            //Calander
            services.AddScoped<ICalendarService, CalendarManager>();
            //Package
            services.AddScoped<IPackageRequestService, PackageRequestManager>();
            //General Mesaj
            services.AddScoped<IGeneralMsjService,GeneralMsjManager>();
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
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IConfiguration configuration, UserManager<User> userManager, RoleManager<IdentityRole> role)
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
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //CustomerOnlineWeek
                endpoints.MapControllerRoute(
                  name: "Diyet Listesi Görüntüle",
                  pattern: "/online/HaftalıkDiyet/{id}",
                  defaults: new { controller = "Online", action = "DietWekklys" }
              );
                //admin
                endpoints.MapControllerRoute(
                    name: "Diyet Listesi Görüntüle",
                    pattern: "/admin/diyet/{id}",
                    defaults: new { controller = "Admin", action = "Diet" }
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
