using Microsoft.EntityFrameworkCore;
using MoviePro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(x=> {
                x.Property(x => x.DateCreated).IsConcurrencyToken();
                x.Property(x => x.DateCreated).HasDefaultValueSql("getdate()");
                x.HasData(new User { Id = 1, Name = "Admin", Email = "admin@gmail.com", Password = "1", UrlImage = "/Avatar_Images/Admin.jpg" });
            });
            modelBuilder.Entity<Genre>(x => {
                x.Property(x => x.Type).HasConversion<string>();
                //Data Genre
                x.HasData(new Genre { Id = 1, Type=TypeofGenre.Action});
                x.HasData(new Genre { Id = 2, Type = TypeofGenre.Adventure });
                x.HasData(new Genre { Id = 3, Type = TypeofGenre.Animal });
                x.HasData(new Genre { Id = 4, Type = TypeofGenre.Animation});
                x.HasData(new Genre { Id = 5, Type = TypeofGenre.Biography});
                x.HasData(new Genre { Id = 6, Type = TypeofGenre.Comedy});
                x.HasData(new Genre { Id = 7, Type = TypeofGenre.Costume});
                x.HasData(new Genre { Id = 8, Type = TypeofGenre.Crime});
                x.HasData(new Genre { Id = 9, Type = TypeofGenre.Documentary});
                x.HasData(new Genre { Id = 10, Type = TypeofGenre.Drama});
                x.HasData(new Genre { Id = 11, Type = TypeofGenre.Family});
                x.HasData(new Genre { Id = 12, Type = TypeofGenre.Fantasy});
                x.HasData(new Genre { Id = 13, Type = TypeofGenre.History});
                x.HasData(new Genre { Id = 14, Type = TypeofGenre.Horror});
                x.HasData(new Genre { Id = 15, Type = TypeofGenre.Musical });
                x.HasData(new Genre { Id = 16, Type = TypeofGenre.Psychological });
                x.HasData(new Genre { Id = 17, Type = TypeofGenre.Romance });
                x.HasData(new Genre { Id = 18, Type = TypeofGenre.Sports });
                x.HasData(new Genre { Id = 19, Type = TypeofGenre.Thriller });
                x.HasData(new Genre { Id = 20, Type = TypeofGenre.Tragedy });
                x.HasData(new Genre { Id = 21, Type = TypeofGenre.War });
            });
            modelBuilder.Entity<Country>(x =>
            {
                x.HasData(new Country { Id = 1, CountryName = "America" });
                x.HasData(new Country { Id = 2, CountryName = "China" });
                x.HasData(new Country { Id = 3, CountryName = "Euro" });
                x.HasData(new Country { Id = 4, CountryName = "India" });
                x.HasData(new Country { Id = 5, CountryName = "Korea" });
                x.HasData(new Country { Id = 6, CountryName = "Taiwan and Hong Kong" });
                x.HasData(new Country { Id = 7, CountryName = "Thailand" });
                x.HasData(new Country { Id = 8, CountryName = "United Kingdom" });
            });
            modelBuilder.Entity<Movie>(x=> {
                x.HasData(new Movie
                {
                    Id = 1,
                    MovieName = "Kevin Hart",
                    Description= "Kevin Darnell Hart[1] (born July 6, 1979)[2] is an American stand-up comedian, actor, and producer. Born and raised in Philadelphia, Pennsylvania, Hart began his career by winning several amateur comedy competitions at clubs throughout New England, culminating in his first real break in 2001 when he was cast by Judd Apatow for a recurring role on the TV series Undeclared. The series lasted only one season, but he soon landed other roles in films such as Paper Soldiers (2002), Scary Movie 3 (2003), Soul Plane (2004), In the Mix (2005), and Little Fockers (2010).",
                    DateReleased = DateTime.Now,
                    UrlImage = "/Movie_Images/Poster (1).jpg",
                    UrlTrailer= "https://www.youtube.com/embed/fDyqHSraeg4",
                    GenreId=1,
                    CountryId=8,
                    UserId=1
                });
                x.HasData(new Movie
                {
                    Id = 2,
                    MovieName = "Zootopia",
                    Description= "Zootopia (titled Zootropolis in various regions)[a] is a 2016 American computer-animated buddy cop film[6][7] produced by Walt Disney Animation Studios and released by Walt Disney Pictures. It is the 55th Disney animated feature film, directed by Byron Howard and Rich Moore, co-directed by Jared Bush, and stars the voices of Ginnifer Goodwin, Jason Bateman, Idris Elba, Jenny Slate, Nate Torrence, Bonnie Hunt, Don Lake, Tommy Chong, J. K. Simmons, Octavia Spencer, Alan Tudyk, and Shakira. Taking place in the titular city where anthropomorphic mammals coexist, it tells a story of an unlikely partnership between a rabbit police officer and a red fox con artist as they uncover a criminal conspiracy involving the disappearance of predators.",
                    DateReleased = DateTime.Now,
                    UrlImage = "/Movie_Images/Poster (2).jpg",
                    UrlTrailer = "https://www.youtube.com/embed/Mo0cE2ZIYPw",
                    GenreId = 4,
                    CountryId = 8,
                    UserId = 1
                });
                x.HasData(new Movie
                {
                    Id = 3,
                    MovieName = "Dirty Granpa",
                    DateReleased = DateTime.Now,
                    Description= "Dirty Grandpa is a 2016 American comedy film about a lawyer who drives his grandfather to Florida during spring break. The film was directed by Dan Mazer and written by John Phillips. It stars Robert De Niro, Zac Efron, Aubrey Plaza, and Zoey Deutch.",
                    UrlImage = "/Movie_Images/Poster (3).jpg",
                    UrlTrailer = "https://www.youtube.com/embed/m77q2u48Cyg",
                    GenreId = 6,
                    CountryId = 8,
                    UserId = 1

                });
                x.HasData(new Movie
                {
                    Id = 4,
                    MovieName = "Neighbor 2",
                    DateReleased = DateTime.Now,
                    Description= "Neighbors 2: Sorority Rising (released in some countries as Bad Neighbours 2 and on home release as Neighbors 2) is a 2016 American comedy film directed by Nicholas Stoller and written by Stoller, Andrew J. Cohen, Brendan O'Brien, Seth Rogen and Evan Goldberg. A sequel to Neighbors (2014), the plot follows the Radners (Rogen and Rose Byrne) having to outwit a new sorority led by Shelby (Chloë Grace Moretz), living next door in order to sell their house currently in escrow. Zac Efron, Dave Franco, Christopher Mintz-Plasse, Jerrod Carmichael, Ike Barinholtz, Carla Gallo, Hannibal Buress, and Lisa Kudrow reprise their roles from the first film; it was Rogen's first live-action sequel.",
                    UrlImage = "/Movie_Images/Poster (4).jpg",
                    UrlTrailer = "https://www.youtube.com/embed/X2i9Zz_AqTg",
                    GenreId = 6,
                    CountryId = 8,
                    UserId = 1

                });
                x.HasData(new Movie
                {
                    Id = 5,
                    MovieName = "Finding Dory",
                    DateReleased = DateTime.Now,
                    Description= "Finding Dory is a 2016 American computer-animated adventure film produced by Pixar Animation Studios and released by Walt Disney Pictures. Directed by Andrew Stanton[5][6] and written by Stanton and Victoria Strouse,[7] the film is a sequel/spinoff[8][9] to Finding Nemo (2003) and features the returning voices of Ellen DeGeneres and Albert Brooks, with Hayden Rolence (replacing Alexander Gould), Ed O'Neill, Kaitlin Olson, Ty Burrell, Diane Keaton, and Eugene Levy joining the cast. The film focuses on the amnesiac fish Dory, who journeys to be reunited with her parents.[10]",
                    UrlImage = "/Movie_Images/Poster (5).jpg",
                    UrlTrailer = "https://www.youtube.com/embed/AMjMFbhyhwY",
                    GenreId = 6,
                    CountryId = 8,
                    UserId = 1

                });
                x.HasData(new Movie
                {
                    Id = 6,
                    MovieName = "Boomerang Suicide Squad",
                    DateReleased = DateTime.Now,
                    Description= "The Suicide Squad is a fictional antihero team appearing in American comic books published by DC Comics. The first version of the Suicide Squad debuted in The Brave and the Bold #25 (September 1959) and the second and modern version, created by John Ostrander, debuted in Legends #3 (January 1987).",
                    UrlImage = "/Movie_Images/Poster (6).jpg",
                    UrlTrailer = "https://www.youtube.com/embed/tObsaSmNWDA",
                    GenreId = 1,
                    CountryId = 8,
                    UserId = 1

                });
                x.HasData(new Movie
                {
                    Id = 7,
                    MovieName = "Zoo Lander",
                    DateReleased = DateTime.Now,
                    Description= "Zoolander is a 2001 American action comedy film directed by Ben Stiller. The film contains elements from a pair of short films directed by Russell Bates and written by Drake Sather and Stiller for the VH1 Fashion Awards television specials in 1996 and 1997. The earlier short films and this film feature a dimwitted, narcissistic male model named Derek Zoolander (Stiller).",
                    UrlImage = "/Movie_Images/Poster (7).jpg",
                    UrlTrailer = "https://www.youtube.com/embed/4CL4LNWHegk",
                    GenreId = 1,
                    CountryId = 8,
                    UserId = 1

                });
                x.HasData(new Movie
                {
                    Id = 8,
                    MovieName = "Ride Along",
                    DateReleased = DateTime.Now,
                    Description= "Ride Along is a 2014 American buddy cop action comedy film directed by Tim Story and starring Ice Cube, Kevin Hart, John Leguizamo, Bryan Callen, Tika Sumpter and Laurence Fishburne. Greg Coolidge, Jason Mantzoukas, Phil Hay, and Matt Manfredi wrote the screenplay based on a story originally from Coolidge.",
                    UrlImage = "/Movie_Images/Poster (8).jpg",
                    UrlTrailer = "https://www.youtube.com/embed/5klp6rkHIks",
                    GenreId = 6,
                    CountryId = 8,
                    UserId = 1

                });
                x.HasData(new Movie
                {
                    Id = 9,
                    MovieName = "Hail Ceasar!",
                    DateReleased = DateTime.Now,
                    Description= "Hail, Caesar! is a 2016 American comedy film written, produced, edited, and directed by Joel and Ethan Coen. The film stars Josh Brolin, George Clooney, Alden Ehrenreich, Ralph Fiennes, Jonah Hill, Scarlett Johansson, Frances McDormand, Tilda Swinton, and Channing Tatum. It is a fictional story that follows the real-life fixer Eddie Mannix (Brolin) working in the Hollywood film industry in the 1950s, trying to discover what happened to a star actor during the filming of a biblical epic.[3]",
                    UrlImage = "/Movie_Images/Poster (9).jpg",
                    UrlTrailer = "https://www.youtube.com/embed/kMqeoW3XRa0",
                    GenreId = 6,
                    CountryId = 8,
                    UserId = 1

                });
                x.HasData(new Movie
                {
                    Id = 10,
                    MovieName = "Rico Guys",
                    DateReleased = DateTime.Now,
                    Description= "Starship Troopers is a 1997 American satirical military science fiction action film directed by Paul Verhoeven and written by Edward Neumeier, based on Robert A. Heinlein's 1959 novel of the same name. The story follows a young soldier named Johnny Rico and his exploits in the Mobile Infantry, a futuristic military unit. Rico's military career progresses from recruit, to non-commissioned officer, and finally to officer, against the backdrop of an interstellar war between mankind and an insectoid species known as Arachnids.",
                    UrlImage = "/Movie_Images/Poster (10).jpg",
                    UrlTrailer = "https://www.youtube.com/embed/e32QpMQUuAc",
                    GenreId = 6,
                    CountryId = 8,
                    UserId = 1

                });
            });
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Magazine> Magazines { get; set; }
        public DbSet<ContactInformation> ContactInformation { get; set; }
        public DbSet<FavoriteMovie> FavoriteMovie { get; set; }
        public DbSet<MoviePro.Models.Chapter> Chapter { get; set; }

    }
}
