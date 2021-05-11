using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Models
{
    public class FavoriteMovie
    {
        public int Id { get; set; }
        public string NameFavoriteMovie { get; set; }
        public int TmpId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
