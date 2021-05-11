using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Models
{
    public class Country
    {
        public int Id { get; set; }
        [DisplayName("Country name")]
        public string CountryName { get; set; }
    }
}
