using Final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class HomeController : Controller
    {

        private IEntertainersRepository repo { get; set; }

        public HomeController(IEntertainersRepository Ent)
        {
            repo = Ent;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddEnt()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEnt(Entertainers ent)
        {
            repo.EntAdd(ent);
            //EntContext.SaveChanges();
            return RedirectToAction("EntClub", ent);
        }

        public IActionResult Entclub()
        {
            var fred = repo.Entertainers
                .ToList();

            return View(fred);
        }

        public IActionResult EntDeets(int Id)
        {
            var entId = repo.Entertainers.Single(x => x.EntertainerId == Id);

            return View(entId);
        }

        [HttpGet]
        public IActionResult EntEdit(int Id)
        {
            var entId = repo.Entertainers.Single(x => x.EntertainerId == Id);

            return View(entId);
        }

        [HttpPost]
        public IActionResult EntEdit(Entertainers ent)
        {
                repo.EditEnt(ent);
                return RedirectToAction("EntClub");
            
        }

        [HttpGet]
        public IActionResult EntDelete(int Id)
        {
            var entId = repo.Entertainers.Single(x => x.EntertainerId == Id);

            return View(entId);
        }

        [HttpPost]
        public IActionResult EntDelete(Entertainers yadda)
        {
            repo.DeleteEnt(yadda);
            return RedirectToAction("EntClub");
        }

    }
}
