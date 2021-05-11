using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviePro.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Controllers
{
    public class SingleGenreController : Controller
    {
        private readonly DataContext _context;
        public SingleGenreController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index(int id)
        {
            ViewData["Genre"] = _context.Genres.Find(id);
            ViewBag.Count = _context.Movies.Include(x => x.Genre).Where(x => x.GenreId == id).Count();
            var model = _context.Movies.Include(x => x.Genre).Where(x => x.GenreId == id).Take(10).ToList();
            return View(model);
        }
        public IActionResult IndexPage(int id,int page)
        {
            page -= 1;
            ViewData["Genre"]= _context.Genres.Find(id);
            ViewBag.page = page;
            ViewBag.Count = _context.Movies.Include(x => x.Genre).Where(x => x.GenreId == id).Count();
            var model = _context.Movies.Include(x => x.Genre).Where(x => x.GenreId == id).Skip(page*10).Take(10).ToList();
            return View("Index",model);
        }
    }
}
