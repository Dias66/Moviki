using Microsoft.EntityFrameworkCore.Migrations;

namespace Movie.Data.Migrations
{
    public partial class addingmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imdb_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    title_english = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    title_long = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    slug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    year = table.Column<int>(type: "int", nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false),
                    runtime = table.Column<int>(type: "int", nullable: false),
                    genres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description_full = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    synopsis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    yt_trailer_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mpa_rating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    background_image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    background_image_original = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    small_cover_image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    medium_cover_image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    large_cover_image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_uploaded = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_uploaded_unix = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
