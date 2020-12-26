using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LB.Data.Migrations
{
    public partial class mai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "lbmail",
                columns: table => new
                {
                    idlbmail = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dnommail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mailuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    passmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lnkmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cusualt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    faltrto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cusumod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fmod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hmod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lbmail", x => x.idlbmail);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lbmail");
        }
    }
}
