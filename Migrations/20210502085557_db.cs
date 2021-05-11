using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePro.Migrations
{
    public partial class db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", rowVersion: true, nullable: false, defaultValueSql: "getdate()"),
                    UrlImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateReleased = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlTrailer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Views = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName" },
                values: new object[,]
                {
                    { 1, "America" },
                    { 2, "China" },
                    { 3, "Euro" },
                    { 4, "India" },
                    { 5, "Korea" },
                    { 6, "Taiwan and Hong Kong" },
                    { 7, "Thailand" },
                    { 8, "United Kingdom" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { 13, null, "History" },
                    { 14, null, "Horror" },
                    { 15, null, "Musical" },
                    { 16, null, "Psychological" },
                    { 20, null, "Tragedy" },
                    { 18, null, "Sports" },
                    { 19, null, "Thriller" },
                    { 12, null, "Fantasy" },
                    { 17, null, "Romance" },
                    { 11, null, "Family" },
                    { 7, null, "Costume" },
                    { 9, null, "Documentary" },
                    { 8, null, "Crime" },
                    { 21, null, "War" },
                    { 6, null, "Comedy" },
                    { 5, null, "Biography" },
                    { 4, null, "Animation" },
                    { 3, null, "Animal" },
                    { 2, null, "Adventure" },
                    { 1, null, "Action" },
                    { 10, null, "Drama" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password", "UrlImage" },
                values: new object[] { 1, "admin@gmail.com", "Admin", "1", "/Avatar_Images/Admin.jpg" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CountryId", "DateReleased", "Description", "GenreId", "MovieName", "Rating", "UrlImage", "UrlTrailer", "UserId", "Views" },
                values: new object[,]
                {
                    { 1, 8, new DateTime(2021, 5, 2, 15, 55, 56, 565, DateTimeKind.Local).AddTicks(4332), "Kevin Darnell Hart[1] (born July 6, 1979)[2] is an American stand-up comedian, actor, and producer. Born and raised in Philadelphia, Pennsylvania, Hart began his career by winning several amateur comedy competitions at clubs throughout New England, culminating in his first real break in 2001 when he was cast by Judd Apatow for a recurring role on the TV series Undeclared. The series lasted only one season, but he soon landed other roles in films such as Paper Soldiers (2002), Scary Movie 3 (2003), Soul Plane (2004), In the Mix (2005), and Little Fockers (2010).", 1, "Kevin Hart", 0, "/Movie_Images/Poster (1).jpg", "https://www.youtube.com/embed/fDyqHSraeg4", 1, 0 },
                    { 2, 8, new DateTime(2021, 5, 2, 15, 55, 56, 566, DateTimeKind.Local).AddTicks(8940), "Zootopia (titled Zootropolis in various regions)[a] is a 2016 American computer-animated buddy cop film[6][7] produced by Walt Disney Animation Studios and released by Walt Disney Pictures. It is the 55th Disney animated feature film, directed by Byron Howard and Rich Moore, co-directed by Jared Bush, and stars the voices of Ginnifer Goodwin, Jason Bateman, Idris Elba, Jenny Slate, Nate Torrence, Bonnie Hunt, Don Lake, Tommy Chong, J. K. Simmons, Octavia Spencer, Alan Tudyk, and Shakira. Taking place in the titular city where anthropomorphic mammals coexist, it tells a story of an unlikely partnership between a rabbit police officer and a red fox con artist as they uncover a criminal conspiracy involving the disappearance of predators.", 4, "Zootopia", 0, "/Movie_Images/Poster (2).jpg", "https://www.youtube.com/embed/Mo0cE2ZIYPw", 1, 0 },
                    { 3, 8, new DateTime(2021, 5, 2, 15, 55, 56, 566, DateTimeKind.Local).AddTicks(8977), "Dirty Grandpa is a 2016 American comedy film about a lawyer who drives his grandfather to Florida during spring break. The film was directed by Dan Mazer and written by John Phillips. It stars Robert De Niro, Zac Efron, Aubrey Plaza, and Zoey Deutch.", 6, "Dirty Granpa", 0, "/Movie_Images/Poster (3).jpg", "https://www.youtube.com/embed/m77q2u48Cyg", 1, 0 },
                    { 4, 8, new DateTime(2021, 5, 2, 15, 55, 56, 566, DateTimeKind.Local).AddTicks(8984), "Neighbors 2: Sorority Rising (released in some countries as Bad Neighbours 2 and on home release as Neighbors 2) is a 2016 American comedy film directed by Nicholas Stoller and written by Stoller, Andrew J. Cohen, Brendan O'Brien, Seth Rogen and Evan Goldberg. A sequel to Neighbors (2014), the plot follows the Radners (Rogen and Rose Byrne) having to outwit a new sorority led by Shelby (Chloë Grace Moretz), living next door in order to sell their house currently in escrow. Zac Efron, Dave Franco, Christopher Mintz-Plasse, Jerrod Carmichael, Ike Barinholtz, Carla Gallo, Hannibal Buress, and Lisa Kudrow reprise their roles from the first film; it was Rogen's first live-action sequel.", 6, "Neighbor 2", 0, "/Movie_Images/Poster (4).jpg", "https://www.youtube.com/embed/X2i9Zz_AqTg", 1, 0 },
                    { 5, 8, new DateTime(2021, 5, 2, 15, 55, 56, 566, DateTimeKind.Local).AddTicks(8988), "Finding Dory is a 2016 American computer-animated adventure film produced by Pixar Animation Studios and released by Walt Disney Pictures. Directed by Andrew Stanton[5][6] and written by Stanton and Victoria Strouse,[7] the film is a sequel/spinoff[8][9] to Finding Nemo (2003) and features the returning voices of Ellen DeGeneres and Albert Brooks, with Hayden Rolence (replacing Alexander Gould), Ed O'Neill, Kaitlin Olson, Ty Burrell, Diane Keaton, and Eugene Levy joining the cast. The film focuses on the amnesiac fish Dory, who journeys to be reunited with her parents.[10]", 6, "Finding Dory", 0, "/Movie_Images/Poster (5).jpg", "https://www.youtube.com/embed/AMjMFbhyhwY", 1, 0 },
                    { 6, 8, new DateTime(2021, 5, 2, 15, 55, 56, 566, DateTimeKind.Local).AddTicks(8997), "The Suicide Squad is a fictional antihero team appearing in American comic books published by DC Comics. The first version of the Suicide Squad debuted in The Brave and the Bold #25 (September 1959) and the second and modern version, created by John Ostrander, debuted in Legends #3 (January 1987).", 1, "Boomerang Suicide Squad", 0, "/Movie_Images/Poster (6).jpg", "https://www.youtube.com/embed/tObsaSmNWDA", 1, 0 },
                    { 7, 8, new DateTime(2021, 5, 2, 15, 55, 56, 566, DateTimeKind.Local).AddTicks(9001), "Zoolander is a 2001 American action comedy film directed by Ben Stiller. The film contains elements from a pair of short films directed by Russell Bates and written by Drake Sather and Stiller for the VH1 Fashion Awards television specials in 1996 and 1997. The earlier short films and this film feature a dimwitted, narcissistic male model named Derek Zoolander (Stiller).", 1, "Zoo Lander", 0, "/Movie_Images/Poster (7).jpg", "https://www.youtube.com/embed/4CL4LNWHegk", 1, 0 },
                    { 8, 8, new DateTime(2021, 5, 2, 15, 55, 56, 566, DateTimeKind.Local).AddTicks(9005), "Ride Along is a 2014 American buddy cop action comedy film directed by Tim Story and starring Ice Cube, Kevin Hart, John Leguizamo, Bryan Callen, Tika Sumpter and Laurence Fishburne. Greg Coolidge, Jason Mantzoukas, Phil Hay, and Matt Manfredi wrote the screenplay based on a story originally from Coolidge.", 6, "Ride Along", 0, "/Movie_Images/Poster (8).jpg", "https://www.youtube.com/embed/5klp6rkHIks", 1, 0 },
                    { 9, 8, new DateTime(2021, 5, 2, 15, 55, 56, 566, DateTimeKind.Local).AddTicks(9009), "Hail, Caesar! is a 2016 American comedy film written, produced, edited, and directed by Joel and Ethan Coen. The film stars Josh Brolin, George Clooney, Alden Ehrenreich, Ralph Fiennes, Jonah Hill, Scarlett Johansson, Frances McDormand, Tilda Swinton, and Channing Tatum. It is a fictional story that follows the real-life fixer Eddie Mannix (Brolin) working in the Hollywood film industry in the 1950s, trying to discover what happened to a star actor during the filming of a biblical epic.[3]", 6, "Hail Ceasar!", 0, "/Movie_Images/Poster (9).jpg", "https://www.youtube.com/embed/kMqeoW3XRa0", 1, 0 },
                    { 10, 8, new DateTime(2021, 5, 2, 15, 55, 56, 566, DateTimeKind.Local).AddTicks(9179), "Starship Troopers is a 1997 American satirical military science fiction action film directed by Paul Verhoeven and written by Edward Neumeier, based on Robert A. Heinlein's 1959 novel of the same name. The story follows a young soldier named Johnny Rico and his exploits in the Mobile Infantry, a futuristic military unit. Rico's military career progresses from recruit, to non-commissioned officer, and finally to officer, against the backdrop of an interstellar war between mankind and an insectoid species known as Arachnids.", 6, "Rico Guys", 0, "/Movie_Images/Poster (10).jpg", "https://www.youtube.com/embed/e32QpMQUuAc", 1, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CountryId",
                table: "Movies",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreId",
                table: "Movies",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_UserId",
                table: "Movies",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
