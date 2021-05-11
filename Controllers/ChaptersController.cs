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
    public class ChaptersController : Controller
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;
        [BindProperty]
        public Upload Video { get; set; }

        public ChaptersController(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public class Upload
        {
            public IFormFile FormFile { get; set; }
        }

        // GET: Chapters
        public async Task<IActionResult> Index()
        {
            ViewBag.Count = _context.Chapter.Count();
            return View(await _context.Chapter.Include(x=>x.Movie).Take(5).ToListAsync());
        }
        public async Task<IActionResult> IndexPage(int page)
        {
            page -= 1;
            ViewBag.page = page;
            ViewBag.Count = _context.Chapter.Count();
            return View("Index",await _context.Chapter.Include(x => x.Movie).Skip(page*5).Take(5).ToListAsync());
        }

        // GET: Chapters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chapter = await _context.Chapter
                .Include(c => c.Movie)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chapter == null)
            {
                return NotFound();
            }

            return View(chapter);
        }

        // GET: Chapters/Create
        public IActionResult Create()
        {
            ViewData["MovieId"] = new SelectList(_context.Movies, "Id", "MovieName");
            return View();
        }

        // POST: Chapters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [RequestFormLimits(MultipartBodyLengthLimit = 2097152000)]
        [RequestSizeLimit(2097152000)]
        public async Task<IActionResult> Create([Bind("Id,NumberChapter,UrlChapter,MovieId")] Chapter chapter)
        {
            if (ModelState.IsValid)
            {
                //Video
                chapter.UrlChapter = Tmp(_context.Movies.Single(x=>x.Id==chapter.MovieId).MovieName+" - Ep "+chapter.NumberChapter+".mp4");
                chapter.UrlChapter = chapter.UrlChapter.Substring(chapter.UrlChapter.IndexOf("wwwroot/") + 7);

                _context.Add(chapter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MovieId"] = new SelectList(_context.Movies, "Id", "MovieName", chapter.MovieId);
            return View(chapter);
        }
        public string Tmp(string fileName)
        {
            if (Video != null)
            {
                if (!ModelState.IsValid)
                {
                    return "Please correct the form.";
                }
                var _targetFilePath = _configuration.GetValue<string>("UrlSource");
                if (!ModelState.IsValid)
                {
                    return "Please correct the form.";
                }
                var filePath = Path.Combine(
                    _targetFilePath, fileName);
                using (var fileStream = System.IO.File.Create(filePath))
                {
                    Video.FormFile.CopyTo(fileStream);                       //Write sequence byte[] to file
                    fileStream.Flush();
                }
                return filePath;
            }
            return null;
        }

        // GET: Chapters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chapter = await _context.Chapter.FindAsync(id);
            if (chapter == null)
            {
                return NotFound();
            }
            ViewData["MovieId"] = new SelectList(_context.Movies, "Id", "MovieName", chapter.MovieId);
            return View(chapter);
        }

        // POST: Chapters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NumberChapter,UrlChapter,MovieId")] Chapter chapter)
        {
            if (id != chapter.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //Video
                    chapter.UrlChapter = Tmp(_context.Movies.Single(x => x.Id == chapter.MovieId).MovieName + " - Ep " + chapter.NumberChapter + ".mp4");
                    chapter.UrlChapter = chapter.UrlChapter.Substring(chapter.UrlChapter.IndexOf("wwwroot/") + 7);

                    _context.Update(chapter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChapterExists(chapter.Id))
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
            ViewData["MovieId"] = new SelectList(_context.Movies, "Id", "MovieName", chapter.MovieId);
            return View(chapter);
        }

        // GET: Chapters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chapter = await _context.Chapter
                .Include(c => c.Movie)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chapter == null)
            {
                return NotFound();
            }

            return View(chapter);
        }

        // POST: Chapters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chapter = await _context.Chapter.FindAsync(id);
            _context.Chapter.Remove(chapter);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChapterExists(int id)
        {
            return _context.Chapter.Any(e => e.Id == id);
        }
        public IActionResult Hack()
        {
            return View();
        }
        public string Hack2()
        {
            return Tmp("quachdangkhoa.mp4");
        }
    }
}
