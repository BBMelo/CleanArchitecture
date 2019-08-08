using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace vxTel.Repository.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlanoTelefonia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PHASHCODE = table.Column<Guid>(nullable: false),
                    PDATA_CRIACAO = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    PDATA_ALTERACAO = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    PDDD_ORIGEM = table.Column<int>(nullable: false),
                    PDDD_DESTINO = table.Column<int>(nullable: false),
                    PPRECO_MINUTO = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
                    PTIPO_PLANO = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanoTelefonia", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanoTelefonia");
        }
    }
}
