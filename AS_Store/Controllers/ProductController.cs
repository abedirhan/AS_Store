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
    public class ProductController : Controller
    {
        private readonly IProduct _context;

        public ProductController(IProduct context)
        {
            _context = context;
        }

        // GET: Product
        public IActionResult Index()
        {
            return View(_context.GetProducts);
        }

        // GET: Product/Details/5
        public IActionResult Details(int? id)
        {
            return View(_context.GetProduct(id));
        }

        // GET: Product/Create
        [HttpGet]
        public IActionResult Create()
        {Product model=new Product();
            model.IdProduct = 0;
            return View(model);
        }

        // POST: Product/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Product/Edit/5
        public IActionResult Edit(int? id)
        {
            var model = _context.GetProduct(id);
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
                Product model = _context.GetProduct(id);
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
