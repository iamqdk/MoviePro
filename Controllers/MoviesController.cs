using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MoviePro.Data;
using MoviePro.Helpers;
using MoviePro.Models;

namespace MoviePro.Controllers
{
    public class MoviesController : Controller
    {
        public class Upload
        {
            public IFormFile FormFile { get; set; }
        }
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;
        [BindProperty]
        public Upload Image { get; set; }
        public MoviesController(DataContext context, IConfiguration configuration)
        {
            _configuration = configuration;
            _context = context;
        }

        // GET: Movies
        public async Task<IActionResult> Index()
        {
            ViewBag.Count = _context.Movies.Count();
            return View(await _context.Movies.Include(x=>x.Country)
                .Include(x=>x.User).Include(x=>x.Genre).Take(5).ToListAsync());
        }
        public async Task<IActionResult> IndexPage(int page)
        {
            page -= 1;
            ViewBag.page = page;
            ViewBag.Count = _context.Movies.Count();
            return View("Index", await _context.Movies.Include(x => x.Country)
                .Include(x => x.User).Include(x => x.Genre).Skip(page * 5).Take(5).ToListAsync());
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .Include(m => m.Country)
                .Include(m => m.Genre)
                .Include(m => m.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "CountryName");
            ViewData["GenreId"] = new SelectList(_context.Genres, "Id", "Type");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name");
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MovieName,DateReleased,Description,UrlTrailer,GenreId,CountryId,UserId,DescriptionByAuthor,Views,Rating")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                //Image
                movie.UrlImage = await Tmp();
                movie.UrlImage = movie.UrlImage.Substring(movie.UrlImage.IndexOf("wwwroot/")+7);
                //Youtube
                movie.UrlTrailer = "https://www.youtube.com/embed/" + movie.UrlTrailer.Substring(movie.UrlTrailer.IndexOf("=")+1);
                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "CountryName", movie.CountryId);
            ViewData["GenreId"] = new SelectList(_context.Genres, "Id", "Type", movie.GenreId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name", movie.UserId);
            return View(movie);
        }
        public async Task<string> Tmp()
        {
            if (Image != null)
            {
                var _permittedExtensions = new string[] { ".png", ".jpg", ".png" };     //permitted extension
                long _fileSizeLimit = 5242880;                                          //fileSizeLimit
                var _targetFilePath = _configuration.GetValue<string>("UrlImage");
                if (!ModelState.IsValid)
                {
                    return "Please correct the form.";
                }
                var formFileContent =
                    await FileHelpers.ProcessFormFile<Upload>(
                        Image.FormFile, ModelState, _permittedExtensions,
                        _fileSizeLimit);                                                // convert file to byte[] with Security Upload

                if (!ModelState.IsValid)
                {
                    return "Please correct the form.";
                }
                var filePath = Path.Combine(
                    _targetFilePath, Image.FormFile.FileName);
                //using (var fileStream = System.IO.File.Create(filePath))
                //{
                //    //await fileStream.WriteAsync(formFileContent);                       //Write sequence byte[] to file
                //}
                return filePath;
            }
            return null;
        }
        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "CountryName", movie.CountryId);
            ViewData["GenreId"] = new SelectList(_context.Genres, "Id", "Type", movie.GenreId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name", movie.UserId);
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MovieName,DateReleased,Description,UrlTrailer,GenreId,CountryId,UserId,DescriptionByAuthor,Views,Rating")] Movie movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //Image
                    movie.UrlImage = await Tmp();
                    movie.UrlImage = movie.UrlImage.Substring(movie.UrlImage.IndexOf("wwwroot/") + 7);
                    //Youtube
                    if (!movie.UrlTrailer.Contains("embed"))
                    {
                        movie.UrlTrailer = "https://www.youtube.com/embed/" + movie.UrlTrailer.Substring(movie.UrlTrailer.IndexOf("=") + 1);
                    }
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "CountryName", movie.CountryId);
            ViewData["GenreId"] = new SelectList(_context.Genres, "Id", "Type", movie.GenreId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name", movie.UserId);
            return View(movie);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .Include(m => m.Country)
                .Include(m => m.Genre)
                .Include(m => m.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.Id == id);
        }
    }
}
