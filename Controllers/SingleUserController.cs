using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviePro.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MoviePro.Controllers
{
    public class SingleUserController : Controller
    {
        private readonly DataContext _context;
        public SingleUserController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index(int id)
        {
            var model = _context.Users.Include(x=>x.FavoriteMovies)
                .Single(x => x.Id == id);
            return View(model);
        }
        public IActionResult Delete(int id,int UserId)
        {
            var model = _context.FavoriteMovie.Single(x => x.Id == id);
            _context.Remove(model);
            _context.SaveChanges();
            return Redirect($"~/SingleUser/Index/{UserId}");
        }
    }
}
