using MoviePro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Interfaces
{
    public interface IMovies
    {
        List<Movie> ListFooterMovies { get; set; }
        List<Movie> ListRecentMovies { get; set; }
        List<Movie> ListPopulatedMovies { get; set; }
        List<Movie> ListTopRatingMovies { get; set; }
        List<Movie> ListRequestedMovies { get; set; }
        Movie TopRatingAndPopulatedMovies { get; set; }
    }
}
