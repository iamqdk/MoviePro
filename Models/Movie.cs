using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [DisplayName("Movie name")]
        [StringLength(25)]
        [Required]
        public string MovieName { get; set; }
        [DisplayName("Date released")]
        [DataType(DataType.Date)]    
        public DateTime DateReleased { get; set; }
        [Required]
        public string Description { get; set; }
        [DisplayName("Image")]
        public string UrlImage { get; set; }
        [DisplayName("Trailer")]
        public string UrlTrailer { get; set; }
        [DisplayName("Genre")]
        public int GenreId { get; set; }
        [DisplayName("Country")]
        public int CountryId { get; set; }
        [DisplayName("Author")]
        public int UserId { get; set; }
        [DisplayName("Description by author")]
        public string DescriptionByAuthor { get; set; }
        public int Views { get; set; }
        public int Rating { get; set; }
        [DisplayName("Chapters")]
        public int NumberChapter { get; set; }
        public Genre Genre { get; set; }
        public Country Country { get; set; }
        public User User { get; set; }
        public List<Chapter> Chapters { get; set; }
    }
}
