using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CommuneLetters.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

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

        public IActionResult Login()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Login(string id)
        {     
            if (id == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid, try again");
            }

            var admindetails = _adb.AdminInfo.FindAsync(id);
            return View(admindetails);

        }


        public IActionResult Profile()
        {
            return RedirectToAction("CIndex", "Client");
        }



        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null)
            {
                return RedirectToAction("AIndex");
            }

            var admindetails = await _adb.AdminInfo.FindAsync(id);
            return View(admindetails);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(Adminstrator currentAdmin)
        {
            if (ModelState.IsValid)
            {
                _adb.Update(currentAdmin);
                await _adb.SaveChangesAsync();
                return RedirectToAction("AIndex");

            }
            return View(currentAdmin);
        }

        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return RedirectToAction("AIndex");
            }

            var admindetails = await _adb.AdminInfo.FindAsync(id);
            return View(admindetails);

        }

        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)

        {
            var admindetails = await _adb.AdminInfo.FindAsync(id);
            _adb.AdminInfo.Remove(admindetails);
            await _adb.SaveChangesAsync();

            return RedirectToAction("AIndex");

        }




    }


}

 