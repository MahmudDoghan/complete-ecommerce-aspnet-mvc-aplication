﻿using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Data.Static;
using eTickets.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class CinemasController : Controller
    {
        private readonly ICinemasService _service;
        public CinemasController(ICinemasService service)
        {
            _service = service;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _service.GetAllAsync();
            return View(allCinemas);
        }

        //Get Cınemas/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create([Bind("Logo,Name,Description")]Cinema cinema)
        {
            if(!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _service.AddAsync(cinema);
            return Redirect(nameof(Index));
        }
        //Get Cınemas/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var cinemadetails = await _service.GetByIdAsync(id);

            if (cinemadetails == null) return View("NotFound");
            return View(cinemadetails);
        }
        //Get Cinemas/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var cinemadetails = await _service.GetByIdAsync(id);
            if (cinemadetails == null) return View("NotFound");
            return View(cinemadetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _service.UpdateAsync(id, cinema);
            return RedirectToAction(nameof(Index));

        }

        //Get: Cinemas/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var cinemadetails = await _service.GetByIdAsync(id);
            if (cinemadetails == null) return View("NotFound");
            return View(cinemadetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cinemadetails = await _service.GetByIdAsync(id);
            if (cinemadetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));

        }
    }
}
