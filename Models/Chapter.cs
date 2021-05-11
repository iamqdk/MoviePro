using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Models
{
    public class Chapter
    {
        public int Id { get; set; }
        [DisplayName("Chap")]
        public int NumberChapter { get; set; }
        [DisplayName("Url")]
        public string UrlChapter { get; set; }
        [DisplayName("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
