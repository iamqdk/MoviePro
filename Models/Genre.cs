using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public TypeofGenre Type { get; set; }
        public string Description { get; set; }
    }
}
