using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace SampleWebApp.Migrations.Parque
{
    public partial class Migracion1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parque",
                columns: table => new
                {
                    ParqueId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Area = table.Column<string>(nullable: true),
                    Barrio = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parque", x => x.ParqueId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Parque");
        }
    }
}
