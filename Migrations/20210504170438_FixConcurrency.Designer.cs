// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviePro.Data;

namespace MoviePro.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210504170438_FixConcurrency")]
    partial class FixConcurrency
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MoviePro.Models.Chapter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("NumberChapter")
                        .HasColumnType("int");

                    b.Property<string>("UrlChapter")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Chapter");
                });

            modelBuilder.Entity("MoviePro.Models.ContactInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ContactInformation");
                });

            modelBuilder.Entity("MoviePro.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryName = "America"
                        },
                        new
                        {
                            Id = 2,
                            CountryName = "China"
                        },
                        new
                        {
                            Id = 3,
                            CountryName = "Euro"
                        },
                        new
                        {
                            Id = 4,
                            CountryName = "India"
                        },
                        new
                        {
                            Id = 5,
                            CountryName = "Korea"
                        },
                        new
                        {
                            Id = 6,
                            CountryName = "Taiwan and Hong Kong"
                        },
                        new
                        {
                            Id = 7,
                            CountryName = "Thailand"
                        },
                        new
                        {
                            Id = 8,
                            CountryName = "United Kingdom"
                        });
                });

            modelBuilder.Entity("MoviePro.Models.FavoriteMovie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameFavoriteMovie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TmpId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("FavoriteMovie");
                });

            modelBuilder.Entity("MoviePro.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Action"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Adventure"
                        },
                        new
                        {
                            Id = 3,
                            Type = "Animal"
                        },
                        new
                        {
                            Id = 4,
                            Type = "Animation"
                        },
                        new
                        {
                            Id = 5,
                            Type = "Biography"
                        },
                        new
                        {
                            Id = 6,
                            Type = "Comedy"
                        },
                        new
                        {
                            Id = 7,
                            Type = "Costume"
                        },
                        new
                        {
                            Id = 8,
                            Type = "Crime"
                        },
                        new
                        {
                            Id = 9,
                            Type = "Documentary"
                        },
                        new
                        {
                            Id = 10,
                            Type = "Drama"
                        },
                        new
                        {
                            Id = 11,
                            Type = "Family"
                        },
                        new
                        {
                            Id = 12,
                            Type = "Fantasy"
                        },
                        new
                        {
                            Id = 13,
                            Type = "History"
                        },
                        new
                        {
                            Id = 14,
                            Type = "Horror"
                        },
                        new
                        {
                            Id = 15,
                            Type = "Musical"
                        },
                        new
                        {
                            Id = 16,
                            Type = "Psychological"
                        },
                        new
                        {
                            Id = 17,
                            Type = "Romance"
                        },
                        new
                        {
                            Id = 18,
                            Type = "Sports"
                        },
                        new
                        {
                            Id = 19,
                            Type = "Thriller"
                        },
                        new
                        {
                            Id = 20,
                            Type = "Tragedy"
                        },
                        new
                        {
                            Id = 21,
                            Type = "War"
                        });
                });

            modelBuilder.Entity("MoviePro.Models.Magazine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Magazines");
                });

            modelBuilder.Entity("MoviePro.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateReleased")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionByAuthor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("MovieName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberChapter")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("UrlImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlTrailer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("GenreId");

                    b.HasIndex("UserId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 8,
                            DateReleased = new DateTime(2021, 5, 5, 0, 4, 37, 696, DateTimeKind.Local).AddTicks(1759),
                            Description = "Kevin Darnell Hart[1] (born July 6, 1979)[2] is an American stand-up comedian, actor, and producer. Born and raised in Philadelphia, Pennsylvania, Hart began his career by winning several amateur comedy competitions at clubs throughout New England, culminating in his first real break in 2001 when he was cast by Judd Apatow for a recurring role on the TV series Undeclared. The series lasted only one season, but he soon landed other roles in films such as Paper Soldiers (2002), Scary Movie 3 (2003), Soul Plane (2004), In the Mix (2005), and Little Fockers (2010).",
                            GenreId = 1,
                            MovieName = "Kevin Hart",
                            NumberChapter = 0,
                            Rating = 0,
                            UrlImage = "/Movie_Images/Poster (1).jpg",
                            UrlTrailer = "https://www.youtube.com/embed/fDyqHSraeg4",
                            UserId = 1,
                            Views = 0
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 8,
                            DateReleased = new DateTime(2021, 5, 5, 0, 4, 37, 697, DateTimeKind.Local).AddTicks(6598),
                            Description = "Zootopia (titled Zootropolis in various regions)[a] is a 2016 American computer-animated buddy cop film[6][7] produced by Walt Disney Animation Studios and released by Walt Disney Pictures. It is the 55th Disney animated feature film, directed by Byron Howard and Rich Moore, co-directed by Jared Bush, and stars the voices of Ginnifer Goodwin, Jason Bateman, Idris Elba, Jenny Slate, Nate Torrence, Bonnie Hunt, Don Lake, Tommy Chong, J. K. Simmons, Octavia Spencer, Alan Tudyk, and Shakira. Taking place in the titular city where anthropomorphic mammals coexist, it tells a story of an unlikely partnership between a rabbit police officer and a red fox con artist as they uncover a criminal conspiracy involving the disappearance of predators.",
                            GenreId = 4,
                            MovieName = "Zootopia",
                            NumberChapter = 0,
                            Rating = 0,
                            UrlImage = "/Movie_Images/Poster (2).jpg",
                            UrlTrailer = "https://www.youtube.com/embed/Mo0cE2ZIYPw",
                            UserId = 1,
                            Views = 0
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 8,
                            DateReleased = new DateTime(2021, 5, 5, 0, 4, 37, 697, DateTimeKind.Local).AddTicks(6633),
                            Description = "Dirty Grandpa is a 2016 American comedy film about a lawyer who drives his grandfather to Florida during spring break. The film was directed by Dan Mazer and written by John Phillips. It stars Robert De Niro, Zac Efron, Aubrey Plaza, and Zoey Deutch.",
                            GenreId = 6,
                            MovieName = "Dirty Granpa",
                            NumberChapter = 0,
                            Rating = 0,
                            UrlImage = "/Movie_Images/Poster (3).jpg",
                            UrlTrailer = "https://www.youtube.com/embed/m77q2u48Cyg",
                            UserId = 1,
                            Views = 0
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 8,
                            DateReleased = new DateTime(2021, 5, 5, 0, 4, 37, 697, DateTimeKind.Local).AddTicks(6639),
                            Description = "Neighbors 2: Sorority Rising (released in some countries as Bad Neighbours 2 and on home release as Neighbors 2) is a 2016 American comedy film directed by Nicholas Stoller and written by Stoller, Andrew J. Cohen, Brendan O'Brien, Seth Rogen and Evan Goldberg. A sequel to Neighbors (2014), the plot follows the Radners (Rogen and Rose Byrne) having to outwit a new sorority led by Shelby (Chloë Grace Moretz), living next door in order to sell their house currently in escrow. Zac Efron, Dave Franco, Christopher Mintz-Plasse, Jerrod Carmichael, Ike Barinholtz, Carla Gallo, Hannibal Buress, and Lisa Kudrow reprise their roles from the first film; it was Rogen's first live-action sequel.",
                            GenreId = 6,
                            MovieName = "Neighbor 2",
                            NumberChapter = 0,
                            Rating = 0,
                            UrlImage = "/Movie_Images/Poster (4).jpg",
                            UrlTrailer = "https://www.youtube.com/embed/X2i9Zz_AqTg",
                            UserId = 1,
                            Views = 0
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 8,
                            DateReleased = new DateTime(2021, 5, 5, 0, 4, 37, 697, DateTimeKind.Local).AddTicks(6643),
                            Description = "Finding Dory is a 2016 American computer-animated adventure film produced by Pixar Animation Studios and released by Walt Disney Pictures. Directed by Andrew Stanton[5][6] and written by Stanton and Victoria Strouse,[7] the film is a sequel/spinoff[8][9] to Finding Nemo (2003) and features the returning voices of Ellen DeGeneres and Albert Brooks, with Hayden Rolence (replacing Alexander Gould), Ed O'Neill, Kaitlin Olson, Ty Burrell, Diane Keaton, and Eugene Levy joining the cast. The film focuses on the amnesiac fish Dory, who journeys to be reunited with her parents.[10]",
                            GenreId = 6,
                            MovieName = "Finding Dory",
                            NumberChapter = 0,
                            Rating = 0,
                            UrlImage = "/Movie_Images/Poster (5).jpg",
                            UrlTrailer = "https://www.youtube.com/embed/AMjMFbhyhwY",
                            UserId = 1,
                            Views = 0
                        },
                        new
                        {
                            Id = 6,
                            CountryId = 8,
                            DateReleased = new DateTime(2021, 5, 5, 0, 4, 37, 697, DateTimeKind.Local).AddTicks(6653),
                            Description = "The Suicide Squad is a fictional antihero team appearing in American comic books published by DC Comics. The first version of the Suicide Squad debuted in The Brave and the Bold #25 (September 1959) and the second and modern version, created by John Ostrander, debuted in Legends #3 (January 1987).",
                            GenreId = 1,
                            MovieName = "Boomerang Suicide Squad",
                            NumberChapter = 0,
                            Rating = 0,
                            UrlImage = "/Movie_Images/Poster (6).jpg",
                            UrlTrailer = "https://www.youtube.com/embed/tObsaSmNWDA",
                            UserId = 1,
                            Views = 0
                        },
                        new
                        {
                            Id = 7,
                            CountryId = 8,
                            DateReleased = new DateTime(2021, 5, 5, 0, 4, 37, 697, DateTimeKind.Local).AddTicks(6657),
                            Description = "Zoolander is a 2001 American action comedy film directed by Ben Stiller. The film contains elements from a pair of short films directed by Russell Bates and written by Drake Sather and Stiller for the VH1 Fashion Awards television specials in 1996 and 1997. The earlier short films and this film feature a dimwitted, narcissistic male model named Derek Zoolander (Stiller).",
                            GenreId = 1,
                            MovieName = "Zoo Lander",
                            NumberChapter = 0,
                            Rating = 0,
                            UrlImage = "/Movie_Images/Poster (7).jpg",
                            UrlTrailer = "https://www.youtube.com/embed/4CL4LNWHegk",
                            UserId = 1,
                            Views = 0
                        },
                        new
                        {
                            Id = 8,
                            CountryId = 8,
                            DateReleased = new DateTime(2021, 5, 5, 0, 4, 37, 697, DateTimeKind.Local).AddTicks(6661),
                            Description = "Ride Along is a 2014 American buddy cop action comedy film directed by Tim Story and starring Ice Cube, Kevin Hart, John Leguizamo, Bryan Callen, Tika Sumpter and Laurence Fishburne. Greg Coolidge, Jason Mantzoukas, Phil Hay, and Matt Manfredi wrote the screenplay based on a story originally from Coolidge.",
                            GenreId = 6,
                            MovieName = "Ride Along",
                            NumberChapter = 0,
                            Rating = 0,
                            UrlImage = "/Movie_Images/Poster (8).jpg",
                            UrlTrailer = "https://www.youtube.com/embed/5klp6rkHIks",
                            UserId = 1,
                            Views = 0
                        },
                        new
                        {
                            Id = 9,
                            CountryId = 8,
                            DateReleased = new DateTime(2021, 5, 5, 0, 4, 37, 697, DateTimeKind.Local).AddTicks(6664),
                            Description = "Hail, Caesar! is a 2016 American comedy film written, produced, edited, and directed by Joel and Ethan Coen. The film stars Josh Brolin, George Clooney, Alden Ehrenreich, Ralph Fiennes, Jonah Hill, Scarlett Johansson, Frances McDormand, Tilda Swinton, and Channing Tatum. It is a fictional story that follows the real-life fixer Eddie Mannix (Brolin) working in the Hollywood film industry in the 1950s, trying to discover what happened to a star actor during the filming of a biblical epic.[3]",
                            GenreId = 6,
                            MovieName = "Hail Ceasar!",
                            NumberChapter = 0,
                            Rating = 0,
                            UrlImage = "/Movie_Images/Poster (9).jpg",
                            UrlTrailer = "https://www.youtube.com/embed/kMqeoW3XRa0",
                            UserId = 1,
                            Views = 0
                        },
                        new
                        {
                            Id = 10,
                            CountryId = 8,
                            DateReleased = new DateTime(2021, 5, 5, 0, 4, 37, 697, DateTimeKind.Local).AddTicks(6669),
                            Description = "Starship Troopers is a 1997 American satirical military science fiction action film directed by Paul Verhoeven and written by Edward Neumeier, based on Robert A. Heinlein's 1959 novel of the same name. The story follows a young soldier named Johnny Rico and his exploits in the Mobile Infantry, a futuristic military unit. Rico's military career progresses from recruit, to non-commissioned officer, and finally to officer, against the backdrop of an interstellar war between mankind and an insectoid species known as Arachnids.",
                            GenreId = 6,
                            MovieName = "Rico Guys",
                            NumberChapter = 0,
                            Rating = 0,
                            UrlImage = "/Movie_Images/Poster (10).jpg",
                            UrlTrailer = "https://www.youtube.com/embed/e32QpMQUuAc",
                            UserId = 1,
                            Views = 0
                        });
                });

            modelBuilder.Entity("MoviePro.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@gmail.com",
                            Name = "Admin",
                            Password = "1",
                            UrlImage = "/Avatar_Images/Admin.jpg"
                        });
                });

            modelBuilder.Entity("MoviePro.Models.Chapter", b =>
                {
                    b.HasOne("MoviePro.Models.Movie", "Movie")
                        .WithMany("Chapters")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MoviePro.Models.FavoriteMovie", b =>
                {
                    b.HasOne("MoviePro.Models.User", "User")
                        .WithMany("FavoriteMovies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MoviePro.Models.Magazine", b =>
                {
                    b.HasOne("MoviePro.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MoviePro.Models.Movie", b =>
                {
                    b.HasOne("MoviePro.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoviePro.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoviePro.Models.User", "User")
                        .WithMany("Movies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("Genre");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MoviePro.Models.Movie", b =>
                {
                    b.Navigation("Chapters");
                });

            modelBuilder.Entity("MoviePro.Models.User", b =>
                {
                    b.Navigation("FavoriteMovies");

                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
