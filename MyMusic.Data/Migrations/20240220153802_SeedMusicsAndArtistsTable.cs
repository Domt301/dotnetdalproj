using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMusic.Data.Migrations
{
    public partial class SeedMusicsAndArtistsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO \"Artists\" (\"Name\") Values ('Linkin Park')");
            migrationBuilder.Sql("INSERT INTO \"Artists\" (\"Name\") Values ('Iron Maiden')");
            migrationBuilder.Sql("INSERT INTO \"Artists\" (\"Name\") Values ('Flogging Molly')");
            migrationBuilder.Sql("INSERT INTO \"Artists\" (\"Name\") Values ('Red Hot Chilli Peppers')");

            migrationBuilder.Sql("INSERT INTO \"Musics\" (\"Name\", \"ArtistId\") Values ('In The End', (SELECT \"Id\" FROM \"Artists\" WHERE \"Name\" = 'Linkin Park'))");
            migrationBuilder.Sql("INSERT INTO \"Musics\" (\"Name\", \"ArtistId\") Values ('Numb', (SELECT \"Id\" FROM \"Artists\" WHERE \"Name\" = 'Linkin Park'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM \"Musics\"");
            migrationBuilder.Sql("DELETE FROM \"Artists\"");
        }
    }
}