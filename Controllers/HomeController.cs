using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LaurenDaines_TopRestaurants.Models;

namespace LaurenDaines_TopRestaurants.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();

            foreach (Restaurant r in Restaurant.GetRestaurants())
            {
                string? link = r.Link ?? "Coming soon.";
                string? favdish = r.FavDish ?? "It's all tasty!";

                restaurantList.Add($"{r.Rank}: {r.Name}<br />{r.Address}<br />{r.PhoneNumber}<br /><a href='{r.Link}'>{link}</a><br />{favdish} <br /><br />");
            }

            return View(restaurantList);
        }

        [HttpGet]
        public IActionResult EnterRestaurant()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnterRestaurant(ApplicationResponse appResponse)
        {
            if (ModelState.IsValid)
            {
                Storage.AddApplication(appResponse);
                return View("Confirmation");
            }
            else
            {
                return View();
            }
        }

        public IActionResult ViewRestaurants()
        {
            return View(Storage.Applications);
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
