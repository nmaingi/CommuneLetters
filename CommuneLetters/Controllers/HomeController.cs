using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CommuneLetters.Models;
using Stripe.Checkout;
using Stripe;

namespace CommuneLetters.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;



        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [Route("create-checkout")]
        [HttpPost]
        public ActionResult Create()
        { 

            var domain = "http://localhost:57428";
            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string>
                {
                    "card",
                },

                LineItems = new List<SessionLineItemOptions>
                {
                    new SessionLineItemOptions
                    {
                        PriceData = new SessionLineItemPriceDataOptions
                        {
                            UnitAmount = 1100,
                            Currency = "usd",
                            ProductData = new SessionLineItemPriceDataProductDataOptions
                            {
                                Name = "CommuneLetters",
                            },
                        },
                        Quantity = 1,
                    },
                },

                Mode = "payment",
                SuccessUrl = domain + "/Home/Success",
                CancelUrl = domain + "/Home/Cancel",
            };
            
            var service = new SessionService();
            Session session = service.Create(options);
            return Json(new { id = session.Id });
        }

            public IActionResult Privacy()
            {
                return View();
            }

            public IActionResult Faqs()
            {
                return View();
            }
            public IActionResult Success()
            {
                return View();
            }


            public IActionResult Cancel()
            {
                return View();
            }


            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        
    }
}