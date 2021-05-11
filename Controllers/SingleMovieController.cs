using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviePro.Data;
using MoviePro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Controllers
{
    public class SingleMovieController : Controller
    {
        private readonly DataContext _context;
        public SingleMovieController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index(int id)
        {

            var model = _context.Movies.Include(x => x.User)
                  .Include(x => x.Genre)
                  .Include(x => x.Chapters)
                  .Include(x => x.Country).First(x => x.Id == id);
            ViewData["FavoriteMovie"] = _context.FavoriteMovie.ToList();
            if (model != null)
            {
                UpdateViews(model);
                return View(model);
            }
            return Content("Movie isn't existed! Try later...");
        }
        [HttpPost]
        public IActionResult SearchMovie(string search)
        {
            ViewData["Search"] = search;
            var model = _context.Movies.Where(x => x.MovieName.Contains(search)).ToList();
            return View(model);
        }
        public async Task<IActionResult> Follow(int movieid, int userid)
        {
            var tmp = _context.Movies.First(x => x.Id == movieid);
            var model = new FavoriteMovie
            {
                NameFavoriteMovie = tmp.MovieName,
                TmpId = tmp.Id,
                UserId = userid
            };
            _context.Add(model);
            await _context.SaveChangesAsync();
            return Redirect($"Index/{movieid}");
        }
        public async Task<IActionResult> Unfollow(int movieid, int userid)
        {
            var model = _context.FavoriteMovie.Single(x => x.TmpId == movieid && x.UserId == userid);
            if (model != null)
            {
                _context.Remove(model);
                await _context.SaveChangesAsync();
            }
            return Redirect($"Index/{movieid}");
        }
        public void UpdateViews(Movie movie)
        {
            movie.Views += 1;
            _context.SaveChanges();
        }
    }
}
