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


        //public IActionResult Index()
        //{
        //    return View();
        //}

        //page employees can VIEW clients

        public IActionResult AdminView()
        {
            var displaydata = _db.ClientInfo.ToList();
            return View(displaydata);
        }

        
        //individual client page where Admin can EDIT status "done" or "not done" //
        public IActionResult AdminClientSingleView()
        {
            return View();
        }


        //create page(i.e clients putting in info)//
        public IActionResult NewClientPage()
        {
            return View();
        }

        
        [HttpPost]
        public async Task<IActionResult> NewClientPage(Client newClient)
        {
            if (ModelState.IsValid)
            {
                _db.Add(newClient);
                await _db.SaveChangesAsync();
                return RedirectToAction("ClientFinal");
            }
            return View(newClient);

        }

        public IActionResult ClientFinal()
        {
            return View();
        }

    }
}

 