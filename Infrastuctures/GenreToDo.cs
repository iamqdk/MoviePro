using MoviePro.Data;
using MoviePro.Interfaces;
using MoviePro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Infrastuctures
{
    public class GenreToDo:IGenre
    {
        public DataContext _context;
        public GenreToDo(DataContext context)
        {
            _context = context;
            ListGenres = _context.Genres.ToList();
        }
        public List<Genre> ListGenres { get; set; }
    }
}
