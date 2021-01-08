using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LB.Data.Migrations
{
    public partial class clients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clilb",
                columns: table => new
                {
                    icli = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ihos = table.Column<int>(type: "int", nullable: true),
                    iftp = table.Column<int>(type: "int", nullable: true),
                    ipredis = table.Column<int>(type: "int", nullable: true),
                    dnom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dnommail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est = table.Column<int>(type: "int", nullable: false),
                    dobs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tcli = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cusualt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    faltrto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cusumod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fmod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hmod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clilb", x => x.icli);
                    table.ForeignKey(
                        name: "FK_clilb_cliftp_iftp",
                        column: x => x.iftp,
                        principalTable: "cliftp",
                        principalColumn: "iftp",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_clilb_clihos_ihos",
                        column: x => x.ihos,
                        principalTable: "clihos",
                        principalColumn: "ihos",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_clilb_clipredis_ipredis",
                        column: x => x.ipredis,
                        principalTable: "clipredis",
                        principalColumn: "ipredis",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_clilb_iftp",
                table: "clilb",
                column: "iftp");

            migrationBuilder.CreateIndex(
                name: "IX_clilb_ihos",
                table: "clilb",
                column: "ihos");

            migrationBuilder.CreateIndex(
                name: "IX_clilb_ipredis",
                table: "clilb",
                column: "ipredis");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clilb");
        }
    }
}
