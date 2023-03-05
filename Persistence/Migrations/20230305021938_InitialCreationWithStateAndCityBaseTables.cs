using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LocationAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreationWithStateAndCityBaseTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Abbreviation = table.Column<string>(type: "TEXT", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    StateId = table.Column<int>(type: "INTEGER", nullable: false),
                    StateId1 = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_States_StateId1",
                        column: x => x.StateId1,
                        principalTable: "States",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[,]
                {
                    { new Guid("052cbff5-2e85-4e23-a344-8cf6ee7e413d"), "AK", "Alaska" },
                    { new Guid("79d9a3ff-5b0c-4b7c-bdde-8d22cd48881d"), "TN", "Tennessee" },
                    { new Guid("ebb64e7e-70aa-4fd2-8996-951d396e6d3a"), "CA", "California" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_StateId1",
                table: "Cities",
                column: "StateId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "States");
        }
    }
}
