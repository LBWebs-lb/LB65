using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LB.Data.Migrations
{
    public partial class accesclients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "icliacc",
                table: "clilb",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "cliacc",
                columns: table => new
                {
                    icliacc = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_cliacc", x => x.icliacc);
                });

            migrationBuilder.CreateIndex(
                name: "IX_clilb_icliacc",
                table: "clilb",
                column: "icliacc");

            migrationBuilder.AddForeignKey(
                name: "FK_clilb_cliacc_icliacc",
                table: "clilb",
                column: "icliacc",
                principalTable: "cliacc",
                principalColumn: "icliacc",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clilb_cliacc_icliacc",
                table: "clilb");

            migrationBuilder.DropTable(
                name: "cliacc");

            migrationBuilder.DropIndex(
                name: "IX_clilb_icliacc",
                table: "clilb");

            migrationBuilder.DropColumn(
                name: "icliacc",
                table: "clilb");
        }
    }
}
