using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LB.Data.Migrations
{
    public partial class prediss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clipredis",
                columns: table => new
                {
                    ipredis = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ptheme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    envcli = table.Column<bool>(type: "bit", nullable: false),
                    themebuy = table.Column<bool>(type: "bit", nullable: false),
                    pctheme = table.Column<int>(type: "int", nullable: false),
                    bouby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paid = table.Column<bool>(type: "bit", nullable: false),
                    cusualt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    faltrto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cusumod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fmod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hmod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clipredis", x => x.ipredis);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clipredis");
        }
    }
}
