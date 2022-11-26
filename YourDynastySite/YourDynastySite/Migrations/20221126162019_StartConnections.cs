using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YourDynastySite.Migrations
{
    public partial class StartConnections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DynastyPersons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MotherId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FatherId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PartnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DynastyPersons", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DynastyPersons");
        }
    }
}
