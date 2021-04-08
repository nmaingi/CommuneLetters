using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CommuneLetters.Models;
using Microsoft.EntityFrameworkCore;

namespace CommuneLetters.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDBContext _db;
        public UserController(ApplicationDBContext db)
        {
            _db = db;
        }

        //index page//
        [HttpGet]
        public IActionResult StartPage()
        {
            return View();
        }

        //page employees can see clients
        [HttpPost]
        public IActionResult AdminView()
        {
            var displaydata = _db.ClientInfo.ToList();
            return View(displaydata);
        }

        //page where new clients are created//
        [HttpGet]
        public IActionResult ClientInfo()
        {
            return View();
        }

        //page where payment is made//
        [HttpPost]
        public IActionResult Payment() => View();

        [HttpPost]
        [Route("/PersonInfo")]
        public IActionResult PersonalInfo(string client)
        {
            Repository.NewClient(new Client(client));
            return Redirect("/Payments");     
        }
        
        [HttpPost]
        public IActionResult Remove(string clientname)
        {
            Client client = Repository.AllClients.Where(e => e.Name == clientname).FirstOrDefault();
            Repository.Remove(client);
            return Redirect("PendingClients");
        }
             
        
        [HttpGet]
        public IActionResult FinalPage() => View();

        [HttpGet]
        public IActionResult FAQs() => View();
    }
}
