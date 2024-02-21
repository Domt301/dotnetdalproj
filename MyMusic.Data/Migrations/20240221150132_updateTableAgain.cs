using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyMusic.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateTableAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Artists",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "city",
                table: "Artists");
        }
    }
}
