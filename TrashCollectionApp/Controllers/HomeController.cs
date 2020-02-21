﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrashCollectionApp.Data;
using TrashCollectionApp.Models;

namespace TrashCollectionApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _logger = logger;
            _userManager = userManager;
            _context = context;
        }

        public IActionResult Index()
        {
            if (User.IsInRole("Customer"))
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var customerInfo = _context.customers.Where(c => c.IdentityUserId == userId).FirstOrDefault();
                if (customerInfo == null)
                {
                    return RedirectToAction("Create", "Customers");
                }
                else
                {
                    return RedirectToAction("Index", "Customers");
                }
            }


            else if (User.IsInRole("Employee"))
            {
                if (User == null)
                {
                    return RedirectToAction("Create", "Employees");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
