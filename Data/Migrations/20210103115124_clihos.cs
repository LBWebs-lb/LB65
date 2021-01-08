using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LB.Data.Migrations
{
    public partial class clihos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clihos",
                columns: table => new
                {
                    ihos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userhos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    passhos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    linkwphos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cusualt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    faltrto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cusumod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fmod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hmod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clihos", x => x.ihos);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clihos");
        }
    }
}
