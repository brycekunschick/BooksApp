using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksApp_Sec02.Migrations
{
    /// <inheritdoc />
    public partial class addingRatingsCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ratings",
                table: "books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "BookID",
                keyValue: 1,
                column: "Ratings",
                value: 0);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "BookID",
                keyValue: 2,
                column: "Ratings",
                value: 0);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "BookID",
                keyValue: 3,
                column: "Ratings",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ratings",
                table: "books");
        }
    }
}
