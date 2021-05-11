using Microsoft.EntityFrameworkCore;
using MoviePro.Data;
using MoviePro.Interfaces;
using MoviePro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Infrastuctures
{
    public class MovieToDo:IMovies
    {
        public DataContext _context;
        public MovieToDo(DataContext context)
        {
            _context = context;
            ListRecentMovies = _context.Movies.OrderByDescending(x => x.Id).Take(8).ToList();
            ListPopulatedMovies=_context.Movies.OrderByDescending(x => x.Views).Take(8).ToList();
            ListTopRatingMovies = _context.Movies.OrderByDescending(x => x.Rating).Take(8).ToList();
            TopRatingAndPopulatedMovies = _context.Movies.Include(x=>x.Genre).OrderByDescending(x => x.Views).ThenByDescending(x => x.Rating).First();
            ListRequestedMovies = _context.Movies.Where(x => x.DateReleased.Year == DateTime.Now.Year).Take(10).ToList();
            ListFooterMovies = _context.Movies.Take(4).ToList();
        }
        public List<Movie> ListRequestedMovies { get; set; }
        public List<Movie> ListRecentMovies { get; set; }
        public List<Movie> ListPopulatedMovies { get; set; }
        public List<Movie> ListTopRatingMovies { get; set; }
        public List<Movie> ListFooterMovies { get; set; }
        public Movie TopRatingAndPopulatedMovies { get; set; }

    }
}
