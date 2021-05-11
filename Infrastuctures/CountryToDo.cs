using MoviePro.Data;
using MoviePro.Interfaces;
using MoviePro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Infrastuctures
{
    public class CountryToDo:ICountry
    {
        public DataContext _context;
        public CountryToDo(DataContext context)
        {
            _context = context;
            ListCountries = _context.Countries.ToList();
        }
        public List<Country> ListCountries { get; set; }
    }
}
