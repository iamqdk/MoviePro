using MoviePro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Models.Services
{
    public class MagazineServices
    {
        public IMagazine _magazine;
        public MagazineServices(IMagazine magazine)
        {
            _magazine = magazine;
        }
        public List<Magazine> MagazineLastestNews()
        {
            return _magazine.LastestNews;
        }
    }
}
