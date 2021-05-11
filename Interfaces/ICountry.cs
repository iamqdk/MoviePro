using MoviePro.Data;
using MoviePro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Interfaces
{
    public interface ICountry
    {
        List<Country> ListCountries { get; set; }
    }
}
