using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using app.business.Abstract;
using app.webui.Identity;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Vonage;
using Vonage.Request;

namespace app.webui.Controllers
{
    //Todo:navbar indexi css yüklenecek
    //? DatabaseGüncellemesini unutma daha sonradan takvim yapıalcak
    public class HomeController : Controller
    {
        // public List<string> GoogleEvents = new List<string>();
        // static string[] Scopes = { CalendarService.Scope.Calendar };
        // static string ApplicationName = "Google Calendar API .NET Quickstart";


        UserManager<User> userManager;
        ICustomerService customerService;
        IPackageRequestService packageRequestService;

        public HomeController(IPackageRequestService _packageRequestService, ICustomerService _customerService, UserManager<User> _userManager)
        {
            packageRequestService = _packageRequestService;
            userManager = _userManager;
            customerService = _customerService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Package()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = await userManager.FindByNameAsync(User.Identity.Name);
                if (User != null)
                {
                    var customerResult = await customerService.GetCustomerByUserId(user.Id);
                    if (customerResult.oprationResult == OprationResult.ok)
                    {
                        if (customerResult.value != null)
                        {
                            var resultRequest = await packageRequestService.GetByCustomerId(customerResult.value.Id);
                            if (resultRequest.oprationResult == OprationResult.ok)
                            {
                                ViewBag.AllRequest = resultRequest.values;
                            }
                        }
                        return View(customerResult.value);
                    }
                }
            }
            return View();
        }
        // public IActionResult Message()
        // {
        //     var credentials = Credentials.FromApiKeyAndSecret(
        //     "6bd93473",
        //     "WSD6SzyAD8BUe2ab"
        //     );

        //     var VonageClient = new VonageClient(credentials);

        //     var response = VonageClient.SmsClient.SendAnSms(new Vonage.Messaging.SendSmsRequest()
        //     {
        //         To = "905068824961",
        //         From = "DytSinemKaraca",
        //         Text = "A text message sent using the Vonage SMS API"
        //     });
        //     return View();
        // }


        // [Obsolete]
        // public IActionResult Try()
        // {

        //     CalendarEventsss();
        //     ViewBag.Eventlist = GoogleEvents;
        //     return View();
        // }

        // [Obsolete]
        // public void CalendarEventsss()
        // {
        //     UserCredential credential;
        //     using (var stream =
        //         new FileStream("credentials.json", FileMode.Open, FileAccess.ReadWrite))
        //     {
        //         // The file token.json stores the user's access and refresh tokens, and is created
        //         // automatically when the authorization flow completes for the first time.
        //         string credPath = "token.json";
        //         credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
        //             GoogleClientSecrets.Load(stream).Secrets,
        //             Scopes,
        //             "user",
        //             CancellationToken.None,
        //             new FileDataStore(credPath, true)).Result;
        //     }

        //     // Create Google Calendar API service.
        //     var service = new CalendarService(new BaseClientService.Initializer()
        //     {
        //         HttpClientInitializer = credential,
        //         ApplicationName = ApplicationName,

        //     });


        //     // EventsResource.InsertRequest request1 = service.Events.Insert(new Event
        //     // {
        //     //     Summary = "My event Summary",
        //     //     Description = "my event desciription",
        //     //     Location="Turkey",
        //     //     Start = new EventDateTime
        //     //     {
        //     //         DateTime = DateTime.Now.AddHours(2)
        //     //     },
        //     //     End = new EventDateTime
        //     //     {
        //     //         DateTime = DateTime.Now.AddHours(3)
        //     //     },


        //     // },"muammer03karaca@gmail.com");

        //     // Event aaa =request1.Execute();


        //     // Define parameters of request.
        //     EventsResource.ListRequest request = service.Events.List("primary");
        //     request.TimeMin = DateTime.Now;
        //     request.ShowDeleted = false;
        //     request.SingleEvents = true;
        //     request.MaxResults = 10;
        //     request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

        //     // List events.
        //     Events events = request.Execute();
        //     Console.WriteLine("Upcoming events:");
        //     if (events.Items != null && events.Items.Count > 0)
        //     {
        //         foreach (var eventItem in events.Items)
        //         {
        //             GoogleEvents.Add(eventItem.Summary);
        //         }
        //     }

        // }
    }
}