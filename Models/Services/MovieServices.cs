using MoviePro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Models.Services
{
    public class MovieServices
    {
        public IMovies _movies;
        public MovieServices(IMovies movies)
        {
            _movies = movies;
        }
        public List<Movie> ListRecentMovies()
        {
            return _movies.ListRecentMovies;
        }
        public List<Movie> ListPopulatedMovies()
        {
            return _movies.ListPopulatedMovies;
        }
        public List<Movie> ListTopRatingMovies()
        {
            return _movies.ListTopRatingMovies;

        }
        public Movie TopRatingAndPopulatedMovies()
        {
            return _movies.TopRatingAndPopulatedMovies;
        }
        public List<Movie> ListRequestedMovies()
        {
            return _movies.ListRequestedMovies;
        }
        public List<Movie> ListFooterMovies()
        {
            return _movies.ListFooterMovies;
        }
    }
}
