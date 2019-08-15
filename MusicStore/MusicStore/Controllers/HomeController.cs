using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Data;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Songs.Where(m => m.IsFeatured).ToList());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "We have no license to sell this.";

            return View();
        }

        public IActionResult Test()
        {
            ViewData["Message"] = "Your testing needs in one convenient place.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact Us (or don't. Don't works too).";

            return View();
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

        public IActionResult Albums()
        {
            return View(_context.Songs.GroupBy(x => x.Album).Select(grp => grp.First()).ToList());
        }

    }
}
