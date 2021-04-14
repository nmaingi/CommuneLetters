using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CommuneLetters.Models;
using Microsoft.EntityFrameworkCore;

namespace CommuneLetters.Controllers
{
    public class AdminController : Controller
    {
        private readonly AdminDBContext _adb;
       
        public AdminController(AdminDBContext adb)
        {
            _adb = adb;
        }

        public IActionResult AIndex()
        {
            var displaydata = _adb.AdminInfo.ToList();
            return View(displaydata);
        }



        public IActionResult AddAdmin()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddAdmin(Adminstrator newAdmin)
        {
            if (ModelState.IsValid)
            {
                _adb.Add(newAdmin);
                await _adb.SaveChangesAsync();
                return RedirectToAction("AIndex");
            }
            return View(newAdmin);

        }


    }
}

 