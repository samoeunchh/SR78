using Microsoft.AspNetCore.Mvc;
using SR78.Models;
using SR78.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SR78.Controllers
{
    public class BrandsController : Controller
    {
        private IBrandRepository _brand;
        public BrandsController(IBrandRepository brand)
        {
            _brand = brand;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _brand.GetBrands());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Brand brand)
        {
            if (ModelState.IsValid)
            {
               if(await _brand.Save(brand))
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(brand);
        }
    }
}
