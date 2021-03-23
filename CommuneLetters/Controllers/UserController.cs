using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CommuneLetters.Models;

namespace CommuneLetters.Controllers
{
    public class UserController : Controller
    {
        [HttpPost]
        public IActionResult AdminView() => View();

        [HttpGet]
        public IActionResult PersonInfo() => View();

        [HttpGet]
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
