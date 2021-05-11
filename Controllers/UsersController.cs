using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoviePro.Data;
using MoviePro.Models;
using MoviePro.Extensions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace MoviePro.Controllers
{
    public class UsersController : Controller
    {
        private readonly DataContext _context;
        public string SessionState = "LoginString";

        public UsersController(DataContext context)
        {
            _context = context;
        }

        // GET: Users
        public IActionResult Index()
        {
            return View();
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }
        public IActionResult Create()
        {
            return View();
        }
        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Email,Name,Password")] User user,string checkbox)
        {
            if (ModelState.IsValid && checkbox=="on")
            {
                user.Email = user.Email.ToLower();
                user.Password = user.Password.ToLower();
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("Create", user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Email,Name,Password,DateCreated")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    user.DateCreated = DateTime.Now;
                    HttpContext.Session.Set<User>(SessionState,null);
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                    HttpContext.Session.Set<User>(SessionState, user);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
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
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string email, string password)
        {
            if (email != null && password != null)
            {
                var model = _context.Users.Single(x => x.Email == email.ToLower() && x.Password == password.ToLower());
                if (model != null)
                {
                    HttpContext.Session.Set<User>(SessionState, model);
                    return RedirectToAction(nameof(Index));
                }
            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Set<User>(SessionState, null);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult AllListMovies()
        {
            var model = _context.Movies
                .Include(x => x.Genre)
                .Include(x => x.Country).ToList();
            return View(model);
        }
        public IActionResult AllListNews()
        {
            var model = _context.Magazines.ToList();
            return View(model);
        }
        public IActionResult Contact()
        {
            return View();
        }
        public JsonResult VerifyEmail(string email)
        {
            email = email.ToLower();
            if (_context.Users.Any(x => x.Email == email))
            {
                return Json("Email already exists! Please try another email.");
            }
            return Json(true);
        }
    }
}
