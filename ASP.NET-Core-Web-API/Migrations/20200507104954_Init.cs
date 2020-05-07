using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core_Web_API.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Wyjazdy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazwaWyjazdu = table.Column<string>(nullable: true),
                    Organizator = table.Column<string>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false),
                    CzyFirma = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wyjazdy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Atrakcje",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazwaAtrakcji = table.Column<string>(nullable: true),
                    Odleglosc = table.Column<int>(nullable: false),
                    Cena = table.Column<int>(nullable: false),
                    Opis = table.Column<string>(nullable: true),
                    WyjazdId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atrakcje", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Atrakcje_Wyjazdy_WyjazdId",
                        column: x => x.WyjazdId,
                        principalTable: "Wyjazdy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Miejsca",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kraj = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    WyjazdId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Miejsca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Miejsca_Wyjazdy_WyjazdId",
                        column: x => x.WyjazdId,
                        principalTable: "Wyjazdy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atrakcje_WyjazdId",
                table: "Atrakcje",
                column: "WyjazdId");

            migrationBuilder.CreateIndex(
                name: "IX_Miejsca_WyjazdId",
                table: "Miejsca",
                column: "WyjazdId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atrakcje");

            migrationBuilder.DropTable(
                name: "Miejsca");

            migrationBuilder.DropTable(
                name: "Wyjazdy");
        }
    }
}
