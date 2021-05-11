using MoviePro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Models.Services
{
    public class CountryServices
    {
        public ICountry _country;
        public CountryServices(ICountry country)
        {
            _country = country;
        }
        public List<Country> ListCountries()
        {
            return _country.ListCountries;
        }
    }
}
