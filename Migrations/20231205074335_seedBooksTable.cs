using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BooksApp_Sec02.Migrations
{
    /// <inheritdoc />
    public partial class seedBooksTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "BookID", "Author", "DatePublished", "Description", "Genre", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Salman Nazir", new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "This has no description", "Coding", 19.99m, "C# for Beginners" },
                    { 2, "Adam Freeman", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "This has no description", "Coding", 59.99m, "Advanced C#" },
                    { 3, "Morgan Freeman", new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "This has no description", "Coding", 15.99m, "HTML for Beginners" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "BookID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "BookID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "BookID",
                keyValue: 3);
        }
    }
}
