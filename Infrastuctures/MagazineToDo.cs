using MoviePro.Data;
using MoviePro.Interfaces;
using MoviePro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Infrastuctures
{
    public class MagazineToDo:IMagazine
    {
        public DataContext _context;
        public MagazineToDo(DataContext context)
        {
            _context = context;
            LastestNews = _context.Magazines.Take(5).ToList();
        }
        public List<Magazine> LastestNews { get; set; }

    }
}
