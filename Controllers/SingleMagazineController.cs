using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviePro.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Controllers
{
    public class SingleMagazineController : Controller
    {
        private readonly DataContext _context;
        public SingleMagazineController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index(int id)
        {
            var model = _context.Magazines.Include(x => x.User).First(x => x.Id == id);
            if (model != null)
            {
                return View(model);
            }
            return Content("Movie isn't existed! Try later...");
        }
        [HttpPost]
        public IActionResult SearchListNews(string name)
        {
            var model = _context.Magazines.Where(x => x.NewsName.Contains(name)).ToList();
            if (model != null)
            {
                return View("../Users/AllListNews", model);
            }
            return RedirectToAction(actionName:"Index",controllerName:"Users");
        }
    }
}
