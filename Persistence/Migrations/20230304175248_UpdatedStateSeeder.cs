using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LocationAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedStateSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("5e1fb917-1ac6-4992-b122-d1f88b0c5ab4"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("f70195f8-3ad7-4b20-8614-a51f44540a8a"));

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[,]
                {
                    { new Guid("7d982c42-3c96-4e9f-8da0-032a89e4380d"), "AK", "Alaska" },
                    { new Guid("827e552c-959b-4c72-bd7c-c306f7d48964"), "CA", "California" },
                    { new Guid("a166a5b7-b475-445d-b6f3-d67b6c9a9be1"), "TN", "Tennessee" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("7d982c42-3c96-4e9f-8da0-032a89e4380d"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("827e552c-959b-4c72-bd7c-c306f7d48964"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("a166a5b7-b475-445d-b6f3-d67b6c9a9be1"));

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[,]
                {
                    { new Guid("5e1fb917-1ac6-4992-b122-d1f88b0c5ab4"), "CA", "California" },
                    { new Guid("f70195f8-3ad7-4b20-8614-a51f44540a8a"), "TN", "Tennessee" }
                });
        }
    }
}
