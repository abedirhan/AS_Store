using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AS_Store.Models;
using AS_Store.Repository;

namespace AS_Store.Controllers
{
    public class BasketController : Controller
    {
        private readonly IBasket _context;

        public BasketController(IBasket context)
        {
            _context = context;
        }

        // GET: Basket
        public IActionResult Index()
        {
            return View(_context.GetBaskets);
        }

        // GET: Product/Details/5
        public IActionResult Details(int? id)
        {
            return View(_context.GetBasket(id));
        }

        // GET: Product/Create
        [HttpGet]
        public IActionResult Create()
        {
            Basket model = new Basket();
            model.IdBasket = 0;
            return View(model);
        }

        // POST: Product/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 

        [HttpPost]
        public IActionResult Create(Basket basket)
        {
            if (ModelState.IsValid)
            {
                _context.Add(basket);
                return RedirectToAction("Index");
            }
            return View(basket);
        }

        // GET: Product/Edit/5
        public IActionResult Edit(int? id)
        {
            var model = _context.GetBasket(id);
            return View("Create", model);
        }


        // GET: Product/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                Basket model = _context.GetBasket(id);
                return View(model);
            }


        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _context.Remove(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
