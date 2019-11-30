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
    public class CustomerController : Controller
    {
        private readonly ICustomer _context;

        public CustomerController(ICustomer context)
        {
            _context = context;
        }

        // GET: Customer
        public IActionResult Index()
        {
            return View(_context.GetCustomers);
        }

        // GET: Product/Details/5
        public IActionResult Details(int? id)
        {
            return View(_context.GetCustomer(id));
        }

        // GET: Product/Create
        [HttpGet]
        public IActionResult Create()
        {
            Customer model = new Customer();
            model.IdCustomer = 0;
            return View(model);
        }

        // POST: Product/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: Product/Edit/5
        public IActionResult Edit(int? id)
        {
            var model = _context.GetCustomer(id);
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
                Customer model = _context.GetCustomer(id);
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
