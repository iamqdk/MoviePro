using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviePro.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Controllers
{
    public class SingleCountryController : Controller
    {
        private readonly DataContext _context;
        public SingleCountryController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index(int id)
        {
            ViewData["Country"] = _context.Countries.Find(id);
            ViewBag.Count = _context.Movies.Include(x => x.Country).Where(x => x.CountryId == id).Count();
            var model = _context.Movies.Include(x => x.Country).Where(x => x.CountryId == id).Take(10).ToList();
            return View(model);
        }
        public IActionResult IndexPage(int id, int page)
        {
            page -= 1;
            ViewData["Country"] = _context.Countries.Find(id);
            ViewBag.page = page;
            ViewBag.Count = _context.Movies.Include(x => x.Country).Where(x => x.CountryId == id).Count();
            var model = _context.Movies.Include(x => x.Country).Where(x => x.CountryId == id).Skip(page * 10).Take(10).ToList();
            return View("Index", model);
        }
    }
}
