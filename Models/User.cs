using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Email Address")]
        [DataType(DataType.EmailAddress)]
        [Remote("VerifyEmail","Users")]
        public string Email { get; set; }
        [DisplayName("Full Name")]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(20,ErrorMessage ="Required minimum length is 5",MinimumLength =5)]
        public string Password { get; set; }
        [Timestamp]
        public DateTime DateCreated { get; set; }
        public string UrlImage { get; set; }
        public List<Movie> Movies { get; set; }
        public List<FavoriteMovie> FavoriteMovies { get; set; }

    }
}
