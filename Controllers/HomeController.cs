﻿using Microsoft.AspNetCore.Mvc;
using FutureValue.Models;

namespace FutureValue.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Name = "Kazi";
            ViewBag.FV = 0.00;
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(FutureValueModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.CalculateFutureValue();
            }
            else
            {
                ViewBag.FV = 0;
            }
            return View(model);
        }
    }
}
