﻿using System;
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
    public class BasketItemController : Controller
    {
        private readonly IBasketItem _context;

        public BasketItemController(IBasketItem context)
        {
            _context = context;
        }

        // GET: BasketItem
        public IActionResult Index()
        {
            return View(_context.GetBasketItems);
        }

        // GET: Product/Details/5
        public IActionResult Details(int? id)
        {
            return View(_context.GetBasketItem(id));
        }

        // GET: Product/Create
        [HttpGet]
        public IActionResult Create()
        {
            BasketItem model = new BasketItem();
            model.IdBasketItem = 0;
            return View(model);
        }

        // POST: Product/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 

        [HttpPost]
        public IActionResult Create(BasketItem basketItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(basketItem);
                return RedirectToAction("Index");
            }
            return View(basketItem);
        }

        // GET: Product/Edit/5
        public IActionResult Edit(int? id)
        {
            var model = _context.GetBasketItem(id);
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
                BasketItem model = _context.GetBasketItem(id);
                return View(model);
            }


        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _context.Remove(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
