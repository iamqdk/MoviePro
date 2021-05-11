using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Models
{
    public class Magazine
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        [Required]
        public string NewsName { get; set; }
        [Required]
        public string Description { get; set; }
        [DisplayName("Date created")]
        [DataType(DataType.Date)]
        public DateTime DateTime { get; set; }
        [DisplayName("Author")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
