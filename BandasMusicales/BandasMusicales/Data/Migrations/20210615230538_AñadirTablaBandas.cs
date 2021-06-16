﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace BandasMusicales.Data.Migrations
{
    public partial class AñadirTablaBandas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bandas",
                columns: table => new
                {
                    BandaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BandaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BandaGenero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BandaCant = table.Column<int>(type: "int", nullable: false),
                    BandaCantCanciones = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bandas", x => x.BandaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bandas");
        }
    }
}
