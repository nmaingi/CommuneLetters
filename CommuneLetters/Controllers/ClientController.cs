using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CommuneLetters.Models;
using Microsoft.EntityFrameworkCore;

namespace CommuneLetters.Controllers
{
    public class ClientController : Controller
    {
        private readonly ClientDBContext _cdb;

        public ClientController(ClientDBContext cdb)
        {
            _cdb = cdb;
        }
        
        public IActionResult CIndex()
        {
            var clientlist = _cdb.ClientInfo.ToList();
            return View(clientlist);
        }

        
        public IActionResult AddClient()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddClient(Client newClient)
        {
            if (ModelState.IsValid)
            {
                _cdb.Add(newClient);
                await _cdb.SaveChangesAsync();
                return RedirectToAction("CheckoutApi","Create");
            }
            return View(newClient);
        }

        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null)
            {
                return RedirectToAction("CIndex");
            }

            var clientdetails = await _cdb.ClientInfo.FindAsync(id);
            return View(clientdetails);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(Client currentClient)
        {
            if (ModelState.IsValid)
            {
                _cdb.Update(currentClient);
                await _cdb.SaveChangesAsync();
                return RedirectToAction("CIndex");

            }
            return View(currentClient);
        }

        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return RedirectToAction("CIndex");
            }

            var clientdetails = await _cdb.ClientInfo.FindAsync(id);
            return View(clientdetails);

        }

        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)

        { 
            var clientdetails = await _cdb.ClientInfo.FindAsync(id);
            _cdb.ClientInfo.Remove(clientdetails);
            await _cdb.SaveChangesAsync();

            return RedirectToAction("CIndex");

        }

        public IActionResult Payment()
        {
            return View();
        }


    }
}