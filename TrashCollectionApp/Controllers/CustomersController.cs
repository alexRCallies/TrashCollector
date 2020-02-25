using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollectionApp.Data;
using TrashCollectionApp.Models;

namespace TrashCollectionApp.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public CustomersController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Details1(Customer customer)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer1 = _context.customers.Where(x => x.IdentityUserId == userId).FirstOrDefault();
            return View(customer1);
        }
            public IActionResult Details(Customer customer)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer2 = _context.customers.Where(x => x.IdentityUserId == userId).FirstOrDefault();
                return View(customer2);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create( Customer customer, IdentityUser user)
        {
            if (ModelState.IsValid)
            {
                var IdentityUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                customer.IdentityUserId = IdentityUserId;
                customer.Balance = 7;
                _context.Add(customer);
                _context.SaveChanges();
               
                return RedirectToAction(nameof(Details));
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public IActionResult Edit(int id)
        {
            var customer = _context.customers.Find(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Customer customer)
        {
            try
            {
                var IdentityUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                customer.IdentityUserId = IdentityUserId;
                _context.customers.Update(customer);
                _context.SaveChanges();

                return RedirectToAction(nameof(Details));
            }
            catch
            {
                return View();
            }
        }
        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.customers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.customers.FindAsync(id);
            _context.customers.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Details));
        }

        private bool CustomerExists(int id)
        {
            return _context.customers.Any(e => e.Id == id);
        }
        public async Task<IActionResult> Change_Pickup_Day(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Change_Pickup_Day(int id, Customer customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
               
                if (customer.OneTimePickupDay.ToString() == "Sunday")
                {

                    return RedirectToAction(nameof(Details));
                }
                else
                {
                    customer.Balance += 5;
                    _context.Update(customer);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Details1));
                }
            }
            return View(customer);
        }
        public async Task<IActionResult> PayBalance(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PayBalance(int id, Customer customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Details));
            }
            return View(customer);
        }
    }
}
