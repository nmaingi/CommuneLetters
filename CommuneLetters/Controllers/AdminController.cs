using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CommuneLetters.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CommuneLetters.Controllers
{
    public class AdminController : Controller
    {
        private readonly AdminDBContext _adb;
        private readonly SignInManager<AdminstratorUser> signInManger;

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

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Adminstrator adminstrator)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManger.PasswordSignInAsync(adminstrator.Username, adminstrator.Password,false,false);
                
                if (result.Succeeded)
                {
                    return RedirectToAction("Profile");
                }
                
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }
            return View(adminstrator);
        }

        public IActionResult Profile()
        {
            return View();
        }




    }

    internal class AdminstratorUser
    {
    }
}

 