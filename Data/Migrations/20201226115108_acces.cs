using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LB.Data.Migrations
{
    public partial class acces : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "lbacc",
                columns: table => new
                {
                    idlb = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userWp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    passWd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    linkWp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    acc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cusualt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    faltrto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cusumod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fmod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hmod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lbacc", x => x.idlb);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lbacc");
        }
    }
}
