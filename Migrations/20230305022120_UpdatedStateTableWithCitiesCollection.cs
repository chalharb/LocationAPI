using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LocationAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedStateTableWithCitiesCollection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("052cbff5-2e85-4e23-a344-8cf6ee7e413d"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("79d9a3ff-5b0c-4b7c-bdde-8d22cd48881d"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("ebb64e7e-70aa-4fd2-8996-951d396e6d3a"));

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[,]
                {
                    { new Guid("36c0d2fe-2a95-44b6-94fd-8e31ad3762a4"), "AK", "Alaska" },
                    { new Guid("7740490d-8ffc-4496-be1a-0b0aaacaf7ce"), "CA", "California" },
                    { new Guid("fe13f7e1-30d5-4ac3-8235-fe57cba53b06"), "TN", "Tennessee" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("36c0d2fe-2a95-44b6-94fd-8e31ad3762a4"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("7740490d-8ffc-4496-be1a-0b0aaacaf7ce"));

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: new Guid("fe13f7e1-30d5-4ac3-8235-fe57cba53b06"));

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[,]
                {
                    { new Guid("052cbff5-2e85-4e23-a344-8cf6ee7e413d"), "AK", "Alaska" },
                    { new Guid("79d9a3ff-5b0c-4b7c-bdde-8d22cd48881d"), "TN", "Tennessee" },
                    { new Guid("ebb64e7e-70aa-4fd2-8996-951d396e6d3a"), "CA", "California" }
                });
        }
    }
}
