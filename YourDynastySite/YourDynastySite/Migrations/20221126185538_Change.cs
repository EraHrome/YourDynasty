using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YourDynastySite.Migrations
{
    public partial class Change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "DynastyPersons",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BirthPlace",
                table: "DynastyPersons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BurialPlace",
                table: "DynastyPersons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BurialRegion",
                table: "DynastyPersons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeathDate",
                table: "DynastyPersons",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "DynastyPersons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SourceLink",
                table: "DynastyPersons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "DynastyPersons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "DynastyPersons");

            migrationBuilder.DropColumn(
                name: "BirthPlace",
                table: "DynastyPersons");

            migrationBuilder.DropColumn(
                name: "BurialPlace",
                table: "DynastyPersons");

            migrationBuilder.DropColumn(
                name: "BurialRegion",
                table: "DynastyPersons");

            migrationBuilder.DropColumn(
                name: "DeathDate",
                table: "DynastyPersons");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "DynastyPersons");

            migrationBuilder.DropColumn(
                name: "SourceLink",
                table: "DynastyPersons");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "DynastyPersons");
        }
    }
}
