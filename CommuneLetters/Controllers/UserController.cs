using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CommuneLetters.Controllers
{
    public class UserController : Controller
    {
        //add feature to create new clients//
        [HttpGet]
        public IActionResult PersonInfo() => View();

        [HttpGet]
        public IActionResult Payment() => View();

        [HttpGet]
        public IActionResult FAQs() => View();
    }
}
