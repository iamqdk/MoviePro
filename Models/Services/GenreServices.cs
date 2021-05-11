using MoviePro.Data;
using MoviePro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Models.Services
{
    public class GenreServices
    {
        public IGenre _genre;
        public GenreServices(IGenre genre)
        {
            _genre = genre;
        }
        public List<Genre> ListGenres()
        {
            return _genre.ListGenres;
        }
    }
}
