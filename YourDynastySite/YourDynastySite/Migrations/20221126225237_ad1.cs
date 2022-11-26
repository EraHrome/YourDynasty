using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YourDynastySite.Migrations
{
    public partial class ad1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PersonId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Users");
        }
    }
}
